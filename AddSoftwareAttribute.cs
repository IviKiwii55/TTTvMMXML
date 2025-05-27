using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VideoSoftwareIndexer.Models;

namespace VideoSoftwareIndexer
{
    public partial class AddSoftwareAttribute : Form
    {
        public AddSoftwareAttribute(string AttributeType, VideoSoftware selected_software)
        {
            InitializeComponent();
            tbAttributeType.Text = AttributeType;
            SelectedSoftware = selected_software;
        }

        private VideoSoftware SelectedSoftware;

        /// <summary>
        /// Inserts a new SoftwareAttribute entry into the db for the provided VES ID
        /// </summary>
        /// <param name="name"></param>
        /// <param name="icon_blob"></param>
        /// <returns></returns>
        private void InsertSoftwareAttribute(VideoSoftware selected_software, string description, string type)
        {
            SoftwareAttribute sa = new SoftwareAttribute()
            {
                Description = description
            };

            if (type == "Con")
                selected_software.Cons.Add(sa);
            else
                selected_software.Pros.Add(sa);
        }
        private void bSave_Click(object sender, EventArgs e)
        {
            // Checks if a valid description was entered
            if (string.IsNullOrEmpty(tbDescription.Text) || string.IsNullOrEmpty(tbDescription.Text))
            {
                MessageBox.Show("Please enter a description!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            InsertSoftwareAttribute(SelectedSoftware,tbDescription.Text, tbAttributeType.Text);
            MessageBox.Show("Attribute entry added!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }
    }
}
