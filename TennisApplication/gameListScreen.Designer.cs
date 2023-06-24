namespace TennisApplication
{
    partial class gameListScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.backPanel = new System.Windows.Forms.Panel();
            this.dateTextBox = new System.Windows.Forms.TextBox();
            this.TeamTwoGamesBox = new System.Windows.Forms.ComboBox();
            this.gamesLabel = new System.Windows.Forms.Label();
            this.teamOneGamesBox = new System.Windows.Forms.ComboBox();
            this.dateLabel = new System.Windows.Forms.Label();
            this.playerTwoBox = new System.Windows.Forms.ComboBox();
            this.playerOneBox = new System.Windows.Forms.ComboBox();
            this.removeButton = new System.Windows.Forms.Button();
            this.addSaveButton = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.playerTwoLabel = new System.Windows.Forms.Label();
            this.playerOneLabel = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.resetButton = new System.Windows.Forms.Button();
            this.searchAddButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.backPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // backPanel
            // 
            this.backPanel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.backPanel.Controls.Add(this.dateTextBox);
            this.backPanel.Controls.Add(this.TeamTwoGamesBox);
            this.backPanel.Controls.Add(this.gamesLabel);
            this.backPanel.Controls.Add(this.teamOneGamesBox);
            this.backPanel.Controls.Add(this.dateLabel);
            this.backPanel.Controls.Add(this.playerTwoBox);
            this.backPanel.Controls.Add(this.playerOneBox);
            this.backPanel.Controls.Add(this.removeButton);
            this.backPanel.Controls.Add(this.addSaveButton);
            this.backPanel.Controls.Add(this.titleLabel);
            this.backPanel.Controls.Add(this.playerTwoLabel);
            this.backPanel.Controls.Add(this.playerOneLabel);
            this.backPanel.Location = new System.Drawing.Point(43, 46);
            this.backPanel.Name = "backPanel";
            this.backPanel.Size = new System.Drawing.Size(369, 508);
            this.backPanel.TabIndex = 25;
            // 
            // dateTextBox
            // 
            this.dateTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTextBox.Location = new System.Drawing.Point(28, 236);
            this.dateTextBox.Name = "dateTextBox";
            this.dateTextBox.Size = new System.Drawing.Size(100, 22);
            this.dateTextBox.TabIndex = 30;
            // 
            // TeamTwoGamesBox
            // 
            this.TeamTwoGamesBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.TeamTwoGamesBox.FormattingEnabled = true;
            this.TeamTwoGamesBox.Items.AddRange(new object[] {
            "Male ",
            "Female",
            "Other"});
            this.TeamTwoGamesBox.Location = new System.Drawing.Point(235, 161);
            this.TeamTwoGamesBox.Name = "TeamTwoGamesBox";
            this.TeamTwoGamesBox.Size = new System.Drawing.Size(100, 24);
            this.TeamTwoGamesBox.TabIndex = 28;
            this.TeamTwoGamesBox.Text = "Use Selection";
            // 
            // gamesLabel
            // 
            this.gamesLabel.AutoSize = true;
            this.gamesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gamesLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gamesLabel.Location = new System.Drawing.Point(27, 137);
            this.gamesLabel.Name = "gamesLabel";
            this.gamesLabel.Size = new System.Drawing.Size(70, 24);
            this.gamesLabel.TabIndex = 27;
            this.gamesLabel.Text = "Games";
            // 
            // teamOneGamesBox
            // 
            this.teamOneGamesBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.teamOneGamesBox.FormattingEnabled = true;
            this.teamOneGamesBox.Items.AddRange(new object[] {
            "Male ",
            "Female",
            "Other"});
            this.teamOneGamesBox.Location = new System.Drawing.Point(28, 161);
            this.teamOneGamesBox.Name = "teamOneGamesBox";
            this.teamOneGamesBox.Size = new System.Drawing.Size(100, 24);
            this.teamOneGamesBox.TabIndex = 26;
            this.teamOneGamesBox.Text = "Use Selection";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.dateLabel.Location = new System.Drawing.Point(24, 209);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(48, 24);
            this.dateLabel.TabIndex = 25;
            this.dateLabel.Text = "Date";
            // 
            // playerTwoBox
            // 
            this.playerTwoBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.playerTwoBox.FormattingEnabled = true;
            this.playerTwoBox.Items.AddRange(new object[] {
            "Male ",
            "Female",
            "Other"});
            this.playerTwoBox.Location = new System.Drawing.Point(237, 93);
            this.playerTwoBox.Name = "playerTwoBox";
            this.playerTwoBox.Size = new System.Drawing.Size(100, 24);
            this.playerTwoBox.TabIndex = 19;
            this.playerTwoBox.Text = "Use Selection";
            this.playerTwoBox.Enter += new System.EventHandler(this.playerTwoBox_Enter);
            this.playerTwoBox.Leave += new System.EventHandler(this.playerTwoBox_Leave);
            // 
            // playerOneBox
            // 
            this.playerOneBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.playerOneBox.FormattingEnabled = true;
            this.playerOneBox.Items.AddRange(new object[] {
            "Male ",
            "Female",
            "Other"});
            this.playerOneBox.Location = new System.Drawing.Point(28, 93);
            this.playerOneBox.Name = "playerOneBox";
            this.playerOneBox.Size = new System.Drawing.Size(100, 24);
            this.playerOneBox.TabIndex = 18;
            this.playerOneBox.Text = "Use Selection";
            this.playerOneBox.Enter += new System.EventHandler(this.playerOneBox_Enter);
            // 
            // removeButton
            // 
            this.removeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeButton.Location = new System.Drawing.Point(28, 434);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(121, 38);
            this.removeButton.TabIndex = 17;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            // 
            // addSaveButton
            // 
            this.addSaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addSaveButton.Location = new System.Drawing.Point(214, 434);
            this.addSaveButton.Name = "addSaveButton";
            this.addSaveButton.Size = new System.Drawing.Size(121, 38);
            this.addSaveButton.TabIndex = 14;
            this.addSaveButton.Text = "Add Player";
            this.addSaveButton.UseVisualStyleBackColor = true;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.titleLabel.Location = new System.Drawing.Point(90, 23);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(172, 29);
            this.titleLabel.TabIndex = 13;
            this.titleLabel.Text = "Game Addition";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // playerTwoLabel
            // 
            this.playerTwoLabel.AutoSize = true;
            this.playerTwoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerTwoLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.playerTwoLabel.Location = new System.Drawing.Point(238, 66);
            this.playerTwoLabel.Name = "playerTwoLabel";
            this.playerTwoLabel.Size = new System.Drawing.Size(104, 24);
            this.playerTwoLabel.TabIndex = 1;
            this.playerTwoLabel.Text = "Player Two";
            // 
            // playerOneLabel
            // 
            this.playerOneLabel.AutoSize = true;
            this.playerOneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerOneLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.playerOneLabel.Location = new System.Drawing.Point(24, 66);
            this.playerOneLabel.Name = "playerOneLabel";
            this.playerOneLabel.Size = new System.Drawing.Size(104, 24);
            this.playerOneLabel.TabIndex = 0;
            this.playerOneLabel.Text = "Player One";
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(494, 112);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(284, 436);
            this.listBox1.TabIndex = 26;
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(705, 46);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(108, 40);
            this.resetButton.TabIndex = 24;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            // 
            // searchAddButton
            // 
            this.searchAddButton.Location = new System.Drawing.Point(582, 46);
            this.searchAddButton.Name = "searchAddButton";
            this.searchAddButton.Size = new System.Drawing.Size(108, 40);
            this.searchAddButton.TabIndex = 23;
            this.searchAddButton.Text = "Search";
            this.searchAddButton.UseVisualStyleBackColor = true;
            this.searchAddButton.Click += new System.EventHandler(this.searchAddButton_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(459, 46);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(108, 40);
            this.backButton.TabIndex = 22;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // gameListScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.backPanel);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.searchAddButton);
            this.Controls.Add(this.backButton);
            this.Name = "gameListScreen";
            this.Size = new System.Drawing.Size(864, 600);
            this.backPanel.ResumeLayout(false);
            this.backPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel backPanel;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button addSaveButton;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label playerTwoLabel;
        private System.Windows.Forms.Label playerOneLabel;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button searchAddButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.ComboBox playerOneBox;
        private System.Windows.Forms.ComboBox playerTwoBox;
        private System.Windows.Forms.ComboBox TeamTwoGamesBox;
        private System.Windows.Forms.Label gamesLabel;
        private System.Windows.Forms.ComboBox teamOneGamesBox;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.TextBox dateTextBox;
    }
}
