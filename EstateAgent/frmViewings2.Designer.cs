namespace EstateAgent
{
    partial class frmViewings2
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
            this.dataGridProperties = new System.Windows.Forms.DataGridView();
            this.propertyID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.House_No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Town = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ViewingsCalendar = new System.Windows.Forms.MonthCalendar();
            this.dataGridViewings = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnNewViewing = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCancelViewings = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewings)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridProperties
            // 
            this.dataGridProperties.AllowUserToAddRows = false;
            this.dataGridProperties.AllowUserToDeleteRows = false;
            this.dataGridProperties.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridProperties.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProperties.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.propertyID,
            this.House_No,
            this.Address,
            this.Town});
            this.dataGridProperties.Location = new System.Drawing.Point(33, 87);
            this.dataGridProperties.MultiSelect = false;
            this.dataGridProperties.Name = "dataGridProperties";
            this.dataGridProperties.ReadOnly = true;
            this.dataGridProperties.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridProperties.Size = new System.Drawing.Size(443, 461);
            this.dataGridProperties.TabIndex = 17;
            this.dataGridProperties.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridProperties_CellContentClick);
            this.dataGridProperties.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridProperties_CellMouseClick);
            this.dataGridProperties.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridProperties_MouseClick);
            // 
            // propertyID
            // 
            this.propertyID.FillWeight = 70F;
            this.propertyID.HeaderText = "PropertyID";
            this.propertyID.Name = "propertyID";
            this.propertyID.ReadOnly = true;
            // 
            // House_No
            // 
            this.House_No.FillWeight = 50F;
            this.House_No.HeaderText = "House Num";
            this.House_No.Name = "House_No";
            this.House_No.ReadOnly = true;
            // 
            // Address
            // 
            this.Address.FillWeight = 120F;
            this.Address.HeaderText = "Address";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            // 
            // Town
            // 
            this.Town.HeaderText = "Town";
            this.Town.Name = "Town";
            this.Town.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(398, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 29);
            this.label1.TabIndex = 18;
            this.label1.Text = "Viewings";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "Choose Property:";
            // 
            // ViewingsCalendar
            // 
            this.ViewingsCalendar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ViewingsCalendar.Location = new System.Drawing.Point(488, 87);
            this.ViewingsCalendar.MaxDate = new System.DateTime(2016, 12, 31, 0, 0, 0, 0);
            this.ViewingsCalendar.MaxSelectionCount = 1;
            this.ViewingsCalendar.Name = "ViewingsCalendar";
            this.ViewingsCalendar.TabIndex = 20;
            this.ViewingsCalendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.ViewingsCalendar_DateChanged);
            // 
            // dataGridViewings
            // 
            this.dataGridViewings.AllowUserToAddRows = false;
            this.dataGridViewings.AllowUserToDeleteRows = false;
            this.dataGridViewings.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridViewings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewings.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridViewings.Location = new System.Drawing.Point(488, 277);
            this.dataGridViewings.MultiSelect = false;
            this.dataGridViewings.Name = "dataGridViewings";
            this.dataGridViewings.ReadOnly = true;
            this.dataGridViewings.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewings.Size = new System.Drawing.Size(326, 271);
            this.dataGridViewings.TabIndex = 21;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "Date";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Time";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "First Name";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.HeaderText = "Last Name";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(485, 258);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 22;
            this.label3.Text = "Viewings";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(607, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 16);
            this.label4.TabIndex = 23;
            this.label4.Text = "Date:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(485, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 16);
            this.label5.TabIndex = 24;
            this.label5.Text = "Choose Date: ";
            // 
            // btnNewViewing
            // 
            this.btnNewViewing.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnNewViewing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewViewing.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewViewing.ForeColor = System.Drawing.Color.White;
            this.btnNewViewing.Location = new System.Drawing.Point(727, 87);
            this.btnNewViewing.Name = "btnNewViewing";
            this.btnNewViewing.Size = new System.Drawing.Size(87, 53);
            this.btnNewViewing.TabIndex = 25;
            this.btnNewViewing.Text = "&New Viewing";
            this.btnNewViewing.UseVisualStyleBackColor = false;
            this.btnNewViewing.Click += new System.EventHandler(this.btnNewViewing_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(727, 205);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(87, 60);
            this.btnExit.TabIndex = 26;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnCancelViewings
            // 
            this.btnCancelViewings.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnCancelViewings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelViewings.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelViewings.ForeColor = System.Drawing.Color.White;
            this.btnCancelViewings.Location = new System.Drawing.Point(727, 146);
            this.btnCancelViewings.Name = "btnCancelViewings";
            this.btnCancelViewings.Size = new System.Drawing.Size(87, 53);
            this.btnCancelViewings.TabIndex = 27;
            this.btnCancelViewings.Text = "&Cancel Viewings";
            this.btnCancelViewings.UseVisualStyleBackColor = false;
            this.btnCancelViewings.Click += new System.EventHandler(this.btnCancelViewings_Click);
            // 
            // frmViewings2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(828, 558);
            this.Controls.Add(this.btnCancelViewings);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnNewViewing);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridViewings);
            this.Controls.Add(this.ViewingsCalendar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridProperties);
            this.Name = "frmViewings2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Viewings";
            this.Load += new System.EventHandler(this.frmViewings2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewings)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridProperties;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MonthCalendar ViewingsCalendar;
        private System.Windows.Forms.DataGridView dataGridViewings;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnNewViewing;
        private System.Windows.Forms.DataGridViewTextBoxColumn propertyID;
        private System.Windows.Forms.DataGridViewTextBoxColumn House_No;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Town;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnCancelViewings;
    }
}