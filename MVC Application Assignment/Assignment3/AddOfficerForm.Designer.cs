namespace Assignment3
{
    partial class AddOfficerForm
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
            this.ambulanceOfficerLabel = new System.Windows.Forms.Label();
            this.firstNamesLabel = new System.Windows.Forms.Label();
            this.surnameLabel = new System.Windows.Forms.Label();
            this.officerIDLabel = new System.Windows.Forms.Label();
            this.skillLevelLabel = new System.Windows.Forms.Label();
            this.ambulanceLabel = new System.Windows.Forms.Label();
            this.firstNamesBox = new System.Windows.Forms.TextBox();
            this.surnameBox = new System.Windows.Forms.TextBox();
            this.officerIDBox = new System.Windows.Forms.TextBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.skillLevelCB = new System.Windows.Forms.ComboBox();
            this.ambulanceCBX = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // ambulanceOfficerLabel
            // 
            this.ambulanceOfficerLabel.AutoSize = true;
            this.ambulanceOfficerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ambulanceOfficerLabel.Location = new System.Drawing.Point(92, 10);
            this.ambulanceOfficerLabel.Name = "ambulanceOfficerLabel";
            this.ambulanceOfficerLabel.Size = new System.Drawing.Size(171, 24);
            this.ambulanceOfficerLabel.TabIndex = 0;
            this.ambulanceOfficerLabel.Text = "Ambulance Officer:";
            this.ambulanceOfficerLabel.Click += new System.EventHandler(this.ambulanceOfficerLabel_Click);
            // 
            // firstNamesLabel
            // 
            this.firstNamesLabel.AutoSize = true;
            this.firstNamesLabel.Location = new System.Drawing.Point(12, 40);
            this.firstNamesLabel.Name = "firstNamesLabel";
            this.firstNamesLabel.Size = new System.Drawing.Size(65, 13);
            this.firstNamesLabel.TabIndex = 1;
            this.firstNamesLabel.Text = "First Names:";
            this.firstNamesLabel.Click += new System.EventHandler(this.firstNamesLabel_Click);
            // 
            // surnameLabel
            // 
            this.surnameLabel.AutoSize = true;
            this.surnameLabel.Location = new System.Drawing.Point(12, 71);
            this.surnameLabel.Name = "surnameLabel";
            this.surnameLabel.Size = new System.Drawing.Size(52, 13);
            this.surnameLabel.TabIndex = 2;
            this.surnameLabel.Text = "Surname:";
            // 
            // officerIDLabel
            // 
            this.officerIDLabel.AutoSize = true;
            this.officerIDLabel.Location = new System.Drawing.Point(12, 106);
            this.officerIDLabel.Name = "officerIDLabel";
            this.officerIDLabel.Size = new System.Drawing.Size(55, 13);
            this.officerIDLabel.TabIndex = 3;
            this.officerIDLabel.Text = "Officer ID:";
            this.officerIDLabel.Click += new System.EventHandler(this.officerIDLabel_Click);
            // 
            // skillLevelLabel
            // 
            this.skillLevelLabel.AutoSize = true;
            this.skillLevelLabel.Location = new System.Drawing.Point(12, 141);
            this.skillLevelLabel.Name = "skillLevelLabel";
            this.skillLevelLabel.Size = new System.Drawing.Size(58, 13);
            this.skillLevelLabel.TabIndex = 4;
            this.skillLevelLabel.Text = "Skill Level:";
            // 
            // ambulanceLabel
            // 
            this.ambulanceLabel.AutoSize = true;
            this.ambulanceLabel.Location = new System.Drawing.Point(12, 172);
            this.ambulanceLabel.Name = "ambulanceLabel";
            this.ambulanceLabel.Size = new System.Drawing.Size(63, 13);
            this.ambulanceLabel.TabIndex = 5;
            this.ambulanceLabel.Text = "Ambulance:";
            // 
            // firstNamesBox
            // 
            this.firstNamesBox.Location = new System.Drawing.Point(96, 37);
            this.firstNamesBox.Name = "firstNamesBox";
            this.firstNamesBox.Size = new System.Drawing.Size(176, 20);
            this.firstNamesBox.TabIndex = 6;
            // 
            // surnameBox
            // 
            this.surnameBox.Location = new System.Drawing.Point(96, 71);
            this.surnameBox.Name = "surnameBox";
            this.surnameBox.Size = new System.Drawing.Size(176, 20);
            this.surnameBox.TabIndex = 7;
            // 
            // officerIDBox
            // 
            this.officerIDBox.Location = new System.Drawing.Point(96, 106);
            this.officerIDBox.Name = "officerIDBox";
            this.officerIDBox.Size = new System.Drawing.Size(176, 20);
            this.officerIDBox.TabIndex = 8;
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.White;
            this.cancelButton.Location = new System.Drawing.Point(15, 224);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 9;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.White;
            this.saveButton.Location = new System.Drawing.Point(320, 227);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 10;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // skillLevelCB
            // 
            this.skillLevelCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.skillLevelCB.FormattingEnabled = true;
            this.skillLevelCB.Items.AddRange(new object[] {
            "Basic",
            "Intermediate",
            "Advanced"});
            this.skillLevelCB.Location = new System.Drawing.Point(96, 141);
            this.skillLevelCB.Name = "skillLevelCB";
            this.skillLevelCB.Size = new System.Drawing.Size(121, 21);
            this.skillLevelCB.TabIndex = 11;
            // 
            // ambulanceCBX
            // 
            this.ambulanceCBX.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ambulanceCBX.FormattingEnabled = true;
            this.ambulanceCBX.Location = new System.Drawing.Point(96, 172);
            this.ambulanceCBX.Name = "ambulanceCBX";
            this.ambulanceCBX.Size = new System.Drawing.Size(121, 21);
            this.ambulanceCBX.Sorted = true;
            this.ambulanceCBX.TabIndex = 12;
            this.ambulanceCBX.SelectedIndexChanged += new System.EventHandler(this.ambulanceCB_SelectedIndexChanged);
            // 
            // AddOfficerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(407, 262);
            this.Controls.Add(this.ambulanceCBX);
            this.Controls.Add(this.skillLevelCB);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.officerIDBox);
            this.Controls.Add(this.surnameBox);
            this.Controls.Add(this.firstNamesBox);
            this.Controls.Add(this.ambulanceLabel);
            this.Controls.Add(this.skillLevelLabel);
            this.Controls.Add(this.officerIDLabel);
            this.Controls.Add(this.surnameLabel);
            this.Controls.Add(this.firstNamesLabel);
            this.Controls.Add(this.ambulanceOfficerLabel);
            this.Name = "AddOfficerForm";
            this.Text = "Officer";
            this.Load += new System.EventHandler(this.Officer_Load);
            this.Shown += new System.EventHandler(this.OfficerForm_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label firstNamesLabel;
        private System.Windows.Forms.Label surnameLabel;
        private System.Windows.Forms.Label officerIDLabel;
        private System.Windows.Forms.Label skillLevelLabel;
        private System.Windows.Forms.Label ambulanceLabel;
        private System.Windows.Forms.TextBox firstNamesBox;
        private System.Windows.Forms.TextBox surnameBox;
        private System.Windows.Forms.TextBox officerIDBox;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.ComboBox skillLevelCB;
        private System.Windows.Forms.ComboBox ambulanceCBX;
        private System.Windows.Forms.Label ambulanceOfficerLabel;
    }
}