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
    public partial class FormStocks : Form
    {
        public FormStocks()
        {
            InitializeComponent();
            Startup();
        }

        MySqlConnection connection = new MySqlConnection("server=127.0.0.1;user id=ianinventory;persistsecurityinfo=True;database=iantestinventory; password='kobieoracion123';");

        private void Startup()
        {
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM datasalesinventory", connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            listViewSales.Items.Clear();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];

                ListViewItem itm = new ListViewItem(dr["refNo"].ToString());
                itm.SubItems.Add(dr["salesNo"].ToString());
                itm.SubItems.Add(dr["salesItem"].ToString());
                itm.SubItems.Add(dr["salesDate"].ToString());
                itm.SubItems.Add(dr["salesPrice"].ToString());
                itm.SubItems.Add(dr["salesQty"].ToString());
                itm.SubItems.Add(dr["salesTotal"].ToString());
                listViewSales.Items.Add(itm);
            }
        }
    }
}
