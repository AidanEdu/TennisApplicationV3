﻿namespace TennisApplication
{
    partial class playerListScreen
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
            this.components = new System.ComponentModel.Container();
            this.backButton = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.searchAddButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.backPanel = new System.Windows.Forms.Panel();
            this.removeButton = new System.Windows.Forms.Button();
            this.ageTextBox = new System.Windows.Forms.TextBox();
            this.addSaveButton = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.warningLabel = new System.Windows.Forms.Label();
            this.ratingBox = new System.Windows.Forms.ComboBox();
            this.genderBox = new System.Windows.Forms.ComboBox();
            this.dobComboBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTestBox = new System.Windows.Forms.TextBox();
            this.ratingLabel = new System.Windows.Forms.Label();
            this.genderLabel = new System.Windows.Forms.Label();
            this.ageLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.backPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(31, 34);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(108, 40);
            this.backButton.TabIndex = 0;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // searchAddButton
            // 
            this.searchAddButton.Location = new System.Drawing.Point(154, 34);
            this.searchAddButton.Name = "searchAddButton";
            this.searchAddButton.Size = new System.Drawing.Size(108, 40);
            this.searchAddButton.TabIndex = 17;
            this.searchAddButton.Text = "Search";
            this.searchAddButton.UseVisualStyleBackColor = true;
            this.searchAddButton.Click += new System.EventHandler(this.filterButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(277, 34);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(108, 40);
            this.resetButton.TabIndex = 18;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.deselectButton_Click);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // backPanel
            // 
            this.backPanel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.backPanel.Controls.Add(this.removeButton);
            this.backPanel.Controls.Add(this.ageTextBox);
            this.backPanel.Controls.Add(this.addSaveButton);
            this.backPanel.Controls.Add(this.titleLabel);
            this.backPanel.Controls.Add(this.warningLabel);
            this.backPanel.Controls.Add(this.ratingBox);
            this.backPanel.Controls.Add(this.genderBox);
            this.backPanel.Controls.Add(this.dobComboBox);
            this.backPanel.Controls.Add(this.lastNameTextBox);
            this.backPanel.Controls.Add(this.firstNameTestBox);
            this.backPanel.Controls.Add(this.ratingLabel);
            this.backPanel.Controls.Add(this.genderLabel);
            this.backPanel.Controls.Add(this.ageLabel);
            this.backPanel.Controls.Add(this.lastNameLabel);
            this.backPanel.Controls.Add(this.firstNameLabel);
            this.backPanel.Location = new System.Drawing.Point(444, 34);
            this.backPanel.Name = "backPanel";
            this.backPanel.Size = new System.Drawing.Size(369, 508);
            this.backPanel.TabIndex = 20;
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
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // ageTextBox
            // 
            this.ageTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ageTextBox.Location = new System.Drawing.Point(28, 219);
            this.ageTextBox.Name = "ageTextBox";
            this.ageTextBox.Size = new System.Drawing.Size(100, 22);
            this.ageTextBox.TabIndex = 16;
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
            this.addSaveButton.Click += new System.EventHandler(this.addSaveButton_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.titleLabel.Location = new System.Drawing.Point(92, 24);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(175, 29);
            this.titleLabel.TabIndex = 13;
            this.titleLabel.Text = "Player Addition";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // warningLabel
            // 
            this.warningLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warningLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.warningLabel.Location = new System.Drawing.Point(164, 66);
            this.warningLabel.Name = "warningLabel";
            this.warningLabel.Size = new System.Drawing.Size(202, 128);
            this.warningLabel.TabIndex = 12;
            this.warningLabel.Text = "adsad";
            // 
            // ratingBox
            // 
            this.ratingBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.ratingBox.FormattingEnabled = true;
            this.ratingBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.ratingBox.Location = new System.Drawing.Point(28, 339);
            this.ratingBox.Name = "ratingBox";
            this.ratingBox.Size = new System.Drawing.Size(100, 24);
            this.ratingBox.TabIndex = 11;
            this.ratingBox.Text = "Use Selection";
            this.ratingBox.Enter += new System.EventHandler(this.ratingBox_Enter);
            this.ratingBox.Leave += new System.EventHandler(this.ratingBox_Leave);
            // 
            // genderBox
            // 
            this.genderBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.genderBox.FormattingEnabled = true;
            this.genderBox.Items.AddRange(new object[] {
            "Male ",
            "Female",
            "Other"});
            this.genderBox.Location = new System.Drawing.Point(28, 279);
            this.genderBox.Name = "genderBox";
            this.genderBox.Size = new System.Drawing.Size(100, 24);
            this.genderBox.TabIndex = 10;
            this.genderBox.Text = "Use Selection";
            this.genderBox.Enter += new System.EventHandler(this.genderBox_Enter);
            this.genderBox.Leave += new System.EventHandler(this.genderBox_Leave);
            // 
            // dobComboBox
            // 
            this.dobComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dobComboBox.Location = new System.Drawing.Point(28, 219);
            this.dobComboBox.Name = "dobComboBox";
            this.dobComboBox.Size = new System.Drawing.Size(100, 22);
            this.dobComboBox.TabIndex = 7;
            this.dobComboBox.Text = "Year/Month/Day";
            this.dobComboBox.TextChanged += new System.EventHandler(this.dobComboBox_TextChanged);
            this.dobComboBox.Enter += new System.EventHandler(this.ageBox_Enter);
            this.dobComboBox.Leave += new System.EventHandler(this.ageBox_Leave);
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameTextBox.Location = new System.Drawing.Point(28, 161);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(100, 22);
            this.lastNameTextBox.TabIndex = 6;
            // 
            // firstNameTestBox
            // 
            this.firstNameTestBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameTestBox.Location = new System.Drawing.Point(28, 94);
            this.firstNameTestBox.Name = "firstNameTestBox";
            this.firstNameTestBox.Size = new System.Drawing.Size(100, 22);
            this.firstNameTestBox.TabIndex = 5;
            // 
            // ratingLabel
            // 
            this.ratingLabel.AutoSize = true;
            this.ratingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ratingLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ratingLabel.Location = new System.Drawing.Point(24, 312);
            this.ratingLabel.Name = "ratingLabel";
            this.ratingLabel.Size = new System.Drawing.Size(63, 24);
            this.ratingLabel.TabIndex = 4;
            this.ratingLabel.Text = "Rating";
            // 
            // genderLabel
            // 
            this.genderLabel.AutoSize = true;
            this.genderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.genderLabel.Location = new System.Drawing.Point(24, 251);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(74, 24);
            this.genderLabel.TabIndex = 3;
            this.genderLabel.Text = "Gender";
            // 
            // ageLabel
            // 
            this.ageLabel.AutoSize = true;
            this.ageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ageLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ageLabel.Location = new System.Drawing.Point(24, 192);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(110, 24);
            this.ageLabel.TabIndex = 2;
            this.ageLabel.Text = "Date of Birth";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lastNameLabel.Location = new System.Drawing.Point(24, 127);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(99, 24);
            this.lastNameLabel.TabIndex = 1;
            this.lastNameLabel.Text = "Last Name";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.firstNameLabel.Location = new System.Drawing.Point(24, 66);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(101, 24);
            this.firstNameLabel.TabIndex = 0;
            this.firstNameLabel.Text = "First Name";
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(66, 100);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(284, 436);
            this.listBox1.TabIndex = 21;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // playerListScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.backPanel);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.searchAddButton);
            this.Controls.Add(this.backButton);
            this.Name = "playerListScreen";
            this.Size = new System.Drawing.Size(864, 600);
            this.backPanel.ResumeLayout(false);
            this.backPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button searchAddButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.Panel backPanel;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label genderLabel;
        private System.Windows.Forms.Label ageLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.TextBox dobComboBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox firstNameTestBox;
        private System.Windows.Forms.ComboBox genderBox;
        private System.Windows.Forms.ComboBox ratingBox;
        private System.Windows.Forms.Button addSaveButton;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label warningLabel;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label ratingLabel;
        private System.Windows.Forms.TextBox ageTextBox;
        private System.Windows.Forms.Button removeButton;
    }
}
