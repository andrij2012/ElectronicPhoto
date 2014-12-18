using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ElectronicPhoto.Model;

namespace ElectronicPhoto
{
    public partial class NewImageForm : Form
    {
        private ImageModel image;

        public NewImageForm(string imagePath)
        {
            InitializeComponent();

            image      =  new ImageModel();
            image.Path = imagePath;
        }

        public void NewImageForm_Load(object sender, EventArgs e)
        {
            previewImagePictureBox.Image = Image.FromFile(image.Path);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (captionTextBox.Text == "")
            {
                captionTextBox.Text = "Caption must be filled";
                return;
            }

            image.Caption = captionTextBox.Text;
            image.Comment = commentTextBox.Text;
            image.Date    = dateTimePicker.Value;
            image.Upload();

            this.Close();
        }

        private void commentTextBox_TextChanged(object sender, EventArgs e)
        {
            countLabel.Text = (commentTextBox.MaxLength - commentTextBox.Text.Length).ToString();
        }
    }
}
