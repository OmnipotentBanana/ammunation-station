using _32582625_AmmunationStation.Classes;
using _32582625_AmmunationStation.Classes.SalesRelated;
using _32582625_AmmunationStation.Classes.SqlFunctions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _32582625_AmmunationStation
{
    public partial class frmSalesOrder : Form
    {
        SqlCommands sqlCommands = new SqlCommands();
        
        Inventory[] items = new Inventory[100]; 
        Inventory item;

        SalesOrderDetail[] salesOrderDetails = new SalesOrderDetail[100];
        SalesOrder salesOrder = new SalesOrder();

        Employee employee = new Employee();
        Client client = new Client();
        float clientSpent = 0;

        bool correctData = false;

        int size = 0;

        public frmSalesOrder()
        {
            InitializeComponent();
        }

        private void frmSellOrder_Load(object sender, EventArgs e)
        {
            fillInventory();

            this.Left = 0;
            this.Top = 0;

            lstItems.View = View.Details;
            lstItems.GridLines = true;
            addItemColumns();
            updateSalesOrderNumber();

            foreach (DataGridViewColumn column in dgvInventory.Columns)
            {
                cmbInventoryColumns.Items.Add(column.HeaderText.ToString());
            }
            cmbInventoryColumns.SelectedIndex = 0;

            if (sqlCommands.sqlSelect("SELECT * FROM Client").Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("No clients currently exist. Please request assistance from an administrator", "No Clients", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.BeginInvoke(new MethodInvoker(Close));
            }

        }

        public void fillInventory()
        {
            string sql = "SELECT * FROM Inventory";
            dgvInventory.DataSource = sqlCommands.sqlSelect(sql).Tables[0].DefaultView;
        }

        private void txtSearchInventory_TextChanged(object sender, EventArgs e)
        {
            string sql = $"SELECT * FROM Inventory WHERE {cmbInventoryColumns.Text} LIKE '%{txtSearchInventory.Text}%'";
            dgvInventory.DataSource = sqlCommands.sqlSelect(sql).Tables[0].DefaultView;
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            if (dgvInventory.SelectedRows.Count == 1)
            {
                bool duplicate = false;
                for (int a = 0; a < size; a++)
                {
                    if (items[a].itemID == item.itemID)
                    {
                        duplicate = true;
                        break;
                    }
                }
                
                if (!duplicate)
                {
                    try
                    {
                        items[size] = item;
                        float margin = float.Parse(numProfitMargin.Value.ToString());
                        float withMargin = item.itemCost + item.itemCost * margin / 100;
                        salesOrderDetails[size] = new SalesOrderDetail(salesOrder.orderNumber, item, (int)numItemQuantity.Value, withMargin);
                        clientSpent += withMargin;
                        lblTotal.Text = "$ " + clientSpent.ToString("0.00"); 
                        string[] row = { item.itemID.ToString(), item.itemSerialNumber, item.itemMake, item.itemModel, item.itemCaliber, item.itemType, withMargin.ToString("0.00"), numItemQuantity.Value.ToString() };
                        ListViewItem listViewItem = new ListViewItem(row);
                        lstItems.Items.Add(listViewItem);
                        size++;
                        numItemQuantity.Value = 1;
                        correctData = true;
                    }
                    catch (NullReferenceException)
                    {
                        MessageBox.Show("No items have been added.");
                        correctData = false;
                    }
                }
                else
                {
                    MessageBox.Show("Item has already been added");
                }
            }
            else
            {
                MessageBox.Show("You need to select an item from the item list first!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                correctData = false;
            }
        }

        private void dgvInventory_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            foreach (DataGridViewRow row in dgvInventory.SelectedRows)
            {
                item = new Inventory(Convert.ToInt32(row.Cells[0].Value), row.Cells[1].Value.ToString(), row.Cells[2].Value.ToString(), row.Cells[3].Value.ToString() , row.Cells[4].Value.ToString(), row.Cells[5].Value.ToString(), float.Parse(row.Cells[6].Value.ToString()), Convert.ToInt32(row.Cells[7].Value));
                numItemQuantity.Maximum = item.itemQuantity;
            }

            if (item.itemQuantity == 0)
            {
                MessageBox.Show("There is no stock of this item. Please order more from a supplier.", "No stock", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnAddItem.Enabled = false;
            }
            else
            {
                btnAddItem.Enabled = true;
            }

            txtSearchInventory.Text = item.itemID.ToString();
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            btnCreateSalesOrder.Enabled = false;
            lblStateIDError.ForeColor = Color.Red;
            correctData = false;
            try
            {
                float.Parse(txtStateID.Text);
                if (txtStateID.Text.Length == 13)
                {
                    DataSet dsClient = new DataSet();
                    DataSet dsAddress = new DataSet();
                    lblStateIDError.Text = "";
                    string sql = $"SELECT * FROM Client WHERE ClientStateID = '{txtStateID.Text}'";
                    dsClient = sqlCommands.sqlSelect(sql);
                    if (dsClient.Tables[0].Rows.Count == 0)
                    {
                        lblStateIDError.Text = "Client does not exist";
                    }
                    else
                    {
                        lblStateIDError.ForeColor = Color.Green;
                        lblStateIDError.Text = "Client Found!";
                        btnCreateSalesOrder.Enabled = true;
                        client.clientID = Convert.ToInt32(dsClient.Tables[0].Rows[0][0].ToString());
                        client.stateID = dsClient.Tables[0].Rows[0][1].ToString();
                        client.firstName = dsClient.Tables[0].Rows[0][2].ToString();
                        client.surname = dsClient.Tables[0].Rows[0][3].ToString();
                        client.moneySpent = float.Parse(dsClient.Tables[0].Rows[0][5].ToString());

                        sql = $"SELECT * FROM ClientAddress WHERE ClientAddressID = {dsClient.Tables[0].Rows[0][4].ToString()}";
                        dsAddress = sqlCommands.sqlSelect(sql);
                        Address address = new Address(Convert.ToInt32(dsAddress.Tables[0].Rows[0][0]), Convert.ToInt32(dsAddress.Tables[0].Rows[0][1]), dsAddress.Tables[0].Rows[0][2].ToString(), dsAddress.Tables[0].Rows[0][3].ToString());

                        client.address = address;
                        correctData = true;
                    }
                }
                else
                {
                    lblStateIDError.Text = "ID is not the correct length";
                }
            }
            catch (Exception)
            {
                lblStateIDError.Text = "ID is not valid";
            }
        }

        public void updateSalesOrderNumber()
        {
            DataSet ds = new DataSet();
            string sql = "SELECT TOP 1 SalesOrderNumber FROM SalesOrder ORDER BY SalesOrderNumber DESC";
            ds = sqlCommands.sqlSelect(sql);
            salesOrder.orderNumber = Convert.ToInt32(sqlCommands.sqlSelect(sql).Tables[0].Rows[0][0]) + 1;
            lblSalesOrderNumber.Text = salesOrder.orderNumber.ToString();
        }

        private void btnCreateSalesOrder_Click(object sender, EventArgs e)
        {
            if (size > 0 && correctData){
                salesOrder.client = client;
                salesOrder.salesOrderDetail = salesOrderDetails;
                salesOrder.size = this.size;
                salesOrder.orderDate = DateTime.Now;

                // sales order x 1
                string sql = $"INSERT INTO SalesOrder (ClientID, SalesOrderDate) VALUES ({salesOrder.client.clientID}, '{salesOrder.orderDate.ToString("yyyy/MM/dd")}')";
                sqlCommands.sqlInsert(sql);

                // sales order detail x size
                for (int a = 0; a < size; a++)
                {
                    var ptr = salesOrder.salesOrderDetail[a];
                    sql = $"INSERT INTO SalesOrderDetail (SalesOrderNumber, ItemID, QuantitySold, UnitPricePaid) VALUES ({ptr.salesOrderNumber}, {ptr.inventoryItem.itemID}, {ptr.quantitySold}, {ptr.unitPricePaid})";
                    sqlCommands.sqlInsert(sql);
                }

                // inventory x size
                for (int a = 0; a < size; a++)
                {
                    var ptr = salesOrder.salesOrderDetail[a];
                    var originalQuantity = items[a].itemQuantity;
                    int remainder = ptr.inventoryItem.itemQuantity - ptr.quantitySold;
                    
                    sql = $"UPDATE Inventory SET ItemQuantity = {remainder} WHERE ItemID = {ptr.inventoryItem.itemID}";
                    sqlCommands.sqlUpdate(sql);
                }

                // create log file
                createTextfileLog();
                sql = "SELECT * FROM INVENTORY";
                dgvInventory.DataSource = sqlCommands.sqlSelect(sql).Tables[0].DefaultView;
                MessageBox.Show("Sale completed successfully!", "Finished", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSearchInventory.Text = "";
                txtStateID.Text = "";
            }
            else
            {
                MessageBox.Show("You haven't added items to sell yet!");
            }
        }

        private void btnClearItems_Click(object sender, EventArgs e)
        {
            correctData = false;
            clientSpent = 0;
            lstItems.Clear();
            addItemColumns();
            size = 0;
            salesOrder = new SalesOrder();
            salesOrderDetails = new SalesOrderDetail[100];
            txtSearchInventory.Text = "";
            dgvInventory.DataSource = sqlCommands.sqlSelect("SELECT * FROM Inventory").Tables[0].DefaultView;
            lblTotal.Text = clientSpent.ToString("0.00");
            btnCreateSalesOrder.Enabled = false;
        }

        public void createTextfileLog() // logs created in My Documents under Ammunation Station Logs\Sales
        {
            var ptr = salesOrder.orderDate;
            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDoc‌​uments), "Ammunation Station Logs", "Sales");

            if (Directory.Exists(path))
            {
                File.WriteAllText(Path.Combine(path, "Sale_" + ptr.Day + "." + ptr.Month + "." + ptr.Year + "_" + ptr.Hour + "." + ptr.Minute + "." + ptr.Second + "_" + employee.getEmployeeName() + employee.getEmployeeSurname() + ".txt"), salesOrder.ToString());
            }
            else
            {
                Directory.CreateDirectory(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDoc‌​uments), "Ammunation Station Logs", "Sales"));
                createTextfileLog();
            }
        }
    }
}
