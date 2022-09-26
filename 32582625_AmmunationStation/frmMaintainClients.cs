using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _32582625_AmmunationStation.Classes;
using _32582625_AmmunationStation.Classes.SqlFunctions;

namespace _32582625_AmmunationStation
{
    public partial class frmMaintainClients : Form
    {
        Client selectedClient;
        Address address;
        SqlCommands sqlCommands = new SqlCommands();
        bool isValid = false;
        Address newAddress = new Address();
        
        public frmMaintainClients()
        {
            InitializeComponent();
        }

        private void frmMaintainClients_Load(object sender, EventArgs e)
        {
            this.Left = 0;
            this.Top = 0;

            refreshDatagrids();
            txtStateID.Focus();
            lblClientIDNumber.Text = "None";
            
            foreach (DataGridViewColumn column in dgvClients.Columns)
            {
                cmbClientColumns.Items.Add(column.HeaderText.ToString());
            }

            cmbClientColumns.SelectedIndex = 0;
            disableTXTBoxes();
            dgvAddress.ClearSelection();
            dgvClients.ClearSelection();
            btnEditClient.Enabled = false;
            btnCancelEdit.Visible = false;

            dgvAddress.Enabled = false;
        }

        private void btnClearClientDetails_Click(object sender, EventArgs e)
        {
            clearDetails();
            selectedClient = null;
        }

        public void clearDetails()
        {
            txtStateID.Text = "";
            txtCityName.Text = "";
            txtFirstName.Text = "";
            txtSurname.Text = "";
            txtStreetNumber.Text = "";
            txtStreetName.Text = "";
            lblClientIDNumber.Text = "";
            btnEditClient.Enabled = false;
        }

        public void enableTXTBoxes()
        {
            txtStateID.Enabled = true;
            txtFirstName.Enabled = true;
            txtSurname.Enabled = true;
            txtStreetName.Enabled = true;
            txtStreetNumber.Enabled = true;
            txtCityName.Enabled = true;
        }
        public void disableTXTBoxes()
        {
            txtStateID.Enabled = false;
            txtFirstName.Enabled = false;
            txtSurname.Enabled = false;
            txtStreetName.Enabled = false;
            txtStreetNumber.Enabled = false;
            txtCityName.Enabled = false;
        }
        public void enableEditing()
        {
            btnAddClient.Enabled = false;
            btnEditClient.Enabled = false;
            btnEditClient.Visible = false;
            btnConfirmEdit.Visible = true;
            btnConfirmEdit.Enabled = false;
            btnCancelEdit.Enabled = true;
            btnCancelEdit.Visible = true;
            disableDGV();
        }

        public void disableEditing()
        {
            btnAddClient.Enabled = true;
            btnEditClient.Enabled = true;
            btnEditClient.Visible = true;
            btnConfirmEdit.Visible = false;
            btnCancelEdit.Enabled = false;
            btnCancelEdit.Visible = false;
            enableDGV();
            
            dgvClients.DataSource = new DataSet();
            disableTXTBoxes();
        }

        public void disableDGV()
        {
            dgvClients.Enabled = false;
        }

        public void enableDGV()
        {
            dgvClients.Enabled = true;
        }

        private void txtSearchClient_TextChanged(object sender, EventArgs e)
        {
            dgvClients.DataSource = filterClients().Tables[0];
        }

        private void populateTextboxes(Client _selectedClient)
        {
            txtStateID.Text = _selectedClient.stateID.ToString();
            txtFirstName.Text = _selectedClient.firstName;
            txtSurname.Text = _selectedClient.surname;
            txtStreetName.Text = _selectedClient.address.streetName;
            txtStreetNumber.Text = _selectedClient.address.streetNumber.ToString();
            txtCityName.Text = _selectedClient.address.cityName;
        }
        
        public DataSet fillClients()
        {
            string sql = $"SELECT * FROM Client";
            return sqlCommands.sqlSelect(sql);
        }
        public DataSet filterClients()
        {
            string sql = $"SELECT * FROM Client WHERE {cmbClientColumns.SelectedItem} LIKE '%{txtSearchClient.Text}%'";
            return sqlCommands.sqlSelect(sql);
        }
        
        public DataSet fillAddress()
        {
            string sql = $"SELECT * FROM ClientAddress";
            return sqlCommands.sqlSelect(sql);
        }

