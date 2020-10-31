using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ian_Inventory_Systeme
{
    public partial class Form1 : Form
    {
        private Form activeform;

        public Form1()
        {
            InitializeComponent();
        }

        public void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeform != null)
            {
                activeform.Close();
            }
            activeform = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.pnlSales.Controls.Add(childForm);
            this.pnlSales.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormDashboard(), sender);
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormStocks(), sender);
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Inventory(), sender);
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Inventory(), sender);
        }
    }
}
