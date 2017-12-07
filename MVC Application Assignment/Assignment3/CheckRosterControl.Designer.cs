namespace Assignment3
{
    partial class CheckRosterControl
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
            this.ambulanceIDLabel = new System.Windows.Forms.Label();
            this.crewMemberBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ambulanceIDLabel
            // 
            this.ambulanceIDLabel.AutoSize = true;
            this.ambulanceIDLabel.Location = new System.Drawing.Point(19, 21);
            this.ambulanceIDLabel.Name = "ambulanceIDLabel";
            this.ambulanceIDLabel.Size = new System.Drawing.Size(71, 13);
            this.ambulanceIDLabel.TabIndex = 0;
            this.ambulanceIDLabel.Text = "AmbulanceID";
            this.ambulanceIDLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // crewMemberBox
            // 
            this.crewMemberBox.Location = new System.Drawing.Point(96, 18);
            this.crewMemberBox.Multiline = true;
            this.crewMemberBox.Name = "crewMemberBox";
            this.crewMemberBox.ReadOnly = true;
            this.crewMemberBox.Size = new System.Drawing.Size(203, 90);
            this.crewMemberBox.TabIndex = 1;
            // 
            // CheckRosterControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.crewMemberBox);
            this.Controls.Add(this.ambulanceIDLabel);
            this.Name = "CheckRosterControl";
            this.Size = new System.Drawing.Size(363, 126);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ambulanceIDLabel;
        private System.Windows.Forms.TextBox crewMemberBox;
    }
}