        public DataSet filterAddress(Address address)
        {
            string sql = $"SELECT * FROM ClientAddress WHERE ClientAddressID = {address.addressID}";
            return sqlCommands.sqlSelect(sql);
        }

        

        private void dgvClients_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btnEditClient.Enabled = true;
            if (dgvClients.SelectedRows.Count == 1 && dgvClients.Rows.Count != 0)
            {
                try
                {
                    int index = dgvClients.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = dgvClients.Rows[index];
                    address = new Address();
                    selectedClient = new Client();
                    selectedClient.clientID = Int32.Parse(selectedRow.Cells[0].Value.ToString()); // not using constructor unlike maintain suppliers
                    selectedClient.stateID = selectedRow.Cells[1].Value.ToString();                 
                    selectedClient.firstName = selectedRow.Cells[2].Value.ToString();
                    selectedClient.surname = selectedRow.Cells[3].Value.ToString();

                    address.addressID = Convert.ToInt32(selectedRow.Cells[4].Value);
                    dgvAddress.DataSource = filterAddress(address).Tables[0];
                    address.streetNumber = Convert.ToInt32(dgvAddress.Rows[0].Cells[1].Value);
                    address.streetName = dgvAddress.Rows[0].Cells[2].Value.ToString();
                    address.cityName = dgvAddress.Rows[0].Cells[3].Value.ToString();

                    selectedClient.address = address;
                    lblClientIDNumber.Text = selectedClient.clientID.ToString();

                    populateTextboxes(selectedClient);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void btnEditClient_Click(object sender, EventArgs e)
        {
            enableEditing();
            enableTXTBoxes();
        }

        private void btnCancelEdit_Click(object sender, EventArgs e)
        {
            disableEditing();
            clearDetails();
            refreshDatagrids();
            btnClearClientDetails.Focus();
            disableTXTBoxes();
        }

        private void txtStateID_TextChanged(object sender, EventArgs e)
        {
            btnConfirmEdit.Enabled = true;

            if (txtStateID.Text.Length != 0)
            {
                isValid = true;
                lblStateIDError.Text = "";
                if (txtStateID.Text.Length == 13)
                {
                    isValid = true;
                }
                else
                {
                    isValid = false;
                    lblStateIDError.Text = "ID length must be 13 numbers";
                }
            }
            else
            {
                isValid = false;
                lblStateIDError.Text = "Value cannot be empty";
                btnConfirmEdit.Enabled = false;
            }
        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
            btnConfirmEdit.Enabled = true;
            if (txtFirstName.Text.Length != 0)
            {
                isValid = true;
                lblFirstNameError.Text = "";
            }
            else
            {
                isValid = false;
                lblFirstNameError.Text = "Value cannot be empty";
                btnConfirmEdit.Enabled = false;
            }
        }

        private void txtSurname_TextChanged(object sender, EventArgs e)
        {
            btnConfirmEdit.Enabled = true;
            if (txtSurname.Text.Length != 0)
            {
                isValid = true;
                lblSurnameError.Text = "";
            }
            else
            {
                isValid = false;
                lblSurnameError.Text = "Value cannot be empty";
                btnConfirmEdit.Enabled = false;
            }
        }

        private void txtStreetNumber_TextChanged(object sender, EventArgs e)
        {
            btnConfirmEdit.Enabled = true;
            if (txtStreetNumber.Text.Length != 0)
            {
                isValid = true;
                lblStreetNumberError.Text = "";
            }
            else
            {
                isValid = false;
                lblStreetNumberError.Text = "Value cannot be empty";
                btnConfirmEdit.Enabled = false;
            }
        }

        private void txtStreetName_TextChanged(object sender, EventArgs e)
        {
            btnConfirmEdit.Enabled = true;
            if (txtStreetName.Text.Length != 0)
            {
                isValid = true;
                lblStreetNameError.Text = "";
            }
            else
            {
                isValid = false;
                lblStreetNameError.Text = "Value cannot be empty";
                btnConfirmEdit.Enabled = false;
            }
        }

        private void txtCityName_TextChanged(object sender, EventArgs e)
        {
            btnConfirmEdit.Enabled = true;
            if (txtCityName.Text.Length != 0)
            {
                isValid = true;
                lblCityNameError.Text = "";
            }
            else
            {
                isValid = false;
                lblCityNameError.Text = "Value cannot be empty";
                btnConfirmEdit.Enabled = false;
            }
        }

        private void btnConfirmEdit_Click(object sender, EventArgs e)
        {
            // edit database values

            if ((selectedClient.stateID.ToLower() != txtStateID.Text.ToLower()) || 
                (selectedClient.firstName.ToLower() != txtFirstName.Text.ToLower()) || 
                (selectedClient.surname.ToLower() != txtSurname.Text.ToLower()) ||  
                (selectedClient.address.streetNumber.ToString().ToLower() != txtStreetNumber.Text.ToLower()) ||
                (selectedClient.address.streetName != txtStreetName.Text) ||
                (selectedClient.address.cityName.ToLower() != txtCityName.Text.ToLower()))
            {
                if (isValid)
                {
                    if (MessageBox.Show("Are you sure you want to edit this user? This action cannot be reverted.", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        Address updatedAddress = new Address();
                        Client updatedClient = new Client();
                        try
                        {
                            updatedAddress.streetNumber = Int32.Parse(txtStreetNumber.Text);
                            updatedAddress.streetName = txtStreetName.Text;
                            updatedAddress.cityName = txtCityName.Text;

                            updatedClient.stateID = txtStateID.Text;
                            updatedClient.firstName = txtFirstName.Text;
                            updatedClient.surname = txtSurname.Text;
                            updatedClient.address = updatedAddress;

                            string sql = $"UPDATE Client SET ClientStateID = '{updatedClient.stateID}', ClientFirstName = '{updatedClient.firstName}', ClientSurname = '{updatedClient.surname}' WHERE ClientID = {selectedClient.clientID}";
                            sqlCommands.sqlUpdate(sql);
                            sql = $"UPDATE ClientAddress SET StreetNumber = {updatedAddress.streetNumber}, StreetName = '{updatedAddress.streetName}', CityName = '{updatedAddress.cityName}' WHERE ClientAddressID = '{selectedClient.address.addressID}'";
                            sqlCommands.sqlUpdate(sql);

                            MessageBox.Show("Updated Successfully");

                            disableEditing();
                            refreshDatagrids();
                            populateTextboxes(updatedClient);
                        }
                        catch
                        {
                            MessageBox.Show("Some values are not valid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Values cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }             
            }
            else
            {
                MessageBox.Show("You did not change a thing!", "Why?", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnRefreshClients_Click(object sender, EventArgs e)
        {
            refreshDatagrids();
            txtSearchClient.Clear(); 
            cmbClientColumns.SelectedIndex = -1;
        }

        public void refreshDatagrids()
        {
            dgvClients.DataSource = fillClients().Tables[0].DefaultView;
            dgvAddress.DataSource = fillAddress().Tables[0].DefaultView;
        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            clearDetails();
            enableTXTBoxes();

            string sql = "SELECT TOP 1 ClientID FROM Client ORDER BY ClientID DESC";
            lblClientIDNumber.Text = (Convert.ToInt32(sqlCommands.sqlSelect(sql).Tables[0].Rows[0][0]) + 1).ToString(); // gets client ID + 1
            
            btnCancelAddition.Visible = true;
            btnEditClient.Enabled = false;
            btnConfirmAddition.Visible = true;
            dgvAddress.Enabled = true;
            disableDGV();
            refreshDatagrids();

            isValid = false;
        }

        private void btnDeleteClient_Click(object sender, EventArgs e)
        {
            if (selectedClient != null)
            {
                if (MessageBox.Show($"Are you sure you want to delete {selectedClient.firstName} {selectedClient.surname}? This action cannot be reverted.", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    sqlCommands.sqlDelete($"DELETE FROM Client WHERE ClientID = {selectedClient.clientID}");
                    refreshDatagrids();
                    clearDetails();
                    selectedClient = null;
                    address = null;
                    MessageBox.Show("Delete Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Please select a client first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelAddition_Click(object sender, EventArgs e)
        {
            btnConfirmAddition.Visible = false;
            btnCancelAddition.Visible = false;
            btnEditClient.Enabled = true;
            disableTXTBoxes();
            clearDetails();
            dgvAddress.Enabled = false;
            btnClearAddress.Visible = false;
            enableDGV();
        }

        private void btnConfirmAddition_Click(object sender, EventArgs e)
        {
            btnCancelAddition.Visible = false;
            
            if (isValid)
            {
                string sql = "SELECT TOP 1 ClientAddressID FROM ClientAddress ORDER BY ClientAddressID DESC";

                newAddress.streetName = txtStreetName.Text;
                newAddress.streetNumber = Convert.ToInt32(txtStreetNumber.Text);
                newAddress.cityName = txtCityName.Text;
                
                if (newAddress.addressID == 0)
                {
                    newAddress.addressID = Convert.ToInt32(sqlCommands.sqlSelect(sql).Tables[0].Rows[0][0]) + 1;
                    sqlCommands.sqlInsert($"INSERT INTO ClientAddress (StreetNumber, StreetName, CityName) VALUES ({newAddress.streetNumber}, '{newAddress.streetName}', '{newAddress.cityName}')");
                }
                
                Client newClient = new Client(Convert.ToInt32(lblClientIDNumber.Text), txtStateID.Text, txtFirstName.Text, txtSurname.Text, 0, newAddress);

                sqlCommands.sqlInsert($"INSERT INTO Client (ClientStateID, ClientFirstName, ClientSurname, ClientAddressID, ClientMoneySpent) VALUES ('{newClient.stateID}', '{newClient.firstName}', '{newClient.surname}', {newClient.address.addressID}, {newClient.moneySpent})");
                
                refreshDatagrids();
                MessageBox.Show("Insertion Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnConfirmAddition.Visible = false;
                enableDGV();
                dgvAddress.Enabled = false;
                btnClearAddress.Visible = false;
                disableTXTBoxes();
            }
            else
            {
                MessageBox.Show("Values cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtSearchStreetNum_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchStreetNum.Text != "")
            {
                if (txtSearchStreetName.Text != "")
                {
                    dgvAddress.DataSource = sqlCommands.sqlSelect($"SELECT * FROM ClientAddress WHERE StreetNumber = {txtSearchStreetNum.Text} AND StreetName LIKE '%{txtSearchStreetName.Text}%'").Tables[0].DefaultView;
                }
                else
                {
                    dgvAddress.DataSource = sqlCommands.sqlSelect($"SELECT * FROM ClientAddress WHERE StreetNumber = {txtSearchStreetNum.Text}").Tables[0].DefaultView;
                }
            }
            else
            {
                dgvAddress.DataSource = sqlCommands.sqlSelect("SELECT * FROM ClientAddress").Tables[0].DefaultView;
            }
        }

        private void txtSearchStreetName_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchStreetName.Text != "")
            {
                if (txtSearchStreetNum.Text != "")
                {
                    dgvAddress.DataSource = sqlCommands.sqlSelect($"SELECT * FROM ClientAddress WHERE StreetNumber = {txtSearchStreetNum.Text} AND StreetName LIKE '%{txtSearchStreetName.Text}%'").Tables[0].DefaultView;
                }
                else
                {
                    dgvAddress.DataSource = sqlCommands.sqlSelect($"SELECT * FROM ClientAddress WHERE StreetName LIKE '%{txtSearchStreetName.Text}%'").Tables[0].DefaultView;
                }
            }
            else
            {
                dgvAddress.DataSource = sqlCommands.sqlSelect("SELECT * FROM ClientAddress").Tables[0].DefaultView;
            }
        }

        private void dgvAddress_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int index = dgvAddress.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dgvAddress.Rows[index];
            newAddress = new Address();
            newAddress.addressID = Convert.ToInt32(selectedRow.Cells[0].Value);
            txtStreetNumber.Text = selectedRow.Cells[1].Value.ToString();
            txtStreetName.Text = selectedRow.Cells[2].Value.ToString();
            txtCityName.Text = selectedRow.Cells[3].Value.ToString();
            btnClearAddress.Visible = true;
            disabletxtAddress();

            isValid = false;
        }

        private void btnClearAddress_Click(object sender, EventArgs e)
        {
            btnClearAddress.Visible = false;
            newAddress = new Address();
            txtStreetName.Clear();
            txtStreetNumber.Clear();
            txtCityName.Clear();
            enabletxtAddress();


        }

        public void enabletxtAddress()
        {
            txtStreetName.Enabled = true;
            txtStreetNumber.Enabled = true;
            txtCityName.Enabled = true;
        }

        public void disabletxtAddress()
        {
            txtStreetName.Enabled = false;
            txtStreetNumber.Enabled = false;
            txtCityName.Enabled = false;
        }
    }
}
