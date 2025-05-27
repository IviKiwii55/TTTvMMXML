using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VideoSoftwareIndexer.Models;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

namespace VideoSoftwareIndexer
{
    public partial class Form1 : Form
    {

        private static string db_name = "videosoftware.xml";
        public Form1()
        {
            InitializeComponent();
            dgvVideoSoftware.AutoGenerateColumns = false;
            dgvCon.AutoGenerateColumns = false;
            dgvPro.AutoGenerateColumns = false;

            CheckIfDBExists(db_name);
            ReadDatabase(db_name);
            ConfigureDataSource();

        }


        #region PrivateElements
        private List<VideoSoftware> software_list = new List<VideoSoftware>();
        private VideoSoftware selected_software;
        private SoftwareAttribute selected_con;
        private SoftwareAttribute selected_pro;
        BindingSource software = new BindingSource();
        BindingSource cons = new BindingSource();
        BindingSource pros = new BindingSource();
        #endregion
        #region PublicElements
        public List<VideoSoftware> SoftwareList => software_list;
        public VideoSoftware SelectedSoftware
        {
            get => selected_software;
            set
            {
                selected_software = value;
                if (value != null)
                {
                    cons.DataSource = value.Cons;
                    pros.DataSource = value.Pros;
                    pros.ResetBindings(false);
                    cons.ResetBindings(false);
                }
            }
        }
        public SoftwareAttribute SelectedCon
        {
            get => selected_con;
            set => selected_con = value;
        }
        public SoftwareAttribute SelectedPro
        {
            get => selected_pro;
            set => selected_pro = value;
        }
        #endregion
        #region Functions

        /// <summary>
        /// Converts the given VideoSoftware object into an XML equivalent
        /// </summary>
        /// <param name="software_object"></param>
        private void SerializeObject(XmlDocument xDoc, VideoSoftware software_object)
        {
            var rootNode = xDoc.GetElementsByTagName("software_list")[0];
            var nav = rootNode.CreateNavigator();
            var emptyNamepsaces = new XmlSerializerNamespaces(new[] { XmlQualifiedName.Empty });

            using (var stream = nav.AppendChild())
            {
                XmlSerializer serializer = new XmlSerializer(typeof(VideoSoftware));
                stream.WriteWhitespace("");
                serializer.Serialize(stream, software_object, emptyNamepsaces);
                stream.Close();
            }
        }

        /// <summary>
        /// Creates and configures an empty .xml object that will be used as a database
        /// </summary>
        /// <param name="db_name"></param>
        private XmlDocument CreateXMLDB(string db_name)
        {
            XmlDocument xmldoc = new XmlDocument();
            XmlElement root = xmldoc.CreateElement("software_list");
            xmldoc.AppendChild(root);
            xmldoc.Save(db_name);

            return xmldoc;
        }

        /// <summary>
        /// Checks if the xml database is present. If not, creates a new one and configures it
        /// </summary>
        /// <param name="db_name"></param>
        private void CheckIfDBExists(string db_name)
        {
            if (File.Exists(db_name))
            {
                return;
            }
            else
                CreateXMLDB(db_name);
        }

        /// <summary>
        /// Reads the list of entries from the database
        /// </summary>
        /// <param name="db_name"></param>
        private void ReadDatabase(string db_name)
        {
            using (var stream = new StreamReader(db_name))
            {
                XmlSerializer deserializer = new XmlSerializer(typeof(List<VideoSoftware>),
                    new XmlRootAttribute("software_list"));

                software_list = (List<VideoSoftware>)deserializer.Deserialize(stream);
                stream.Close();
            }

        }

