
namespace _32582625_AmmunationStation
{
    partial class frmMaintainClients
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle37 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle38 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle39 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle40 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle41 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle42 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grpData = new System.Windows.Forms.GroupBox();
            this.btnRefreshClients = new System.Windows.Forms.Button();
            this.dgvAddress = new System.Windows.Forms.DataGridView();
            this.dgvClients = new System.Windows.Forms.DataGridView();
            this.txtSearchClient = new System.Windows.Forms.TextBox();
            this.cmbClientColumns = new System.Windows.Forms.ComboBox();
            this.lblClientAddress = new System.Windows.Forms.Label();
            this.lblSearchClient = new System.Windows.Forms.Label();
            this.grpClientOptions = new System.Windows.Forms.GroupBox();
            this.btnConfirmEdit = new System.Windows.Forms.Button();
            this.btnDeleteClient = new System.Windows.Forms.Button();
            this.btnAddClient = new System.Windows.Forms.Button();
            this.btnCancelEdit = new System.Windows.Forms.Button();
            this.btnEditClient = new System.Windows.Forms.Button();
            this.btnClearClientDetails = new System.Windows.Forms.Button();
            this.lblCityName = new System.Windows.Forms.Label();
            this.lblStreetNumber = new System.Windows.Forms.Label();
            this.lblStreetName = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblClientIDNumber = new System.Windows.Forms.Label();
            this.lblClientID = new System.Windows.Forms.Label();
            this.lblStateID = new System.Windows.Forms.Label();
            this.txtCityName = new System.Windows.Forms.TextBox();
            this.txtStreetName = new System.Windows.Forms.TextBox();
            this.txtStreetNumber = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtStateID = new System.Windows.Forms.TextBox();
            this.lblStateIDError = new System.Windows.Forms.Label();
            this.lblFirstNameError = new System.Windows.Forms.Label();
            this.lblSurnameError = new System.Windows.Forms.Label();
            this.lblStreetNumberError = new System.Windows.Forms.Label();
            this.lblStreetNameError = new System.Windows.Forms.Label();
            this.lblCityNameError = new System.Windows.Forms.Label();
            this.btnConfirmAddition = new System.Windows.Forms.Button();
            this.btnCancelAddition = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSearchStreetNum = new System.Windows.Forms.TextBox();
            this.txtSearchStreetName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClearAddress = new System.Windows.Forms.Button();
            this.grpData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).BeginInit();
            this.grpClientOptions.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpData
            // 
            this.grpData.Controls.Add(this.groupBox1);
            this.grpData.Controls.Add(this.btnRefreshClients);
            this.grpData.Controls.Add(this.dgvAddress);
            this.grpData.Controls.Add(this.dgvClients);
            this.grpData.Controls.Add(this.txtSearchClient);
            this.grpData.Controls.Add(this.cmbClientColumns);
            this.grpData.Controls.Add(this.lblClientAddress);
            this.grpData.Controls.Add(this.lblSearchClient);
            this.grpData.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpData.Location = new System.Drawing.Point(551, 12);
            this.grpData.Name = "grpData";
            this.grpData.Size = new System.Drawing.Size(678, 563);
            this.grpData.TabIndex = 0;
            this.grpData.TabStop = false;
            this.grpData.Text = "Clients";
            // 
            // btnRefreshClients
            // 
            this.btnRefreshClients.Location = new System.Drawing.Point(570, 19);
            this.btnRefreshClients.Name = "btnRefreshClients";
            this.btnRefreshClients.Size = new System.Drawing.Size(102, 23);
            this.btnRefreshClients.TabIndex = 8;
            this.btnRefreshClients.Text = "Refresh Database";
            this.btnRefreshClients.UseVisualStyleBackColor = true;
            this.btnRefreshClients.Click += new System.EventHandler(this.btnRefreshClients_Click);
            // 
            // dgvAddress
            // 
            this.dgvAddress.AllowUserToAddRows = false;
            this.dgvAddress.AllowUserToDeleteRows = false;
            this.dgvAddress.AllowUserToResizeColumns = false;
            this.dgvAddress.AllowUserToResizeRows = false;
            this.dgvAddress.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle37.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle37.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle37.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle37.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle37.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle37.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle37.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAddress.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle37;
            this.dgvAddress.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle38.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle38.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle38.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle38.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle38.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle38.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle38.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAddress.DefaultCellStyle = dataGridViewCellStyle38;
            this.dgvAddress.Location = new System.Drawing.Point(10, 317);
            this.dgvAddress.Name = "dgvAddress";
            this.dgvAddress.ReadOnly = true;
            dataGridViewCellStyle39.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle39.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle39.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle39.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle39.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle39.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle39.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAddress.RowHeadersDefaultCellStyle = dataGridViewCellStyle39;
            this.dgvAddress.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAddress.Size = new System.Drawing.Size(444, 240);
            this.dgvAddress.TabIndex = 7;
            this.dgvAddress.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvAddress_CellMouseClick);
            // 
            // dgvClients
            // 
            this.dgvClients.AllowUserToAddRows = false;
            this.dgvClients.AllowUserToDeleteRows = false;
            this.dgvClients.AllowUserToResizeColumns = false;
            this.dgvClients.AllowUserToResizeRows = false;
            this.dgvClients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle40.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle40.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle40.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle40.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle40.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle40.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle40.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClients.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle40;
            this.dgvClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle41.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle41.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle41.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle41.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle41.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle41.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle41.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvClients.DefaultCellStyle = dataGridViewCellStyle41;
            this.dgvClients.Location = new System.Drawing.Point(10, 51);
            this.dgvClients.Name = "dgvClients";
            this.dgvClients.ReadOnly = true;
            dataGridViewCellStyle42.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle42.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle42.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle42.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle42.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle42.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle42.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClients.RowHeadersDefaultCellStyle = dataGridViewCellStyle42;
            this.dgvClients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClients.Size = new System.Drawing.Size(662, 243);
            this.dgvClients.TabIndex = 6;
            this.dgvClients.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvClients_CellMouseClick);
            // 
            // txtSearchClient
            // 
            this.txtSearchClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchClient.Location = new System.Drawing.Point(241, 19);
            this.txtSearchClient.Name = "txtSearchClient";
            this.txtSearchClient.Size = new System.Drawing.Size(173, 23);
            this.txtSearchClient.TabIndex = 5;
            this.txtSearchClient.TextChanged += new System.EventHandler(this.txtSearchClient_TextChanged);
            // 
            // cmbClientColumns
            // 
            this.cmbClientColumns.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClientColumns.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbClientColumns.FormattingEnabled = true;
            this.cmbClientColumns.Location = new System.Drawing.Point(89, 18);
            this.cmbClientColumns.Name = "cmbClientColumns";
            this.cmbClientColumns.Size = new System.Drawing.Size(146, 24);
            this.cmbClientColumns.TabIndex = 4;
            // 
            // lblClientAddress
            // 
            this.lblClientAddress.AutoSize = true;
            this.lblClientAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientAddress.Location = new System.Drawing.Point(7, 296);
            this.lblClientAddress.Name = "lblClientAddress";
            this.lblClientAddress.Size = new System.Drawing.Size(103, 17);
            this.lblClientAddress.TabIndex = 2;
            this.lblClientAddress.Text = "Client Address:";
            // 
            // lblSearchClient
            // 
            this.lblSearchClient.AutoSize = true;
            this.lblSearchClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchClient.Location = new System.Drawing.Point(7, 21);
            this.lblSearchClient.Name = "lblSearchClient";
            this.lblSearchClient.Size = new System.Drawing.Size(76, 17);
            this.lblSearchClient.TabIndex = 2;
            this.lblSearchClient.Text = "Search by:";
            // 
            // grpClientOptions
            // 
            this.grpClientOptions.Controls.Add(this.btnClearAddress);
            this.grpClientOptions.Controls.Add(this.btnConfirmEdit);
            this.grpClientOptions.Controls.Add(this.lblCityNameError);
            this.grpClientOptions.Controls.Add(this.lblStreetNameError);
            this.grpClientOptions.Controls.Add(this.lblStreetNumberError);
            this.grpClientOptions.Controls.Add(this.lblSurnameError);
            this.grpClientOptions.Controls.Add(this.lblFirstNameError);
            this.grpClientOptions.Controls.Add(this.lblStateIDError);
            this.grpClientOptions.Controls.Add(this.btnDeleteClient);
            this.grpClientOptions.Controls.Add(this.btnConfirmAddition);
            this.grpClientOptions.Controls.Add(this.btnAddClient);
            this.grpClientOptions.Controls.Add(this.btnCancelAddition);
            this.grpClientOptions.Controls.Add(this.btnCancelEdit);
            this.grpClientOptions.Controls.Add(this.btnEditClient);
            this.grpClientOptions.Controls.Add(this.btnClearClientDetails);
            this.grpClientOptions.Controls.Add(this.lblCityName);
            this.grpClientOptions.Controls.Add(this.lblStreetNumber);
            this.grpClientOptions.Controls.Add(this.lblStreetName);
            this.grpClientOptions.Controls.Add(this.lblSurname);
            this.grpClientOptions.Controls.Add(this.lblFirstName);
            this.grpClientOptions.Controls.Add(this.lblClientIDNumber);
            this.grpClientOptions.Controls.Add(this.lblClientID);
            this.grpClientOptions.Controls.Add(this.lblStateID);
            this.grpClientOptions.Controls.Add(this.txtCityName);
            this.grpClientOptions.Controls.Add(this.txtStreetName);
            this.grpClientOptions.Controls.Add(this.txtStreetNumber);
            this.grpClientOptions.Controls.Add(this.txtSurname);
            this.grpClientOptions.Controls.Add(this.txtFirstName);
            this.grpClientOptions.Controls.Add(this.txtStateID);
            this.grpClientOptions.Location = new System.Drawing.Point(12, 12);
            this.grpClientOptions.Name = "grpClientOptions";
            this.grpClientOptions.Size = new System.Drawing.Size(512, 563);
            this.grpClientOptions.TabIndex = 1;
            this.grpClientOptions.TabStop = false;
            this.grpClientOptions.Text = "Client Options";
            // 
            // btnConfirmEdit
            // 
            this.btnConfirmEdit.Enabled = false;
            this.btnConfirmEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmEdit.Location = new System.Drawing.Point(186, 443);
            this.btnConfirmEdit.Name = "btnConfirmEdit";
            this.btnConfirmEdit.Size = new System.Drawing.Size(141, 34);
            this.btnConfirmEdit.TabIndex = 6;
            this.btnConfirmEdit.Text = "Confirm Edit";
            this.btnConfirmEdit.UseVisualStyleBackColor = true;
            this.btnConfirmEdit.Visible = false;
            this.btnConfirmEdit.Click += new System.EventHandler(this.btnConfirmEdit_Click);
            // 
            // btnDeleteClient
            // 
            this.btnDeleteClient.Location = new System.Drawing.Point(219, 532);
            this.btnDeleteClient.Name = "btnDeleteClient";
            this.btnDeleteClient.Size = new System.Drawing.Size(79, 25);
            this.btnDeleteClient.TabIndex = 4;
            this.btnDeleteClient.Text = "Delete Client";
            this.btnDeleteClient.UseVisualStyleBackColor = true;
            this.btnDeleteClient.Click += new System.EventHandler(this.btnDeleteClient_Click);
            // 
            // btnAddClient
            // 
            this.btnAddClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddClient.Location = new System.Drawing.Point(186, 403);
            this.btnAddClient.Name = "btnAddClient";
            this.btnAddClient.Size = new System.Drawing.Size(141, 34);
            this.btnAddClient.TabIndex = 4;
            this.btnAddClient.Text = "Add Client";
            this.btnAddClient.UseVisualStyleBackColor = true;
            this.btnAddClient.Click += new System.EventHandler(this.btnAddClient_Click);
            // 
            // btnCancelEdit
            // 
            this.btnCancelEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelEdit.Location = new System.Drawing.Point(186, 483);
            this.btnCancelEdit.Name = "btnCancelEdit";
            this.btnCancelEdit.Size = new System.Drawing.Size(141, 34);
            this.btnCancelEdit.TabIndex = 4;
            this.btnCancelEdit.Text = "Cancel Editing";
            this.btnCancelEdit.UseVisualStyleBackColor = true;
            this.btnCancelEdit.Click += new System.EventHandler(this.btnCancelEdit_Click);
            // 
            // btnEditClient
            // 
            this.btnEditClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditClient.Location = new System.Drawing.Point(186, 443);
            this.btnEditClient.Name = "btnEditClient";
            this.btnEditClient.Size = new System.Drawing.Size(141, 34);
            this.btnEditClient.TabIndex = 4;
            this.btnEditClient.Text = "Edit Client";
            this.btnEditClient.UseVisualStyleBackColor = true;
            this.btnEditClient.Click += new System.EventHandler(this.btnEditClient_Click);
            // 
            // btnClearClientDetails
            // 
            this.btnClearClientDetails.Location = new System.Drawing.Point(462, 15);
            this.btnClearClientDetails.Name = "btnClearClientDetails";
            this.btnClearClientDetails.Size = new System.Drawing.Size(44, 23);
            this.btnClearClientDetails.TabIndex = 3;
            this.btnClearClientDetails.Text = "Clear";
            this.btnClearClientDetails.UseVisualStyleBackColor = true;
            this.btnClearClientDetails.Click += new System.EventHandler(this.btnClearClientDetails_Click);
            // 
            // lblCityName
            // 
            this.lblCityName.AutoSize = true;
            this.lblCityName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCityName.Location = new System.Drawing.Point(80, 347);
            this.lblCityName.Name = "lblCityName";
            this.lblCityName.Size = new System.Drawing.Size(76, 17);
            this.lblCityName.TabIndex = 2;
            this.lblCityName.Text = "City Name:";
            // 
            // lblStreetNumber
            // 
            this.lblStreetNumber.AutoSize = true;
            this.lblStreetNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStreetNumber.Location = new System.Drawing.Point(52, 247);
            this.lblStreetNumber.Name = "lblStreetNumber";
            this.lblStreetNumber.Size = new System.Drawing.Size(104, 17);
            this.lblStreetNumber.TabIndex = 2;
            this.lblStreetNumber.Text = "Street Number:";
            // 
            // lblStreetName
            // 
            this.lblStreetName.AutoSize = true;
            this.lblStreetName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStreetName.Location = new System.Drawing.Point(65, 297);
            this.lblStreetName.Name = "lblStreetName";
            this.lblStreetName.Size = new System.Drawing.Size(91, 17);
            this.lblStreetName.TabIndex = 2;
            this.lblStreetName.Text = "Street Name:";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSurname.Location = new System.Drawing.Point(87, 198);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(69, 17);
            this.lblSurname.TabIndex = 2;
            this.lblSurname.Text = "Surname:";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(76, 147);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(80, 17);
            this.lblFirstName.TabIndex = 2;
            this.lblFirstName.Text = "First Name:";
            // 
            // lblClientIDNumber
            // 
            this.lblClientIDNumber.AutoSize = true;
            this.lblClientIDNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientIDNumber.Location = new System.Drawing.Point(304, 51);
            this.lblClientIDNumber.Name = "lblClientIDNumber";
            this.lblClientIDNumber.Size = new System.Drawing.Size(0, 17);
            this.lblClientIDNumber.TabIndex = 2;
            // 
            // lblClientID
            // 
            this.lblClientID.AutoSize = true;
            this.lblClientID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientID.Location = new System.Drawing.Point(183, 51);
            this.lblClientID.Name = "lblClientID";
            this.lblClientID.Size = new System.Drawing.Size(115, 17);
            this.lblClientID.TabIndex = 2;
            this.lblClientID.Text = "Current Client ID:";
            // 
            // lblStateID
            // 
            this.lblStateID.AutoSize = true;
            this.lblStateID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStateID.Location = new System.Drawing.Point(94, 97);
            this.lblStateID.Name = "lblStateID";
            this.lblStateID.Size = new System.Drawing.Size(62, 17);
            this.lblStateID.TabIndex = 2;
            this.lblStateID.Text = "State ID:";
            // 
            // txtCityName
            // 
            this.txtCityName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCityName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCityName.Location = new System.Drawing.Point(186, 344);
            this.txtCityName.Name = "txtCityName";
            this.txtCityName.Size = new System.Drawing.Size(141, 23);
            this.txtCityName.TabIndex = 1;
            this.txtCityName.TextChanged += new System.EventHandler(this.txtCityName_TextChanged);
            // 
            // txtStreetName
            // 
            this.txtStreetName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStreetName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStreetName.Location = new System.Drawing.Point(186, 294);
            this.txtStreetName.Name = "txtStreetName";
            this.txtStreetName.Size = new System.Drawing.Size(141, 23);
            this.txtStreetName.TabIndex = 1;
            this.txtStreetName.TextChanged += new System.EventHandler(this.txtStreetName_TextChanged);
            // 
            // txtStreetNumber
            // 
            this.txtStreetNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStreetNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStreetNumber.Location = new System.Drawing.Point(186, 244);
            this.txtStreetNumber.Name = "txtStreetNumber";
            this.txtStreetNumber.Size = new System.Drawing.Size(141, 23);
            this.txtStreetNumber.TabIndex = 1;
            this.txtStreetNumber.TextChanged += new System.EventHandler(this.txtStreetNumber_TextChanged);
            // 
            // txtSurname
            // 
            this.txtSurname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSurname.Location = new System.Drawing.Point(186, 194);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(141, 23);
            this.txtSurname.TabIndex = 1;
            this.txtSurname.TextChanged += new System.EventHandler(this.txtSurname_TextChanged);
            // 
            // txtFirstName
            // 
            this.txtFirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.Location = new System.Drawing.Point(186, 144);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(141, 23);
            this.txtFirstName.TabIndex = 1;
            this.txtFirstName.TextChanged += new System.EventHandler(this.txtFirstName_TextChanged);
            // 
            // txtStateID
            // 
            this.txtStateID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStateID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStateID.Location = new System.Drawing.Point(186, 94);
            this.txtStateID.Name = "txtStateID";
            this.txtStateID.Size = new System.Drawing.Size(141, 23);
            this.txtStateID.TabIndex = 0;
            this.txtStateID.TextChanged += new System.EventHandler(this.txtStateID_TextChanged);
            // 
            // lblStateIDError
            // 
            this.lblStateIDError.ForeColor = System.Drawing.Color.Red;
            this.lblStateIDError.Location = new System.Drawing.Point(186, 120);
            this.lblStateIDError.Name = "lblStateIDError";
            this.lblStateIDError.Size = new System.Drawing.Size(141, 21);
            this.lblStateIDError.TabIndex = 5;
            // 
            // lblFirstNameError
            // 
            this.lblFirstNameError.ForeColor = System.Drawing.Color.Red;
            this.lblFirstNameError.Location = new System.Drawing.Point(186, 169);
            this.lblFirstNameError.Name = "lblFirstNameError";
            this.lblFirstNameError.Size = new System.Drawing.Size(141, 22);
            this.lblFirstNameError.TabIndex = 5;
            // 
            // lblSurnameError
            // 
            this.lblSurnameError.ForeColor = System.Drawing.Color.Red;
            this.lblSurnameError.Location = new System.Drawing.Point(186, 220);
            this.lblSurnameError.Name = "lblSurnameError";
            this.lblSurnameError.Size = new System.Drawing.Size(141, 21);
            this.lblSurnameError.TabIndex = 5;
            // 
            // lblStreetNumberError
            // 
            this.lblStreetNumberError.ForeColor = System.Drawing.Color.Red;
            this.lblStreetNumberError.Location = new System.Drawing.Point(186, 270);
            this.lblStreetNumberError.Name = "lblStreetNumberError";
            this.lblStreetNumberError.Size = new System.Drawing.Size(141, 21);
            this.lblStreetNumberError.TabIndex = 5;
            // 
            // lblStreetNameError
            // 
            this.lblStreetNameError.ForeColor = System.Drawing.Color.Red;
            this.lblStreetNameError.Location = new System.Drawing.Point(186, 320);
            this.lblStreetNameError.Name = "lblStreetNameError";
            this.lblStreetNameError.Size = new System.Drawing.Size(141, 21);
            this.lblStreetNameError.TabIndex = 5;
            // 
            // lblCityNameError
            // 
            this.lblCityNameError.ForeColor = System.Drawing.Color.Red;
            this.lblCityNameError.Location = new System.Drawing.Point(186, 370);
            this.lblCityNameError.Name = "lblCityNameError";
            this.lblCityNameError.Size = new System.Drawing.Size(141, 17);
            this.lblCityNameError.TabIndex = 5;
            // 
            // btnConfirmAddition
            // 
            this.btnConfirmAddition.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmAddition.Location = new System.Drawing.Point(186, 403);
            this.btnConfirmAddition.Name = "btnConfirmAddition";
            this.btnConfirmAddition.Size = new System.Drawing.Size(144, 34);
            this.btnConfirmAddition.TabIndex = 4;
            this.btnConfirmAddition.Text = "Confirm Addition";
            this.btnConfirmAddition.UseVisualStyleBackColor = true;
            this.btnConfirmAddition.Visible = false;
            this.btnConfirmAddition.Click += new System.EventHandler(this.btnConfirmAddition_Click);
            // 
            // btnCancelAddition
            // 
            this.btnCancelAddition.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelAddition.Location = new System.Drawing.Point(189, 483);
            this.btnCancelAddition.Name = "btnCancelAddition";
            this.btnCancelAddition.Size = new System.Drawing.Size(144, 34);
            this.btnCancelAddition.TabIndex = 4;
            this.btnCancelAddition.Text = "Cancel Addition";
            this.btnCancelAddition.UseVisualStyleBackColor = true;
            this.btnCancelAddition.Click += new System.EventHandler(this.btnCancelAddition_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtSearchStreetName);
            this.groupBox1.Controls.Add(this.txtSearchStreetNum);
            this.groupBox1.Location = new System.Drawing.Point(460, 317);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(218, 120);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Address";
            // 
            // txtSearchStreetNum
            // 
            this.txtSearchStreetNum.Location = new System.Drawing.Point(86, 30);
            this.txtSearchStreetNum.Name = "txtSearchStreetNum";
            this.txtSearchStreetNum.Size = new System.Drawing.Size(126, 20);
            this.txtSearchStreetNum.TabIndex = 0;
            this.txtSearchStreetNum.TextChanged += new System.EventHandler(this.txtSearchStreetNum_TextChanged);
            // 
            // txtSearchStreetName
            // 
            this.txtSearchStreetName.Location = new System.Drawing.Point(86, 66);
            this.txtSearchStreetName.Name = "txtSearchStreetName";
            this.txtSearchStreetName.Size = new System.Drawing.Size(126, 20);
            this.txtSearchStreetName.TabIndex = 0;
            this.txtSearchStreetName.TextChanged += new System.EventHandler(this.txtSearchStreetName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Number:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name:";
            // 
            // btnClearAddress
            // 
            this.btnClearAddress.Location = new System.Drawing.Point(353, 293);
            this.btnClearAddress.Name = "btnClearAddress";
            this.btnClearAddress.Size = new System.Drawing.Size(88, 23);
            this.btnClearAddress.TabIndex = 7;
            this.btnClearAddress.Text = "Clear Address";
            this.btnClearAddress.UseVisualStyleBackColor = true;
            this.btnClearAddress.Visible = false;
            this.btnClearAddress.Click += new System.EventHandler(this.btnClearAddress_Click);
            // 
            // frmMaintainClients
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1241, 587);
            this.Controls.Add(this.grpClientOptions);
            this.Controls.Add(this.grpData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMaintainClients";
            this.Text = "Maintain Clients";
            this.Load += new System.EventHandler(this.frmMaintainClients_Load);
            this.grpData.ResumeLayout(false);
            this.grpData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).EndInit();
            this.grpClientOptions.ResumeLayout(false);
            this.grpClientOptions.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grpData;
        private System.Windows.Forms.GroupBox grpClientOptions;
        private System.Windows.Forms.Label lblStreetName;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblStateID;
        private System.Windows.Forms.TextBox txtStreetNumber;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtStateID;
        private System.Windows.Forms.Label lblStreetNumber;
        private System.Windows.Forms.TextBox txtCityName;
        private System.Windows.Forms.TextBox txtStreetName;
        private System.Windows.Forms.Label lblCityName;
        private System.Windows.Forms.Button btnClearClientDetails;
        private System.Windows.Forms.Button btnEditClient;
        private System.Windows.Forms.Button btnDeleteClient;
        private System.Windows.Forms.Button btnAddClient;
        private System.Windows.Forms.Label lblClientAddress;
        private System.Windows.Forms.Label lblClientID;
        private System.Windows.Forms.Label lblClientIDNumber;
        private System.Windows.Forms.ComboBox cmbClientColumns;
        private System.Windows.Forms.Label lblSearchClient;
        private System.Windows.Forms.TextBox txtSearchClient;
        private System.Windows.Forms.DataGridView dgvClients;
        private System.Windows.Forms.DataGridView dgvAddress;
        private System.Windows.Forms.Button btnCancelEdit;
        private System.Windows.Forms.Button btnConfirmEdit;
        private System.Windows.Forms.Button btnRefreshClients;
        private System.Windows.Forms.Label lblCityNameError;
        private System.Windows.Forms.Label lblStreetNameError;
        private System.Windows.Forms.Label lblStreetNumberError;
        private System.Windows.Forms.Label lblSurnameError;
        private System.Windows.Forms.Label lblFirstNameError;
        private System.Windows.Forms.Label lblStateIDError;
        private System.Windows.Forms.Button btnConfirmAddition;
        private System.Windows.Forms.Button btnCancelAddition;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSearchStreetName;
        private System.Windows.Forms.TextBox txtSearchStreetNum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClearAddress;
    }
}