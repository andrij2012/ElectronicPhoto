using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace eGallery
{
    public partial class MainForm : Form
    {
        // Images
        private IEnumerable<string> images;

        private int imageIndex = 0;

        public MainForm()
        {
            InitializeComponent();
        }

        // Main menu: Exit: Close program
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Main menu: Open folder: Opens folder
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string[] imageExtensions = { ".jpg", ".png", ".gif" };

            FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
            folderBrowser.RootFolder          = Environment.SpecialFolder.MyDocuments;

            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                images = Directory.EnumerateFiles(folderBrowser.SelectedPath, "*.*", SearchOption.AllDirectories).Where(s => imageExtensions.Any(ext => ext == Path.GetExtension(s)));
                updateImage();
            }
        }

        private void updateImage()
        {
            galleryPictureBox.Image = Image.FromFile(images.ElementAt(imageIndex));
        }

        private void next()
        {
            if (images != null)
            {
                imageIndex = ((images.Count<string>() - 1) == imageIndex) ? 0 : imageIndex + 1;
                updateImage();
            }
        }

        private void prev()
        {
            if (images != null)
            {
                imageIndex = (imageIndex == 0) ? (images.Count<string>() - 1) : imageIndex - 1;
                updateImage();
            }
        }

        private void play()
        {
            Timer timer = new Timer();
            timer.Tick += new EventHandler(nexButton_Click);
            timer.Interval = 5000;
            timer.Start();

        }

        private void nexButton_Click(object sender, EventArgs e)
        {
            next();
        }

        private void prevButton_Click(object sender, EventArgs e)
        {
            prev();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Left)
            {
                prev();
            }

            if (keyData == Keys.Right)
            {
                next();
            }

            if (keyData == Keys.Space)
            {
                play();
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            play();
        }
    }
}
