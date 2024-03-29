﻿namespace ContactsApp.View
{
    partial class ContactForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContactForm));
            this.VKTextBox = new System.Windows.Forms.TextBox();
            this.VKLabel = new System.Windows.Forms.Label();
            this.DateOfBirthLabel = new System.Windows.Forms.Label();
            this.PhoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.PhoneNumberLabel = new System.Windows.Forms.Label();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.FullNameTextBox = new System.Windows.Forms.TextBox();
            this.FullNameLabel = new System.Windows.Forms.Label();
            this.DateOfBirthTimePicker = new System.Windows.Forms.DateTimePicker();
            this.DialogPanel = new System.Windows.Forms.Panel();
            this.OKButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.AddPhotoButton = new System.Windows.Forms.PictureBox();
            this.PhotoPictureBox = new System.Windows.Forms.PictureBox();
            this.FullNamePictureBox = new System.Windows.Forms.PictureBox();
            this.EmailPictureBox = new System.Windows.Forms.PictureBox();
            this.PhoneNumberPictureBox = new System.Windows.Forms.PictureBox();
            this.DateOfBirthPictureBox = new System.Windows.Forms.PictureBox();
            this.VKPictureBox = new System.Windows.Forms.PictureBox();
            this.DialogPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AddPhotoButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PhotoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FullNamePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmailPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PhoneNumberPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateOfBirthPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VKPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // VKTextBox
            // 
            this.VKTextBox.Location = new System.Drawing.Point(157, 279);
            this.VKTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.VKTextBox.Name = "VKTextBox";
            this.VKTextBox.Size = new System.Drawing.Size(232, 22);
            this.VKTextBox.TabIndex = 21;
            this.VKTextBox.TextChanged += new System.EventHandler(this.VKTextBox_TextChanged);
            // 
            // VKLabel
            // 
            this.VKLabel.AutoSize = true;
            this.VKLabel.Location = new System.Drawing.Point(157, 260);
            this.VKLabel.Margin = new System.Windows.Forms.Padding(4, 12, 4, 0);
            this.VKLabel.Name = "VKLabel";
            this.VKLabel.Size = new System.Drawing.Size(27, 16);
            this.VKLabel.TabIndex = 20;
            this.VKLabel.Text = "VK:";
            // 
            // DateOfBirthLabel
            // 
            this.DateOfBirthLabel.AutoSize = true;
            this.DateOfBirthLabel.Location = new System.Drawing.Point(157, 199);
            this.DateOfBirthLabel.Margin = new System.Windows.Forms.Padding(4, 12, 4, 0);
            this.DateOfBirthLabel.Name = "DateOfBirthLabel";
            this.DateOfBirthLabel.Size = new System.Drawing.Size(82, 16);
            this.DateOfBirthLabel.TabIndex = 18;
            this.DateOfBirthLabel.Text = "Date of Birth:";
            // 
            // PhoneNumberTextBox
            // 
            this.PhoneNumberTextBox.Location = new System.Drawing.Point(157, 159);
            this.PhoneNumberTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.PhoneNumberTextBox.Name = "PhoneNumberTextBox";
            this.PhoneNumberTextBox.Size = new System.Drawing.Size(232, 22);
            this.PhoneNumberTextBox.TabIndex = 17;
            this.PhoneNumberTextBox.Text = "+7 (951) 620-11-36";
            this.PhoneNumberTextBox.TextChanged += new System.EventHandler(this.PhoneNumberTextBox_TextChanged);
            // 
            // PhoneNumberLabel
            // 
            this.PhoneNumberLabel.AutoSize = true;
            this.PhoneNumberLabel.Location = new System.Drawing.Point(157, 139);
            this.PhoneNumberLabel.Margin = new System.Windows.Forms.Padding(4, 12, 4, 0);
            this.PhoneNumberLabel.Name = "PhoneNumberLabel";
            this.PhoneNumberLabel.Size = new System.Drawing.Size(97, 16);
            this.PhoneNumberLabel.TabIndex = 16;
            this.PhoneNumberLabel.Text = "PhoneNumber:";
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EmailTextBox.Location = new System.Drawing.Point(157, 98);
            this.EmailTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(484, 22);
            this.EmailTextBox.TabIndex = 15;
            this.EmailTextBox.Text = "cool_snail@gmail.com";
            this.EmailTextBox.TextChanged += new System.EventHandler(this.EmailTextBox_TextChanged);
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Location = new System.Drawing.Point(157, 79);
            this.EmailLabel.Margin = new System.Windows.Forms.Padding(4, 12, 4, 0);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(48, 16);
            this.EmailLabel.TabIndex = 14;
            this.EmailLabel.Text = "E-mail:";
            // 
            // FullNameTextBox
            // 
            this.FullNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FullNameTextBox.Location = new System.Drawing.Point(157, 38);
            this.FullNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.FullNameTextBox.Name = "FullNameTextBox";
            this.FullNameTextBox.Size = new System.Drawing.Size(484, 22);
            this.FullNameTextBox.TabIndex = 13;
            this.FullNameTextBox.Text = "Улитка из бара в модной рубашке";
            this.FullNameTextBox.TextChanged += new System.EventHandler(this.FullNameTextBox_TextChanged);
            // 
            // FullNameLabel
            // 
            this.FullNameLabel.AutoSize = true;
            this.FullNameLabel.Location = new System.Drawing.Point(157, 18);
            this.FullNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FullNameLabel.Name = "FullNameLabel";
            this.FullNameLabel.Size = new System.Drawing.Size(68, 16);
            this.FullNameLabel.TabIndex = 12;
            this.FullNameLabel.Text = "Full name:";
            // 
            // DateOfBirthTimePicker
            // 
            this.DateOfBirthTimePicker.CalendarMonthBackground = System.Drawing.SystemColors.Control;
            this.DateOfBirthTimePicker.CalendarTitleBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.DateOfBirthTimePicker.Location = new System.Drawing.Point(157, 219);
            this.DateOfBirthTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.DateOfBirthTimePicker.Name = "DateOfBirthTimePicker";
            this.DateOfBirthTimePicker.Size = new System.Drawing.Size(232, 22);
            this.DateOfBirthTimePicker.TabIndex = 23;
            this.DateOfBirthTimePicker.ValueChanged += new System.EventHandler(this.DateOfBirthTimePicker_ValueChanged);
            // 
            // DialogPanel
            // 
            this.DialogPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.DialogPanel.Controls.Add(this.OKButton);
            this.DialogPanel.Controls.Add(this.CancelButton);
            this.DialogPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DialogPanel.Location = new System.Drawing.Point(0, 330);
            this.DialogPanel.Margin = new System.Windows.Forms.Padding(0);
            this.DialogPanel.Name = "DialogPanel";
            this.DialogPanel.Size = new System.Drawing.Size(659, 60);
            this.DialogPanel.TabIndex = 24;
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(435, 17);
            this.OKButton.Margin = new System.Windows.Forms.Padding(4);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(100, 28);
            this.OKButton.TabIndex = 1;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(543, 17);
            this.CancelButton.Margin = new System.Windows.Forms.Padding(4);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(100, 28);
            this.CancelButton.TabIndex = 0;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // AddPhotoButton
            // 
            this.AddPhotoButton.BackColor = System.Drawing.Color.White;
            this.AddPhotoButton.Image = global::ContactsApp.View.Properties.Resources.add_photo_32x32_gray;
            this.AddPhotoButton.Location = new System.Drawing.Point(61, 145);
            this.AddPhotoButton.Margin = new System.Windows.Forms.Padding(4);
            this.AddPhotoButton.Name = "AddPhotoButton";
            this.AddPhotoButton.Size = new System.Drawing.Size(43, 39);
            this.AddPhotoButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.AddPhotoButton.TabIndex = 22;
            this.AddPhotoButton.TabStop = false;
            this.AddPhotoButton.Click += new System.EventHandler(this.AddPhotoButton_Click);
            this.AddPhotoButton.MouseEnter += new System.EventHandler(this.AddPhotoButton_MouseEnter);
            this.AddPhotoButton.MouseLeave += new System.EventHandler(this.AddPhotoButton_MouseLeave);
            // 
            // PhotoPictureBox
            // 
            this.PhotoPictureBox.Image = global::ContactsApp.View.Properties.Resources.photo_placeholder_100x100;
            this.PhotoPictureBox.Location = new System.Drawing.Point(16, 15);
            this.PhotoPictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.PhotoPictureBox.Name = "PhotoPictureBox";
            this.PhotoPictureBox.Size = new System.Drawing.Size(133, 123);
            this.PhotoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PhotoPictureBox.TabIndex = 11;
            this.PhotoPictureBox.TabStop = false;
            // 
            // FullNamePictureBox
            // 
            this.FullNamePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("FullNamePictureBox.Image")));
            this.FullNamePictureBox.Location = new System.Drawing.Point(232, 18);
            this.FullNamePictureBox.Name = "FullNamePictureBox";
            this.FullNamePictureBox.Size = new System.Drawing.Size(16, 16);
            this.FullNamePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.FullNamePictureBox.TabIndex = 25;
            this.FullNamePictureBox.TabStop = false;
            // 
            // EmailPictureBox
            // 
            this.EmailPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("EmailPictureBox.Image")));
            this.EmailPictureBox.Location = new System.Drawing.Point(212, 79);
            this.EmailPictureBox.Name = "EmailPictureBox";
            this.EmailPictureBox.Size = new System.Drawing.Size(16, 16);
            this.EmailPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.EmailPictureBox.TabIndex = 26;
            this.EmailPictureBox.TabStop = false;
            // 
            // PhoneNumberPictureBox
            // 
            this.PhoneNumberPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("PhoneNumberPictureBox.Image")));
            this.PhoneNumberPictureBox.Location = new System.Drawing.Point(261, 139);
            this.PhoneNumberPictureBox.Name = "PhoneNumberPictureBox";
            this.PhoneNumberPictureBox.Size = new System.Drawing.Size(16, 16);
            this.PhoneNumberPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PhoneNumberPictureBox.TabIndex = 27;
            this.PhoneNumberPictureBox.TabStop = false;
            // 
            // DateOfBirthPictureBox
            // 
            this.DateOfBirthPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("DateOfBirthPictureBox.Image")));
            this.DateOfBirthPictureBox.Location = new System.Drawing.Point(246, 199);
            this.DateOfBirthPictureBox.Name = "DateOfBirthPictureBox";
            this.DateOfBirthPictureBox.Size = new System.Drawing.Size(16, 16);
            this.DateOfBirthPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.DateOfBirthPictureBox.TabIndex = 28;
            this.DateOfBirthPictureBox.TabStop = false;
            // 
            // VKPictureBox
            // 
            this.VKPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("VKPictureBox.Image")));
            this.VKPictureBox.Location = new System.Drawing.Point(191, 260);
            this.VKPictureBox.Name = "VKPictureBox";
            this.VKPictureBox.Size = new System.Drawing.Size(16, 16);
            this.VKPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.VKPictureBox.TabIndex = 29;
            this.VKPictureBox.TabStop = false;
            // 
            // ContactForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(659, 390);
            this.Controls.Add(this.VKPictureBox);
            this.Controls.Add(this.DateOfBirthPictureBox);
            this.Controls.Add(this.PhoneNumberPictureBox);
            this.Controls.Add(this.EmailPictureBox);
            this.Controls.Add(this.FullNamePictureBox);
            this.Controls.Add(this.DialogPanel);
            this.Controls.Add(this.DateOfBirthTimePicker);
            this.Controls.Add(this.AddPhotoButton);
            this.Controls.Add(this.VKTextBox);
            this.Controls.Add(this.VKLabel);
            this.Controls.Add(this.DateOfBirthLabel);
            this.Controls.Add(this.PhoneNumberTextBox);
            this.Controls.Add(this.PhoneNumberLabel);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.FullNameTextBox);
            this.Controls.Add(this.FullNameLabel);
            this.Controls.Add(this.PhotoPictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "ContactForm";
            this.ShowIcon = false;
            this.DialogPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AddPhotoButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PhotoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FullNamePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmailPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PhoneNumberPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateOfBirthPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VKPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox VKTextBox;
        private System.Windows.Forms.Label VKLabel;
        private System.Windows.Forms.Label DateOfBirthLabel;
        private System.Windows.Forms.TextBox PhoneNumberTextBox;
        private System.Windows.Forms.Label PhoneNumberLabel;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.TextBox FullNameTextBox;
        private System.Windows.Forms.Label FullNameLabel;
        private System.Windows.Forms.PictureBox PhotoPictureBox;
        private System.Windows.Forms.PictureBox AddPhotoButton;
        private System.Windows.Forms.DateTimePicker DateOfBirthTimePicker;
        private System.Windows.Forms.Panel DialogPanel;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.PictureBox FullNamePictureBox;
        private System.Windows.Forms.PictureBox EmailPictureBox;
        private System.Windows.Forms.PictureBox PhoneNumberPictureBox;
        private System.Windows.Forms.PictureBox DateOfBirthPictureBox;
        private System.Windows.Forms.PictureBox VKPictureBox;
    }
}