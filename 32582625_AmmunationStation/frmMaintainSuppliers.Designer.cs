
namespace _32582625_AmmunationStation
{
    partial class frmMaintainSuppliers
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnConfirmEdit = new System.Windows.Forms.Button();
            this.btnDeleteSupplier = new System.Windows.Forms.Button();
            this.btnAddSupplier = new System.Windows.Forms.Button();
            this.btnCancelEdit = new System.Windows.Forms.Button();
            this.btnEditSupplier = new System.Windows.Forms.Button();
            this.btnClearSupplierDetails = new System.Windows.Forms.Button();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblLocation = new System.Windows.Forms.Label();
            this.lblSupplierIDNumber = new System.Windows.Forms.Label();
            this.lblSupplierID = new System.Windows.Forms.Label();
            this.lblSupplierName = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.txtSupplierName = new System.Windows.Forms.TextBox();
            this.btnRefreshSuppliers = new System.Windows.Forms.Button();
            this.dgvSuppliers = new System.Windows.Forms.DataGridView();
            this.txtSearchSupplier = new System.Windows.Forms.TextBox();
            this.cmbSupplierColumns = new System.Windows.Forms.ComboBox();
            this.lblSearchSupplier = new System.Windows.Forms.Label();
            this.grpSupplierOptions = new System.Windows.Forms.GroupBox();
            this.grpData = new System.Windows.Forms.GroupBox();
            this.lblNameWarning = new System.Windows.Forms.Label();
            this.lblLocationWarning = new System.Windows.Forms.Label();
            this.lblEmailWarning = new System.Windows.Forms.Label();
            this.btnConfirmAddition = new System.Windows.Forms.Button();
            this.btnCancelAddition = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuppliers)).BeginInit();
            this.grpSupplierOptions.SuspendLayout();
            this.grpData.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConfirmEdit
            // 
            this.btnConfirmEdit.Enabled = false;
            this.btnConfirmEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmEdit.Location = new System.Drawing.Point(186, 345);
            this.btnConfirmEdit.Name = "btnConfirmEdit";
            this.btnConfirmEdit.Size = new System.Drawing.Size(141, 34);
            this.btnConfirmEdit.TabIndex = 6;
            this.btnConfirmEdit.Text = "Confirm Edit";
            this.btnConfirmEdit.UseVisualStyleBackColor = true;
            this.btnConfirmEdit.Visible = false;
            this.btnConfirmEdit.Click += new System.EventHandler(this.btnConfirmEdit_Click);
            // 
            // btnDeleteSupplier
            // 
            this.btnDeleteSupplier.Location = new System.Drawing.Point(219, 434);
            this.btnDeleteSupplier.Name = "btnDeleteSupplier";
            this.btnDeleteSupplier.Size = new System.Drawing.Size(79, 25);
            this.btnDeleteSupplier.TabIndex = 4;
            this.btnDeleteSupplier.Text = "Delete Supplier";
            this.btnDeleteSupplier.UseVisualStyleBackColor = true;
            this.btnDeleteSupplier.Click += new System.EventHandler(this.btnDeleteSupplier_Click);
            // 
            // btnAddSupplier
            // 
            this.btnAddSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSupplier.Location = new System.Drawing.Point(186, 305);
            this.btnAddSupplier.Name = "btnAddSupplier";
            this.btnAddSupplier.Size = new System.Drawing.Size(141, 34);
            this.btnAddSupplier.TabIndex = 4;
            this.btnAddSupplier.Text = "Add Supplier";
            this.btnAddSupplier.UseVisualStyleBackColor = true;
            this.btnAddSupplier.Click += new System.EventHandler(this.btnAddSupplier_Click);
            // 
            // btnCancelEdit
            // 
            this.btnCancelEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelEdit.Location = new System.Drawing.Point(186, 385);
            this.btnCancelEdit.Name = "btnCancelEdit";
            this.btnCancelEdit.Size = new System.Drawing.Size(141, 34);
            this.btnCancelEdit.TabIndex = 4;
            this.btnCancelEdit.Text = "Cancel Editing";
            this.btnCancelEdit.UseVisualStyleBackColor = true;
            this.btnCancelEdit.Click += new System.EventHandler(this.btnCancelEdit_Click);
            // 
            // btnEditSupplier
            // 
            this.btnEditSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditSupplier.Location = new System.Drawing.Point(186, 345);
            this.btnEditSupplier.Name = "btnEditSupplier";
            this.btnEditSupplier.Size = new System.Drawing.Size(141, 34);
            this.btnEditSupplier.TabIndex = 4;
            this.btnEditSupplier.Text = "Edit Supplier";
            this.btnEditSupplier.UseVisualStyleBackColor = true;
            this.btnEditSupplier.Click += new System.EventHandler(this.btnEditSupplier_Click);
            // 
            // btnClearSupplierDetails
            // 
            this.btnClearSupplierDetails.Location = new System.Drawing.Point(462, 15);
            this.btnClearSupplierDetails.Name = "btnClearSupplierDetails";
            this.btnClearSupplierDetails.Size = new System.Drawing.Size(44, 23);
            this.btnClearSupplierDetails.TabIndex = 3;
            this.btnClearSupplierDetails.Text = "Clear";
            this.btnClearSupplierDetails.UseVisualStyleBackColor = true;
            this.btnClearSupplierDetails.Click += new System.EventHandler(this.btnClearSupplierDetails_Click);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(94, 233);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(51, 17);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "E-Mail:";
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocation.Location = new System.Drawing.Point(79, 182);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(66, 17);
            this.lblLocation.TabIndex = 2;
            this.lblLocation.Text = "Location:";
            // 
            // lblSupplierIDNumber
            // 
            this.lblSupplierIDNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplierIDNumber.Location = new System.Drawing.Point(321, 84);
            this.lblSupplierIDNumber.Name = "lblSupplierIDNumber";
            this.lblSupplierIDNumber.Size = new System.Drawing.Size(85, 17);
            this.lblSupplierIDNumber.TabIndex = 2;
            // 
            // lblSupplierID
            // 
            this.lblSupplierID.AutoSize = true;
            this.lblSupplierID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplierID.Location = new System.Drawing.Point(183, 84);
            this.lblSupplierID.Name = "lblSupplierID";
            this.lblSupplierID.Size = new System.Drawing.Size(132, 17);
            this.lblSupplierID.TabIndex = 2;
            this.lblSupplierID.Text = "Current Supplier ID:";
            // 
            // lblSupplierName
            // 
            this.lblSupplierName.AutoSize = true;
            this.lblSupplierName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplierName.Location = new System.Drawing.Point(40, 134);
            this.lblSupplierName.Name = "lblSupplierName";
            this.lblSupplierName.Size = new System.Drawing.Size(105, 17);
            this.lblSupplierName.TabIndex = 2;
            this.lblSupplierName.Text = "Supplier Name:";
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(175, 229);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(273, 23);
            this.txtEmail.TabIndex = 1;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // txtLocation
            // 
            this.txtLocation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLocation.Location = new System.Drawing.Point(175, 179);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(273, 23);
            this.txtLocation.TabIndex = 1;
            this.txtLocation.TextChanged += new System.EventHandler(this.txtLocation_TextChanged);
            // 
            // txtSupplierName
            // 
            this.txtSupplierName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSupplierName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSupplierName.Location = new System.Drawing.Point(175, 129);
            this.txtSupplierName.Name = "txtSupplierName";
            this.txtSupplierName.Size = new System.Drawing.Size(273, 23);
            this.txtSupplierName.TabIndex = 0;
            this.txtSupplierName.TextChanged += new System.EventHandler(this.txtSupplierName_TextChanged);
            // 
            // btnRefreshSuppliers
            // 
            this.btnRefreshSuppliers.Location = new System.Drawing.Point(570, 19);
            this.btnRefreshSuppliers.Name = "btnRefreshSuppliers";
            this.btnRefreshSuppliers.Size = new System.Drawing.Size(102, 23);
            this.btnRefreshSuppliers.TabIndex = 8;
            this.btnRefreshSuppliers.Text = "Refresh Database";
            this.btnRefreshSuppliers.UseVisualStyleBackColor = true;
            this.btnRefreshSuppliers.Click += new System.EventHandler(this.btnRefreshSuppliers_Click);
            // 
            // dgvSuppliers
            // 
            this.dgvSuppliers.AllowUserToAddRows = false;
            this.dgvSuppliers.AllowUserToDeleteRows = false;
            this.dgvSuppliers.AllowUserToResizeColumns = false;
            this.dgvSuppliers.AllowUserToResizeRows = false;
            this.dgvSuppliers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle28.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle28.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle28.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle28.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle28.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle28.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSuppliers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle28;
            this.dgvSuppliers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle29.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle29.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle29.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle29.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle29.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle29.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSuppliers.DefaultCellStyle = dataGridViewCellStyle29;
            this.dgvSuppliers.Location = new System.Drawing.Point(10, 51);
            this.dgvSuppliers.MultiSelect = false;
            this.dgvSuppliers.Name = "dgvSuppliers";
            this.dgvSuppliers.ReadOnly = true;
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle30.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle30.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle30.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle30.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle30.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle30.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSuppliers.RowHeadersDefaultCellStyle = dataGridViewCellStyle30;
            this.dgvSuppliers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSuppliers.Size = new System.Drawing.Size(662, 506);
            this.dgvSuppliers.TabIndex = 6;
            this.dgvSuppliers.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvSuppliers_CellMouseClick);
            // 
            // txtSearchSupplier
            // 
            this.txtSearchSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchSupplier.Location = new System.Drawing.Point(241, 19);
            this.txtSearchSupplier.Name = "txtSearchSupplier";
            this.txtSearchSupplier.Size = new System.Drawing.Size(173, 23);
            this.txtSearchSupplier.TabIndex = 5;
            this.txtSearchSupplier.TextChanged += new System.EventHandler(this.txtSearchSupplier_TextChanged);
            // 
            // cmbSupplierColumns
            // 
            this.cmbSupplierColumns.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSupplierColumns.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSupplierColumns.FormattingEnabled = true;
            this.cmbSupplierColumns.Location = new System.Drawing.Point(89, 18);
            this.cmbSupplierColumns.Name = "cmbSupplierColumns";
            this.cmbSupplierColumns.Size = new System.Drawing.Size(146, 24);
            this.cmbSupplierColumns.TabIndex = 4;
            // 
            // lblSearchSupplier
            // 
            this.lblSearchSupplier.AutoSize = true;
            this.lblSearchSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchSupplier.Location = new System.Drawing.Point(7, 21);
            this.lblSearchSupplier.Name = "lblSearchSupplier";
            this.lblSearchSupplier.Size = new System.Drawing.Size(76, 17);
            this.lblSearchSupplier.TabIndex = 2;
            this.lblSearchSupplier.Text = "Search by:";
            // 
            // grpSupplierOptions
            // 
            this.grpSupplierOptions.Controls.Add(this.lblEmailWarning);
            this.grpSupplierOptions.Controls.Add(this.lblLocationWarning);
            this.grpSupplierOptions.Controls.Add(this.lblNameWarning);
            this.grpSupplierOptions.Controls.Add(this.btnConfirmEdit);
            this.grpSupplierOptions.Controls.Add(this.btnDeleteSupplier);
            this.grpSupplierOptions.Controls.Add(this.btnConfirmAddition);
            this.grpSupplierOptions.Controls.Add(this.btnAddSupplier);
            this.grpSupplierOptions.Controls.Add(this.btnCancelAddition);
            this.grpSupplierOptions.Controls.Add(this.btnCancelEdit);
            this.grpSupplierOptions.Controls.Add(this.btnEditSupplier);
            this.grpSupplierOptions.Controls.Add(this.btnClearSupplierDetails);
            this.grpSupplierOptions.Controls.Add(this.lblEmail);
            this.grpSupplierOptions.Controls.Add(this.lblLocation);
            this.grpSupplierOptions.Controls.Add(this.lblSupplierIDNumber);
            this.grpSupplierOptions.Controls.Add(this.lblSupplierID);
            this.grpSupplierOptions.Controls.Add(this.lblSupplierName);
            this.grpSupplierOptions.Controls.Add(this.txtEmail);
            this.grpSupplierOptions.Controls.Add(this.txtLocation);
            this.grpSupplierOptions.Controls.Add(this.txtSupplierName);
            this.grpSupplierOptions.Location = new System.Drawing.Point(12, 12);
            this.grpSupplierOptions.Name = "grpSupplierOptions";
            this.grpSupplierOptions.Size = new System.Drawing.Size(512, 563);
            this.grpSupplierOptions.TabIndex = 3;
            this.grpSupplierOptions.TabStop = false;
            this.grpSupplierOptions.Text = "Supplier Options";
            // 
            // grpData
            // 
            this.grpData.Controls.Add(this.btnRefreshSuppliers);
            this.grpData.Controls.Add(this.dgvSuppliers);
            this.grpData.Controls.Add(this.txtSearchSupplier);
            this.grpData.Controls.Add(this.cmbSupplierColumns);
            this.grpData.Controls.Add(this.lblSearchSupplier);
            this.grpData.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpData.Location = new System.Drawing.Point(551, 12);
            this.grpData.Name = "grpData";
            this.grpData.Size = new System.Drawing.Size(678, 563);
            this.grpData.TabIndex = 2;
            this.grpData.TabStop = false;
            this.grpData.Text = "Suppliers";
            // 
            // lblNameWarning
            // 
            this.lblNameWarning.ForeColor = System.Drawing.Color.Red;
            this.lblNameWarning.Location = new System.Drawing.Point(172, 153);
            this.lblNameWarning.Name = "lblNameWarning";
            this.lblNameWarning.Size = new System.Drawing.Size(276, 23);
            this.lblNameWarning.TabIndex = 7;
            // 
            // lblLocationWarning
            // 
            this.lblLocationWarning.ForeColor = System.Drawing.Color.Red;
            this.lblLocationWarning.Location = new System.Drawing.Point(172, 203);
            this.lblLocationWarning.Name = "lblLocationWarning";
            this.lblLocationWarning.Size = new System.Drawing.Size(276, 23);
            this.lblLocationWarning.TabIndex = 7;
            // 
            // lblEmailWarning
            // 
            this.lblEmailWarning.ForeColor = System.Drawing.Color.Red;
            this.lblEmailWarning.Location = new System.Drawing.Point(172, 255);
            this.lblEmailWarning.Name = "lblEmailWarning";
            this.lblEmailWarning.Size = new System.Drawing.Size(276, 23);
            this.lblEmailWarning.TabIndex = 7;
            // 
            // btnConfirmAddition
            // 
            this.btnConfirmAddition.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmAddition.Location = new System.Drawing.Point(186, 305);
            this.btnConfirmAddition.Name = "btnConfirmAddition";
            this.btnConfirmAddition.Size = new System.Drawing.Size(141, 34);
            this.btnConfirmAddition.TabIndex = 4;
            this.btnConfirmAddition.Text = "Confirm Addition";
            this.btnConfirmAddition.UseVisualStyleBackColor = true;
            this.btnConfirmAddition.Visible = false;
            this.btnConfirmAddition.Click += new System.EventHandler(this.btnConfirmAddition_Click);
            // 
            // btnCancelAddition
            // 
            this.btnCancelAddition.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelAddition.Location = new System.Drawing.Point(186, 385);
            this.btnCancelAddition.Name = "btnCancelAddition";
            this.btnCancelAddition.Size = new System.Drawing.Size(141, 34);
            this.btnCancelAddition.TabIndex = 4;
            this.btnCancelAddition.Text = "Cancel Addition";
            this.btnCancelAddition.UseVisualStyleBackColor = true;
            this.btnCancelAddition.Visible = false;
            this.btnCancelAddition.Click += new System.EventHandler(this.btnCancelAddition_Click);
            // 
            // frmMaintainSuppliers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1241, 587);
            this.Controls.Add(this.grpSupplierOptions);
            this.Controls.Add(this.grpData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMaintainSuppliers";
            this.Text = "frmMaintainSuppliers";
            this.Load += new System.EventHandler(this.frmMaintainSuppliers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuppliers)).EndInit();
            this.grpSupplierOptions.ResumeLayout(false);
            this.grpSupplierOptions.PerformLayout();
            this.grpData.ResumeLayout(false);
            this.grpData.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnConfirmEdit;
        private System.Windows.Forms.Button btnDeleteSupplier;
        private System.Windows.Forms.Button btnAddSupplier;
        private System.Windows.Forms.Button btnCancelEdit;
        private System.Windows.Forms.Button btnEditSupplier;
        private System.Windows.Forms.Button btnClearSupplierDetails;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Label lblSupplierIDNumber;
        private System.Windows.Forms.Label lblSupplierID;
        private System.Windows.Forms.Label lblSupplierName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.TextBox txtSupplierName;
        private System.Windows.Forms.Button btnRefreshSuppliers;
        private System.Windows.Forms.DataGridView dgvSuppliers;
        private System.Windows.Forms.TextBox txtSearchSupplier;
        private System.Windows.Forms.ComboBox cmbSupplierColumns;
        private System.Windows.Forms.Label lblSearchSupplier;
        private System.Windows.Forms.GroupBox grpSupplierOptions;
        private System.Windows.Forms.GroupBox grpData;
        private System.Windows.Forms.Label lblEmailWarning;
        private System.Windows.Forms.Label lblLocationWarning;
        private System.Windows.Forms.Label lblNameWarning;
        private System.Windows.Forms.Button btnConfirmAddition;
        private System.Windows.Forms.Button btnCancelAddition;
    }
}