using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ian_Inventory_Systeme.Forms
{
    public partial class Inventory : Form
    {
        public Inventory()
        {
            InitializeComponent();
            Refresh();
            StartUp();
        }
        // pede 
        // Database connection
        MySqlConnection connection = new MySqlConnection("server=127.0.0.1;user = Nefarry1;persistsecurityinfo=True;database=iantestinventory; password='aislife22';");

        private void StartUp()
        {
            tbSales.TabPages.Remove(tabPageEdit); // Hides the Edit Button
        }

        // Refreshes the listViewInventory
        private void Refresh()
        {
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM datainventory", connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            listViewInventory.Items.Clear();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];

                ListViewItem itm = new ListViewItem(dr["prodNo"].ToString());
                itm.SubItems.Add(dr["prodItem"].ToString());
                itm.SubItems.Add(dr["prodBrand"].ToString());
                itm.SubItems.Add(dr["prodPrice"].ToString());
                itm.SubItems.Add(dr["prodQuantity"].ToString());
                itm.SubItems.Add(dr["prodDOA"].ToString());
                itm.SubItems.Add(dr["prodEXPD"].ToString());
                listViewInventory.Items.Add(itm);
            }
        }

        // Clears the textbox
        private void FormSalesClear()
        {
            prodAddNo.Text = "";
            prodAddItem.Text = "";
            prodAddBrand.Text = "";
            prodAddPrice.Text = "";
            prodAddQty.Text = "";
            prodAddDOA.Text = "";
            prodAddEXPD.Text = "";
            tbSales.TabPages.Clear();
            tbSales.TabPages.Add(tabPageInventory);
            tbSales.TabPages.Add(tabPageAdd);
        }

        // Add button - adds data inputed by the users from the textbox to database
        private void btnInventoryAdd_Click(object sender, EventArgs e)
        {
            Refresh(); // Refreshes the listview
            string[] arr = new string[7];
            arr[0] = prodAddNo.Text;
            arr[1] = prodAddItem.Text;
            arr[2] = prodAddBrand.Text;
            arr[3] = prodAddPrice.Text;
            arr[4] = prodAddQty.Text;
            arr[5] = prodAddDOA.Text;
            arr[6] = prodAddEXPD.Text;


            // Checks if textbox are empty
            if (prodAddNo.Text == "")
            {
                MessageBox.Show("Please Complete the Form");
            }
            else if (prodAddItem.Text == "")
            {
                MessageBox.Show("Please Complete the Form");
            }
            else if (prodAddQty.Text == "")
            {
                MessageBox.Show("Please Complete the Form");
            }
            else if (prodAddBrand.Text == "")
            {
                MessageBox.Show("Please Complete the Form");
            }
            else if (prodAddPrice.Text == "")
            {
                MessageBox.Show("Please Complete the Form");
            }
            else if (prodAddDOA.Text == "")
            {
                MessageBox.Show("Please Complete the Form");
            }
            else if (prodAddEXPD.Text == "")
            {
                MessageBox.Show("Please Complete the Form");
            }
            else
            {
                // Database connection string
                string constring = "server=127.0.0.1;user = Nefarry1;persistsecurityinfo=True;database=iantestinventory; password='aislife22';";
                // Database command string
                string Query = "INSERT INTO datainventory (prodNo, prodItem, prodBrand, prodPrice, prodQuantity, prodDOA, prodEXPD) VALUES ('" + prodAddNo.Text + "','" + prodAddItem.Text + "', '" + prodAddBrand.Text + "', '" + prodAddPrice.Text + "', '" + prodAddQty.Text + "', '" + prodAddDOA.Text + "', '" + prodAddEXPD.Text + "')";
                MySqlConnection conDataBase = new MySqlConnection(constring); // Create new connection
                MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase); // Fuses the connection and the SQL command
                MySqlDataReader myReader;

                // Adds the data from the windows form to the MySQL database
                try
                {
                    conDataBase.Open(); // Opens the database connection
                    myReader = cmdDataBase.ExecuteReader();
                    MessageBox.Show("Success!");
                    FormSalesClear();
                    while (myReader.Read())
                    {

                    }
                    Refresh(); // Refreshes the listview
                }
                catch (Exception ex) // Error message
                {
                    MessageBox.Show(ex.Message);
                    MessageBox.Show("Item is already in the database");
                    FormSalesClear();
                }
            }
        }

        // Refresh button PS. Tanggalin nato
        private void btnSalesRefresh_Click(object sender, EventArgs e)
        {
            Refresh(); // Refreshes the listview
        }

        // Delete button - deletes data selected from the listview in the database
        private void btnSalesDelete_Click(object sender, EventArgs e)
        {
            try
            {
                for (int j = 0; j <= listViewInventory.Items.Count - 1; j++)
                {
                    string test = listViewInventory.SelectedItems[j].SubItems[1].Text;
                    // Database connection string
                    string MyConnection2 = "server=127.0.0.1;user = Nefarry1;persistsecurityinfo=True;database=iantestinventory; password='aislife22';";
                    // Database command string
                    string Query = "DELETE FROM datainventory where prodItem='" + test + "'";
                    MySqlConnection MyConn2 = new MySqlConnection(MyConnection2); // Create new connection
                    MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2); // Fuses the connection and the SQL command
                    MySqlDataReader MyReader2;
                    MyConn2.Open(); // Opens the database connection
                    MyReader2 = MyCommand2.ExecuteReader();

                    while (MyReader2.Read())
                    {

                    }
                    MyConn2.Close(); // Closes the database connection
                    MessageBox.Show("Data Deleted");
                    Refresh(); // Refreshes the listview
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); // Error message
            }

        }
        
        // Edit button - edits data that is selected from the listview in the database
        private void btnSalesEdit_Click(object sender, EventArgs e)
        {
            tbSales.TabPages.Add(tabPageEdit);
            foreach (int i in listViewInventory.SelectedIndices)
            {
                string test = listViewInventory.Items[i].Text;
                DataTable dt = new DataTable();
                connection.Open();
                MySqlDataReader myReader = null;
                MySqlCommand myCommand = new MySqlCommand("SELECT * FROM datainventory WHERE prodNo= '" + test + "'", connection);
                
                myReader = myCommand.ExecuteReader();

                while (myReader.Read())
                {
                    prodEditNo.Text = (myReader["prodNo"].ToString());
                    prodEditItem.Text = (myReader["prodItem"].ToString());
                    prodEditBrand.Text = (myReader["prodBrand"].ToString());
                    prodEditPrice.Text = (myReader["prodPrice"].ToString());
                    prodEditQty.Text = (myReader["prodQuantity"].ToString());
                }
                connection.Close();
                tbSales.SelectedTab = tabPageEdit;
            }
        }

        private void FormSales_Load(object sender, EventArgs e)
        {

        }

        private void prodAddBrand_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        // Checkout button - this is the button for the POS System
        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            // Checks if there's already an open form
            if (Application.OpenForms["CheckOutForm"] == null)
            {
                new CheckOutForm().Show();
            }
            else
            {
                MessageBox.Show("This window is already open");
                Application.OpenForms["CheckOutForm"].BringToFront();
            }
        }

        private void tbSales_MouseClick(object sender, MouseEventArgs e)
        {
            tbSales.TabPages.Remove(tabPageEdit);
            prodEditNo.Text = "";
            prodEditItem.Text = "";
            prodEditBrand.Text = "";
            prodEditPrice.Text = "";
            prodEditQty.Text = "";
        }

        protected void btnInventoryEdit_Click(object sender, EventArgs e)
        {
            /*
            string query = "UPDATE datainventory SET prodNo = @prodNo, prodItem = @prodItem, prodBrand = @prodBrand, prodPrice = @prodPrice, prodQuantity = @prodQuantity WHERE prodNo = @prodNo";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@prodNo", prodEditNo.Text);
            cmd.Parameters.AddWithValue("@prodItem", prodEditItem.Text);
            cmd.Parameters.AddWithValue("@prodBrand", prodEditBrand.Text);
            cmd.Parameters.AddWithValue("@prodPrice", prodEditPrice.Text);
            cmd.Parameters.AddWithValue("@prodQuantity", prodEditQty.Text);
            cmd.Connection.Open();
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Updated Successfuly!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            */
            using (MySqlConnection sqlConn = new MySqlConnection("server=127.0.0.1;user = Nefarry1;persistsecurityinfo=True;database=iantestinventory; password='aislife22';"))
            {
                string query = "UPDATE datainventory SET prodNo = @No,prodItem = @Item,prodBrand = @Brand, prodPrice = @Price,prodQuantity = @Qty where prodNo = @No ";
                MySqlCommand cmd = new MySqlCommand(query, sqlConn);
                cmd.Parameters.AddWithValue("@No",prodEditNo.Text);
                cmd.Parameters.AddWithValue("@Item", prodEditItem.Text);
                cmd.Parameters.AddWithValue("@Brand", prodEditBrand.Text);
                cmd.Parameters.AddWithValue("@Price", prodEditPrice.Text);
                cmd.Parameters.AddWithValue("@Qty", prodEditQty.Text);
                cmd.Connection.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data Updated");
                    prodEditNo.Text = "";
                    prodEditItem.Text = "";
                    prodEditBrand.Text = "";
                    prodEditPrice.Text = "";
                    prodEditQty.Text = "";
                    Refresh();
                    tbSales.SelectedTab = tabPageEdit;
                    tbSales.TabPages.Remove(tabPageEdit);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
