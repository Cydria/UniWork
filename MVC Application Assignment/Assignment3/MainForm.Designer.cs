namespace Assignment3
{
    partial class ASRS
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
            this.officersButton = new System.Windows.Forms.Button();
            this.ambulancesButton = new System.Windows.Forms.Button();
            this.checkRostersButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.asrsTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // officersButton
            // 
            this.officersButton.BackColor = System.Drawing.Color.White;
            this.officersButton.Location = new System.Drawing.Point(75, 41);
            this.officersButton.Name = "officersButton";
            this.officersButton.Size = new System.Drawing.Size(300, 60);
            this.officersButton.TabIndex = 0;
            this.officersButton.Text = "Officers";
            this.officersButton.UseVisualStyleBackColor = false;
            this.officersButton.Click += new System.EventHandler(this.officersButton_Click);
            // 
            // ambulancesButton
            // 
            this.ambulancesButton.BackColor = System.Drawing.Color.White;
            this.ambulancesButton.Location = new System.Drawing.Point(75, 107);
            this.ambulancesButton.Name = "ambulancesButton";
            this.ambulancesButton.Size = new System.Drawing.Size(300, 60);
            this.ambulancesButton.TabIndex = 1;
            this.ambulancesButton.Text = "Ambulances";
            this.ambulancesButton.UseVisualStyleBackColor = false;
            this.ambulancesButton.Click += new System.EventHandler(this.ambulancesButton_Click);
            // 
            // checkRostersButton
            // 
            this.checkRostersButton.BackColor = System.Drawing.Color.White;
            this.checkRostersButton.Location = new System.Drawing.Point(75, 173);
            this.checkRostersButton.Name = "checkRostersButton";
            this.checkRostersButton.Size = new System.Drawing.Size(300, 60);
            this.checkRostersButton.TabIndex = 2;
            this.checkRostersButton.Text = "Check Rosters";
            this.checkRostersButton.UseVisualStyleBackColor = false;
            this.checkRostersButton.Click += new System.EventHandler(this.checkRostersButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.White;
            this.exitButton.Location = new System.Drawing.Point(152, 239);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(150, 50);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // asrsTitle
            // 
            this.asrsTitle.AutoSize = true;
            this.asrsTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.asrsTitle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.asrsTitle.Location = new System.Drawing.Point(7, 9);
            this.asrsTitle.Name = "asrsTitle";
            this.asrsTitle.Size = new System.Drawing.Size(413, 29);
            this.asrsTitle.TabIndex = 4;
            this.asrsTitle.Text = "Ambulance Staff Rostering System";
            this.asrsTitle.Click += new System.EventHandler(this.asrsTitle_Click);
            // 
            // ASRS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(434, 312);
            this.Controls.Add(this.asrsTitle);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.checkRostersButton);
            this.Controls.Add(this.ambulancesButton);
            this.Controls.Add(this.officersButton);
            this.Name = "ASRS";
            this.Text = "ASRS";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button officersButton;
        private System.Windows.Forms.Button ambulancesButton;
        private System.Windows.Forms.Button checkRostersButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label asrsTitle;
    }
}

