namespace ContactsApp.View
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
            this.VKTextBox = new System.Windows.Forms.TextBox();
            this.VKLabel = new System.Windows.Forms.Label();
            this.DateOfBirthLabel = new System.Windows.Forms.Label();
            this.PhoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.PhoneNumberLabel = new System.Windows.Forms.Label();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.FullNameTextBox = new System.Windows.Forms.TextBox();
            this.FullNameLabel = new System.Windows.Forms.Label();
            this.PhotoPictureBox = new System.Windows.Forms.PictureBox();
            this.AddPhotoButton = new System.Windows.Forms.PictureBox();
            this.DateOfBirthTimePicker = new System.Windows.Forms.DateTimePicker();
            this.DialogPanel = new System.Windows.Forms.Panel();
            this.OKButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.fullnameErrorPictureBox = new System.Windows.Forms.PictureBox();
            this.emailErrorPictureBox = new System.Windows.Forms.PictureBox();
            this.phoneNumberErrorPictureBox = new System.Windows.Forms.PictureBox();
            this.dateOfBirthErrorPictureBox = new System.Windows.Forms.PictureBox();
            this.VkErrorPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PhotoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddPhotoButton)).BeginInit();
            this.DialogPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fullnameErrorPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emailErrorPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneNumberErrorPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateOfBirthErrorPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VkErrorPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // VKTextBox
            // 
            this.VKTextBox.Location = new System.Drawing.Point(118, 227);
            this.VKTextBox.Name = "VKTextBox";
            this.VKTextBox.Size = new System.Drawing.Size(175, 20);
            this.VKTextBox.TabIndex = 21;
            this.VKTextBox.TextChanged += new System.EventHandler(this.VKTextBox_TextChanged);
            // 
            // VKLabel
            // 
            this.VKLabel.AutoSize = true;
            this.VKLabel.Location = new System.Drawing.Point(118, 211);
            this.VKLabel.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.VKLabel.Name = "VKLabel";
            this.VKLabel.Size = new System.Drawing.Size(24, 13);
            this.VKLabel.TabIndex = 20;
            this.VKLabel.Text = "VK:";
            // 
            // DateOfBirthLabel
            // 
            this.DateOfBirthLabel.AutoSize = true;
            this.DateOfBirthLabel.Location = new System.Drawing.Point(118, 162);
            this.DateOfBirthLabel.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.DateOfBirthLabel.Name = "DateOfBirthLabel";
            this.DateOfBirthLabel.Size = new System.Drawing.Size(69, 13);
            this.DateOfBirthLabel.TabIndex = 18;
            this.DateOfBirthLabel.Text = "Date of Birth:";
            // 
            // PhoneNumberTextBox
            // 
            this.PhoneNumberTextBox.Location = new System.Drawing.Point(118, 129);
            this.PhoneNumberTextBox.Name = "PhoneNumberTextBox";
            this.PhoneNumberTextBox.Size = new System.Drawing.Size(175, 20);
            this.PhoneNumberTextBox.TabIndex = 17;
            this.PhoneNumberTextBox.Text = "+7 (951) 620-11-36";
            this.PhoneNumberTextBox.TextChanged += new System.EventHandler(this.PhoneNumberTextBox_TextChanged);
            // 
            // PhoneNumberLabel
            // 
            this.PhoneNumberLabel.AutoSize = true;
            this.PhoneNumberLabel.Location = new System.Drawing.Point(118, 113);
            this.PhoneNumberLabel.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.PhoneNumberLabel.Name = "PhoneNumberLabel";
            this.PhoneNumberLabel.Size = new System.Drawing.Size(78, 13);
            this.PhoneNumberLabel.TabIndex = 16;
            this.PhoneNumberLabel.Text = "PhoneNumber:";
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EmailTextBox.Location = new System.Drawing.Point(118, 80);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(364, 20);
            this.EmailTextBox.TabIndex = 15;
            this.EmailTextBox.Text = "cool_snail@gmail.com";
            this.EmailTextBox.TextChanged += new System.EventHandler(this.EmailTextBox_TextChanged);
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Location = new System.Drawing.Point(118, 64);
            this.EmailLabel.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(38, 13);
            this.EmailLabel.TabIndex = 14;
            this.EmailLabel.Text = "E-mail:";
            // 
            // FullNameTextBox
            // 
            this.FullNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FullNameTextBox.Location = new System.Drawing.Point(118, 31);
            this.FullNameTextBox.Name = "FullNameTextBox";
            this.FullNameTextBox.Size = new System.Drawing.Size(364, 20);
            this.FullNameTextBox.TabIndex = 13;
            this.FullNameTextBox.Text = "Улитка из бара в модной рубашке";
            this.FullNameTextBox.TextChanged += new System.EventHandler(this.FullNameTextBox_TextChanged);
            // 
            // FullNameLabel
            // 
            this.FullNameLabel.AutoSize = true;
            this.FullNameLabel.Location = new System.Drawing.Point(118, 15);
            this.FullNameLabel.Name = "FullNameLabel";
            this.FullNameLabel.Size = new System.Drawing.Size(55, 13);
            this.FullNameLabel.TabIndex = 12;
            this.FullNameLabel.Text = "Full name:";
            // 
            // PhotoPictureBox
            // 
            this.PhotoPictureBox.Image = global::ContactsApp.View.Properties.Resources.photo_placeholder_100x100;
            this.PhotoPictureBox.Location = new System.Drawing.Point(12, 12);
            this.PhotoPictureBox.Name = "PhotoPictureBox";
            this.PhotoPictureBox.Size = new System.Drawing.Size(100, 100);
            this.PhotoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PhotoPictureBox.TabIndex = 11;
            this.PhotoPictureBox.TabStop = false;
            // 
            // AddPhotoButton
            // 
            this.AddPhotoButton.BackColor = System.Drawing.Color.White;
            this.AddPhotoButton.Image = global::ContactsApp.View.Properties.Resources.add_photo_32x32_gray;
            this.AddPhotoButton.Location = new System.Drawing.Point(46, 118);
            this.AddPhotoButton.Name = "AddPhotoButton";
            this.AddPhotoButton.Size = new System.Drawing.Size(32, 32);
            this.AddPhotoButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.AddPhotoButton.TabIndex = 22;
            this.AddPhotoButton.TabStop = false;
            this.AddPhotoButton.Click += new System.EventHandler(this.AddPhotoButton_Click);
            this.AddPhotoButton.MouseEnter += new System.EventHandler(this.AddPhotoButton_MouseEnter);
            this.AddPhotoButton.MouseLeave += new System.EventHandler(this.AddPhotoButton_MouseLeave);
            // 
            // DateOfBirthTimePicker
            // 
            this.DateOfBirthTimePicker.CalendarMonthBackground = System.Drawing.SystemColors.Control;
            this.DateOfBirthTimePicker.CalendarTitleBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.DateOfBirthTimePicker.Location = new System.Drawing.Point(118, 178);
            this.DateOfBirthTimePicker.Name = "DateOfBirthTimePicker";
            this.DateOfBirthTimePicker.Size = new System.Drawing.Size(175, 20);
            this.DateOfBirthTimePicker.TabIndex = 23;
            this.DateOfBirthTimePicker.ValueChanged += new System.EventHandler(this.DateOfBirthTimePicker_ValueChanged);
            // 
            // DialogPanel
            // 
            this.DialogPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.DialogPanel.Controls.Add(this.OKButton);
            this.DialogPanel.Controls.Add(this.CancelButton);
            this.DialogPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DialogPanel.Location = new System.Drawing.Point(0, 268);
            this.DialogPanel.Margin = new System.Windows.Forms.Padding(0);
            this.DialogPanel.Name = "DialogPanel";
            this.DialogPanel.Size = new System.Drawing.Size(494, 49);
            this.DialogPanel.TabIndex = 24;
            // 
            // OKButton
            // 
            this.OKButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OKButton.Location = new System.Drawing.Point(326, 14);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 23);
            this.OKButton.TabIndex = 1;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelButton.Location = new System.Drawing.Point(407, 14);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 0;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // fullnameErrorPictureBox
            // 
            this.fullnameErrorPictureBox.Image = global::ContactsApp.View.Properties.Resources.icon_error_30_30;
            this.fullnameErrorPictureBox.Location = new System.Drawing.Point(179, 14);
            this.fullnameErrorPictureBox.Name = "fullnameErrorPictureBox";
            this.fullnameErrorPictureBox.Size = new System.Drawing.Size(15, 15);
            this.fullnameErrorPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.fullnameErrorPictureBox.TabIndex = 25;
            this.fullnameErrorPictureBox.TabStop = false;
            this.fullnameErrorPictureBox.Visible = false;
            // 
            // emailErrorPictureBox
            // 
            this.emailErrorPictureBox.Image = global::ContactsApp.View.Properties.Resources.icon_error_30_30;
            this.emailErrorPictureBox.Location = new System.Drawing.Point(162, 63);
            this.emailErrorPictureBox.Name = "emailErrorPictureBox";
            this.emailErrorPictureBox.Size = new System.Drawing.Size(15, 15);
            this.emailErrorPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.emailErrorPictureBox.TabIndex = 26;
            this.emailErrorPictureBox.TabStop = false;
            this.emailErrorPictureBox.Visible = false;
            // 
            // phoneNumberErrorPictureBox
            // 
            this.phoneNumberErrorPictureBox.Image = global::ContactsApp.View.Properties.Resources.icon_error_30_30;
            this.phoneNumberErrorPictureBox.Location = new System.Drawing.Point(202, 112);
            this.phoneNumberErrorPictureBox.Name = "phoneNumberErrorPictureBox";
            this.phoneNumberErrorPictureBox.Size = new System.Drawing.Size(15, 15);
            this.phoneNumberErrorPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.phoneNumberErrorPictureBox.TabIndex = 27;
            this.phoneNumberErrorPictureBox.TabStop = false;
            this.phoneNumberErrorPictureBox.Visible = false;
            // 
            // dateOfBirthErrorPictureBox
            // 
            this.dateOfBirthErrorPictureBox.Image = global::ContactsApp.View.Properties.Resources.icon_error_30_30;
            this.dateOfBirthErrorPictureBox.Location = new System.Drawing.Point(193, 161);
            this.dateOfBirthErrorPictureBox.Name = "dateOfBirthErrorPictureBox";
            this.dateOfBirthErrorPictureBox.Size = new System.Drawing.Size(15, 15);
            this.dateOfBirthErrorPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.dateOfBirthErrorPictureBox.TabIndex = 28;
            this.dateOfBirthErrorPictureBox.TabStop = false;
            this.dateOfBirthErrorPictureBox.Visible = false;
            // 
            // VkErrorPictureBox
            // 
            this.VkErrorPictureBox.Image = global::ContactsApp.View.Properties.Resources.icon_error_30_30;
            this.VkErrorPictureBox.Location = new System.Drawing.Point(148, 210);
            this.VkErrorPictureBox.Name = "VkErrorPictureBox";
            this.VkErrorPictureBox.Size = new System.Drawing.Size(15, 15);
            this.VkErrorPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.VkErrorPictureBox.TabIndex = 29;
            this.VkErrorPictureBox.TabStop = false;
            this.VkErrorPictureBox.Visible = false;
            // 
            // ContactForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(494, 317);
            this.Controls.Add(this.VkErrorPictureBox);
            this.Controls.Add(this.dateOfBirthErrorPictureBox);
            this.Controls.Add(this.phoneNumberErrorPictureBox);
            this.Controls.Add(this.emailErrorPictureBox);
            this.Controls.Add(this.fullnameErrorPictureBox);
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
            this.MaximizeBox = false;
            this.Name = "ContactForm";
            this.ShowIcon = false;
            ((System.ComponentModel.ISupportInitialize)(this.PhotoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddPhotoButton)).EndInit();
            this.DialogPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fullnameErrorPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emailErrorPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneNumberErrorPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateOfBirthErrorPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VkErrorPictureBox)).EndInit();
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
        private System.Windows.Forms.PictureBox fullnameErrorPictureBox;
        private System.Windows.Forms.PictureBox emailErrorPictureBox;
        private System.Windows.Forms.PictureBox phoneNumberErrorPictureBox;
        private System.Windows.Forms.PictureBox dateOfBirthErrorPictureBox;
        private System.Windows.Forms.PictureBox VkErrorPictureBox;
    }
}