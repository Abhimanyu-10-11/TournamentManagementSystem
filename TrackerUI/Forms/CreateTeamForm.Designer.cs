namespace TrackerUI
{
    partial class CreateTeamForm
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
            CreateTeamLable = new Label();
            TeamNameTextBox = new TextBox();
            TeamNameLable = new Label();
            SelectTeamMemberComboBox = new ComboBox();
            SelectTeamLable = new Label();
            AddMemberButton = new Button();
            AddNewMemberGroupBox = new GroupBox();
            CreateMemberBotton = new Button();
            CellPhoneNumberTextbox = new TextBox();
            CellPhoneLable = new Label();
            EmailTextbox = new TextBox();
            EmailLable = new Label();
            LastNameTextBox = new TextBox();
            LastNameLable = new Label();
            FirstNameTextBox = new TextBox();
            FirstNameLable = new Label();
            CreateTeamButton = new Button();
            TeamMemberListBox = new ListBox();
            RemoveSelectedTeamMemberButton = new Button();
            AddNewMemberGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // CreateTeamLable
            // 
            CreateTeamLable.AutoSize = true;
            CreateTeamLable.Font = new Font("Segoe UI Semibold", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CreateTeamLable.ForeColor = SystemColors.MenuHighlight;
            CreateTeamLable.Location = new Point(27, 12);
            CreateTeamLable.Name = "CreateTeamLable";
            CreateTeamLable.Size = new Size(291, 62);
            CreateTeamLable.TabIndex = 3;
            CreateTeamLable.Text = "Create Team";
            // 
            // TeamNameTextBox
            // 
            TeamNameTextBox.Location = new Point(54, 139);
            TeamNameTextBox.Name = "TeamNameTextBox";
            TeamNameTextBox.Size = new Size(390, 27);
            TeamNameTextBox.TabIndex = 12;
            // 
            // TeamNameLable
            // 
            TeamNameLable.AutoSize = true;
            TeamNameLable.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TeamNameLable.ForeColor = SystemColors.MenuHighlight;
            TeamNameLable.Location = new Point(54, 95);
            TeamNameLable.Name = "TeamNameLable";
            TeamNameLable.Size = new Size(175, 41);
            TeamNameLable.TabIndex = 11;
            TeamNameLable.Text = "Team Name";
            // 
            // SelectTeamMemberComboBox
            // 
            SelectTeamMemberComboBox.FormattingEnabled = true;
            SelectTeamMemberComboBox.Location = new Point(54, 238);
            SelectTeamMemberComboBox.Name = "SelectTeamMemberComboBox";
            SelectTeamMemberComboBox.Size = new Size(390, 28);
            SelectTeamMemberComboBox.TabIndex = 16;
            // 
            // SelectTeamLable
            // 
            SelectTeamLable.AutoSize = true;
            SelectTeamLable.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SelectTeamLable.ForeColor = SystemColors.MenuHighlight;
            SelectTeamLable.Location = new Point(54, 191);
            SelectTeamLable.Name = "SelectTeamLable";
            SelectTeamLable.Size = new Size(335, 46);
            SelectTeamLable.TabIndex = 15;
            SelectTeamLable.Text = "Select Team Member";
            // 
            // AddMemberButton
            // 
            AddMemberButton.FlatAppearance.MouseDownBackColor = Color.Gray;
            AddMemberButton.FlatAppearance.MouseOverBackColor = Color.LightGray;
            AddMemberButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AddMemberButton.ForeColor = SystemColors.Highlight;
            AddMemberButton.Location = new Point(99, 285);
            AddMemberButton.Name = "AddMemberButton";
            AddMemberButton.Size = new Size(260, 50);
            AddMemberButton.TabIndex = 17;
            AddMemberButton.Text = "Add Member";
            AddMemberButton.UseVisualStyleBackColor = true;
            AddMemberButton.Click += AddMemberButton_Click;
            // 
            // AddNewMemberGroupBox
            // 
            AddNewMemberGroupBox.Controls.Add(CreateMemberBotton);
            AddNewMemberGroupBox.Controls.Add(CellPhoneNumberTextbox);
            AddNewMemberGroupBox.Controls.Add(CellPhoneLable);
            AddNewMemberGroupBox.Controls.Add(EmailTextbox);
            AddNewMemberGroupBox.Controls.Add(EmailLable);
            AddNewMemberGroupBox.Controls.Add(LastNameTextBox);
            AddNewMemberGroupBox.Controls.Add(LastNameLable);
            AddNewMemberGroupBox.Controls.Add(FirstNameTextBox);
            AddNewMemberGroupBox.Controls.Add(FirstNameLable);
            AddNewMemberGroupBox.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AddNewMemberGroupBox.ForeColor = SystemColors.MenuHighlight;
            AddNewMemberGroupBox.Location = new Point(54, 354);
            AddNewMemberGroupBox.Name = "AddNewMemberGroupBox";
            AddNewMemberGroupBox.Size = new Size(436, 352);
            AddNewMemberGroupBox.TabIndex = 18;
            AddNewMemberGroupBox.TabStop = false;
            AddNewMemberGroupBox.Text = "Add New Member";
            // 
            // CreateMemberBotton
            // 
            CreateMemberBotton.FlatAppearance.MouseDownBackColor = Color.Gray;
            CreateMemberBotton.FlatAppearance.MouseOverBackColor = Color.LightGray;
            CreateMemberBotton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CreateMemberBotton.ForeColor = SystemColors.Highlight;
            CreateMemberBotton.Location = new Point(70, 293);
            CreateMemberBotton.Name = "CreateMemberBotton";
            CreateMemberBotton.Size = new Size(235, 44);
            CreateMemberBotton.TabIndex = 19;
            CreateMemberBotton.Text = "Create Member";
            CreateMemberBotton.UseVisualStyleBackColor = true;
            CreateMemberBotton.Click += CreateMemberBotton_Click;
            // 
            // CellPhoneNumberTextbox
            // 
            CellPhoneNumberTextbox.Location = new Point(173, 233);
            CellPhoneNumberTextbox.Name = "CellPhoneNumberTextbox";
            CellPhoneNumberTextbox.Size = new Size(225, 47);
            CellPhoneNumberTextbox.TabIndex = 26;
            // 
            // CellPhoneLable
            // 
            CellPhoneLable.AutoSize = true;
            CellPhoneLable.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CellPhoneLable.ForeColor = SystemColors.MenuHighlight;
            CellPhoneLable.Location = new Point(9, 233);
            CellPhoneLable.Name = "CellPhoneLable";
            CellPhoneLable.Size = new Size(153, 41);
            CellPhoneLable.TabIndex = 25;
            CellPhoneLable.Text = "Cellphone";
            // 
            // EmailTextbox
            // 
            EmailTextbox.Location = new Point(173, 167);
            EmailTextbox.Name = "EmailTextbox";
            EmailTextbox.Size = new Size(225, 47);
            EmailTextbox.TabIndex = 24;
            // 
            // EmailLable
            // 
            EmailLable.AutoSize = true;
            EmailLable.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EmailLable.ForeColor = SystemColors.MenuHighlight;
            EmailLable.Location = new Point(9, 167);
            EmailLable.Name = "EmailLable";
            EmailLable.Size = new Size(88, 41);
            EmailLable.TabIndex = 23;
            EmailLable.Text = "Email";
            // 
            // LastNameTextBox
            // 
            LastNameTextBox.Location = new Point(173, 109);
            LastNameTextBox.Name = "LastNameTextBox";
            LastNameTextBox.Size = new Size(225, 47);
            LastNameTextBox.TabIndex = 22;
            // 
            // LastNameLable
            // 
            LastNameLable.AutoSize = true;
            LastNameLable.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LastNameLable.ForeColor = SystemColors.MenuHighlight;
            LastNameLable.Location = new Point(9, 107);
            LastNameLable.Name = "LastNameLable";
            LastNameLable.Size = new Size(157, 41);
            LastNameLable.TabIndex = 21;
            LastNameLable.Text = "Last Name";
            // 
            // FirstNameTextBox
            // 
            FirstNameTextBox.Location = new Point(173, 56);
            FirstNameTextBox.Name = "FirstNameTextBox";
            FirstNameTextBox.Size = new Size(225, 47);
            FirstNameTextBox.TabIndex = 20;
            // 
            // FirstNameLable
            // 
            FirstNameLable.AutoSize = true;
            FirstNameLable.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FirstNameLable.ForeColor = SystemColors.MenuHighlight;
            FirstNameLable.Location = new Point(6, 48);
            FirstNameLable.Name = "FirstNameLable";
            FirstNameLable.Size = new Size(160, 41);
            FirstNameLable.TabIndex = 19;
            FirstNameLable.Text = "First Name";
            // 
            // CreateTeamButton
            // 
            CreateTeamButton.FlatAppearance.MouseDownBackColor = Color.Gray;
            CreateTeamButton.FlatAppearance.MouseOverBackColor = Color.LightGray;
            CreateTeamButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CreateTeamButton.ForeColor = SystemColors.Highlight;
            CreateTeamButton.Location = new Point(331, 732);
            CreateTeamButton.Name = "CreateTeamButton";
            CreateTeamButton.Size = new Size(326, 51);
            CreateTeamButton.TabIndex = 19;
            CreateTeamButton.Text = "Create Team";
            CreateTeamButton.UseVisualStyleBackColor = true;
            CreateTeamButton.Click += CreateTeamButton_Click;
            // 
            // TeamMemberListBox
            // 
            TeamMemberListBox.FormattingEnabled = true;
            TeamMemberListBox.Location = new Point(530, 139);
            TeamMemberListBox.Name = "TeamMemberListBox";
            TeamMemberListBox.Size = new Size(336, 564);
            TeamMemberListBox.TabIndex = 20;
            // 
            // RemoveSelectedTeamMemberButton
            // 
            RemoveSelectedTeamMemberButton.FlatAppearance.MouseDownBackColor = Color.Gray;
            RemoveSelectedTeamMemberButton.FlatAppearance.MouseOverBackColor = Color.LightGray;
            RemoveSelectedTeamMemberButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RemoveSelectedTeamMemberButton.ForeColor = SystemColors.Highlight;
            RemoveSelectedTeamMemberButton.Location = new Point(886, 354);
            RemoveSelectedTeamMemberButton.Name = "RemoveSelectedTeamMemberButton";
            RemoveSelectedTeamMemberButton.Size = new Size(145, 103);
            RemoveSelectedTeamMemberButton.TabIndex = 24;
            RemoveSelectedTeamMemberButton.Text = "Remove Selected";
            RemoveSelectedTeamMemberButton.UseVisualStyleBackColor = true;
            RemoveSelectedTeamMemberButton.Click += RemoveSelectedTeamMemberButton_Click;
            // 
            // CreateTeamForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1056, 795);
            Controls.Add(RemoveSelectedTeamMemberButton);
            Controls.Add(TeamMemberListBox);
            Controls.Add(CreateTeamButton);
            Controls.Add(AddNewMemberGroupBox);
            Controls.Add(AddMemberButton);
            Controls.Add(SelectTeamMemberComboBox);
            Controls.Add(SelectTeamLable);
            Controls.Add(TeamNameTextBox);
            Controls.Add(TeamNameLable);
            Controls.Add(CreateTeamLable);
            Name = "CreateTeamForm";
            Text = " ";
            AddNewMemberGroupBox.ResumeLayout(false);
            AddNewMemberGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label CreateTeamLable;
        private TextBox TeamNameTextBox;
        private Label TeamNameLable;
        private ComboBox SelectTeamMemberComboBox;
        private Label SelectTeamLable;
        private Button AddMemberButton;
        private GroupBox AddNewMemberGroupBox;
        private TextBox FirstNameTextBox;
        private Label FirstNameLable;
        private TextBox LastNameTextBox;
        private Label LastNameLable;
        private TextBox CellPhoneNumberTextbox;
        private Label CellPhoneLable;
        private TextBox EmailTextbox;
        private Label EmailLable;
        private Button CreateMemberBotton;
        private Button CreateTeamButton;
        private ListBox TeamMemberListBox;
        private Button RemoveSelectedTeamMemberButton;
    }
}