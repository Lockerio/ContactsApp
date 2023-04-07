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
            this.AddContactButton = new System.Windows.Forms.Button();
            this.EditContactButton = new System.Windows.Forms.Button();
            this.RemoveContactButton = new System.Windows.Forms.Button();
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
            this.SuspendLayout();
            // 
            // MainTableLayoutPanel
            // 
            this.MainTableLayoutPanel.ColumnCount = 2;
            this.MainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.MainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainTableLayoutPanel.Controls.Add(this.ContactReadPanel, 1, 0);
            this.MainTableLayoutPanel.Controls.Add(this.ContactsListPanel, 0, 0);
            this.MainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.MainTableLayoutPanel.Name = "MainTableLayoutPanel";
            this.MainTableLayoutPanel.RowCount = 1;
            this.MainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainTableLayoutPanel.Size = new System.Drawing.Size(800, 450);
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
            this.ContactReadPanel.Location = new System.Drawing.Point(253, 3);
            this.ContactReadPanel.Name = "ContactReadPanel";
            this.ContactReadPanel.Size = new System.Drawing.Size(544, 444);
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
            this.BirthdayPanel.Location = new System.Drawing.Point(3, 366);
            this.BirthdayPanel.Name = "BirthdayPanel";
            this.BirthdayPanel.Size = new System.Drawing.Size(538, 75);
            this.BirthdayPanel.TabIndex = 11;
            // 
            // BirthdayPanelCloseButton
            // 
            this.BirthdayPanelCloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BirthdayPanelCloseButton.FlatAppearance.BorderSize = 0;
            this.BirthdayPanelCloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BirthdayPanelCloseButton.Image = global::ContactsApp.View.Properties.Resources.close_32x32;
            this.BirthdayPanelCloseButton.Location = new System.Drawing.Point(503, 3);
            this.BirthdayPanelCloseButton.Name = "BirthdayPanelCloseButton";
            this.BirthdayPanelCloseButton.Size = new System.Drawing.Size(32, 32);
            this.BirthdayPanelCloseButton.TabIndex = 12;
            this.BirthdayPanelCloseButton.UseVisualStyleBackColor = true;
            // 
            // BirtdaySurnamesLabel
            // 
            this.BirtdaySurnamesLabel.AutoSize = true;
            this.BirtdaySurnamesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BirtdaySurnamesLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.BirtdaySurnamesLabel.Location = new System.Drawing.Point(78, 43);
            this.BirtdaySurnamesLabel.Name = "BirtdaySurnamesLabel";
            this.BirtdaySurnamesLabel.Size = new System.Drawing.Size(208, 13);
            this.BirtdaySurnamesLabel.TabIndex = 14;
            this.BirtdaySurnamesLabel.Text = "Улитка из бара, Линдеманн и др.";
            // 
            // BithdayLabel
            // 
            this.BithdayLabel.AutoSize = true;
            this.BithdayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BithdayLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.BithdayLabel.Location = new System.Drawing.Point(78, 21);
            this.BithdayLabel.Name = "BithdayLabel";
            this.BithdayLabel.Size = new System.Drawing.Size(124, 13);
            this.BithdayLabel.TabIndex = 13;
            this.BithdayLabel.Text = "Today is Birthday of:";
            // 
            // InfoPictureBox
            // 
            this.InfoPictureBox.Image = global::ContactsApp.View.Properties.Resources.info_48x48;
            this.InfoPictureBox.Location = new System.Drawing.Point(3, 3);
            this.InfoPictureBox.Name = "InfoPictureBox";
            this.InfoPictureBox.Size = new System.Drawing.Size(69, 69);
            this.InfoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.InfoPictureBox.TabIndex = 12;
            this.InfoPictureBox.TabStop = false;
            // 
            // VKTextBox
            // 
            this.VKTextBox.Location = new System.Drawing.Point(109, 218);
            this.VKTextBox.Name = "VKTextBox";
            this.VKTextBox.Size = new System.Drawing.Size(175, 20);
            this.VKTextBox.TabIndex = 10;
            // 
            // VKLabel
            // 
            this.VKLabel.AutoSize = true;
            this.VKLabel.Location = new System.Drawing.Point(109, 202);
            this.VKLabel.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.VKLabel.Name = "VKLabel";
            this.VKLabel.Size = new System.Drawing.Size(24, 13);
            this.VKLabel.TabIndex = 9;
            this.VKLabel.Text = "VK:";
            // 
            // DateOfBirthTextBox
            // 
            this.DateOfBirthTextBox.Location = new System.Drawing.Point(109, 169);
            this.DateOfBirthTextBox.Name = "DateOfBirthTextBox";
            this.DateOfBirthTextBox.Size = new System.Drawing.Size(175, 20);
            this.DateOfBirthTextBox.TabIndex = 8;
            // 
            // DateOfBirthLabel
            // 
            this.DateOfBirthLabel.AutoSize = true;
            this.DateOfBirthLabel.Location = new System.Drawing.Point(109, 153);
            this.DateOfBirthLabel.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.DateOfBirthLabel.Name = "DateOfBirthLabel";
            this.DateOfBirthLabel.Size = new System.Drawing.Size(69, 13);
            this.DateOfBirthLabel.TabIndex = 7;
            this.DateOfBirthLabel.Text = "Date of Birth:";
            // 
            // PhoneNumberTextBox
            // 
            this.PhoneNumberTextBox.Location = new System.Drawing.Point(109, 120);
            this.PhoneNumberTextBox.Name = "PhoneNumberTextBox";
            this.PhoneNumberTextBox.Size = new System.Drawing.Size(175, 20);
            this.PhoneNumberTextBox.TabIndex = 6;
            this.PhoneNumberTextBox.Text = "+7 (951) 620-11-36";
            // 
            // PhoneNumberLabel
            // 
            this.PhoneNumberLabel.AutoSize = true;
            this.PhoneNumberLabel.Location = new System.Drawing.Point(109, 104);
            this.PhoneNumberLabel.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.PhoneNumberLabel.Name = "PhoneNumberLabel";
            this.PhoneNumberLabel.Size = new System.Drawing.Size(78, 13);
            this.PhoneNumberLabel.TabIndex = 5;
            this.PhoneNumberLabel.Text = "PhoneNumber:";
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EmailTextBox.Location = new System.Drawing.Point(109, 71);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(432, 20);
            this.EmailTextBox.TabIndex = 4;
            this.EmailTextBox.Text = "cool_snail@gmail.com";
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Location = new System.Drawing.Point(109, 55);
            this.EmailLabel.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(38, 13);
            this.EmailLabel.TabIndex = 3;
            this.EmailLabel.Text = "E-mail:";
            // 
            // FullNameTextBox
            // 
            this.FullNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FullNameTextBox.Location = new System.Drawing.Point(109, 22);
            this.FullNameTextBox.Name = "FullNameTextBox";
            this.FullNameTextBox.Size = new System.Drawing.Size(432, 20);
            this.FullNameTextBox.TabIndex = 2;
            this.FullNameTextBox.Text = "Улитка из бара в модной рубашке";
            // 
            // FullNameLabel
            // 
            this.FullNameLabel.AutoSize = true;
            this.FullNameLabel.Location = new System.Drawing.Point(109, 6);
            this.FullNameLabel.Name = "FullNameLabel";
            this.FullNameLabel.Size = new System.Drawing.Size(55, 13);
            this.FullNameLabel.TabIndex = 1;
            this.FullNameLabel.Text = "Full name:";
            // 
            // PhotoPictureBox
            // 
            this.PhotoPictureBox.Image = global::ContactsApp.View.Properties.Resources.photo_placeholder_100x100;
            this.PhotoPictureBox.Location = new System.Drawing.Point(3, 3);
            this.PhotoPictureBox.Name = "PhotoPictureBox";
            this.PhotoPictureBox.Size = new System.Drawing.Size(100, 100);
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
            this.ContactsListPanel.Location = new System.Drawing.Point(3, 3);
            this.ContactsListPanel.Name = "ContactsListPanel";
            this.ContactsListPanel.Size = new System.Drawing.Size(244, 444);
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
            this.ButtonsTableLayoutPanel.Location = new System.Drawing.Point(3, 406);
            this.ButtonsTableLayoutPanel.Name = "ButtonsTableLayoutPanel";
            this.ButtonsTableLayoutPanel.RowCount = 1;
            this.ButtonsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ButtonsTableLayoutPanel.Size = new System.Drawing.Size(238, 35);
            this.ButtonsTableLayoutPanel.TabIndex = 3;
            // 
            // AddContactButton
            // 
            this.AddContactButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddContactButton.FlatAppearance.BorderSize = 0;
            this.AddContactButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddContactButton.Image = global::ContactsApp.View.Properties.Resources.add_contact_32x32_gray;
            this.AddContactButton.Location = new System.Drawing.Point(0, 0);
            this.AddContactButton.Margin = new System.Windows.Forms.Padding(0);
            this.AddContactButton.Name = "AddContactButton";
            this.AddContactButton.Size = new System.Drawing.Size(79, 35);
            this.AddContactButton.TabIndex = 0;
            this.AddContactButton.UseVisualStyleBackColor = true;
            this.AddContactButton.Click += new System.EventHandler(this.AddContactButton_Click);
            // 
            // EditContactButton
            // 
            this.EditContactButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EditContactButton.FlatAppearance.BorderSize = 0;
            this.EditContactButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditContactButton.Image = global::ContactsApp.View.Properties.Resources.edit_contact_32x32_gray;
            this.EditContactButton.Location = new System.Drawing.Point(79, 0);
            this.EditContactButton.Margin = new System.Windows.Forms.Padding(0);
            this.EditContactButton.Name = "EditContactButton";
            this.EditContactButton.Size = new System.Drawing.Size(79, 35);
            this.EditContactButton.TabIndex = 1;
            this.EditContactButton.UseVisualStyleBackColor = true;
            // 
            // RemoveContactButton
            // 
            this.RemoveContactButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RemoveContactButton.FlatAppearance.BorderSize = 0;
            this.RemoveContactButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveContactButton.Image = global::ContactsApp.View.Properties.Resources.remove_contact_32x32_gray;
            this.RemoveContactButton.Location = new System.Drawing.Point(158, 0);
            this.RemoveContactButton.Margin = new System.Windows.Forms.Padding(0);
            this.RemoveContactButton.Name = "RemoveContactButton";
            this.RemoveContactButton.Size = new System.Drawing.Size(80, 35);
            this.RemoveContactButton.TabIndex = 2;
            this.RemoveContactButton.UseVisualStyleBackColor = true;
            // 
            // FindLabel
            // 
            this.FindLabel.AutoSize = true;
            this.FindLabel.Location = new System.Drawing.Point(3, 6);
            this.FindLabel.Name = "FindLabel";
            this.FindLabel.Size = new System.Drawing.Size(30, 13);
            this.FindLabel.TabIndex = 2;
            this.FindLabel.Text = "Find:";
            // 
            // FindTextBox
            // 
            this.FindTextBox.Location = new System.Drawing.Point(39, 3);
            this.FindTextBox.Name = "FindTextBox";
            this.FindTextBox.Size = new System.Drawing.Size(202, 20);
            this.FindTextBox.TabIndex = 1;
            // 
            // ContactsListBox
            // 
            this.ContactsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ContactsListBox.FormattingEnabled = true;
            this.ContactsListBox.IntegralHeight = false;
            this.ContactsListBox.Items.AddRange(new object[] {
            "Тилль Линдеманн",
            "Улитка из бара",
            "Рихард Круспе",
            "Пауль Ландерс",
            "Оливер Ридель",
            "Кристиан Лоренц",
            "Кристоф Шнайдер"});
            this.ContactsListBox.Location = new System.Drawing.Point(3, 29);
            this.ContactsListBox.Name = "ContactsListBox";
            this.ContactsListBox.Size = new System.Drawing.Size(238, 377);
            this.ContactsListBox.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MainTableLayoutPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "ContactsApp";
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
        private System.Windows.Forms.Button AddContactButton;
        private System.Windows.Forms.Button EditContactButton;
        private System.Windows.Forms.Button RemoveContactButton;
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
    }
}

