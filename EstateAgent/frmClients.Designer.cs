namespace EstateAgent
{
    partial class frmClients
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
            this.lblHeader = new System.Windows.Forms.Label();
            this.radioBtnClients = new System.Windows.Forms.RadioButton();
            this.radioBtnOwners = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panelClients = new System.Windows.Forms.Panel();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnP1Exit = new System.Windows.Forms.Button();
            this.btnUpdateClient = new System.Windows.Forms.Button();
            this.btnAddClients = new System.Windows.Forms.Button();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtPNum = new System.Windows.Forms.TextBox();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridClients = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelOwners = new System.Windows.Forms.Panel();
            this.btnOwnerRemove = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnPanelOwnersAdd = new System.Windows.Forms.Button();
            this.btnPanelOwnersUpdate = new System.Windows.Forms.Button();
            this.txtPanelOwnersLName = new System.Windows.Forms.TextBox();
            this.txtPanelOwnersAddress = new System.Windows.Forms.TextBox();
            this.txtPanelOwnersPhone = new System.Windows.Forms.TextBox();
            this.txtPanelOwnersFName = new System.Windows.Forms.TextBox();
            this.dataGridOwners = new System.Windows.Forms.DataGridView();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.panelClients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClients)).BeginInit();
            this.panelOwners.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOwners)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(402, 23);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(73, 24);
            this.lblHeader.TabIndex = 1;
            this.lblHeader.Text = "Clients";
            // 
            // radioBtnClients
            // 
            this.radioBtnClients.AutoSize = true;
            this.radioBtnClients.Location = new System.Drawing.Point(6, 16);
            this.radioBtnClients.Name = "radioBtnClients";
            this.radioBtnClients.Size = new System.Drawing.Size(56, 17);
            this.radioBtnClients.TabIndex = 21;
            this.radioBtnClients.TabStop = true;
            this.radioBtnClients.Text = "Clients";
            this.radioBtnClients.UseVisualStyleBackColor = true;
            this.radioBtnClients.CheckedChanged += new System.EventHandler(this.radioBtnClients_CheckedChanged);
            // 
            // radioBtnOwners
            // 
            this.radioBtnOwners.AutoSize = true;
            this.radioBtnOwners.Location = new System.Drawing.Point(97, 16);
            this.radioBtnOwners.Name = "radioBtnOwners";
            this.radioBtnOwners.Size = new System.Drawing.Size(103, 17);
            this.radioBtnOwners.TabIndex = 22;
            this.radioBtnOwners.TabStop = true;
            this.radioBtnOwners.Text = "Property Owners";
            this.radioBtnOwners.UseVisualStyleBackColor = true;
            this.radioBtnOwners.CheckedChanged += new System.EventHandler(this.radioBtnOwners_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioBtnOwners);
            this.groupBox1.Controls.Add(this.radioBtnClients);
            this.groupBox1.Location = new System.Drawing.Point(19, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(219, 39);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choose Option";
            // 
            // panelClients
            // 
            this.panelClients.Controls.Add(this.btnRemove);
            this.panelClients.Controls.Add(this.btnP1Exit);
            this.panelClients.Controls.Add(this.btnUpdateClient);
            this.panelClients.Controls.Add(this.btnAddClients);
            this.panelClients.Controls.Add(this.txtLName);
            this.panelClients.Controls.Add(this.txtAddress);
            this.panelClients.Controls.Add(this.txtPNum);
            this.panelClients.Controls.Add(this.txtFName);
            this.panelClients.Controls.Add(this.label5);
            this.panelClients.Controls.Add(this.label4);
            this.panelClients.Controls.Add(this.label3);
            this.panelClients.Controls.Add(this.label2);
            this.panelClients.Controls.Add(this.dataGridClients);
            this.panelClients.Location = new System.Drawing.Point(7, 86);
            this.panelClients.Name = "panelClients";
            this.panelClients.Size = new System.Drawing.Size(939, 519);
            this.panelClients.TabIndex = 24;
            this.panelClients.Paint += new System.Windows.Forms.PaintEventHandler(this.panelClients_Paint);
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRemove.Location = new System.Drawing.Point(596, 303);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(260, 89);
            this.btnRemove.TabIndex = 42;
            this.btnRemove.Text = "&Remove";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click_1);
            // 
            // btnP1Exit
            // 
            this.btnP1Exit.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnP1Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnP1Exit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnP1Exit.Location = new System.Drawing.Point(596, 398);
            this.btnP1Exit.Name = "btnP1Exit";
            this.btnP1Exit.Size = new System.Drawing.Size(260, 85);
            this.btnP1Exit.TabIndex = 41;
            this.btnP1Exit.Text = "E&xit";
            this.btnP1Exit.UseVisualStyleBackColor = false;
            this.btnP1Exit.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnUpdateClient
            // 
            this.btnUpdateClient.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnUpdateClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateClient.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnUpdateClient.Location = new System.Drawing.Point(596, 212);
            this.btnUpdateClient.Name = "btnUpdateClient";
            this.btnUpdateClient.Size = new System.Drawing.Size(260, 85);
            this.btnUpdateClient.TabIndex = 37;
            this.btnUpdateClient.Text = "&Update";
            this.btnUpdateClient.UseVisualStyleBackColor = false;
            this.btnUpdateClient.Click += new System.EventHandler(this.btnUpdateClient_Click);
            // 
            // btnAddClients
            // 
            this.btnAddClients.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnAddClients.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddClients.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddClients.Location = new System.Drawing.Point(596, 122);
            this.btnAddClients.Name = "btnAddClients";
            this.btnAddClients.Size = new System.Drawing.Size(260, 84);
            this.btnAddClients.TabIndex = 36;
            this.btnAddClients.Text = "&Add";
            this.btnAddClients.UseVisualStyleBackColor = false;
            this.btnAddClients.Click += new System.EventHandler(this.btnAddClients_Click);
            // 
            // txtLName
            // 
            this.txtLName.Location = new System.Drawing.Point(693, 32);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(163, 20);
            this.txtLName.TabIndex = 29;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(693, 58);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(163, 20);
            this.txtAddress.TabIndex = 28;
            // 
            // txtPNum
            // 
            this.txtPNum.Location = new System.Drawing.Point(693, 84);
            this.txtPNum.Name = "txtPNum";
            this.txtPNum.Size = new System.Drawing.Size(163, 20);
            this.txtPNum.TabIndex = 27;
            // 
            // txtFName
            // 
            this.txtFName.Location = new System.Drawing.Point(693, 6);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(163, 20);
            this.txtFName.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(593, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 18);
            this.label5.TabIndex = 25;
            this.label5.Text = "Surname";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(593, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 18);
            this.label4.TabIndex = 24;
            this.label4.Text = "Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(593, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 18);
            this.label3.TabIndex = 23;
            this.label3.Text = "Phone No.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(593, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 18);
            this.label2.TabIndex = 22;
            this.label2.Text = "Forename";
            // 
            // dataGridClients
            // 
            this.dataGridClients.AllowUserToAddRows = false;
            this.dataGridClients.AllowUserToDeleteRows = false;
            this.dataGridClients.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridClients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridClients.Location = new System.Drawing.Point(12, 6);
            this.dataGridClients.MultiSelect = false;
            this.dataGridClients.Name = "dataGridClients";
            this.dataGridClients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridClients.Size = new System.Drawing.Size(557, 477);
            this.dataGridClients.TabIndex = 21;
            this.dataGridClients.Click += new System.EventHandler(this.dataGridClients_Click);
            this.dataGridClients.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridClients_MouseClick_1);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.FillWeight = 70F;
            this.Column1.HeaderText = "Client ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "First Name";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.FillWeight = 110F;
            this.Column3.HeaderText = "Last Name";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.FillWeight = 120F;
            this.Column4.HeaderText = "Address";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.HeaderText = "Phone No";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // panelOwners
            // 
            this.panelOwners.Controls.Add(this.btnOwnerRemove);
            this.panelOwners.Controls.Add(this.btnExit);
            this.panelOwners.Controls.Add(this.label1);
            this.panelOwners.Controls.Add(this.label6);
            this.panelOwners.Controls.Add(this.label7);
            this.panelOwners.Controls.Add(this.label8);
            this.panelOwners.Controls.Add(this.btnPanelOwnersAdd);
            this.panelOwners.Controls.Add(this.btnPanelOwnersUpdate);
            this.panelOwners.Controls.Add(this.txtPanelOwnersLName);
            this.panelOwners.Controls.Add(this.txtPanelOwnersAddress);
            this.panelOwners.Controls.Add(this.txtPanelOwnersPhone);
            this.panelOwners.Controls.Add(this.txtPanelOwnersFName);
            this.panelOwners.Controls.Add(this.dataGridOwners);
            this.panelOwners.Location = new System.Drawing.Point(7, 86);
            this.panelOwners.Name = "panelOwners";
            this.panelOwners.Size = new System.Drawing.Size(864, 519);
            this.panelOwners.TabIndex = 23;
            this.panelOwners.Visible = false;
            // 
            // btnOwnerRemove
            // 
            this.btnOwnerRemove.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnOwnerRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOwnerRemove.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnOwnerRemove.Location = new System.Drawing.Point(596, 324);
            this.btnOwnerRemove.Name = "btnOwnerRemove";
            this.btnOwnerRemove.Size = new System.Drawing.Size(260, 89);
            this.btnOwnerRemove.TabIndex = 43;
            this.btnOwnerRemove.Text = "&Remove";
            this.btnOwnerRemove.UseVisualStyleBackColor = false;
            this.btnOwnerRemove.Click += new System.EventHandler(this.btnOwnerRemove_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExit.Location = new System.Drawing.Point(596, 419);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(260, 84);
            this.btnExit.TabIndex = 40;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(593, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 18);
            this.label1.TabIndex = 39;
            this.label1.Text = "Surname";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(593, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 18);
            this.label6.TabIndex = 38;
            this.label6.Text = "Address";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(593, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 18);
            this.label7.TabIndex = 37;
            this.label7.Text = "Phone No.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(593, 8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 18);
            this.label8.TabIndex = 36;
            this.label8.Text = "Forename";
            // 
            // btnPanelOwnersAdd
            // 
            this.btnPanelOwnersAdd.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnPanelOwnersAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPanelOwnersAdd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPanelOwnersAdd.Location = new System.Drawing.Point(596, 155);
            this.btnPanelOwnersAdd.Name = "btnPanelOwnersAdd";
            this.btnPanelOwnersAdd.Size = new System.Drawing.Size(260, 78);
            this.btnPanelOwnersAdd.TabIndex = 35;
            this.btnPanelOwnersAdd.Text = "&Add";
            this.btnPanelOwnersAdd.UseVisualStyleBackColor = false;
            this.btnPanelOwnersAdd.Click += new System.EventHandler(this.btnPanelOwnersAdd_Click);
            // 
            // btnPanelOwnersUpdate
            // 
            this.btnPanelOwnersUpdate.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnPanelOwnersUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPanelOwnersUpdate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPanelOwnersUpdate.Location = new System.Drawing.Point(596, 239);
            this.btnPanelOwnersUpdate.Name = "btnPanelOwnersUpdate";
            this.btnPanelOwnersUpdate.Size = new System.Drawing.Size(260, 79);
            this.btnPanelOwnersUpdate.TabIndex = 34;
            this.btnPanelOwnersUpdate.Text = "&Update";
            this.btnPanelOwnersUpdate.UseVisualStyleBackColor = false;
            this.btnPanelOwnersUpdate.Click += new System.EventHandler(this.btnPanelOwnersUpdate_Click);
            // 
            // txtPanelOwnersLName
            // 
            this.txtPanelOwnersLName.Location = new System.Drawing.Point(693, 32);
            this.txtPanelOwnersLName.Name = "txtPanelOwnersLName";
            this.txtPanelOwnersLName.Size = new System.Drawing.Size(163, 20);
            this.txtPanelOwnersLName.TabIndex = 33;
            // 
            // txtPanelOwnersAddress
            // 
            this.txtPanelOwnersAddress.Location = new System.Drawing.Point(693, 58);
            this.txtPanelOwnersAddress.Name = "txtPanelOwnersAddress";
            this.txtPanelOwnersAddress.Size = new System.Drawing.Size(163, 20);
            this.txtPanelOwnersAddress.TabIndex = 32;
            // 
            // txtPanelOwnersPhone
            // 
            this.txtPanelOwnersPhone.Location = new System.Drawing.Point(693, 84);
            this.txtPanelOwnersPhone.Name = "txtPanelOwnersPhone";
            this.txtPanelOwnersPhone.Size = new System.Drawing.Size(163, 20);
            this.txtPanelOwnersPhone.TabIndex = 31;
            // 
            // txtPanelOwnersFName
            // 
            this.txtPanelOwnersFName.Location = new System.Drawing.Point(693, 6);
            this.txtPanelOwnersFName.Name = "txtPanelOwnersFName";
            this.txtPanelOwnersFName.Size = new System.Drawing.Size(163, 20);
            this.txtPanelOwnersFName.TabIndex = 30;
            // 
            // dataGridOwners
            // 
            this.dataGridOwners.AllowUserToAddRows = false;
            this.dataGridOwners.AllowUserToDeleteRows = false;
            this.dataGridOwners.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridOwners.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridOwners.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10});
            this.dataGridOwners.Location = new System.Drawing.Point(13, 6);
            this.dataGridOwners.MultiSelect = false;
            this.dataGridOwners.Name = "dataGridOwners";
            this.dataGridOwners.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridOwners.Size = new System.Drawing.Size(556, 497);
            this.dataGridOwners.TabIndex = 0;
            this.dataGridOwners.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridOwners_MouseClick);
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column6.FillWeight = 60F;
            this.Column6.HeaderText = "OwnerID";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column7.HeaderText = "First Name";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column8.HeaderText = "Surname";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column9.FillWeight = 120F;
            this.Column9.HeaderText = "Address";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column10
            // 
            this.Column10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column10.HeaderText = "Phone No.";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // frmClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 607);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.panelOwners);
            this.Controls.Add(this.panelClients);
            this.Name = "frmClients";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clients and Property Owners";
            this.Load += new System.EventHandler(this.frmClients_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panelClients.ResumeLayout(false);
            this.panelClients.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClients)).EndInit();
            this.panelOwners.ResumeLayout(false);
            this.panelOwners.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOwners)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.RadioButton radioBtnClients;
        private System.Windows.Forms.RadioButton radioBtnOwners;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panelClients;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtPNum;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridClients;
        private System.Windows.Forms.Panel panelOwners;
        private System.Windows.Forms.Button btnPanelOwnersAdd;
        private System.Windows.Forms.Button btnPanelOwnersUpdate;
        private System.Windows.Forms.TextBox txtPanelOwnersLName;
        private System.Windows.Forms.TextBox txtPanelOwnersAddress;
        private System.Windows.Forms.TextBox txtPanelOwnersPhone;
        private System.Windows.Forms.TextBox txtPanelOwnersFName;
        private System.Windows.Forms.DataGridView dataGridOwners;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnAddClients;
        private System.Windows.Forms.Button btnUpdateClient;
        private System.Windows.Forms.Button btnP1Exit;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnOwnerRemove;
    }
}