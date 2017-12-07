namespace Assignment3
{
    partial class AddAmbulanceForm
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
            this.components = new System.ComponentModel.Container();
            this.ambulanceLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.ambulanceIDBox = new System.Windows.Forms.TextBox();
            this.crewMemberBox = new System.Windows.Forms.TextBox();
            this.addAmbulanceCBX = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // ambulanceLabel
            // 
            this.ambulanceLabel.AutoSize = true;
            this.ambulanceLabel.Location = new System.Drawing.Point(111, 9);
            this.ambulanceLabel.Name = "ambulanceLabel";
            this.ambulanceLabel.Size = new System.Drawing.Size(63, 13);
            this.ambulanceLabel.TabIndex = 0;
            this.ambulanceLabel.Text = "Ambulance:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ambulance ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Station:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Crew:";
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.White;
            this.cancelButton.Location = new System.Drawing.Point(12, 205);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(80, 45);
            this.cancelButton.TabIndex = 7;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.White;
            this.saveButton.Location = new System.Drawing.Point(192, 203);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(80, 45);
            this.saveButton.TabIndex = 8;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // ambulanceIDBox
            // 
            this.ambulanceIDBox.Location = new System.Drawing.Point(114, 43);
            this.ambulanceIDBox.Name = "ambulanceIDBox";
            this.ambulanceIDBox.Size = new System.Drawing.Size(158, 20);
            this.ambulanceIDBox.TabIndex = 9;
            // 
            // crewMemberBox
            // 
            this.crewMemberBox.BackColor = System.Drawing.Color.White;
            this.crewMemberBox.Location = new System.Drawing.Point(114, 105);
            this.crewMemberBox.Multiline = true;
            this.crewMemberBox.Name = "crewMemberBox";
            this.crewMemberBox.ReadOnly = true;
            this.crewMemberBox.Size = new System.Drawing.Size(158, 60);
            this.crewMemberBox.TabIndex = 0;
            // 
            // addAmbulanceCBX
            // 
            this.addAmbulanceCBX.FormattingEnabled = true;
            this.addAmbulanceCBX.Location = new System.Drawing.Point(114, 73);
            this.addAmbulanceCBX.Name = "addAmbulanceCBX";
            this.addAmbulanceCBX.Size = new System.Drawing.Size(121, 21);
            this.addAmbulanceCBX.TabIndex = 10;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // AddAmbulanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.addAmbulanceCBX);
            this.Controls.Add(this.crewMemberBox);
            this.Controls.Add(this.ambulanceIDBox);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ambulanceLabel);
            this.Name = "AddAmbulanceForm";
            this.Text = "AmbulanceForm";
            this.Load += new System.EventHandler(this.AddAmbulanceForm_Load);
            this.Shown += new System.EventHandler(this.AmbulanceForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ambulanceLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TextBox ambulanceIDBox;
        private System.Windows.Forms.TextBox crewMemberBox;
        private System.Windows.Forms.ComboBox addAmbulanceCBX;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}