namespace TrackerUI.Forms
{
    partial class CreatePrizeForm
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
            CreatePrizeLable = new Label();
            PlaceNumberTextBox = new TextBox();
            PlaceNumberLable = new Label();
            PlaceNameTextbox = new TextBox();
            PlaceNameLable = new Label();
            PrizeAmountTextBox = new TextBox();
            PrizeAmountLable = new Label();
            orLable = new Label();
            PrizePercentageValueTextBox = new TextBox();
            PrizePercentageLable = new Label();
            CreatePrizeButton = new Button();
            SuspendLayout();
            // 
            // CreatePrizeLable
            // 
            CreatePrizeLable.AutoSize = true;
            CreatePrizeLable.Font = new Font("Segoe UI Semibold", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CreatePrizeLable.ForeColor = SystemColors.MenuHighlight;
            CreatePrizeLable.Location = new Point(29, 26);
            CreatePrizeLable.Name = "CreatePrizeLable";
            CreatePrizeLable.Size = new Size(281, 62);
            CreatePrizeLable.TabIndex = 4;
            CreatePrizeLable.Text = "Create Prize";
            // 
            // PlaceNumberTextBox
            // 
            PlaceNumberTextBox.Location = new Point(280, 128);
            PlaceNumberTextBox.Name = "PlaceNumberTextBox";
            PlaceNumberTextBox.Size = new Size(225, 27);
            PlaceNumberTextBox.TabIndex = 22;
            // 
            // PlaceNumberLable
            // 
            PlaceNumberLable.AutoSize = true;
            PlaceNumberLable.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PlaceNumberLable.ForeColor = SystemColors.MenuHighlight;
            PlaceNumberLable.Location = new Point(38, 114);
            PlaceNumberLable.Name = "PlaceNumberLable";
            PlaceNumberLable.Size = new Size(204, 41);
            PlaceNumberLable.TabIndex = 21;
            PlaceNumberLable.Text = "Place Number";
            // 
            // PlaceNameTextbox
            // 
            PlaceNameTextbox.Location = new Point(280, 178);
            PlaceNameTextbox.Name = "PlaceNameTextbox";
            PlaceNameTextbox.Size = new Size(225, 27);
            PlaceNameTextbox.TabIndex = 24;
            // 
            // PlaceNameLable
            // 
            PlaceNameLable.AutoSize = true;
            PlaceNameLable.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PlaceNameLable.ForeColor = SystemColors.MenuHighlight;
            PlaceNameLable.Location = new Point(38, 164);
            PlaceNameLable.Name = "PlaceNameLable";
            PlaceNameLable.Size = new Size(174, 41);
            PlaceNameLable.TabIndex = 23;
            PlaceNameLable.Text = "Place Name";
            // 
            // PrizeAmountTextBox
            // 
            PrizeAmountTextBox.Location = new Point(280, 226);
            PrizeAmountTextBox.Name = "PrizeAmountTextBox";
            PrizeAmountTextBox.Size = new Size(225, 27);
            PrizeAmountTextBox.TabIndex = 26;
            PrizeAmountTextBox.Text = "0";
            // 
            // PrizeAmountLable
            // 
            PrizeAmountLable.AutoSize = true;
            PrizeAmountLable.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PrizeAmountLable.ForeColor = SystemColors.MenuHighlight;
            PrizeAmountLable.Location = new Point(38, 212);
            PrizeAmountLable.Name = "PrizeAmountLable";
            PrizeAmountLable.Size = new Size(197, 41);
            PrizeAmountLable.TabIndex = 25;
            PrizeAmountLable.Text = "Prize Amount";
            // 
            // orLable
            // 
            orLable.AutoSize = true;
            orLable.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            orLable.ForeColor = SystemColors.MenuHighlight;
            orLable.Location = new Point(143, 282);
            orLable.Name = "orLable";
            orLable.Size = new Size(190, 41);
            orLable.TabIndex = 27;
            orLable.Text = "------or------";
            // 
            // PrizePercentageValueTextBox
            // 
            PrizePercentageValueTextBox.Location = new Point(280, 345);
            PrizePercentageValueTextBox.Name = "PrizePercentageValueTextBox";
            PrizePercentageValueTextBox.Size = new Size(225, 27);
            PrizePercentageValueTextBox.TabIndex = 29;
            PrizePercentageValueTextBox.Text = "0";
            // 
            // PrizePercentageLable
            // 
            PrizePercentageLable.AutoSize = true;
            PrizePercentageLable.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PrizePercentageLable.ForeColor = SystemColors.MenuHighlight;
            PrizePercentageLable.Location = new Point(38, 335);
            PrizePercentageLable.Name = "PrizePercentageLable";
            PrizePercentageLable.Size = new Size(238, 41);
            PrizePercentageLable.TabIndex = 28;
            PrizePercentageLable.Text = "Prize Percentage";
            // 
            // CreatePrizeButton
            // 
            CreatePrizeButton.FlatAppearance.MouseDownBackColor = Color.Gray;
            CreatePrizeButton.FlatAppearance.MouseOverBackColor = Color.LightGray;
            CreatePrizeButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CreatePrizeButton.ForeColor = SystemColors.Highlight;
            CreatePrizeButton.Location = new Point(88, 425);
            CreatePrizeButton.Name = "CreatePrizeButton";
            CreatePrizeButton.Size = new Size(326, 51);
            CreatePrizeButton.TabIndex = 30;
            CreatePrizeButton.Text = "Create Prize";
            CreatePrizeButton.UseVisualStyleBackColor = true;
            CreatePrizeButton.Click += CreatePrizeButton_Click;
            // 
            // CreatePrizeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(536, 521);
            Controls.Add(CreatePrizeButton);
            Controls.Add(PrizePercentageValueTextBox);
            Controls.Add(PrizePercentageLable);
            Controls.Add(orLable);
            Controls.Add(PrizeAmountTextBox);
            Controls.Add(PrizeAmountLable);
            Controls.Add(PlaceNameTextbox);
            Controls.Add(PlaceNameLable);
            Controls.Add(PlaceNumberTextBox);
            Controls.Add(PlaceNumberLable);
            Controls.Add(CreatePrizeLable);
            Name = "CreatePrizeForm";
            Text = "Create Prize";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label CreatePrizeLable;
        private TextBox PlaceNumberTextBox;
        private Label PlaceNumberLable;
        private TextBox PlaceNameTextbox;
        private Label PlaceNameLable;
        private TextBox PrizeAmountTextBox;
        private Label PrizeAmountLable;
        private Label orLable;
        private TextBox PrizePercentageValueTextBox;
        private Label PrizePercentageLable;
        private Button CreatePrizeButton;
    }
}