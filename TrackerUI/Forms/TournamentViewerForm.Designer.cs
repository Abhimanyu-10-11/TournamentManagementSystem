namespace TrackerUI
{
    partial class TournamentViewerForm
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
            TournamentLableTorunamentViewerForm = new Label();
            tournamentName = new Label();
            RoundLabel = new Label();
            MatchUpListBox = new ListBox();
            UnplayedOnlyCheckBox = new CheckBox();
            RoundNumberComboBox = new ComboBox();
            TeamOneLable = new Label();
            ScoreTeamOneLable = new Label();
            TeamOneScoreTextBox = new TextBox();
            TeamTwoScoreTextBox = new TextBox();
            ScoreTeamTwoLable = new Label();
            TeamTwoLabel = new Label();
            ScoreSaveButton = new Button();
            VSLable = new Label();
            SuspendLayout();
            // 
            // TournamentLableTorunamentViewerForm
            // 
            TournamentLableTorunamentViewerForm.AutoSize = true;
            TournamentLableTorunamentViewerForm.Font = new Font("Segoe UI Semibold", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TournamentLableTorunamentViewerForm.ForeColor = SystemColors.MenuHighlight;
            TournamentLableTorunamentViewerForm.Location = new Point(44, 45);
            TournamentLableTorunamentViewerForm.Name = "TournamentLableTorunamentViewerForm";
            TournamentLableTorunamentViewerForm.Size = new Size(294, 62);
            TournamentLableTorunamentViewerForm.TabIndex = 0;
            TournamentLableTorunamentViewerForm.Text = "Tournament:";
            // 
            // tournamentName
            // 
            tournamentName.AutoSize = true;
            tournamentName.Font = new Font("Segoe UI Semibold", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tournamentName.ForeColor = SystemColors.MenuHighlight;
            tournamentName.Location = new Point(327, 45);
            tournamentName.Name = "tournamentName";
            tournamentName.Size = new Size(200, 62);
            tournamentName.TabIndex = 1;
            tournamentName.Text = "<none>";
            // 
            // RoundLabel
            // 
            RoundLabel.AutoSize = true;
            RoundLabel.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RoundLabel.ForeColor = SystemColors.MenuHighlight;
            RoundLabel.Location = new Point(44, 161);
            RoundLabel.Name = "RoundLabel";
            RoundLabel.Size = new Size(117, 46);
            RoundLabel.TabIndex = 2;
            RoundLabel.Text = "Round";
            // 
            // MatchUpListBox
            // 
            MatchUpListBox.FormattingEnabled = true;
            MatchUpListBox.ItemHeight = 37;
            MatchUpListBox.Location = new Point(69, 291);
            MatchUpListBox.Name = "MatchUpListBox";
            MatchUpListBox.Size = new Size(349, 337);
            MatchUpListBox.TabIndex = 3;
            MatchUpListBox.SelectedIndexChanged += MatchUpListBox_SelectedIndexChanged;
            // 
            // UnplayedOnlyCheckBox
            // 
            UnplayedOnlyCheckBox.AutoSize = true;
            UnplayedOnlyCheckBox.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UnplayedOnlyCheckBox.ForeColor = SystemColors.MenuHighlight;
            UnplayedOnlyCheckBox.Location = new Point(167, 223);
            UnplayedOnlyCheckBox.Name = "UnplayedOnlyCheckBox";
            UnplayedOnlyCheckBox.Size = new Size(261, 50);
            UnplayedOnlyCheckBox.TabIndex = 4;
            UnplayedOnlyCheckBox.Text = "Unplayed Only";
            UnplayedOnlyCheckBox.UseVisualStyleBackColor = true;
            UnplayedOnlyCheckBox.CheckedChanged += UnplayedOnlyCheckBox_CheckedChanged;
            // 
            // RoundNumberComboBox
            // 
            RoundNumberComboBox.FormattingEnabled = true;
            RoundNumberComboBox.Location = new Point(167, 161);
            RoundNumberComboBox.Name = "RoundNumberComboBox";
            RoundNumberComboBox.Size = new Size(251, 45);
            RoundNumberComboBox.TabIndex = 5;
            RoundNumberComboBox.SelectedIndexChanged += RoundNumberComboBox_SelectedIndexChanged;
            // 
            // TeamOneLable
            // 
            TeamOneLable.AutoSize = true;
            TeamOneLable.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TeamOneLable.ForeColor = SystemColors.MenuHighlight;
            TeamOneLable.Location = new Point(458, 291);
            TeamOneLable.Name = "TeamOneLable";
            TeamOneLable.Size = new Size(194, 41);
            TeamOneLable.TabIndex = 6;
            TeamOneLable.Text = "<Team One>";
            // 
            // ScoreTeamOneLable
            // 
            ScoreTeamOneLable.AutoSize = true;
            ScoreTeamOneLable.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ScoreTeamOneLable.ForeColor = SystemColors.MenuHighlight;
            ScoreTeamOneLable.Location = new Point(469, 343);
            ScoreTeamOneLable.Name = "ScoreTeamOneLable";
            ScoreTeamOneLable.Size = new Size(92, 41);
            ScoreTeamOneLable.TabIndex = 7;
            ScoreTeamOneLable.Text = "Score";
            // 
            // TeamOneScoreTextBox
            // 
            TeamOneScoreTextBox.Location = new Point(579, 343);
            TeamOneScoreTextBox.Name = "TeamOneScoreTextBox";
            TeamOneScoreTextBox.Size = new Size(125, 43);
            TeamOneScoreTextBox.TabIndex = 8;
            // 
            // TeamTwoScoreTextBox
            // 
            TeamTwoScoreTextBox.Location = new Point(579, 500);
            TeamTwoScoreTextBox.Name = "TeamTwoScoreTextBox";
            TeamTwoScoreTextBox.Size = new Size(125, 43);
            TeamTwoScoreTextBox.TabIndex = 11;
            // 
            // ScoreTeamTwoLable
            // 
            ScoreTeamTwoLable.AutoSize = true;
            ScoreTeamTwoLable.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ScoreTeamTwoLable.ForeColor = SystemColors.MenuHighlight;
            ScoreTeamTwoLable.Location = new Point(469, 500);
            ScoreTeamTwoLable.Name = "ScoreTeamTwoLable";
            ScoreTeamTwoLable.Size = new Size(92, 41);
            ScoreTeamTwoLable.TabIndex = 10;
            ScoreTeamTwoLable.Text = "Score";
            // 
            // TeamTwoLabel
            // 
            TeamTwoLabel.AutoSize = true;
            TeamTwoLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TeamTwoLabel.ForeColor = SystemColors.MenuHighlight;
            TeamTwoLabel.Location = new Point(458, 448);
            TeamTwoLabel.Name = "TeamTwoLabel";
            TeamTwoLabel.Size = new Size(194, 41);
            TeamTwoLabel.TabIndex = 9;
            TeamTwoLabel.Text = "<Team One>";
            // 
            // ScoreSaveButton
            // 
            ScoreSaveButton.FlatAppearance.MouseDownBackColor = Color.Gray;
            ScoreSaveButton.FlatAppearance.MouseOverBackColor = Color.LightGray;
            ScoreSaveButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ScoreSaveButton.ForeColor = SystemColors.Highlight;
            ScoreSaveButton.Location = new Point(720, 407);
            ScoreSaveButton.Name = "ScoreSaveButton";
            ScoreSaveButton.Size = new Size(124, 51);
            ScoreSaveButton.TabIndex = 12;
            ScoreSaveButton.Text = "Score";
            ScoreSaveButton.UseVisualStyleBackColor = true;
            ScoreSaveButton.Click += ScoreSaveButton_Click;
            // 
            // VSLable
            // 
            VSLable.AutoSize = true;
            VSLable.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            VSLable.ForeColor = SystemColors.MenuHighlight;
            VSLable.Location = new Point(532, 399);
            VSLable.Name = "VSLable";
            VSLable.Size = new Size(53, 41);
            VSLable.TabIndex = 13;
            VSLable.Text = "VS";
            // 
            // TournamentViewerForm
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(905, 673);
            Controls.Add(VSLable);
            Controls.Add(ScoreSaveButton);
            Controls.Add(TeamTwoScoreTextBox);
            Controls.Add(ScoreTeamTwoLable);
            Controls.Add(TeamTwoLabel);
            Controls.Add(TeamOneScoreTextBox);
            Controls.Add(ScoreTeamOneLable);
            Controls.Add(TeamOneLable);
            Controls.Add(RoundNumberComboBox);
            Controls.Add(UnplayedOnlyCheckBox);
            Controls.Add(MatchUpListBox);
            Controls.Add(RoundLabel);
            Controls.Add(tournamentName);
            Controls.Add(TournamentLableTorunamentViewerForm);
            Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(6);
            Name = "TournamentViewerForm";
            Text = "Tournament Viewer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label TournamentLableTorunamentViewerForm;
        private Label tournamentName;
        private Label RoundLabel;
        private ListBox MatchUpListBox;
        private CheckBox UnplayedOnlyCheckBox;
        private ComboBox RoundNumberComboBox;
        private Label TeamOneLable;
        private Label ScoreTeamOneLable;
        private TextBox TeamOneScoreTextBox;
        private TextBox TeamTwoScoreTextBox;
        private Label ScoreTeamTwoLable;
        private Label TeamTwoLabel;
        private Button ScoreSaveButton;
        private Label VSLable;
    }
}