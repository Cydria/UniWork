namespace Assignment3
{
    partial class AmbulancesListForm
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
            this.ambulancesLabel = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.addNewButton = new System.Windows.Forms.Button();
            this.ambulanceGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ambulanceGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // ambulancesLabel
            // 
            this.ambulancesLabel.AutoSize = true;
            this.ambulancesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ambulancesLabel.Location = new System.Drawing.Point(90, 9);
            this.ambulancesLabel.Name = "ambulancesLabel";
            this.ambulancesLabel.Size = new System.Drawing.Size(116, 24);
            this.ambulancesLabel.TabIndex = 0;
            this.ambulancesLabel.Text = "Ambulances";
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.White;
            this.backButton.Location = new System.Drawing.Point(12, 210);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(90, 40);
            this.backButton.TabIndex = 2;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // addNewButton
            // 
            this.addNewButton.BackColor = System.Drawing.Color.White;
            this.addNewButton.Location = new System.Drawing.Point(185, 210);
            this.addNewButton.Name = "addNewButton";
            this.addNewButton.Size = new System.Drawing.Size(90, 40);
            this.addNewButton.TabIndex = 3;
            this.addNewButton.Text = "Add New";
            this.addNewButton.UseVisualStyleBackColor = false;
            this.addNewButton.Click += new System.EventHandler(this.addNewButton_Click);
            // 
            // ambulanceGrid
            // 
            this.ambulanceGrid.AllowUserToAddRows = false;
            this.ambulanceGrid.AllowUserToDeleteRows = false;
            this.ambulanceGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ambulanceGrid.BackgroundColor = System.Drawing.Color.White;
            this.ambulanceGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ambulanceGrid.GridColor = System.Drawing.Color.White;
            this.ambulanceGrid.Location = new System.Drawing.Point(12, 36);
            this.ambulanceGrid.Name = "ambulanceGrid";
            this.ambulanceGrid.ReadOnly = true;
            this.ambulanceGrid.RowHeadersVisible = false;
            this.ambulanceGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ambulanceGrid.Size = new System.Drawing.Size(263, 168);
            this.ambulanceGrid.TabIndex = 4;
            this.ambulanceGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ambulanceGrid_CellContentClick);
            // 
            // AmbulancesListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.ambulanceGrid);
            this.Controls.Add(this.addNewButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.ambulancesLabel);
            this.Name = "AmbulancesListForm";
            this.Text = "AmbulancesForm";
            this.Load += new System.EventHandler(this.AmbulancesListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ambulanceGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ambulancesLabel;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button addNewButton;
        private System.Windows.Forms.DataGridView ambulanceGrid;
    }
}