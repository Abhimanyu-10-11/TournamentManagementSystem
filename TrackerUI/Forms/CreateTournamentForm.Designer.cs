namespace TrackerUI
{
    partial class CreateTournamentForm
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
            CreateTournamentLable = new Label();
            TournamentNameTextBox = new TextBox();
            TournamentNameLable = new Label();
            EntryFeeTextBox = new TextBox();
            EntryFeeLable = new Label();
            SelectTeamComboBox = new ComboBox();
            SelectTeamLable = new Label();
            CreateNewTeamLableLink = new LinkLabel();
            AddTeamButton = new Button();
            CreatePrizeButton = new Button();
            CreateTournamentButton = new Button();
            TournamentPlayersListBox = new ListBox();
            TeamsPlayersLable = new Label();
            PrizeListBox = new Label();
            PrizesListBox = new ListBox();
            RemoveSelectedTeamsPlayersButton = new Button();
            RemoveSelectedPrizeButton = new Button();
            SuspendLayout();
            // 
            // CreateTournamentLable
            // 
            CreateTournamentLable.AutoSize = true;
            CreateTournamentLable.Font = new Font("Segoe UI Semibold", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CreateTournamentLable.ForeColor = SystemColors.MenuHighlight;
            CreateTournamentLable.Location = new Point(27, 38);
            CreateTournamentLable.Name = "CreateTournamentLable";
            CreateTournamentLable.Size = new Size(434, 62);
            CreateTournamentLable.TabIndex = 2;
            CreateTournamentLable.Text = "Create Tournament";
            // 
            // TournamentNameTextBox
            // 
            TournamentNameTextBox.Location = new Point(49, 182);
            TournamentNameTextBox.Name = "TournamentNameTextBox";
            TournamentNameTextBox.Size = new Size(284, 27);
            TournamentNameTextBox.TabIndex = 10;
            // 
            // TournamentNameLable
            // 
            TournamentNameLable.AutoSize = true;
            TournamentNameLable.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TournamentNameLable.ForeColor = SystemColors.MenuHighlight;
            TournamentNameLable.Location = new Point(49, 138);
            TournamentNameLable.Name = "TournamentNameLable";
            TournamentNameLable.Size = new Size(264, 41);
            TournamentNameLable.TabIndex = 9;
            TournamentNameLable.Text = "Tournament Name";
            // 
            // EntryFeeTextBox
            // 
            EntryFeeTextBox.Location = new Point(195, 251);
            EntryFeeTextBox.Name = "EntryFeeTextBox";
            EntryFeeTextBox.Size = new Size(125, 27);
            EntryFeeTextBox.TabIndex = 12;
            // 
            // EntryFeeLable
            // 
            EntryFeeLable.AutoSize = true;
            EntryFeeLable.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EntryFeeLable.ForeColor = SystemColors.MenuHighlight;
            EntryFeeLable.Location = new Point(49, 242);
            EntryFeeLable.Name = "EntryFeeLable";
            EntryFeeLable.Size = new Size(140, 41);
            EntryFeeLable.TabIndex = 11;
            EntryFeeLable.Text = "Entry Fee";
            // 
            // SelectTeamComboBox
            // 
            SelectTeamComboBox.FormattingEnabled = true;
            SelectTeamComboBox.Location = new Point(49, 354);
            SelectTeamComboBox.Name = "SelectTeamComboBox";
            SelectTeamComboBox.Size = new Size(284, 28);
            SelectTeamComboBox.TabIndex = 14;
            // 
            // SelectTeamLable
            // 
            SelectTeamLable.AutoSize = true;
            SelectTeamLable.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SelectTeamLable.ForeColor = SystemColors.MenuHighlight;
            SelectTeamLable.Location = new Point(49, 307);
            SelectTeamLable.Name = "SelectTeamLable";
            SelectTeamLable.Size = new Size(198, 46);
            SelectTeamLable.TabIndex = 13;
            SelectTeamLable.Text = "Select Team";
            // 
            // CreateNewTeamLableLink
            // 
            CreateNewTeamLableLink.AutoSize = true;
            CreateNewTeamLableLink.Location = new Point(241, 327);
            CreateNewTeamLableLink.Name = "CreateNewTeamLableLink";
            CreateNewTeamLableLink.Size = new Size(92, 20);
            CreateNewTeamLableLink.TabIndex = 15;
            CreateNewTeamLableLink.TabStop = true;
            CreateNewTeamLableLink.Text = "Create Team";
            CreateNewTeamLableLink.LinkClicked += CreateNewTeamLableLink_LinkClicked;
            // 
            // AddTeamButton
            // 
            AddTeamButton.FlatAppearance.MouseDownBackColor = Color.Gray;
            AddTeamButton.FlatAppearance.MouseOverBackColor = Color.LightGray;
            AddTeamButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AddTeamButton.ForeColor = SystemColors.Highlight;
            AddTeamButton.Location = new Point(91, 394);
            AddTeamButton.Name = "AddTeamButton";
            AddTeamButton.Size = new Size(187, 51);
            AddTeamButton.TabIndex = 16;
            AddTeamButton.Text = "Add Team";
            AddTeamButton.UseVisualStyleBackColor = true;
            AddTeamButton.Click += AddTeamButton_Click;
            // 
            // CreatePrizeButton
            // 
            CreatePrizeButton.FlatAppearance.MouseDownBackColor = Color.Gray;
            CreatePrizeButton.FlatAppearance.MouseOverBackColor = Color.LightGray;
            CreatePrizeButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CreatePrizeButton.ForeColor = SystemColors.Highlight;
            CreatePrizeButton.Location = new Point(91, 456);
            CreatePrizeButton.Name = "CreatePrizeButton";
            CreatePrizeButton.Size = new Size(187, 51);
            CreatePrizeButton.TabIndex = 17;
            CreatePrizeButton.Text = "Create Prize";
            CreatePrizeButton.UseVisualStyleBackColor = true;
            CreatePrizeButton.Click += CreatePrizeButton_Click;
            // 
            // CreateTournamentButton
            // 
            CreateTournamentButton.FlatAppearance.MouseDownBackColor = Color.Gray;
            CreateTournamentButton.FlatAppearance.MouseOverBackColor = Color.LightGray;
            CreateTournamentButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CreateTournamentButton.ForeColor = SystemColors.Highlight;
            CreateTournamentButton.Location = new Point(297, 549);
            CreateTournamentButton.Name = "CreateTournamentButton";
            CreateTournamentButton.Size = new Size(326, 51);
            CreateTournamentButton.TabIndex = 18;
            CreateTournamentButton.Text = "Create Tournament";
            CreateTournamentButton.UseVisualStyleBackColor = true;
            CreateTournamentButton.Click += CreateTournamentButton_Click;
            // 
            // TournamentPlayersListBox
            // 
            TournamentPlayersListBox.FormattingEnabled = true;
            TournamentPlayersListBox.Location = new Point(446, 182);
            TournamentPlayersListBox.Name = "TournamentPlayersListBox";
            TournamentPlayersListBox.Size = new Size(290, 124);
            TournamentPlayersListBox.TabIndex = 19;
            // 
            // TeamsPlayersLable
            // 
            TeamsPlayersLable.AutoSize = true;
            TeamsPlayersLable.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TeamsPlayersLable.ForeColor = SystemColors.MenuHighlight;
            TeamsPlayersLable.Location = new Point(433, 138);
            TeamsPlayersLable.Name = "TeamsPlayersLable";
            TeamsPlayersLable.Size = new Size(222, 41);
            TeamsPlayersLable.TabIndex = 20;
            TeamsPlayersLable.Text = "Teams / Players";
            // 
            // PrizeListBox
            // 
            PrizeListBox.AutoSize = true;
            PrizeListBox.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PrizeListBox.ForeColor = SystemColors.MenuHighlight;
            PrizeListBox.Location = new Point(433, 339);
            PrizeListBox.Name = "PrizeListBox";
            PrizeListBox.Size = new Size(95, 41);
            PrizeListBox.TabIndex = 22;
            PrizeListBox.Text = "Prizes";
            // 
            // PrizesListBox
            // 
            PrizesListBox.FormattingEnabled = true;
            PrizesListBox.Location = new Point(446, 383);
            PrizesListBox.Name = "PrizesListBox";
            PrizesListBox.Size = new Size(290, 124);
            PrizesListBox.TabIndex = 21;
            // 
            // RemoveSelectedTeamsPlayersButton
            // 
            RemoveSelectedTeamsPlayersButton.FlatAppearance.MouseDownBackColor = Color.Gray;
            RemoveSelectedTeamsPlayersButton.FlatAppearance.MouseOverBackColor = Color.LightGray;
            RemoveSelectedTeamsPlayersButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RemoveSelectedTeamsPlayersButton.ForeColor = SystemColors.Highlight;
            RemoveSelectedTeamsPlayersButton.Location = new Point(772, 193);
            RemoveSelectedTeamsPlayersButton.Name = "RemoveSelectedTeamsPlayersButton";
            RemoveSelectedTeamsPlayersButton.Size = new Size(145, 103);
            RemoveSelectedTeamsPlayersButton.TabIndex = 23;
            RemoveSelectedTeamsPlayersButton.Text = "Remove Selected";
            RemoveSelectedTeamsPlayersButton.UseVisualStyleBackColor = true;
            RemoveSelectedTeamsPlayersButton.Click += RemoveSelectedTeamsPlayersButton_Click;
            // 
            // RemoveSelectedPrizeButton
            // 
            RemoveSelectedPrizeButton.FlatAppearance.MouseDownBackColor = Color.Gray;
            RemoveSelectedPrizeButton.FlatAppearance.MouseOverBackColor = Color.LightGray;
            RemoveSelectedPrizeButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RemoveSelectedPrizeButton.ForeColor = SystemColors.Highlight;
            RemoveSelectedPrizeButton.Location = new Point(772, 397);
            RemoveSelectedPrizeButton.Name = "RemoveSelectedPrizeButton";
            RemoveSelectedPrizeButton.Size = new Size(145, 103);
            RemoveSelectedPrizeButton.TabIndex = 24;
            RemoveSelectedPrizeButton.Text = "Remove Selected";
            RemoveSelectedPrizeButton.UseVisualStyleBackColor = true;
            RemoveSelectedPrizeButton.Click += RemoveSelectedPrizeButton_Click;
            // 
            // CreateTournamentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(979, 640);
            Controls.Add(RemoveSelectedPrizeButton);
            Controls.Add(RemoveSelectedTeamsPlayersButton);
            Controls.Add(PrizeListBox);
            Controls.Add(PrizesListBox);
            Controls.Add(TeamsPlayersLable);
            Controls.Add(TournamentPlayersListBox);
            Controls.Add(CreateTournamentButton);
            Controls.Add(CreatePrizeButton);
            Controls.Add(AddTeamButton);
            Controls.Add(CreateNewTeamLableLink);
            Controls.Add(SelectTeamComboBox);
            Controls.Add(SelectTeamLable);
            Controls.Add(EntryFeeTextBox);
            Controls.Add(EntryFeeLable);
            Controls.Add(TournamentNameTextBox);
            Controls.Add(TournamentNameLable);
            Controls.Add(CreateTournamentLable);
            Name = "CreateTournamentForm";
            Text = "Create Tournament";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label CreateTournamentLable;
        private TextBox TournamentNameTextBox;
        private Label TournamentNameLable;
        private TextBox EntryFeeTextBox;
        private Label EntryFeeLable;
        private ComboBox SelectTeamComboBox;
        private Label SelectTeamLable;
        private LinkLabel CreateNewTeamLableLink;
        private Button AddTeamButton;
        private Button CreatePrizeButton;
        private Button CreateTournamentButton;
        private ListBox TournamentPlayersListBox;
        private Label TeamsPlayersLable;
        private Label PrizeListBox;
        private ListBox PrizesListBox;
        private Button RemoveSelectedTeamsPlayersButton;
        private Button RemoveSelectedPrizeButton;
    }
}