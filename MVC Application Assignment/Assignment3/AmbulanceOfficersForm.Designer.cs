namespace Assignment3
{
    partial class AmbulanceOfficersForm
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
            this.ambulanceOfficersTitle = new System.Windows.Forms.Label();
            this.ambulanceOfficersGrid = new System.Windows.Forms.DataGridView();
            this.backButton = new System.Windows.Forms.Button();
            this.addNewButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ambulanceOfficersGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // ambulanceOfficersTitle
            // 
            this.ambulanceOfficersTitle.AutoSize = true;
            this.ambulanceOfficersTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ambulanceOfficersTitle.Location = new System.Drawing.Point(178, 9);
            this.ambulanceOfficersTitle.Name = "ambulanceOfficersTitle";
            this.ambulanceOfficersTitle.Size = new System.Drawing.Size(240, 29);
            this.ambulanceOfficersTitle.TabIndex = 0;
            this.ambulanceOfficersTitle.Text = "Ambulance Officers";
            // 
            // ambulanceOfficersGrid
            // 
            this.ambulanceOfficersGrid.AllowUserToAddRows = false;
            this.ambulanceOfficersGrid.AllowUserToDeleteRows = false;
            this.ambulanceOfficersGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ambulanceOfficersGrid.BackgroundColor = System.Drawing.Color.White;
            this.ambulanceOfficersGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ambulanceOfficersGrid.GridColor = System.Drawing.Color.White;
            this.ambulanceOfficersGrid.Location = new System.Drawing.Point(12, 41);
            this.ambulanceOfficersGrid.MultiSelect = false;
            this.ambulanceOfficersGrid.Name = "ambulanceOfficersGrid";
            this.ambulanceOfficersGrid.ReadOnly = true;
            this.ambulanceOfficersGrid.RowHeadersVisible = false;
            this.ambulanceOfficersGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ambulanceOfficersGrid.Size = new System.Drawing.Size(582, 268);
            this.ambulanceOfficersGrid.TabIndex = 1;
            this.ambulanceOfficersGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ambulanceOfficersGrid_CellContentClick);
            this.ambulanceOfficersGrid.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ambulanceOfficersGrid_CellContentDoubleClick);
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.White;
            this.backButton.Location = new System.Drawing.Point(12, 315);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(160, 45);
            this.backButton.TabIndex = 2;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // addNewButton
            // 
            this.addNewButton.BackColor = System.Drawing.Color.White;
            this.addNewButton.Location = new System.Drawing.Point(434, 315);
            this.addNewButton.Name = "addNewButton";
            this.addNewButton.Size = new System.Drawing.Size(160, 45);
            this.addNewButton.TabIndex = 3;
            this.addNewButton.Text = "Add New";
            this.addNewButton.UseVisualStyleBackColor = false;
            this.addNewButton.Click += new System.EventHandler(this.addNewButton_Click);
            // 
            // AmbulanceOfficersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(606, 372);
            this.Controls.Add(this.addNewButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.ambulanceOfficersGrid);
            this.Controls.Add(this.ambulanceOfficersTitle);
            this.Name = "AmbulanceOfficersForm";
            this.Text = "AmbulanceOfficers";
            this.Load += new System.EventHandler(this.AmbulanceOfficersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ambulanceOfficersGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ambulanceOfficersTitle;
        private System.Windows.Forms.DataGridView ambulanceOfficersGrid;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button addNewButton;
    }
}