namespace ElectronicPhoto
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageContainer = new System.Windows.Forms.PictureBox();
            this.captionLabel = new System.Windows.Forms.Label();
            this.commentLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.previousButton = new System.Windows.Forms.Button();
            this.playButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.rotateButtonMinus = new System.Windows.Forms.Button();
            this.rotateButtonPlus = new System.Windows.Forms.Button();
            this.fullscreenButton = new System.Windows.Forms.Button();
            this.mainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageContainer)).BeginInit();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(802, 24);
            this.mainMenu.TabIndex = 0;
            this.mainMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addImageToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // addImageToolStripMenuItem
            // 
            this.addImageToolStripMenuItem.Name = "addImageToolStripMenuItem";
            this.addImageToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.addImageToolStripMenuItem.Text = "Add image";
            this.addImageToolStripMenuItem.Click += new System.EventHandler(this.addImageToolStripMenuItem_Click);
            // 
            // imageContainer
            // 
            this.imageContainer.Location = new System.Drawing.Point(13, 28);
            this.imageContainer.Name = "imageContainer";
            this.imageContainer.Size = new System.Drawing.Size(777, 297);
            this.imageContainer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageContainer.TabIndex = 1;
            this.imageContainer.TabStop = false;
            // 
            // captionLabel
            // 
            this.captionLabel.AutoSize = true;
            this.captionLabel.Location = new System.Drawing.Point(13, 337);
            this.captionLabel.Name = "captionLabel";
            this.captionLabel.Size = new System.Drawing.Size(0, 13);
            this.captionLabel.TabIndex = 2;
            // 
            // commentLabel
            // 
            this.commentLabel.AutoSize = true;
            this.commentLabel.Location = new System.Drawing.Point(13, 365);
            this.commentLabel.Name = "commentLabel";
            this.commentLabel.Size = new System.Drawing.Size(0, 13);
            this.commentLabel.TabIndex = 3;
            // 
            // dateLabel
            // 
            this.dateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(672, 337);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(0, 13);
            this.dateLabel.TabIndex = 4;
            this.dateLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // previousButton
            // 
            this.previousButton.Location = new System.Drawing.Point(120, 332);
            this.previousButton.Name = "previousButton";
            this.previousButton.Size = new System.Drawing.Size(75, 23);
            this.previousButton.TabIndex = 5;
            this.previousButton.Text = "Previous";
            this.previousButton.UseVisualStyleBackColor = true;
            this.previousButton.Click += new System.EventHandler(this.previousButton_Click);
            // 
            // playButton
            // 
            this.playButton.Location = new System.Drawing.Point(208, 332);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(75, 23);
            this.playButton.TabIndex = 6;
            this.playButton.Text = "Play";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(299, 332);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(75, 23);
            this.nextButton.TabIndex = 7;
            this.nextButton.Text = "Next";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // rotateButtonMinus
            // 
            this.rotateButtonMinus.Location = new System.Drawing.Point(393, 332);
            this.rotateButtonMinus.Name = "rotateButtonMinus";
            this.rotateButtonMinus.Size = new System.Drawing.Size(75, 23);
            this.rotateButtonMinus.TabIndex = 8;
            this.rotateButtonMinus.Text = "Rotate -90";
            this.rotateButtonMinus.UseVisualStyleBackColor = true;
            this.rotateButtonMinus.Click += new System.EventHandler(this.rotateButtonMinus_Click);
            // 
            // rotateButtonPlus
            // 
            this.rotateButtonPlus.Location = new System.Drawing.Point(488, 332);
            this.rotateButtonPlus.Name = "rotateButtonPlus";
            this.rotateButtonPlus.Size = new System.Drawing.Size(75, 23);
            this.rotateButtonPlus.TabIndex = 9;
            this.rotateButtonPlus.Text = "Rotate +90";
            this.rotateButtonPlus.UseVisualStyleBackColor = true;
            this.rotateButtonPlus.Click += new System.EventHandler(this.rotateButtonPlus_Click);
            // 
            // fullscreenButton
            // 
            this.fullscreenButton.Location = new System.Drawing.Point(582, 332);
            this.fullscreenButton.Name = "fullscreenButton";
            this.fullscreenButton.Size = new System.Drawing.Size(75, 23);
            this.fullscreenButton.TabIndex = 10;
            this.fullscreenButton.Text = "Fullscreen";
            this.fullscreenButton.UseVisualStyleBackColor = true;
            this.fullscreenButton.Click += new System.EventHandler(this.fullscreenButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 472);
            this.Controls.Add(this.fullscreenButton);
            this.Controls.Add(this.rotateButtonPlus);
            this.Controls.Add(this.rotateButtonMinus);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.previousButton);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.commentLabel);
            this.Controls.Add(this.captionLabel);
            this.Controls.Add(this.imageContainer);
            this.Controls.Add(this.mainMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mainMenu;
            this.Name = "MainForm";
            this.Text = "Electronic Photo";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageContainer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addImageToolStripMenuItem;
        private System.Windows.Forms.PictureBox imageContainer;
        private System.Windows.Forms.Label captionLabel;
        private System.Windows.Forms.Label commentLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Button previousButton;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button rotateButtonMinus;
        private System.Windows.Forms.Button rotateButtonPlus;
        private System.Windows.Forms.Button fullscreenButton;
    }
}

