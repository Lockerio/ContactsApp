namespace ContactsApp.View
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MainTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.ContactReadPanel = new System.Windows.Forms.Panel();
            this.BirthdayPanel = new System.Windows.Forms.Panel();
            this.BirthdayPanelCloseButton = new System.Windows.Forms.Button();
            this.BirtdaySurnamesLabel = new System.Windows.Forms.Label();
            this.BithdayLabel = new System.Windows.Forms.Label();
            this.InfoPictureBox = new System.Windows.Forms.PictureBox();
            this.VKTextBox = new System.Windows.Forms.TextBox();
            this.VKLabel = new System.Windows.Forms.Label();
            this.DateOfBirthTextBox = new System.Windows.Forms.TextBox();
            this.DateOfBirthLabel = new System.Windows.Forms.Label();
            this.PhoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.PhoneNumberLabel = new System.Windows.Forms.Label();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.FullNameTextBox = new System.Windows.Forms.TextBox();
            this.FullNameLabel = new System.Windows.Forms.Label();
            this.PhotoPictureBox = new System.Windows.Forms.PictureBox();
            this.ContactsListPanel = new System.Windows.Forms.Panel();
            this.ButtonsTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.AddContactButton = new System.Windows.Forms.PictureBox();
            this.EditContactButton = new System.Windows.Forms.PictureBox();
            this.RemoveContactButton = new System.Windows.Forms.PictureBox();
            this.FindLabel = new System.Windows.Forms.Label();
            this.FindTextBox = new System.Windows.Forms.TextBox();
            this.ContactsListBox = new System.Windows.Forms.ListBox();
            this.MainTableLayoutPanel.SuspendLayout();
            this.ContactReadPanel.SuspendLayout();
            this.BirthdayPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InfoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PhotoPictureBox)).BeginInit();
            this.ContactsListPanel.SuspendLayout();
            this.ButtonsTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AddContactButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditContactButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RemoveContactButton)).BeginInit();
            this.SuspendLayout();
            // 
            // MainTableLayoutPanel
            // 
            this.MainTableLayoutPanel.ColumnCount = 2;
            this.MainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 333F));
            this.MainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainTableLayoutPanel.Controls.Add(this.ContactReadPanel, 1, 0);
            this.MainTableLayoutPanel.Controls.Add(this.ContactsListPanel, 0, 0);
            this.MainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.MainTableLayoutPanel.Margin = new System.Windows.Forms.Padding(4);
            this.MainTableLayoutPanel.Name = "MainTableLayoutPanel";
            this.MainTableLayoutPanel.RowCount = 1;
            this.MainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainTableLayoutPanel.Size = new System.Drawing.Size(1067, 554);
            this.MainTableLayoutPanel.TabIndex = 0;
            // 
            // ContactReadPanel
            // 
            this.ContactReadPanel.Controls.Add(this.BirthdayPanel);
            this.ContactReadPanel.Controls.Add(this.VKTextBox);
            this.ContactReadPanel.Controls.Add(this.VKLabel);
            this.ContactReadPanel.Controls.Add(this.DateOfBirthTextBox);
            this.ContactReadPanel.Controls.Add(this.DateOfBirthLabel);
            this.ContactReadPanel.Controls.Add(this.PhoneNumberTextBox);
            this.ContactReadPanel.Controls.Add(this.PhoneNumberLabel);
            this.ContactReadPanel.Controls.Add(this.EmailTextBox);
            this.ContactReadPanel.Controls.Add(this.EmailLabel);
            this.ContactReadPanel.Controls.Add(this.FullNameTextBox);
            this.ContactReadPanel.Controls.Add(this.FullNameLabel);
            this.ContactReadPanel.Controls.Add(this.PhotoPictureBox);
            this.ContactReadPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContactReadPanel.Location = new System.Drawing.Point(337, 4);
            this.ContactReadPanel.Margin = new System.Windows.Forms.Padding(4);
            this.ContactReadPanel.Name = "ContactReadPanel";
            this.ContactReadPanel.Size = new System.Drawing.Size(726, 546);
            this.ContactReadPanel.TabIndex = 0;
            // 
            // BirthdayPanel
            // 
            this.BirthdayPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BirthdayPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.BirthdayPanel.Controls.Add(this.BirthdayPanelCloseButton);
            this.BirthdayPanel.Controls.Add(this.BirtdaySurnamesLabel);
            this.BirthdayPanel.Controls.Add(this.BithdayLabel);
            this.BirthdayPanel.Controls.Add(this.InfoPictureBox);
            this.BirthdayPanel.Location = new System.Drawing.Point(4, 450);
            this.BirthdayPanel.Margin = new System.Windows.Forms.Padding(4);
            this.BirthdayPanel.Name = "BirthdayPanel";
            this.BirthdayPanel.Size = new System.Drawing.Size(718, 92);
            this.BirthdayPanel.TabIndex = 11;
            // 
            // BirthdayPanelCloseButton
            // 
            this.BirthdayPanelCloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BirthdayPanelCloseButton.FlatAppearance.BorderSize = 0;
            this.BirthdayPanelCloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BirthdayPanelCloseButton.Image = global::ContactsApp.View.Properties.Resources.close_32x32;
            this.BirthdayPanelCloseButton.Location = new System.Drawing.Point(672, 4);
            this.BirthdayPanelCloseButton.Margin = new System.Windows.Forms.Padding(4);
            this.BirthdayPanelCloseButton.Name = "BirthdayPanelCloseButton";
            this.BirthdayPanelCloseButton.Size = new System.Drawing.Size(43, 39);
            this.BirthdayPanelCloseButton.TabIndex = 12;
            this.BirthdayPanelCloseButton.UseVisualStyleBackColor = true;
            this.BirthdayPanelCloseButton.Click += new System.EventHandler(this.BirthdayPanelCloseButton_Click);
            // 
            // BirtdaySurnamesLabel
            // 
            this.BirtdaySurnamesLabel.AutoSize = true;
            this.BirtdaySurnamesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BirtdaySurnamesLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.BirtdaySurnamesLabel.Location = new System.Drawing.Point(104, 53);
            this.BirtdaySurnamesLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BirtdaySurnamesLabel.Name = "BirtdaySurnamesLabel";
            this.BirtdaySurnamesLabel.Size = new System.Drawing.Size(260, 17);
            this.BirtdaySurnamesLabel.TabIndex = 14;
            this.BirtdaySurnamesLabel.Text = "Улитка из бара, Линдеманн и др.";
            // 
            // BithdayLabel
            // 
            this.BithdayLabel.AutoSize = true;
            this.BithdayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BithdayLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.BithdayLabel.Location = new System.Drawing.Point(104, 26);
            this.BithdayLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BithdayLabel.Name = "BithdayLabel";
            this.BithdayLabel.Size = new System.Drawing.Size(159, 17);
            this.BithdayLabel.TabIndex = 13;
            this.BithdayLabel.Text = "Today is Birthday of:";
            // 
            // InfoPictureBox
            // 
            this.InfoPictureBox.Image = global::ContactsApp.View.Properties.Resources.info_48x48;
            this.InfoPictureBox.Location = new System.Drawing.Point(4, 4);
            this.InfoPictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.InfoPictureBox.Name = "InfoPictureBox";
            this.InfoPictureBox.Size = new System.Drawing.Size(92, 85);
            this.InfoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.InfoPictureBox.TabIndex = 12;
            this.InfoPictureBox.TabStop = false;
            // 
            // VKTextBox
            // 
            this.VKTextBox.Location = new System.Drawing.Point(145, 268);
            this.VKTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.VKTextBox.Name = "VKTextBox";
            this.VKTextBox.Size = new System.Drawing.Size(232, 22);
            this.VKTextBox.TabIndex = 10;
            this.VKTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.VKTextBox_KeyPress);
            // 
            // VKLabel
            // 
            this.VKLabel.AutoSize = true;
            this.VKLabel.Location = new System.Drawing.Point(145, 249);
            this.VKLabel.Margin = new System.Windows.Forms.Padding(4, 12, 4, 0);
            this.VKLabel.Name = "VKLabel";
            this.VKLabel.Size = new System.Drawing.Size(27, 16);
            this.VKLabel.TabIndex = 9;
            this.VKLabel.Text = "VK:";
            // 
            // DateOfBirthTextBox
            // 
            this.DateOfBirthTextBox.Location = new System.Drawing.Point(145, 208);
            this.DateOfBirthTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.DateOfBirthTextBox.Name = "DateOfBirthTextBox";
            this.DateOfBirthTextBox.Size = new System.Drawing.Size(232, 22);
            this.DateOfBirthTextBox.TabIndex = 8;
            this.DateOfBirthTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DateOfBirthTextBox_KeyPress);
            // 
            // DateOfBirthLabel
            // 
            this.DateOfBirthLabel.AutoSize = true;
            this.DateOfBirthLabel.Location = new System.Drawing.Point(145, 188);
            this.DateOfBirthLabel.Margin = new System.Windows.Forms.Padding(4, 12, 4, 0);
            this.DateOfBirthLabel.Name = "DateOfBirthLabel";
            this.DateOfBirthLabel.Size = new System.Drawing.Size(82, 16);
            this.DateOfBirthLabel.TabIndex = 7;
            this.DateOfBirthLabel.Text = "Date of Birth:";
            // 
            // PhoneNumberTextBox
            // 
            this.PhoneNumberTextBox.Location = new System.Drawing.Point(145, 148);
            this.PhoneNumberTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.PhoneNumberTextBox.Name = "PhoneNumberTextBox";
            this.PhoneNumberTextBox.Size = new System.Drawing.Size(232, 22);
            this.PhoneNumberTextBox.TabIndex = 6;
            this.PhoneNumberTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PhoneNumberTextBox_KeyPress);
            // 
            // PhoneNumberLabel
            // 
            this.PhoneNumberLabel.AutoSize = true;
            this.PhoneNumberLabel.Location = new System.Drawing.Point(145, 128);
            this.PhoneNumberLabel.Margin = new System.Windows.Forms.Padding(4, 12, 4, 0);
            this.PhoneNumberLabel.Name = "PhoneNumberLabel";
            this.PhoneNumberLabel.Size = new System.Drawing.Size(97, 16);
            this.PhoneNumberLabel.TabIndex = 5;
            this.PhoneNumberLabel.Text = "PhoneNumber:";
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EmailTextBox.Location = new System.Drawing.Point(145, 87);
            this.EmailTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(576, 22);
            this.EmailTextBox.TabIndex = 4;
            this.EmailTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EmailTextBox_KeyPress);
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Location = new System.Drawing.Point(145, 68);
            this.EmailLabel.Margin = new System.Windows.Forms.Padding(4, 12, 4, 0);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(48, 16);
            this.EmailLabel.TabIndex = 3;
            this.EmailLabel.Text = "E-mail:";
            // 
            // FullNameTextBox
            // 
            this.FullNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FullNameTextBox.Location = new System.Drawing.Point(145, 27);
            this.FullNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.FullNameTextBox.Name = "FullNameTextBox";
            this.FullNameTextBox.Size = new System.Drawing.Size(576, 22);
            this.FullNameTextBox.TabIndex = 2;
            this.FullNameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FullNameTextBox_KeyPress);
            // 
            // FullNameLabel
            // 
            this.FullNameLabel.AutoSize = true;
            this.FullNameLabel.Location = new System.Drawing.Point(145, 7);
            this.FullNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FullNameLabel.Name = "FullNameLabel";
            this.FullNameLabel.Size = new System.Drawing.Size(68, 16);
            this.FullNameLabel.TabIndex = 1;
            this.FullNameLabel.Text = "Full name:";
            // 
            // PhotoPictureBox
            // 
            this.PhotoPictureBox.Image = global::ContactsApp.View.Properties.Resources.photo_placeholder_100x100;
            this.PhotoPictureBox.Location = new System.Drawing.Point(4, 4);
            this.PhotoPictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.PhotoPictureBox.Name = "PhotoPictureBox";
            this.PhotoPictureBox.Size = new System.Drawing.Size(133, 123);
            this.PhotoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PhotoPictureBox.TabIndex = 0;
            this.PhotoPictureBox.TabStop = false;
            // 
            // ContactsListPanel
            // 
            this.ContactsListPanel.Controls.Add(this.ButtonsTableLayoutPanel);
            this.ContactsListPanel.Controls.Add(this.FindLabel);
            this.ContactsListPanel.Controls.Add(this.FindTextBox);
            this.ContactsListPanel.Controls.Add(this.ContactsListBox);
            this.ContactsListPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContactsListPanel.Location = new System.Drawing.Point(4, 4);
            this.ContactsListPanel.Margin = new System.Windows.Forms.Padding(4);
            this.ContactsListPanel.Name = "ContactsListPanel";
            this.ContactsListPanel.Size = new System.Drawing.Size(325, 546);
            this.ContactsListPanel.TabIndex = 1;
            // 
            // ButtonsTableLayoutPanel
            // 
            this.ButtonsTableLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonsTableLayoutPanel.ColumnCount = 3;
            this.ButtonsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.ButtonsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.ButtonsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.ButtonsTableLayoutPanel.Controls.Add(this.AddContactButton, 0, 0);
            this.ButtonsTableLayoutPanel.Controls.Add(this.EditContactButton, 1, 0);
            this.ButtonsTableLayoutPanel.Controls.Add(this.RemoveContactButton, 2, 0);
            this.ButtonsTableLayoutPanel.Location = new System.Drawing.Point(4, 500);
            this.ButtonsTableLayoutPanel.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonsTableLayoutPanel.Name = "ButtonsTableLayoutPanel";
            this.ButtonsTableLayoutPanel.RowCount = 1;
            this.ButtonsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ButtonsTableLayoutPanel.Size = new System.Drawing.Size(317, 43);
            this.ButtonsTableLayoutPanel.TabIndex = 3;
            // 
            // AddContactButton
            // 
            this.AddContactButton.Image = global::ContactsApp.View.Properties.Resources.add_contact_32x32_gray;
            this.AddContactButton.Location = new System.Drawing.Point(0, 0);
            this.AddContactButton.Margin = new System.Windows.Forms.Padding(0);
            this.AddContactButton.Name = "AddContactButton";
            this.AddContactButton.Size = new System.Drawing.Size(105, 43);
            this.AddContactButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.AddContactButton.TabIndex = 0;
            this.AddContactButton.TabStop = false;
            this.AddContactButton.Click += new System.EventHandler(this.AddContactButton_Click);
            this.AddContactButton.MouseEnter += new System.EventHandler(this.AddContactButton_MouseEnter);
            this.AddContactButton.MouseLeave += new System.EventHandler(this.AddContactButton_MouseLeave);
            // 
            // EditContactButton
            // 
            this.EditContactButton.Image = global::ContactsApp.View.Properties.Resources.edit_contact_32x32_gray;
            this.EditContactButton.Location = new System.Drawing.Point(105, 0);
            this.EditContactButton.Margin = new System.Windows.Forms.Padding(0);
            this.EditContactButton.Name = "EditContactButton";
            this.EditContactButton.Size = new System.Drawing.Size(105, 43);
            this.EditContactButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.EditContactButton.TabIndex = 1;
            this.EditContactButton.TabStop = false;
            this.EditContactButton.Click += new System.EventHandler(this.EditContactButton_Click);
            this.EditContactButton.MouseEnter += new System.EventHandler(this.EditContactButton_MouseEnter);
            this.EditContactButton.MouseLeave += new System.EventHandler(this.EditContactButton_MouseLeave);
            // 
            // RemoveContactButton
            // 
            this.RemoveContactButton.Image = global::ContactsApp.View.Properties.Resources.remove_contact_32x32_gray;
            this.RemoveContactButton.Location = new System.Drawing.Point(210, 0);
            this.RemoveContactButton.Margin = new System.Windows.Forms.Padding(0);
            this.RemoveContactButton.Name = "RemoveContactButton";
            this.RemoveContactButton.Size = new System.Drawing.Size(107, 43);
            this.RemoveContactButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.RemoveContactButton.TabIndex = 2;
            this.RemoveContactButton.TabStop = false;
            this.RemoveContactButton.Click += new System.EventHandler(this.RemoveContactButton_Click);
            this.RemoveContactButton.MouseEnter += new System.EventHandler(this.RemoveContactButton_MouseEnter);
            this.RemoveContactButton.MouseLeave += new System.EventHandler(this.RemoveContactButton_MouseLeave);
            // 
            // FindLabel
            // 
            this.FindLabel.AutoSize = true;
            this.FindLabel.Location = new System.Drawing.Point(4, 7);
            this.FindLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FindLabel.Name = "FindLabel";
            this.FindLabel.Size = new System.Drawing.Size(36, 16);
            this.FindLabel.TabIndex = 2;
            this.FindLabel.Text = "Find:";
            // 
            // FindTextBox
            // 
            this.FindTextBox.Location = new System.Drawing.Point(52, 4);
            this.FindTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.FindTextBox.Name = "FindTextBox";
            this.FindTextBox.Size = new System.Drawing.Size(268, 22);
            this.FindTextBox.TabIndex = 1;
            // 
            // ContactsListBox
            // 
            this.ContactsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ContactsListBox.FormattingEnabled = true;
            this.ContactsListBox.IntegralHeight = false;
            this.ContactsListBox.ItemHeight = 16;
            this.ContactsListBox.Location = new System.Drawing.Point(4, 36);
            this.ContactsListBox.Margin = new System.Windows.Forms.Padding(4);
            this.ContactsListBox.Name = "ContactsListBox";
            this.ContactsListBox.Size = new System.Drawing.Size(316, 463);
            this.ContactsListBox.TabIndex = 0;
            this.ContactsListBox.SelectedIndexChanged += new System.EventHandler(this.ContactsListBox_SelectedIndexChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.MainTableLayoutPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "ContactsApp";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.MainTableLayoutPanel.ResumeLayout(false);
            this.ContactReadPanel.ResumeLayout(false);
            this.ContactReadPanel.PerformLayout();
            this.BirthdayPanel.ResumeLayout(false);
            this.BirthdayPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InfoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PhotoPictureBox)).EndInit();
            this.ContactsListPanel.ResumeLayout(false);
            this.ContactsListPanel.PerformLayout();
            this.ButtonsTableLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AddContactButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditContactButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RemoveContactButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel MainTableLayoutPanel;
        private System.Windows.Forms.Panel ContactReadPanel;
        private System.Windows.Forms.Panel ContactsListPanel;
        private System.Windows.Forms.ListBox ContactsListBox;
        private System.Windows.Forms.Label FindLabel;
        private System.Windows.Forms.TextBox FindTextBox;
        private System.Windows.Forms.TableLayoutPanel ButtonsTableLayoutPanel;
        private System.Windows.Forms.PictureBox PhotoPictureBox;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.TextBox FullNameTextBox;
        private System.Windows.Forms.Label FullNameLabel;
        private System.Windows.Forms.Label PhoneNumberLabel;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.TextBox VKTextBox;
        private System.Windows.Forms.Label VKLabel;
        private System.Windows.Forms.TextBox DateOfBirthTextBox;
        private System.Windows.Forms.Label DateOfBirthLabel;
        private System.Windows.Forms.TextBox PhoneNumberTextBox;
        private System.Windows.Forms.Panel BirthdayPanel;
        private System.Windows.Forms.Label BirtdaySurnamesLabel;
        private System.Windows.Forms.Label BithdayLabel;
        private System.Windows.Forms.PictureBox InfoPictureBox;
        private System.Windows.Forms.Button BirthdayPanelCloseButton;
        private System.Windows.Forms.PictureBox AddContactButton;
        private System.Windows.Forms.PictureBox EditContactButton;
        private System.Windows.Forms.PictureBox RemoveContactButton;
    }
}