        /// <summary>
        /// Commits changes to database
        /// </summary>
        /// <param name="db_name"></param>
        private void CommitToDatabase(string db_name)
        {
            try
            {
                File.Delete(db_name);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error recreating database! Error:{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            XmlDocument xDoc = CreateXMLDB(db_name);
            foreach (VideoSoftware vs in SoftwareList)
            {
                SerializeObject(xDoc, vs);
            }

            try
            {
                xDoc.Save(db_name);
                MessageBox.Show("Commit successful!");
            }
            catch(Exception ex) { MessageBox.Show($"Error commiting changes! Error: {ex.Message}"); }
        }

        /// <summary>
        /// Binds the data sources of each DataGridView to a BindableSource
        /// This allows a data refresh to happen each time entries are added or removed
        /// </summary>
        private void ConfigureDataSource()
        {
            software.DataSource = SoftwareList;
            dgvVideoSoftware.DataSource = software;
            dgvCon.DataSource = cons;
            dgvPro.DataSource = pros;
        }

        #endregion
        #region EventHandlers
        private void bAddSoftware_Click(object sender, EventArgs e)
        {
            // Instantiates a new AddVS window so the user can add a VES entry
            AddVS addVS = new AddVS();
            if (addVS.ShowDialog() == DialogResult.OK)
            {
                software_list.Add(addVS.NewVideoSoftware);
                software.ResetBindings(false);
            }
        }
        private void bRemoveSoftware_Click(object sender, EventArgs e)
        {
            // If an entry is selected
            if (SelectedSoftware != null)
            {
                SoftwareList.Remove(SelectedSoftware);
                software.ResetBindings(false);
            }
        }
        private void bAddCon_Click(object sender, EventArgs e)
        {
            // If a VES entry is not selected, returns
            if (SelectedSoftware == null)
                return;

            // Instantiates a AddSoftwareAttribute window so the user can add a new software attribute
            AddSoftwareAttribute asa = new AddSoftwareAttribute("Con", SelectedSoftware);
            asa.ShowDialog();

            // Refreshes the attribute data
            cons.ResetBindings(false);
        }
        private void bAddPro_Click(object sender, EventArgs e)
        {
            // If a VES entry is not selected, returns
            if (SelectedSoftware == null)
                return;

            // Instantiates a AddSoftwareAttribute window so the user can add a new software attribute
            AddSoftwareAttribute asa = new AddSoftwareAttribute("Pro", SelectedSoftware);
            asa.ShowDialog();

            // Refreshes the attribute data
            pros.ResetBindings(false);
        }
        private void bRemoveCon_Click(object sender, EventArgs e)
        {
            // If a SoftwareAttribute of type "Con" is not selected, returns
            if (SelectedCon == null) return;

            // Checks if the user actually wants to delete the entry
            DialogResult answer = MessageBox.Show("Are you sure you want to remove this item?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (answer == DialogResult.Yes)
            {
                SelectedSoftware.Cons.Remove(SelectedCon);
                cons.ResetBindings(false);
            }
        }
        private void bRemovePro_Click(object sender, EventArgs e)
        {
            // If a SoftwareAttribute of type "Pro" is not selected, returns
            if (SelectedPro == null) return;

            DialogResult answer = MessageBox.Show("Are you sure you want to remove this item?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (answer == DialogResult.Yes)
            {
                SelectedSoftware.Pros.Remove(SelectedPro);
                pros.ResetBindings(false);
            }
        }
        private void dgvVideoSoftware_SelectionChanged(object sender, EventArgs e)
        {
            // Gets the current selected VES
            if (dgvVideoSoftware.SelectedRows.Count > 0)
            {
                SelectedSoftware = dgvVideoSoftware.SelectedRows[0].DataBoundItem as VideoSoftware;
            }
            else { SelectedSoftware = null; }
        }
        private void dgvCon_SelectionChanged(object sender, EventArgs e)
        {
            // Gets the current selected SoftwareAttribute of type "Con"
            if (dgvCon.SelectedRows.Count > 0)
            {
                SelectedCon = dgvCon.SelectedRows[0].DataBoundItem as SoftwareAttribute;
            }
            else { SelectedCon = null; }
        }
        private void dgvPro_SelectionChanged(object sender, EventArgs e)
        {
            // Gets the current selected SoftwareAttribute of type "Pro"
            if (dgvPro.SelectedRows.Count > 0)
            {
                SelectedPro = dgvPro.SelectedRows[0].DataBoundItem as SoftwareAttribute;
            }
            else { SelectedPro = null; }
        }
        private void bCommit_Click(object sender, EventArgs e)
        {
            CommitToDatabase(db_name);
        }
        #endregion
    }
}
