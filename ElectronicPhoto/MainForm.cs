using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;
using ElectronicPhoto.Utility;
using ElectronicPhoto.Graphics;
using ElectronicPhoto.Model;

namespace ElectronicPhoto 
{
    public partial class MainForm : Form
    {
        private Slider slider;

        public MainForm()
        {
            InitializeComponent();
            this.Activated += new EventHandler(MainForm_Activated);
        }

        public void MainForm_Load(object sender, EventArgs e)
        {
            List<ImageModel> imageCollection = ImageModel.GetAll();
            slider = new Slider(imageContainer, imageCollection, captionLabel, commentLabel, dateLabel);
        }

        public void MainForm_Activated(object sender, EventArgs e)
        {
            List<ImageModel> imageCollection = ImageModel.GetAll();
            slider.ImageCollection = imageCollection;
        }

        private void addImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog addImageDialog = new OpenFileDialog();
            addImageDialog.Title            = "Add image";
            addImageDialog.Filter           = "Image files (*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif|All files (*.*)|*.*";
            addImageDialog.RestoreDirectory = false;
            addImageDialog.InitialDirectory = Environment.CurrentDirectory;

            if (addImageDialog.ShowDialog() == DialogResult.OK)
            {
                string image = addImageDialog.FileName;
                NewImageForm newImageForm = new NewImageForm(addImageDialog.FileName);
                newImageForm.Show();
            }
        }

        private void fullscreenButton_Click(object sender, EventArgs e)
        {
            Form fullscreenForm                  = new Form();
            fullscreenForm.ControlBox            = false;
            fullscreenForm.FormBorderStyle       = FormBorderStyle.None;
            fullscreenForm.BackgroundImageLayout = ImageLayout.Zoom;
            fullscreenForm.BackgroundImage       = imageContainer.Image;
            fullscreenForm.Location              = new Point(Screen.PrimaryScreen.Bounds.Left, Screen.PrimaryScreen.Bounds.Top);
            fullscreenForm.Size                  = Screen.PrimaryScreen.Bounds.Size;
            fullscreenForm.BackColor             = Color.Black;
            fullscreenForm.Show();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            slider.Next(sender, e);
        }

        private void previousButton_Click(object sender, EventArgs e)
        {
            slider.Previous(sender, e);
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            slider.Play(sender, e);
        }

        private void rotateButtonMinus_Click(object sender, EventArgs e)
        {
            slider.RotateMinus(sender, e);
        }

        private void rotateButtonPlus_Click(object sender, EventArgs e)
        {
            slider.RotatePlus(sender, e);
        }
    }
}
