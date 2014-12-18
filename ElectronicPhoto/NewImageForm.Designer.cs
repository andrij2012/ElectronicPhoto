namespace ElectronicPhoto
{
    partial class NewImageForm
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
            this.previewImagePictureBox = new System.Windows.Forms.PictureBox();
            this.captionLabel = new System.Windows.Forms.Label();
            this.captionTextBox = new System.Windows.Forms.TextBox();
            this.previewImageLabel = new System.Windows.Forms.Label();
            this.commentLabel = new System.Windows.Forms.Label();
            this.commentTextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.dateLabel = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.countLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.previewImagePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // previewImagePictureBox
            // 
            this.previewImagePictureBox.Location = new System.Drawing.Point(12, 25);
            this.previewImagePictureBox.Name = "previewImagePictureBox";
            this.previewImagePictureBox.Size = new System.Drawing.Size(319, 149);
            this.previewImagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.previewImagePictureBox.TabIndex = 0;
            this.previewImagePictureBox.TabStop = false;
            // 
            // captionLabel
            // 
            this.captionLabel.AutoSize = true;
            this.captionLabel.Location = new System.Drawing.Point(9, 177);
            this.captionLabel.Name = "captionLabel";
            this.captionLabel.Size = new System.Drawing.Size(47, 13);
            this.captionLabel.TabIndex = 1;
            this.captionLabel.Text = "Caption*";
            // 
            // captionTextBox
            // 
            this.captionTextBox.Location = new System.Drawing.Point(12, 193);
            this.captionTextBox.Name = "captionTextBox";
            this.captionTextBox.Size = new System.Drawing.Size(319, 20);
            this.captionTextBox.TabIndex = 2;
            // 
            // previewImageLabel
            // 
            this.previewImageLabel.AutoSize = true;
            this.previewImageLabel.Location = new System.Drawing.Point(9, 9);
            this.previewImageLabel.Name = "previewImageLabel";
            this.previewImageLabel.Size = new System.Drawing.Size(83, 13);
            this.previewImageLabel.TabIndex = 3;
            this.previewImageLabel.Text = "Image\'s preview";
            // 
            // commentLabel
            // 
            this.commentLabel.AutoSize = true;
            this.commentLabel.Location = new System.Drawing.Point(9, 221);
            this.commentLabel.Name = "commentLabel";
            this.commentLabel.Size = new System.Drawing.Size(51, 13);
            this.commentLabel.TabIndex = 4;
            this.commentLabel.Text = "Comment";
            // 
            // commentTextBox
            // 
            this.commentTextBox.Location = new System.Drawing.Point(12, 237);
            this.commentTextBox.MaxLength = 350;
            this.commentTextBox.Multiline = true;
            this.commentTextBox.Name = "commentTextBox";
            this.commentTextBox.Size = new System.Drawing.Size(319, 77);
            this.commentTextBox.TabIndex = 5;
            this.commentTextBox.TextChanged += new System.EventHandler(this.commentTextBox_TextChanged);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(208, 322);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(123, 28);
            this.addButton.TabIndex = 6;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(9, 329);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(33, 13);
            this.dateLabel.TabIndex = 7;
            this.dateLabel.Text = "Date:";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker.Location = new System.Drawing.Point(48, 327);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(154, 20);
            this.dateTimePicker.TabIndex = 8;
            // 
            // countLabel
            // 
            this.countLabel.AutoSize = true;
            this.countLabel.Location = new System.Drawing.Point(66, 221);
            this.countLabel.Name = "countLabel";
            this.countLabel.Size = new System.Drawing.Size(25, 13);
            this.countLabel.TabIndex = 9;
            this.countLabel.Text = "350";
            // 
            // NewImageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 359);
            this.Controls.Add(this.countLabel);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.commentTextBox);
            this.Controls.Add(this.commentLabel);
            this.Controls.Add(this.previewImageLabel);
            this.Controls.Add(this.captionTextBox);
            this.Controls.Add(this.captionLabel);
            this.Controls.Add(this.previewImagePictureBox);
            this.Name = "NewImageForm";
            this.Text = "Image data";
            this.Load += new System.EventHandler(this.NewImageForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.previewImagePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox previewImagePictureBox;
        private System.Windows.Forms.Label captionLabel;
        private System.Windows.Forms.TextBox captionTextBox;
        private System.Windows.Forms.Label previewImageLabel;
        private System.Windows.Forms.Label commentLabel;
        private System.Windows.Forms.TextBox commentTextBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label countLabel;
    }
}