using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Ian_Inventory_Systeme.Forms
{
    public partial class CheckOutForm : Form
    {
        public CheckOutForm()
        {
            InitializeComponent();
        }

        // Open connection for database
        MySqlConnection connection = new MySqlConnection("server=127.0.0.1;user id=ianinventory;persistsecurityinfo=True;database=iantestinventory; password='kobieoracion123';");

        // Selecting data from database and displaying to listViewReceipt (Check Out)
        private void Startup()
        {
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM datasalesinventory ORDER BY salesDate DESC", connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            listViewReceipt.Items.Clear();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];

                ListViewItem itm = new ListViewItem(dr["refNo"].ToString());
                itm.SubItems.Add(dr["salesItem"].ToString());
                itm.SubItems.Add(dr["salesPrice"].ToString());
                itm.SubItems.Add(dr["salesQty"].ToString());
                itm.SubItems.Add(dr["salesTotal"].ToString());
                listViewReceipt.Items.Add(itm);
            }
        }

        private void CheckOutForm_Load(object sender, EventArgs e)
        {
            cofProdNo.Focus(); // Not working - this function is to focus on the cofProdNo textbox when opened
        }

        // [BUG] The user must be able to change the quantity of the the item before adding it to the listViewReceipt
        // Automatically multiply the price and quantity and display on the cofTotal textbox
        private void cofProdQty_TextChanged(object sender, EventArgs e)
        {
            if (cofProdQty.Text.Length > 0)
            {
                string quantity = cofProdQty.Text;

                int price = Convert.ToInt32(cofProdPrice.Text);
                int qty = Convert.ToInt32(quantity);
                int total = price * qty;

                cofTotal.Text = total.ToString();
            }
        }


        //Automatically shows the other data after changing the cofProdNo.
        private void cofProdNo_TextChanged(object sender, EventArgs e)
        {
            if (cofProdNo.Text.Length > 0)
            {
                string search = cofProdNo.Text;

                DataTable dt = new DataTable();
                connection.Open();
                MySqlDataReader myReader = null;
                MySqlCommand myCommand = new MySqlCommand("SELECT * FROM datainventory WHERE prodNo= '" + search + "'", connection);

                myReader = myCommand.ExecuteReader();

                while (myReader.Read())
                {
                    cofProdItem.Text = (myReader["prodItem"].ToString());
                    cofProdBrand.Text = (myReader["prodBrand"].ToString());
                    cofProdPrice.Text = (myReader["prodPrice"].ToString());
                    cofProdQty.Text = (myReader["prodQuantity"].ToString());
                }
                connection.Close();

                cofProdQty.Focus();

                /*
                // [BUG] This code automatically send the data to the listViewReceipt without confirming the user's input on the quantity textbox.
                listViewReceipt.Items.Add("");
                listViewReceipt.Items[listViewReceipt.Items.Count - 1].SubItems.Add(cofProdItem.Text);
                listViewReceipt.Items[listViewReceipt.Items.Count - 1].SubItems.Add(cofProdPrice.Text);
                listViewReceipt.Items[listViewReceipt.Items.Count - 1].SubItems.Add(cofProdQty.Text);

                cofProdNo.Clear();
                cofProdItem.Clear();
                cofProdBrand.Clear();
                cofProdPrice.Clear();
                cofProdQty.Clear();
                cofTotal.Clear();
                cofProdNo.Focus();
                */
            }
        }
    }
}
