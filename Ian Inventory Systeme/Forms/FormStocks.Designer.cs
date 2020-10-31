namespace Ian_Inventory_Systeme.Forms
{
    partial class FormStocks
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbSales = new System.Windows.Forms.TabControl();
            this.tabPageSales = new System.Windows.Forms.TabPage();
            this.listViewSales = new System.Windows.Forms.ListView();
            this.salesRefNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.salesNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.salesItem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.salesDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.salesPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.salesQty = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.salesTotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel2.SuspendLayout();
            this.tbSales.SuspendLayout();
            this.tabPageSales.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1142, 74);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MintCream;
            this.panel2.Controls.Add(this.tbSales);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 74);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1142, 681);
            this.panel2.TabIndex = 1;
            // 
            // tbSales
            // 
            this.tbSales.Controls.Add(this.tabPageSales);
            this.tbSales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbSales.ItemSize = new System.Drawing.Size(300, 30);
            this.tbSales.Location = new System.Drawing.Point(0, 0);
            this.tbSales.Name = "tbSales";
            this.tbSales.Padding = new System.Drawing.Point(50, 3);
            this.tbSales.SelectedIndex = 0;
            this.tbSales.Size = new System.Drawing.Size(1142, 681);
            this.tbSales.TabIndex = 0;
            // 
            // tabPageSales
            // 
            this.tabPageSales.Controls.Add(this.listViewSales);
            this.tabPageSales.Location = new System.Drawing.Point(4, 34);
            this.tabPageSales.Name = "tabPageSales";
            this.tabPageSales.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSales.Size = new System.Drawing.Size(1134, 643);
            this.tabPageSales.TabIndex = 0;
            this.tabPageSales.Text = "Sales";
            this.tabPageSales.UseVisualStyleBackColor = true;
            // 
            // listViewSales
            // 
            this.listViewSales.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.salesRefNo,
            this.salesNo,
            this.salesItem,
            this.salesDate,
            this.salesPrice,
            this.salesQty,
            this.salesTotal});
            this.listViewSales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewSales.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.listViewSales.GridLines = true;
            this.listViewSales.Location = new System.Drawing.Point(3, 3);
            this.listViewSales.Name = "listViewSales";
            this.listViewSales.Size = new System.Drawing.Size(1128, 637);
            this.listViewSales.TabIndex = 1;
            this.listViewSales.UseCompatibleStateImageBehavior = false;
            this.listViewSales.View = System.Windows.Forms.View.Details;
            // 
            // salesRefNo
            // 
            this.salesRefNo.Text = "Ref #";
            this.salesRefNo.Width = 131;
            // 
            // salesNo
            // 
            this.salesNo.Text = "Product No";
            this.salesNo.Width = 153;
            // 
            // salesItem
            // 
            this.salesItem.Text = "Item";
            this.salesItem.Width = 301;
            // 
            // salesDate
            // 
            this.salesDate.Text = "Date of Purchase";
            this.salesDate.Width = 155;
            // 
            // salesPrice
            // 
            this.salesPrice.Text = "Price";
            this.salesPrice.Width = 122;
            // 
            // salesQty
            // 
            this.salesQty.Text = "Quantity";
            this.salesQty.Width = 72;
            // 
            // salesTotal
            // 
            this.salesTotal.Text = "Total";
            this.salesTotal.Width = 204;
            // 
            // FormStocks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(1142, 755);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormStocks";
            this.Text = "FormStocks";
            this.panel2.ResumeLayout(false);
            this.tbSales.ResumeLayout(false);
            this.tabPageSales.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TabControl tbSales;
        private System.Windows.Forms.TabPage tabPageSales;
        private System.Windows.Forms.ListView listViewSales;
        private System.Windows.Forms.ColumnHeader salesRefNo;
        private System.Windows.Forms.ColumnHeader salesNo;
        private System.Windows.Forms.ColumnHeader salesItem;
        private System.Windows.Forms.ColumnHeader salesDate;
        private System.Windows.Forms.ColumnHeader salesPrice;
        private System.Windows.Forms.ColumnHeader salesQty;
        private System.Windows.Forms.ColumnHeader salesTotal;
    }
}