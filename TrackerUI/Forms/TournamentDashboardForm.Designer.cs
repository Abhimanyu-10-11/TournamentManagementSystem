namespace TrackerUI.Forms
{
    partial class TournamentDashboardForm
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
            TournamentDashboardLable = new Label();
            LoadExistingTournamentDropDown = new ComboBox();
            LoadExistingTournamentLable = new Label();
            LoadTournamentButton = new Button();
            CreateTournamentBotton = new Button();
            SuspendLayout();
            // 
            // TournamentDashboardLable
            // 
            TournamentDashboardLable.AutoSize = true;
            TournamentDashboardLable.Font = new Font("Segoe UI Semibold", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TournamentDashboardLable.ForeColor = SystemColors.MenuHighlight;
            TournamentDashboardLable.Location = new Point(75, 55);
            TournamentDashboardLable.Name = "TournamentDashboardLable";
            TournamentDashboardLable.Size = new Size(527, 62);
            TournamentDashboardLable.TabIndex = 5;
            TournamentDashboardLable.Text = "Tournament Dashboard";
            TournamentDashboardLable.TextAlign = ContentAlignment.TopCenter;
            // 
            // LoadExistingTournamentDropDown
            // 
            LoadExistingTournamentDropDown.FormattingEnabled = true;
            LoadExistingTournamentDropDown.Location = new Point(143, 206);
            LoadExistingTournamentDropDown.Name = "LoadExistingTournamentDropDown";
            LoadExistingTournamentDropDown.Size = new Size(390, 28);
            LoadExistingTournamentDropDown.TabIndex = 18;
            // 
            // LoadExistingTournamentLable
            // 
            LoadExistingTournamentLable.AutoSize = true;
            LoadExistingTournamentLable.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LoadExistingTournamentLable.ForeColor = SystemColors.MenuHighlight;
            LoadExistingTournamentLable.Location = new Point(136, 148);
            LoadExistingTournamentLable.Name = "LoadExistingTournamentLable";
            LoadExistingTournamentLable.Size = new Size(405, 46);
            LoadExistingTournamentLable.TabIndex = 17;
            LoadExistingTournamentLable.Text = "Load Existing Tournament";
            // 
            // LoadTournamentButton
            // 
            LoadTournamentButton.FlatAppearance.MouseDownBackColor = Color.Gray;
            LoadTournamentButton.FlatAppearance.MouseOverBackColor = Color.LightGray;
            LoadTournamentButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LoadTournamentButton.ForeColor = SystemColors.Highlight;
            LoadTournamentButton.Location = new Point(175, 252);
            LoadTournamentButton.Name = "LoadTournamentButton";
            LoadTournamentButton.Size = new Size(326, 51);
            LoadTournamentButton.TabIndex = 31;
            LoadTournamentButton.Text = "Load Tournament";
            LoadTournamentButton.UseVisualStyleBackColor = true;
            LoadTournamentButton.Click += LoadTournamentButton_Click;
            // 
            // CreateTournamentBotton
            // 
            CreateTournamentBotton.FlatAppearance.MouseDownBackColor = Color.Gray;
            CreateTournamentBotton.FlatAppearance.MouseOverBackColor = Color.LightGray;
            CreateTournamentBotton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CreateTournamentBotton.ForeColor = SystemColors.Highlight;
            CreateTournamentBotton.Location = new Point(137, 326);
            CreateTournamentBotton.Name = "CreateTournamentBotton";
            CreateTournamentBotton.Size = new Size(403, 88);
            CreateTournamentBotton.TabIndex = 32;
            CreateTournamentBotton.Text = "Create Tournament";
            CreateTournamentBotton.UseVisualStyleBackColor = true;
            CreateTournamentBotton.Click += CreateTournamentLabel_Click;
            // 
            // TournamentDashboardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(671, 463);
            Controls.Add(CreateTournamentBotton);
            Controls.Add(LoadTournamentButton);
            Controls.Add(LoadExistingTournamentDropDown);
            Controls.Add(LoadExistingTournamentLable);
            Controls.Add(TournamentDashboardLable);
            Name = "TournamentDashboardForm";
            Text = "Tournament Dashboard";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label TournamentDashboardLable;
        private ComboBox LoadExistingTournamentDropDown;
        private Label LoadExistingTournamentLable;
        private Button LoadTournamentButton;
        private Button CreateTournamentBotton;
    }
}