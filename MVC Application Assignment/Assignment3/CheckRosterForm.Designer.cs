namespace Assignment3
{
    partial class CheckRosterForm
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
            this.checkRostersLabel = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.checkRosterLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // checkRostersLabel
            // 
            this.checkRostersLabel.AutoSize = true;
            this.checkRostersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkRostersLabel.Location = new System.Drawing.Point(182, 9);
            this.checkRostersLabel.Name = "checkRostersLabel";
            this.checkRostersLabel.Size = new System.Drawing.Size(155, 26);
            this.checkRostersLabel.TabIndex = 0;
            this.checkRostersLabel.Text = "Check Rosters";
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(12, 227);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 1;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // checkRosterLayout
            // 
            this.checkRosterLayout.AutoScroll = true;
            this.checkRosterLayout.Location = new System.Drawing.Point(12, 38);
            this.checkRosterLayout.Name = "checkRosterLayout";
            this.checkRosterLayout.Size = new System.Drawing.Size(477, 183);
            this.checkRosterLayout.TabIndex = 2;
            // 
            // CheckRosterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(501, 262);
            this.Controls.Add(this.checkRosterLayout);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.checkRostersLabel);
            this.Name = "CheckRosterForm";
            this.Text = "CheckRosterForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label checkRostersLabel;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.FlowLayoutPanel checkRosterLayout;
    }
}