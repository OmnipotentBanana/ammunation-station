
namespace _32582625_AmmunationStation
{
    partial class frmSalesOrder
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
            this.grpInventory = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.numProfitMargin = new System.Windows.Forms.NumericUpDown();
            this.lblSalesOrderNumber = new System.Windows.Forms.Label();
            this.lblSalesOrder = new System.Windows.Forms.Label();
            this.numItemQuantity = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.txtSearchInventory = new System.Windows.Forms.TextBox();
            this.cmbInventoryColumns = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvInventory = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnClearItems = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCreateSalesOrder = new System.Windows.Forms.Button();
            this.lblStateIDError = new System.Windows.Forms.Label();
            this.txtStateID = new System.Windows.Forms.TextBox();
            this.lblStateID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lstItems = new System.Windows.Forms.ListView();
            this.grpInventory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numProfitMargin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numItemQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpInventory
            // 
            this.grpInventory.Controls.Add(this.label5);
            this.grpInventory.Controls.Add(this.numProfitMargin);
            this.grpInventory.Controls.Add(this.lblSalesOrderNumber);
            this.grpInventory.Controls.Add(this.lblSalesOrder);
            this.grpInventory.Controls.Add(this.numItemQuantity);
            this.grpInventory.Controls.Add(this.label3);
            this.grpInventory.Controls.Add(this.btnAddItem);
            this.grpInventory.Controls.Add(this.txtSearchInventory);
            this.grpInventory.Controls.Add(this.cmbInventoryColumns);
            this.grpInventory.Controls.Add(this.label1);
            this.grpInventory.Controls.Add(this.dgvInventory);
            this.grpInventory.Location = new System.Drawing.Point(12, 12);
            this.grpInventory.Name = "grpInventory";
            this.grpInventory.Size = new System.Drawing.Size(1217, 249);
            this.grpInventory.TabIndex = 0;
            this.grpInventory.TabStop = false;
            this.grpInventory.Text = "Inventory";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(927, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Margin (%):";
            // 
            // numProfitMargin
            // 
            this.numProfitMargin.Location = new System.Drawing.Point(1020, 173);
            this.numProfitMargin.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numProfitMargin.Name = "numProfitMargin";
            this.numProfitMargin.Size = new System.Drawing.Size(120, 20);
            this.numProfitMargin.TabIndex = 3;
            this.numProfitMargin.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // lblSalesOrderNumber
            // 
            this.lblSalesOrderNumber.AutoSize = true;
            this.lblSalesOrderNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalesOrderNumber.Location = new System.Drawing.Point(1075, 30);
            this.lblSalesOrderNumber.Name = "lblSalesOrderNumber";
            this.lblSalesOrderNumber.Size = new System.Drawing.Size(0, 17);
            this.lblSalesOrderNumber.TabIndex = 7;
            // 
            // lblSalesOrder
            // 
            this.lblSalesOrder.AutoSize = true;
            this.lblSalesOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalesOrder.Location = new System.Drawing.Point(927, 30);
            this.lblSalesOrder.Name = "lblSalesOrder";
            this.lblSalesOrder.Size = new System.Drawing.Size(142, 17);
            this.lblSalesOrder.TabIndex = 7;
            this.lblSalesOrder.Text = "Sales Order Number:";
            // 
            // numItemQuantity
            // 
            this.numItemQuantity.Location = new System.Drawing.Point(1020, 146);
            this.numItemQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numItemQuantity.Name = "numItemQuantity";
            this.numItemQuantity.Size = new System.Drawing.Size(120, 20);
            this.numItemQuantity.TabIndex = 2;
            this.numItemQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(937, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Quantity:";
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(945, 207);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(175, 23);
            this.btnAddItem.TabIndex = 4;
            this.btnAddItem.Text = "Add Selected Item";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // txtSearchInventory
            // 
            this.txtSearchInventory.Location = new System.Drawing.Point(931, 103);
            this.txtSearchInventory.Name = "txtSearchInventory";
            this.txtSearchInventory.Size = new System.Drawing.Size(209, 20);
            this.txtSearchInventory.TabIndex = 1;
            this.txtSearchInventory.TextChanged += new System.EventHandler(this.txtSearchInventory_TextChanged);
            // 
            // cmbInventoryColumns
            // 
            this.cmbInventoryColumns.FormattingEnabled = true;
            this.cmbInventoryColumns.Location = new System.Drawing.Point(992, 67);
            this.cmbInventoryColumns.Name = "cmbInventoryColumns";
            this.cmbInventoryColumns.Size = new System.Drawing.Size(148, 21);
            this.cmbInventoryColumns.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(928, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search by:";
            // 
            // dgvInventory
            // 
            this.dgvInventory.AllowUserToAddRows = false;
            this.dgvInventory.AllowUserToDeleteRows = false;
            this.dgvInventory.AllowUserToResizeColumns = false;
            this.dgvInventory.AllowUserToResizeRows = false;
            this.dgvInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventory.Location = new System.Drawing.Point(6, 19);
            this.dgvInventory.MultiSelect = false;
            this.dgvInventory.Name = "dgvInventory";
            this.dgvInventory.ReadOnly = true;
            this.dgvInventory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInventory.Size = new System.Drawing.Size(844, 211);
            this.dgvInventory.TabIndex = 9;
            this.dgvInventory.TabStop = false;
            this.dgvInventory.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvInventory_CellMouseClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnClearItems);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lstItems);
            this.groupBox1.Location = new System.Drawing.Point(12, 267);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1217, 308);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sell to a Client";
            // 
            // btnClearItems
            // 
            this.btnClearItems.Location = new System.Drawing.Point(705, 19);
            this.btnClearItems.Name = "btnClearItems";
            this.btnClearItems.Size = new System.Drawing.Size(75, 23);
            this.btnClearItems.TabIndex = 7;
            this.btnClearItems.Text = "Clear Items";
            this.btnClearItems.UseVisualStyleBackColor = true;
            this.btnClearItems.Click += new System.EventHandler(this.btnClearItems_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblTotal);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.btnCreateSalesOrder);
            this.groupBox2.Controls.Add(this.lblStateIDError);
            this.groupBox2.Controls.Add(this.txtStateID);
            this.groupBox2.Controls.Add(this.lblStateID);
            this.groupBox2.Location = new System.Drawing.Point(826, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(355, 281);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sell to";
            // 
            // lblTotal
            // 
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(102, 127);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(212, 20);
            this.lblTotal.TabIndex = 5;
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(37, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Total:";
            // 
            // btnCreateSalesOrder
            // 
            this.btnCreateSalesOrder.Enabled = false;
            this.btnCreateSalesOrder.Location = new System.Drawing.Point(119, 172);
            this.btnCreateSalesOrder.Name = "btnCreateSalesOrder";
            this.btnCreateSalesOrder.Size = new System.Drawing.Size(175, 23);
            this.btnCreateSalesOrder.TabIndex = 6;
            this.btnCreateSalesOrder.Text = "Create Sales Order";
            this.btnCreateSalesOrder.UseVisualStyleBackColor = true;
            this.btnCreateSalesOrder.Click += new System.EventHandler(this.btnCreateSalesOrder_Click);
            // 
            // lblStateIDError
            // 
            this.lblStateIDError.ForeColor = System.Drawing.Color.Red;
            this.lblStateIDError.Location = new System.Drawing.Point(105, 84);
            this.lblStateIDError.Name = "lblStateIDError";
            this.lblStateIDError.Size = new System.Drawing.Size(209, 23);
            this.lblStateIDError.TabIndex = 2;
            this.lblStateIDError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtStateID
            // 
            this.txtStateID.Location = new System.Drawing.Point(105, 61);
            this.txtStateID.Name = "txtStateID";
            this.txtStateID.Size = new System.Drawing.Size(209, 20);
            this.txtStateID.TabIndex = 5;
            this.txtStateID.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblStateID
            // 
            this.lblStateID.AutoSize = true;
            this.lblStateID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStateID.Location = new System.Drawing.Point(19, 62);
            this.lblStateID.Name = "lblStateID";
            this.lblStateID.Size = new System.Drawing.Size(62, 17);
            this.lblStateID.TabIndex = 0;
            this.lblStateID.Text = "State ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Selected Items:";
            // 
            // lstItems
            // 
            this.lstItems.HideSelection = false;
            this.lstItems.Location = new System.Drawing.Point(6, 43);
            this.lstItems.Name = "lstItems";
            this.lstItems.Size = new System.Drawing.Size(774, 259);
            this.lstItems.TabIndex = 8;
            this.lstItems.TabStop = false;
            this.lstItems.UseCompatibleStateImageBehavior = false;
            // 
            // frmSalesOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1241, 587);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpInventory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSalesOrder";
            this.Text = "frmSellOrder";
            this.Load += new System.EventHandler(this.frmSellOrder_Load);
            this.grpInventory.ResumeLayout(false);
            this.grpInventory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numProfitMargin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numItemQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpInventory;
        private System.Windows.Forms.DataGridView dgvInventory;
        private System.Windows.Forms.TextBox txtSearchInventory;
        private System.Windows.Forms.ComboBox cmbInventoryColumns;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView lstItems;
        private System.Windows.Forms.NumericUpDown numItemQuantity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtStateID;
        private System.Windows.Forms.Label lblStateID;
        private System.Windows.Forms.Label lblStateIDError;
        private System.Windows.Forms.Label lblSalesOrderNumber;
        private System.Windows.Forms.Label lblSalesOrder;
        private System.Windows.Forms.Button btnCreateSalesOrder;
        private System.Windows.Forms.Button btnClearItems;
        private System.Windows.Forms.NumericUpDown numProfitMargin;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}