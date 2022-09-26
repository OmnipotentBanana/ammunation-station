using _32582625_AmmunationStation.Classes.SalesRelated;
using _32582625_AmmunationStation.Classes.SqlFunctions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using _32582625_AmmunationStation.Classes;

namespace _32582625_AmmunationStation
{
    public partial class frmPurchaseOrder : Form
    {
        #region Global Variables
        SqlCommands sqlCommands = new SqlCommands();
        PurchaseOrderDetail[] purchaseOrderDetails = new PurchaseOrderDetail[100];
        PurchaseOrder purchaseOrder = new PurchaseOrder();
        Inventory[] items = new Inventory[100];
        Employee employee = new Employee();
        int totalQuantity = 0;
        float totalPrice = 0;
        int size = 0;
        int newPONum;
        #endregion

        public frmPurchaseOrder()
        {
            InitializeComponent();
        }

        private void frmPurchaseOrder_Load(object sender, EventArgs e)
        {
            this.Left = 0;
            this.Top = 0;
            fillPurchaseOrders();
            lstItems.View = View.Details;
            lstItems.GridLines = true;
            addItemColumns();
            updateQuantity();

            string sql = "SELECT TOP 1 PurchaseOrderNumber FROM PurchaseOrder ORDER BY PurchaseOrderNumber DESC";
            purchaseOrder.orderNumber = Convert.ToInt32(sqlCommands.sqlSelect(sql).Tables[0].Rows[0][0]) + 1;
            lblPurchaseOrderNUM.Text = purchaseOrder.orderNumber.ToString();

            dgvSuppliers.Columns[0].Width = 60;
            purchaseOrder.orderDate = DateTime.Now;
            txtPurchaseOrderDate.Text = purchaseOrder.orderDate.ToShortDateString();

            if (dgvSuppliers.Rows.Count == 0)
            {
                MessageBox.Show("No suppliers currently exist. Please request assistance from an administrator", "No Suppliers", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.BeginInvoke(new MethodInvoker(Close));
            }
        }

        public void fillPurchaseOrders()
        {
            string sql = "SELECT * FROM Supplier";
            dgvSuppliers.DataSource = sqlCommands.sqlSelect(sql).Tables[0].DefaultView;
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            if ((txtSerialNumber.Text != "") && (txtMake.Text != "") && (txtCaliber.Text != "") && (txtType.Text != "") && (txtCost.Text != "") && (numQuantity.Value > 0))
            {
                if (size != 100)
                {
                    try
                    {
                        string sql = "SELECT TOP 1 ItemID FROM Inventory ORDER BY ItemID DESC";
                        int newItemID = Convert.ToInt32(sqlCommands.sqlSelect(sql).Tables[0].Rows[0][0]);

                        Inventory item = new Inventory(newItemID + size, txtSerialNumber.Text, txtMake.Text, txtModel.Text, txtCaliber.Text, txtType.Text, float.Parse(txtCost.Text), Convert.ToInt32(numQuantity.Value));
                        items[size] = item;
                        totalQuantity += item.itemQuantity;
                        totalPrice += item.itemCost * item.itemQuantity;
                        sql = "SELECT TOP 1 ID FROM PurchaseOrderDetail ORDER BY ID DESC";
                        int newPODID = Convert.ToInt32(sqlCommands.sqlSelect(sql).Tables[0].Rows[0][0]);
                        sql = "SELECT TOP 1 PurchaseOrderNumber FROM PurchaseOrder ORDER BY PurchaseOrderNumber DESC";
                        newPONum = Convert.ToInt32(sqlCommands.sqlSelect(sql).Tables[0].Rows[0][0]) + 1;

                        PurchaseOrderDetail purchaseOrderDetail = new PurchaseOrderDetail(newPODID + size, newPONum, item, item.itemQuantity, item.itemCost);
                        purchaseOrderDetails[size] = purchaseOrderDetail;
                        purchaseOrder.purchaseOrderDetails = purchaseOrderDetails;

                        string[] row = { item.itemID.ToString(), item.itemSerialNumber, item.itemMake, item.itemModel, item.itemCaliber, item.itemType, item.itemCost.ToString(), item.itemQuantity.ToString() };
                        ListViewItem listViewItem = new ListViewItem(row);
                        lstItems.Items.Add(listViewItem);
                        clearItems();
                        updateQuantity();
                        size++;
                    }
                    catch
                    {
                        MessageBox.Show("Some values are not valid.");
                    }
                }
                else
                {
                    MessageBox.Show("Cannot add any more items. Please create a new purchase order.");
                    btnAddItem.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("Not a single value can be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public void updateQuantity()
        {
            lblTotalQuantity.Text = totalQuantity.ToString();
            lblTotalPrice.Text = "$ " + totalPrice.ToString();
        }
        public void clearItems()
        {
            txtSerialNumber.Clear();
            txtMake.Clear();
            txtCaliber.Clear();
            txtType.Clear();
            txtModel.Clear();
            txtCost.Clear();
            txtPurchaseOrderDate.Clear();
            numQuantity.Value = 1;
        }

        public void addItemColumns()
        {
            lstItems.Columns.Add("Item ID", 50);
            lstItems.Columns.Add("Serial Number", 100);
            lstItems.Columns.Add("Make", 105);
            lstItems.Columns.Add("Model", 105);
            lstItems.Columns.Add("Caliber", 105);
            lstItems.Columns.Add("Type", 105);
            lstItems.Columns.Add("Cost", 95);
            lstItems.Columns.Add("Quantity", 55);
        }

        private void btnClearList_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to clear the item list? This action cannot be reverted.", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                lstItems.View = View.Details;
                lstItems.GridLines = true;
                totalQuantity = 0;
                totalPrice = 0;
                numQuantity.Value = 1;
                lstItems.Clear();
                addItemColumns();
                updateQuantity();
                size = 0;
                btnAddItem.Enabled = true;
            }
        }

        private void lblSupplierHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You need to select a supplier at the data grid on the right. If the supplier does not exist, ask an administrator for assistance. The textbox also acts as a search bar.", "Supplier", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dgvSuppliers_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int index = dgvSuppliers.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dgvSuppliers.Rows[index];
            Supplier supplier = new Supplier(Convert.ToInt32(selectedRow.Cells[0].Value), selectedRow.Cells[1].Value.ToString(), selectedRow.Cells[2].Value.ToString(), selectedRow.Cells[3].Value.ToString());
            purchaseOrder.supplier = supplier;
            txtSupplierName.Text = supplier.supplierName;
        }

        private void txtSupplierName_TextChanged(object sender, EventArgs e)
        {
            string sql = $"SELECT * FROM Supplier WHERE SupplierName LIKE '%{txtSupplierName.Text}%'";
            dgvSuppliers.DataSource = sqlCommands.sqlSelect(sql).Tables[0].DefaultView;
        }

        private void btnAddPurchaseOrder_Click(object sender, EventArgs e)
        {
            if (txtSupplierName.Text != "")
            {
                if (MessageBox.Show("Are you sure you want to process the new purchase order directed towards " + purchaseOrder.supplier.supplierName + " on " + purchaseOrder.orderDate.ToShortDateString() + "? Total quantity of items is " + totalQuantity.ToString() + " summing up to a total of $ " + totalPrice.ToString() + ".", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (size > 0)
                    {
                        string sql = $"SELECT * FROM Supplier WHERE SupplierName = '{txtSupplierName.Text}'";
                        
                        if (sqlCommands.sqlSelect(sql).Tables[0].Rows.Count > 0)
                        {
                            // purchase order x 1
                            purchaseOrder.size = size;
                            sql = $"INSERT INTO PurchaseOrder (SupplierID, PurchaseOrderDate) VALUES ({purchaseOrder.supplier.supplierID}, '{purchaseOrder.orderDate.ToString("yyyy/MM/dd")}')"; 
                            sqlCommands.sqlInsert(sql);

                            // purchase order detail x size
                            for (int a = 0; a < size; a++) 
                            {
                                var ptr = purchaseOrder.purchaseOrderDetails[a];
                                sql = $"INSERT INTO PurchaseOrderDetail (PurchaseOrderNumber, ItemID, QuantityOrdered, UnitPricePaid) VALUES ({ptr.purchaseOrderNumber}, {ptr.inventoryItem.itemID}, {ptr.quantityOrdered}, {ptr.unitPricePaid})"; 
                                sqlCommands.sqlInsert(sql);
                            }

                            // inventory x size
                            for (int a = 0; a < size; a++) 
                            {
                                var ptr = purchaseOrder.purchaseOrderDetails[a].inventoryItem;
                                sql = $"INSERT INTO Inventory (ItemSerialNumber, ItemMake, ItemModel, ItemCaliber, ItemType, ItemCost, ItemQuantity) VALUES ('{ptr.itemSerialNumber}', '{ptr.itemMake}', '{ptr.itemModel}', '{ptr.itemCaliber}', '{ptr.itemType}', {ptr.itemCost}, {ptr.itemQuantity})"; 
                                sqlCommands.sqlInsert(sql);
                            }

                            // create log file
                            createTextfileLog();
                        }
                        else
                        {
                            MessageBox.Show("No such supplier exists. Please select a valid supplier at the right.", "Invalid Supplier", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("You have to add items first!", "Add Items", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a supplier.", "Invalid Supplier", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #region Create Text File Log for Purchase Order
        public void createTextfileLog() // logs created in My Documents under Ammunation Station Logs\Purchases
        {
            var ptr = purchaseOrder.orderDate;
            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDoc‌​uments), "Ammunation Station Logs", "Purchases");

            if (Directory.Exists(path))
            {
                File.WriteAllText(Path.Combine(path, "Purchase_" + ptr.Day + "." + ptr.Month + "." + ptr.Year + "_" + ptr.Hour + "." + ptr.Minute + "." + ptr.Second + "_" + employee.getEmployeeName() + employee.getEmployeeSurname() + ".txt"), purchaseOrder.ToString());
            }
            else
            {
                Directory.CreateDirectory(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDoc‌​uments), "Ammunation Station Logs", "Purchases"));
                createTextfileLog();
            }
        }
        #endregion

        #region Cancel Purchase Order
        private void btnCancelPurchaseOrder_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to clear the purchase order?. This action cannot be reverted.", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                clearItems();
                txtSupplierName.Clear();
                totalQuantity = 0;
                totalPrice = 0;
                size = 0;
                lstItems.Items.Clear();
            }
        }
        #endregion
    }
}