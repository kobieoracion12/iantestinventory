namespace Ian_Inventory_Systeme.Forms
{
    partial class Inventory
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inventory));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.btnSalesEdit = new System.Windows.Forms.Button();
            this.btnSalesDelete = new System.Windows.Forms.Button();
            this.btnSalesRefresh = new System.Windows.Forms.Button();
            this.tbSales = new System.Windows.Forms.TabControl();
            this.tabPageInventory = new System.Windows.Forms.TabPage();
            this.listViewInventory = new System.Windows.Forms.ListView();
            this.columnProNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnItems = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnBranding = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnQty = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDateOA = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnEXPD = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPageAdd = new System.Windows.Forms.TabPage();
            this.label17 = new System.Windows.Forms.Label();
            this.prodAddPrice = new System.Windows.Forms.TextBox();
            this.prodAddBrand = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.prodAddEXPD = new System.Windows.Forms.MaskedTextBox();
            this.prodAddDOA = new System.Windows.Forms.MaskedTextBox();
            this.btn_abCancel = new System.Windows.Forms.Button();
            this.btnInventoryAdd = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.prodAddQty = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.prodAddItem = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.prodAddNo = new System.Windows.Forms.TextBox();
            this.tabPageEdit = new System.Windows.Forms.TabPage();
            this.label18 = new System.Windows.Forms.Label();
            this.prodEditPrice = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.prodEditQty = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.prodEditBrand = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.prodEditItem = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.prodEditNo = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnInventoryEdit = new System.Windows.Forms.Button();
            this.iantestinventoryDataSet = new Ian_Inventory_Systeme.iantestinventoryDataSet();
            this.iantestinventoryDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.datainventoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.datainventoryTableAdapter = new Ian_Inventory_Systeme.iantestinventoryDataSetTableAdapters.datainventoryTableAdapter();
            this.panel1.SuspendLayout();
            this.tbSales.SuspendLayout();
            this.tabPageInventory.SuspendLayout();
            this.tabPageAdd.SuspendLayout();
            this.tabPageEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iantestinventoryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iantestinventoryDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datainventoryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.btnCheckOut);
            this.panel1.Controls.Add(this.btnSalesEdit);
            this.panel1.Controls.Add(this.btnSalesDelete);
            this.panel1.Controls.Add(this.btnSalesRefresh);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1142, 74);
            this.panel1.TabIndex = 0;
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(159)))), ((int)(((byte)(107)))));
            this.btnCheckOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckOut.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckOut.ForeColor = System.Drawing.Color.White;
            this.btnCheckOut.Image = ((System.Drawing.Image)(resources.GetObject("btnCheckOut.Image")));
            this.btnCheckOut.Location = new System.Drawing.Point(29, 17);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(122, 40);
            this.btnCheckOut.TabIndex = 59;
            this.btnCheckOut.Text = "Check Out";
            this.btnCheckOut.UseVisualStyleBackColor = true;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // btnSalesEdit
            // 
            this.btnSalesEdit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(159)))), ((int)(((byte)(107)))));
            this.btnSalesEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalesEdit.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalesEdit.ForeColor = System.Drawing.Color.White;
            this.btnSalesEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnSalesEdit.Image")));
            this.btnSalesEdit.Location = new System.Drawing.Point(851, 17);
            this.btnSalesEdit.Name = "btnSalesEdit";
            this.btnSalesEdit.Size = new System.Drawing.Size(122, 40);
            this.btnSalesEdit.TabIndex = 58;
            this.btnSalesEdit.Text = "Edit";
            this.btnSalesEdit.UseVisualStyleBackColor = true;
            this.btnSalesEdit.Click += new System.EventHandler(this.btnSalesEdit_Click);
            // 
            // btnSalesDelete
            // 
            this.btnSalesDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(99)))), ((int)(((byte)(79)))));
            this.btnSalesDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalesDelete.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalesDelete.ForeColor = System.Drawing.Color.White;
            this.btnSalesDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnSalesDelete.Image")));
            this.btnSalesDelete.Location = new System.Drawing.Point(979, 17);
            this.btnSalesDelete.Name = "btnSalesDelete";
            this.btnSalesDelete.Size = new System.Drawing.Size(122, 40);
            this.btnSalesDelete.TabIndex = 57;
            this.btnSalesDelete.Text = "Delete";
            this.btnSalesDelete.UseVisualStyleBackColor = true;
            this.btnSalesDelete.Click += new System.EventHandler(this.btnSalesDelete_Click);
            // 
            // btnSalesRefresh
            // 
            this.btnSalesRefresh.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(159)))), ((int)(((byte)(107)))));
            this.btnSalesRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalesRefresh.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalesRefresh.ForeColor = System.Drawing.Color.White;
            this.btnSalesRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnSalesRefresh.Image")));
            this.btnSalesRefresh.Location = new System.Drawing.Point(723, 17);
            this.btnSalesRefresh.Name = "btnSalesRefresh";
            this.btnSalesRefresh.Size = new System.Drawing.Size(122, 40);
            this.btnSalesRefresh.TabIndex = 56;
            this.btnSalesRefresh.Text = "Refresh";
            this.btnSalesRefresh.UseVisualStyleBackColor = true;
            this.btnSalesRefresh.Click += new System.EventHandler(this.btnSalesRefresh_Click);
            // 
            // tbSales
            // 
            this.tbSales.Controls.Add(this.tabPageInventory);
            this.tbSales.Controls.Add(this.tabPageAdd);
            this.tbSales.Controls.Add(this.tabPageEdit);
            this.tbSales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbSales.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSales.ItemSize = new System.Drawing.Size(300, 30);
            this.tbSales.Location = new System.Drawing.Point(0, 74);
            this.tbSales.Name = "tbSales";
            this.tbSales.Padding = new System.Drawing.Point(50, 3);
            this.tbSales.SelectedIndex = 0;
            this.tbSales.Size = new System.Drawing.Size(1142, 681);
            this.tbSales.TabIndex = 0;
            this.tbSales.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tbSales_MouseClick);
            // 
            // tabPageInventory
            // 
            this.tabPageInventory.Controls.Add(this.listViewInventory);
            this.tabPageInventory.Location = new System.Drawing.Point(4, 34);
            this.tabPageInventory.Name = "tabPageInventory";
            this.tabPageInventory.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageInventory.Size = new System.Drawing.Size(1134, 643);
            this.tabPageInventory.TabIndex = 0;
            this.tabPageInventory.Text = "Inventory";
            this.tabPageInventory.UseVisualStyleBackColor = true;
            // 
            // listViewInventory
            // 
            this.listViewInventory.AllowColumnReorder = true;
            this.listViewInventory.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnProNo,
            this.columnItems,
            this.columnBranding,
            this.columnPrice,
            this.columnQty,
            this.columnDateOA,
            this.columnEXPD});
            this.listViewInventory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewInventory.FullRowSelect = true;
            this.listViewInventory.GridLines = true;
            this.listViewInventory.Location = new System.Drawing.Point(3, 3);
            this.listViewInventory.Name = "listViewInventory";
            this.listViewInventory.Size = new System.Drawing.Size(1128, 637);
            this.listViewInventory.TabIndex = 0;
            this.listViewInventory.UseCompatibleStateImageBehavior = false;
            this.listViewInventory.View = System.Windows.Forms.View.Details;
            // 
            // columnProNo
            // 
            this.columnProNo.Text = "Product #";
            this.columnProNo.Width = 101;
            // 
            // columnItems
            // 
            this.columnItems.Text = "Item";
            this.columnItems.Width = 238;
            // 
            // columnBranding
            // 
            this.columnBranding.Text = "Brand";
            this.columnBranding.Width = 260;
            // 
            // columnPrice
            // 
            this.columnPrice.Text = "Price";
            this.columnPrice.Width = 95;
            // 
            // columnQty
            // 
            this.columnQty.Text = "Quantity";
            this.columnQty.Width = 63;
            // 
            // columnDateOA
            // 
            this.columnDateOA.Text = "Date of Arrival";
            this.columnDateOA.Width = 195;
            // 
            // columnEXPD
            // 
            this.columnEXPD.Text = "Expiration Date";
            this.columnEXPD.Width = 205;
            // 
            // tabPageAdd
            // 
            this.tabPageAdd.Controls.Add(this.label17);
            this.tabPageAdd.Controls.Add(this.prodAddPrice);
            this.tabPageAdd.Controls.Add(this.prodAddBrand);
            this.tabPageAdd.Controls.Add(this.label8);
            this.tabPageAdd.Controls.Add(this.label7);
            this.tabPageAdd.Controls.Add(this.prodAddEXPD);
            this.tabPageAdd.Controls.Add(this.prodAddDOA);
            this.tabPageAdd.Controls.Add(this.btn_abCancel);
            this.tabPageAdd.Controls.Add(this.btnInventoryAdd);
            this.tabPageAdd.Controls.Add(this.label5);
            this.tabPageAdd.Controls.Add(this.label6);
            this.tabPageAdd.Controls.Add(this.label4);
            this.tabPageAdd.Controls.Add(this.label2);
            this.tabPageAdd.Controls.Add(this.prodAddQty);
            this.tabPageAdd.Controls.Add(this.label1);
            this.tabPageAdd.Controls.Add(this.prodAddItem);
            this.tabPageAdd.Controls.Add(this.label3);
            this.tabPageAdd.Controls.Add(this.prodAddNo);
            this.tabPageAdd.Location = new System.Drawing.Point(4, 34);
            this.tabPageAdd.Name = "tabPageAdd";
            this.tabPageAdd.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAdd.Size = new System.Drawing.Size(1134, 643);
            this.tabPageAdd.TabIndex = 1;
            this.tabPageAdd.Text = "Add Item";
            this.tabPageAdd.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold);
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(120)))), ((int)(((byte)(115)))));
            this.label17.Location = new System.Drawing.Point(267, 268);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(54, 21);
            this.label17.TabIndex = 60;
            this.label17.Text = "PRICE";
            // 
            // prodAddPrice
            // 
            this.prodAddPrice.AcceptsReturn = true;
            this.prodAddPrice.BackColor = System.Drawing.Color.White;
            this.prodAddPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prodAddPrice.Location = new System.Drawing.Point(499, 256);
            this.prodAddPrice.Multiline = true;
            this.prodAddPrice.Name = "prodAddPrice";
            this.prodAddPrice.Size = new System.Drawing.Size(335, 33);
            this.prodAddPrice.TabIndex = 59;
            // 
            // prodAddBrand
            // 
            this.prodAddBrand.AcceptsReturn = true;
            this.prodAddBrand.BackColor = System.Drawing.Color.White;
            this.prodAddBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prodAddBrand.Location = new System.Drawing.Point(499, 212);
            this.prodAddBrand.Multiline = true;
            this.prodAddBrand.Name = "prodAddBrand";
            this.prodAddBrand.Size = new System.Drawing.Size(335, 33);
            this.prodAddBrand.TabIndex = 58;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(120)))), ((int)(((byte)(115)))));
            this.label8.Location = new System.Drawing.Point(508, 437);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 14);
            this.label8.TabIndex = 57;
            this.label8.Text = "YYYY/MM/DD";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(120)))), ((int)(((byte)(115)))));
            this.label7.Location = new System.Drawing.Point(508, 382);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 14);
            this.label7.TabIndex = 56;
            this.label7.Text = "YYYY/MM/DD";
            // 
            // prodAddEXPD
            // 
            this.prodAddEXPD.AllowDrop = true;
            this.prodAddEXPD.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.prodAddEXPD.Location = new System.Drawing.Point(499, 405);
            this.prodAddEXPD.Mask = "0000/00/00";
            this.prodAddEXPD.Name = "prodAddEXPD";
            this.prodAddEXPD.Size = new System.Drawing.Size(335, 29);
            this.prodAddEXPD.TabIndex = 55;
            // 
            // prodAddDOA
            // 
            this.prodAddDOA.AllowDrop = true;
            this.prodAddDOA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.prodAddDOA.Location = new System.Drawing.Point(499, 350);
            this.prodAddDOA.Mask = "0000/00/00";
            this.prodAddDOA.Name = "prodAddDOA";
            this.prodAddDOA.Size = new System.Drawing.Size(335, 29);
            this.prodAddDOA.TabIndex = 54;
            // 
            // btn_abCancel
            // 
            this.btn_abCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(99)))), ((int)(((byte)(79)))));
            this.btn_abCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_abCancel.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_abCancel.ForeColor = System.Drawing.Color.White;
            this.btn_abCancel.Image = ((System.Drawing.Image)(resources.GetObject("btn_abCancel.Image")));
            this.btn_abCancel.Location = new System.Drawing.Point(564, 494);
            this.btn_abCancel.Name = "btn_abCancel";
            this.btn_abCancel.Size = new System.Drawing.Size(122, 40);
            this.btn_abCancel.TabIndex = 53;
            this.btn_abCancel.Text = "Cancel";
            this.btn_abCancel.UseVisualStyleBackColor = true;
            // 
            // btnInventoryAdd
            // 
            this.btnInventoryAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(159)))), ((int)(((byte)(107)))));
            this.btnInventoryAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventoryAdd.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventoryAdd.ForeColor = System.Drawing.Color.White;
            this.btnInventoryAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnInventoryAdd.Image")));
            this.btnInventoryAdd.Location = new System.Drawing.Point(436, 494);
            this.btnInventoryAdd.Name = "btnInventoryAdd";
            this.btnInventoryAdd.Size = new System.Drawing.Size(122, 40);
            this.btnInventoryAdd.TabIndex = 52;
            this.btnInventoryAdd.Text = "Add";
            this.btnInventoryAdd.UseVisualStyleBackColor = true;
            this.btnInventoryAdd.Click += new System.EventHandler(this.btnInventoryAdd_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(120)))), ((int)(((byte)(115)))));
            this.label5.Location = new System.Drawing.Point(267, 359);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 21);
            this.label5.TabIndex = 24;
            this.label5.Text = "DATE OF ARRIVAL";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(120)))), ((int)(((byte)(115)))));
            this.label6.Location = new System.Drawing.Point(267, 412);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 21);
            this.label6.TabIndex = 22;
            this.label6.Text = "EXPIRATION DATE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(120)))), ((int)(((byte)(115)))));
            this.label4.Location = new System.Drawing.Point(267, 315);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 21);
            this.label4.TabIndex = 18;
            this.label4.Text = "QUANTITY";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(120)))), ((int)(((byte)(115)))));
            this.label2.Location = new System.Drawing.Point(267, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 21);
            this.label2.TabIndex = 16;
            this.label2.Text = "PRODUCT BRAND";
            // 
            // prodAddQty
            // 
            this.prodAddQty.AcceptsReturn = true;
            this.prodAddQty.BackColor = System.Drawing.Color.White;
            this.prodAddQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prodAddQty.Location = new System.Drawing.Point(499, 303);
            this.prodAddQty.Multiline = true;
            this.prodAddQty.Name = "prodAddQty";
            this.prodAddQty.Size = new System.Drawing.Size(335, 33);
            this.prodAddQty.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(120)))), ((int)(((byte)(115)))));
            this.label1.Location = new System.Drawing.Point(267, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 21);
            this.label1.TabIndex = 14;
            this.label1.Text = "PRODUCT NAME";
            // 
            // prodAddItem
            // 
            this.prodAddItem.AcceptsReturn = true;
            this.prodAddItem.AllowDrop = true;
            this.prodAddItem.BackColor = System.Drawing.Color.White;
            this.prodAddItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prodAddItem.Location = new System.Drawing.Point(499, 165);
            this.prodAddItem.Multiline = true;
            this.prodAddItem.Name = "prodAddItem";
            this.prodAddItem.Size = new System.Drawing.Size(335, 33);
            this.prodAddItem.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(120)))), ((int)(((byte)(115)))));
            this.label3.Location = new System.Drawing.Point(267, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 21);
            this.label3.TabIndex = 12;
            this.label3.Text = "PRODUCT #";
            // 
            // prodAddNo
            // 
            this.prodAddNo.AcceptsReturn = true;
            this.prodAddNo.BackColor = System.Drawing.Color.White;
            this.prodAddNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prodAddNo.Location = new System.Drawing.Point(499, 113);
            this.prodAddNo.Multiline = true;
            this.prodAddNo.Name = "prodAddNo";
            this.prodAddNo.Size = new System.Drawing.Size(335, 33);
            this.prodAddNo.TabIndex = 0;
            // 
            // tabPageEdit
            // 
            this.tabPageEdit.Controls.Add(this.label18);
            this.tabPageEdit.Controls.Add(this.prodEditPrice);
            this.tabPageEdit.Controls.Add(this.label13);
            this.tabPageEdit.Controls.Add(this.prodEditQty);
            this.tabPageEdit.Controls.Add(this.label14);
            this.tabPageEdit.Controls.Add(this.prodEditBrand);
            this.tabPageEdit.Controls.Add(this.label15);
            this.tabPageEdit.Controls.Add(this.prodEditItem);
            this.tabPageEdit.Controls.Add(this.label16);
            this.tabPageEdit.Controls.Add(this.prodEditNo);
            this.tabPageEdit.Controls.Add(this.button1);
            this.tabPageEdit.Controls.Add(this.btnInventoryEdit);
            this.tabPageEdit.Location = new System.Drawing.Point(4, 34);
            this.tabPageEdit.Name = "tabPageEdit";
            this.tabPageEdit.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEdit.Size = new System.Drawing.Size(1134, 643);
            this.tabPageEdit.TabIndex = 2;
            this.tabPageEdit.Text = "Edit";
            this.tabPageEdit.UseVisualStyleBackColor = true;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold);
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(120)))), ((int)(((byte)(115)))));
            this.label18.Location = new System.Drawing.Point(274, 305);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(54, 21);
            this.label18.TabIndex = 75;
            this.label18.Text = "PRICE";
            // 
            // prodEditPrice
            // 
            this.prodEditPrice.AcceptsReturn = true;
            this.prodEditPrice.BackColor = System.Drawing.Color.White;
            this.prodEditPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prodEditPrice.Location = new System.Drawing.Point(506, 295);
            this.prodEditPrice.Multiline = true;
            this.prodEditPrice.Name = "prodEditPrice";
            this.prodEditPrice.Size = new System.Drawing.Size(335, 33);
            this.prodEditPrice.TabIndex = 74;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(120)))), ((int)(((byte)(115)))));
            this.label13.Location = new System.Drawing.Point(274, 349);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(91, 21);
            this.label13.TabIndex = 65;
            this.label13.Text = "QUANTITY";
            // 
            // prodEditQty
            // 
            this.prodEditQty.BackColor = System.Drawing.Color.White;
            this.prodEditQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prodEditQty.Location = new System.Drawing.Point(506, 337);
            this.prodEditQty.Multiline = true;
            this.prodEditQty.Name = "prodEditQty";
            this.prodEditQty.Size = new System.Drawing.Size(335, 33);
            this.prodEditQty.TabIndex = 64;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold);
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(120)))), ((int)(((byte)(115)))));
            this.label14.Location = new System.Drawing.Point(274, 263);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(145, 21);
            this.label14.TabIndex = 63;
            this.label14.Text = "PRODUCT BRAND";
            // 
            // prodEditBrand
            // 
            this.prodEditBrand.BackColor = System.Drawing.Color.White;
            this.prodEditBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prodEditBrand.Location = new System.Drawing.Point(506, 251);
            this.prodEditBrand.Multiline = true;
            this.prodEditBrand.Name = "prodEditBrand";
            this.prodEditBrand.Size = new System.Drawing.Size(335, 33);
            this.prodEditBrand.TabIndex = 62;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold);
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(120)))), ((int)(((byte)(115)))));
            this.label15.Location = new System.Drawing.Point(274, 215);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(137, 21);
            this.label15.TabIndex = 61;
            this.label15.Text = "PRODUCT NAME";
            // 
            // prodEditItem
            // 
            this.prodEditItem.BackColor = System.Drawing.Color.White;
            this.prodEditItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prodEditItem.Location = new System.Drawing.Point(506, 204);
            this.prodEditItem.Multiline = true;
            this.prodEditItem.Name = "prodEditItem";
            this.prodEditItem.Size = new System.Drawing.Size(335, 33);
            this.prodEditItem.TabIndex = 60;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold);
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(120)))), ((int)(((byte)(115)))));
            this.label16.Location = new System.Drawing.Point(274, 163);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(98, 21);
            this.label16.TabIndex = 59;
            this.label16.Text = "PRODUCT #";
            // 
            // prodEditNo
            // 
            this.prodEditNo.BackColor = System.Drawing.Color.White;
            this.prodEditNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prodEditNo.Location = new System.Drawing.Point(506, 152);
            this.prodEditNo.Multiline = true;
            this.prodEditNo.Name = "prodEditNo";
            this.prodEditNo.Size = new System.Drawing.Size(335, 33);
            this.prodEditNo.TabIndex = 58;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(99)))), ((int)(((byte)(79)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(568, 421);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 40);
            this.button1.TabIndex = 69;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnInventoryEdit
            // 
            this.btnInventoryEdit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(159)))), ((int)(((byte)(107)))));
            this.btnInventoryEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventoryEdit.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventoryEdit.ForeColor = System.Drawing.Color.White;
            this.btnInventoryEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnInventoryEdit.Image")));
            this.btnInventoryEdit.Location = new System.Drawing.Point(440, 421);
            this.btnInventoryEdit.Name = "btnInventoryEdit";
            this.btnInventoryEdit.Size = new System.Drawing.Size(122, 40);
            this.btnInventoryEdit.TabIndex = 68;
            this.btnInventoryEdit.Text = "Edit";
            this.btnInventoryEdit.UseVisualStyleBackColor = true;
            this.btnInventoryEdit.Click += new System.EventHandler(this.btnInventoryEdit_Click);
            // 
            // iantestinventoryDataSet
            // 
            this.iantestinventoryDataSet.DataSetName = "iantestinventoryDataSet";
            this.iantestinventoryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // iantestinventoryDataSetBindingSource
            // 
            this.iantestinventoryDataSetBindingSource.DataSource = this.iantestinventoryDataSet;
            this.iantestinventoryDataSetBindingSource.Position = 0;
            // 
            // datainventoryBindingSource
            // 
            this.datainventoryBindingSource.DataMember = "datainventory";
            this.datainventoryBindingSource.DataSource = this.iantestinventoryDataSetBindingSource;
            // 
            // datainventoryTableAdapter
            // 
            this.datainventoryTableAdapter.ClearBeforeFill = true;
            // 
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1142, 755);
            this.Controls.Add(this.tbSales);
            this.Controls.Add(this.panel1);
            this.Name = "Inventory";
            this.Text = "FormSales";
            this.Load += new System.EventHandler(this.FormSales_Load);
            this.panel1.ResumeLayout(false);
            this.tbSales.ResumeLayout(false);
            this.tabPageInventory.ResumeLayout(false);
            this.tabPageAdd.ResumeLayout(false);
            this.tabPageAdd.PerformLayout();
            this.tabPageEdit.ResumeLayout(false);
            this.tabPageEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iantestinventoryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iantestinventoryDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datainventoryBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tbSales;
        private System.Windows.Forms.TabPage tabPageInventory;
        private System.Windows.Forms.ListView listViewInventory;
        private System.Windows.Forms.ColumnHeader columnProNo;
        private System.Windows.Forms.ColumnHeader columnItems;
        private System.Windows.Forms.ColumnHeader columnBranding;
        private System.Windows.Forms.ColumnHeader columnQty;
        private System.Windows.Forms.ColumnHeader columnDateOA;
        private System.Windows.Forms.ColumnHeader columnEXPD;
        private System.Windows.Forms.TabPage tabPageAdd;
        private System.Windows.Forms.TextBox prodAddNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox prodAddItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox prodAddDOA;
        private System.Windows.Forms.Button btn_abCancel;
        private System.Windows.Forms.Button btnInventoryAdd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSalesDelete;
        private System.Windows.Forms.Button btnSalesRefresh;
        private System.Windows.Forms.MaskedTextBox prodAddEXPD;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSalesEdit;
        private System.Windows.Forms.TabPage tabPageEdit;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnInventoryEdit;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox prodEditQty;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox prodEditBrand;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox prodEditItem;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox prodEditNo;
        private System.Windows.Forms.TextBox prodAddQty;
        private System.Windows.Forms.TextBox prodAddBrand;
        private System.Windows.Forms.BindingSource iantestinventoryDataSetBindingSource;
        private iantestinventoryDataSet iantestinventoryDataSet;
        private System.Windows.Forms.BindingSource datainventoryBindingSource;
        private iantestinventoryDataSetTableAdapters.datainventoryTableAdapter datainventoryTableAdapter;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.ColumnHeader columnPrice;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox prodAddPrice;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox prodEditPrice;
    }
}