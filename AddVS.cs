using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VideoSoftwareIndexer.Models;

namespace VideoSoftwareIndexer
{
    public partial class AddVS : Form
    {
        public AddVS()
        {
            InitializeComponent();
        }

        #region PrivateElements
        private byte[] image_blob = null;
        private readonly int max_image_size = 1000000;
        #endregion
        #region PublicElements
        public VideoSoftware NewVideoSoftware { get; set; }
        #endregion
        #region Functions
        /// <summary>
        /// Converts the selected image into a byte array so it can be inserted into the db
        /// </summary>
        /// <param name="image_path"></param>
        /// <returns></returns>
        private byte[] ConvertImageToBlob(string image_path)
        {
            byte[] imgBytes = new byte[max_image_size];
            try
            {
                Image img = Image.FromFile(image_path);
                MemoryStream tmpStream = new MemoryStream();
                img.Save(tmpStream, ImageFormat.Png); // change to other format
                tmpStream.Seek(0, SeekOrigin.Begin);
                tmpStream.Read(imgBytes, 0, max_image_size);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error while converting selected image to blob. Error info: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return imgBytes;
        }

        /// <summary>
        /// Creates a new VS entry based on the input parameters
        /// </summary>
        /// <param name="name"></param>
        /// <param name="image_blob"></param>
        private VideoSoftware CreateNewVS(string name, byte[] image_blob)
        {
            VideoSoftware vs = new VideoSoftware();
            vs.Name = name;
            vs.IconBlob = image_blob;

            return vs;
        }
        #endregion
        #region EventHandlers
        private void bBrowse_Click(object sender, EventArgs e)
        {
            //Creates a file dialog so the user can choose an image
            //The file dialog only allows png images to be selected
            OpenFileDialog fd = new OpenFileDialog();
            fd.Filter = "PNG Image (*.png)|*.png";
            fd.Multiselect = false;
            fd.ShowDialog();

            //If an image was selected, convert it to a byte array(blob)
            if (!string.IsNullOrEmpty(fd.FileName))
            {
                image_blob = ConvertImageToBlob(fd.FileName);
            }
        }
        private void bSave_Click(object sender, EventArgs e)
        {
            string name = tbName.Text;

            // Checks if a name is entered
            if (string.IsNullOrEmpty(name) || string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Please enter a software name!", "Warning", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }
            // Checks if a valid icon is selected
            if (image_blob == null)
            {
                MessageBox.Show("Please choose a valid icon!", "Warning", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            NewVideoSoftware = CreateNewVS(name, image_blob);

            MessageBox.Show("Software entry created!", "Information", MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        #endregion

    }
}
