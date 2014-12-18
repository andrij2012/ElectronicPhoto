using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ElectronicPhoto.Model;

namespace ElectronicPhoto.Graphics
{
    class Slider
    {
        private int currentImage = 0;

        private Timer timer;

        private Label caption;

        private Label comment;

        private Label date;

        private List<ImageModel> _imageCollection;

        public List<ImageModel> ImageCollection
        {
            set
            {
                this._imageCollection = value;
                renderImage();
            }
            get
            {
                return this._imageCollection;
            }
        }

        private PictureBox _imageContainer;

        public PictureBox ImageContainer
        {
            set
            {
                this._imageContainer = value;
                renderImage();
            }
            get
            {
                return this._imageContainer;
            }
        }

        public Slider(PictureBox imageContainer, List<ImageModel> imageCollection, Label caption, Label comment, Label date)
        {
            this.ImageCollection = imageCollection;
            this.ImageContainer  = imageContainer;
            this.caption = caption;
            this.comment = comment;
            this.date    = date;

            renderImage();
        }

        private void renderImage()
        {
            if (this.ImageCollection.Count > 0)
            {
                this.ImageContainer.Image = Image.FromFile(this.ImageCollection[currentImage].Path);
                caption.Text = this.ImageCollection[currentImage].Caption;
                comment.Text = this.ImageCollection[currentImage].Comment;
                date.Text = this.ImageCollection[currentImage].Date.ToString();
            }
        }

        public void Next(object sender, EventArgs e)
        {
            if (this.ImageCollection.Count > 1)
            {
                currentImage = ((ImageCollection.Count - 1) == currentImage) ? 0 : currentImage + 1;
                renderImage();
            }
        }

        public void Previous(object sender, EventArgs e)
        {
            if (ImageCollection.Count > 1)
            {
                currentImage = (currentImage == 0) ? (ImageCollection.Count - 1) : currentImage - 1;
                renderImage();
            }
        }

        public void Play(object sender, EventArgs e)
        {
            timer = new Timer();
            timer.Tick += new EventHandler(Next);
            timer.Interval = 5000;
            timer.Start();
        }

        public void Pause(object sender, EventArgs e)
        {
            timer.Stop();
        }

        public void RotatePlus(object sender, EventArgs e)
        {
            ImageContainer.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            ImageContainer.Refresh();
        }

        public void RotateMinus(object sender, EventArgs e)
        {
            ImageContainer.Image.RotateFlip(RotateFlipType.Rotate270FlipNone);
            ImageContainer.Refresh();
        }
    }
}
