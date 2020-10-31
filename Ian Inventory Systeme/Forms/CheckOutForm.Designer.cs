namespace Ian_Inventory_Systeme.Forms
{
    partial class CheckOutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckOutForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.listViewReceipt = new System.Windows.Forms.ListView();
            this.rcptNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.rcptItem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.rcptPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.rcptQty = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel2 = new System.Windows.Forms.Panel();
            this.cofPrice = new System.Windows.Forms.Panel();
            this.btnNewRcpt = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSalesRefresh = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.cofTotal = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cofProdQty = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cofProdPrice = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cofProdBrand = new System.Windows.Forms.TextBox();
            this.cofProdItem = new System.Windows.Forms.TextBox();
            this.cofProdNo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.prodAddNo = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.cofTotalAll = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.cofPrice.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Controls.Add(this.listViewReceipt);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(328, 631);
            this.panel1.TabIndex = 0;
            // 
            // listViewReceipt
            // 
            this.listViewReceipt.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.rcptNo,
            this.rcptItem,
            this.rcptPrice,
            this.rcptQty});
            this.listViewReceipt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewReceipt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewReceipt.Location = new System.Drawing.Point(0, 0);
            this.listViewReceipt.Name = "listViewReceipt";
            this.listViewReceipt.Size = new System.Drawing.Size(328, 631);
            this.listViewReceipt.TabIndex = 0;
            this.listViewReceipt.UseCompatibleStateImageBehavior = false;
            this.listViewReceipt.View = System.Windows.Forms.View.Details;
            // 
            // rcptNo
            // 
            this.rcptNo.Text = "#";
            this.rcptNo.Width = 30;
            // 
            // rcptItem
            // 
            this.rcptItem.Text = "Item";
            this.rcptItem.Width = 174;
            // 
            // rcptPrice
            // 
            this.rcptPrice.Text = "Price";
            this.rcptPrice.Width = 81;
            // 
            // rcptQty
            // 
            this.rcptQty.Text = "Qty";
            this.rcptQty.Width = 309;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Controls.Add(this.cofPrice);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.textBox4);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.textBox3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.prodAddNo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(328, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(692, 631);
            this.panel2.TabIndex = 1;
            // 
            // cofPrice
            // 
            this.cofPrice.BackColor = System.Drawing.Color.Gainsboro;
            this.cofPrice.Controls.Add(this.cofTotalAll);
            this.cofPrice.Controls.Add(this.btnNewRcpt);
            this.cofPrice.Controls.Add(this.button1);
            this.cofPrice.Controls.Add(this.btnSalesRefresh);
            this.cofPrice.Controls.Add(this.label12);
            this.cofPrice.Controls.Add(this.cofTotal);
            this.cofPrice.Controls.Add(this.label11);
            this.cofPrice.Controls.Add(this.cofProdQty);
            this.cofPrice.Controls.Add(this.label6);
            this.cofPrice.Controls.Add(this.cofProdPrice);
            this.cofPrice.Controls.Add(this.label8);
            this.cofPrice.Controls.Add(this.label9);
            this.cofPrice.Controls.Add(this.label10);
            this.cofPrice.Controls.Add(this.cofProdBrand);
            this.cofPrice.Controls.Add(this.cofProdItem);
            this.cofPrice.Controls.Add(this.cofProdNo);
            this.cofPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cofPrice.Location = new System.Drawing.Point(0, 0);
            this.cofPrice.Name = "cofPrice";
            this.cofPrice.Size = new System.Drawing.Size(692, 631);
            this.cofPrice.TabIndex = 20;
            // 
            // btnNewRcpt
            // 
            this.btnNewRcpt.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(159)))), ((int)(((byte)(107)))));
            this.btnNewRcpt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewRcpt.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewRcpt.ForeColor = System.Drawing.Color.White;
            this.btnNewRcpt.Image = ((System.Drawing.Image)(resources.GetObject("btnNewRcpt.Image")));
            this.btnNewRcpt.Location = new System.Drawing.Point(56, 473);
            this.btnNewRcpt.Name = "btnNewRcpt";
            this.btnNewRcpt.Size = new System.Drawing.Size(213, 40);
            this.btnNewRcpt.TabIndex = 5;
            this.btnNewRcpt.Text = "New Receipt";
            this.btnNewRcpt.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(159)))), ((int)(((byte)(107)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(456, 473);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 40);
            this.button1.TabIndex = 7;
            this.button1.Text = "Void";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnSalesRefresh
            // 
            this.btnSalesRefresh.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(159)))), ((int)(((byte)(107)))));
            this.btnSalesRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalesRefresh.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalesRefresh.ForeColor = System.Drawing.Color.White;
            this.btnSalesRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnSalesRefresh.Image")));
            this.btnSalesRefresh.Location = new System.Drawing.Point(273, 473);
            this.btnSalesRefresh.Name = "btnSalesRefresh";
            this.btnSalesRefresh.Size = new System.Drawing.Size(180, 40);
            this.btnSalesRefresh.TabIndex = 6;
            this.btnSalesRefresh.Text = "Manual Code";
            this.btnSalesRefresh.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(120)))), ((int)(((byte)(115)))));
            this.label12.Location = new System.Drawing.Point(52, 341);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(190, 21);
            this.label12.TabIndex = 23;
            this.label12.Text = "TOTAL OVER QUANTITY";
            // 
            // cofTotal
            // 
            this.cofTotal.AcceptsReturn = true;
            this.cofTotal.BackColor = System.Drawing.Color.White;
            this.cofTotal.Enabled = false;
            this.cofTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cofTotal.Location = new System.Drawing.Point(56, 365);
            this.cofTotal.Multiline = true;
            this.cofTotal.Name = "cofTotal";
            this.cofTotal.Size = new System.Drawing.Size(580, 64);
            this.cofTotal.TabIndex = 22;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(120)))), ((int)(((byte)(115)))));
            this.label11.Location = new System.Drawing.Point(402, 257);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 21);
            this.label11.TabIndex = 21;
            this.label11.Text = "QUANTITY";
            // 
            // cofProdQty
            // 
            this.cofProdQty.AcceptsReturn = true;
            this.cofProdQty.BackColor = System.Drawing.Color.White;
            this.cofProdQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cofProdQty.Location = new System.Drawing.Point(406, 281);
            this.cofProdQty.Multiline = true;
            this.cofProdQty.Name = "cofProdQty";
            this.cofProdQty.Size = new System.Drawing.Size(230, 41);
            this.cofProdQty.TabIndex = 4;
            this.cofProdQty.TextChanged += new System.EventHandler(this.cofProdQty_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(120)))), ((int)(((byte)(115)))));
            this.label6.Location = new System.Drawing.Point(402, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 21);
            this.label6.TabIndex = 19;
            this.label6.Text = "PRICE";
            // 
            // cofProdPrice
            // 
            this.cofProdPrice.AcceptsReturn = true;
            this.cofProdPrice.BackColor = System.Drawing.Color.White;
            this.cofProdPrice.Enabled = false;
            this.cofProdPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cofProdPrice.Location = new System.Drawing.Point(406, 208);
            this.cofProdPrice.Multiline = true;
            this.cofProdPrice.Name = "cofProdPrice";
            this.cofProdPrice.Size = new System.Drawing.Size(230, 41);
            this.cofProdPrice.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(120)))), ((int)(((byte)(115)))));
            this.label8.Location = new System.Drawing.Point(52, 257);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 21);
            this.label8.TabIndex = 15;
            this.label8.Text = "BRAND";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(120)))), ((int)(((byte)(115)))));
            this.label9.Location = new System.Drawing.Point(52, 184);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 21);
            this.label9.TabIndex = 14;
            this.label9.Text = "ITEM";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(120)))), ((int)(((byte)(115)))));
            this.label10.Location = new System.Drawing.Point(52, 85);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 21);
            this.label10.TabIndex = 13;
            this.label10.Text = "PRODUCT #";
            // 
            // cofProdBrand
            // 
            this.cofProdBrand.AcceptsReturn = true;
            this.cofProdBrand.BackColor = System.Drawing.Color.White;
            this.cofProdBrand.Enabled = false;
            this.cofProdBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cofProdBrand.Location = new System.Drawing.Point(56, 281);
            this.cofProdBrand.Multiline = true;
            this.cofProdBrand.Name = "cofProdBrand";
            this.cofProdBrand.Size = new System.Drawing.Size(315, 41);
            this.cofProdBrand.TabIndex = 2;
            // 
            // cofProdItem
            // 
            this.cofProdItem.AcceptsReturn = true;
            this.cofProdItem.BackColor = System.Drawing.Color.White;
            this.cofProdItem.Enabled = false;
            this.cofProdItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cofProdItem.Location = new System.Drawing.Point(56, 208);
            this.cofProdItem.Multiline = true;
            this.cofProdItem.Name = "cofProdItem";
            this.cofProdItem.Size = new System.Drawing.Size(315, 41);
            this.cofProdItem.TabIndex = 1;
            // 
            // cofProdNo
            // 
            this.cofProdNo.AcceptsReturn = true;
            this.cofProdNo.BackColor = System.Drawing.Color.White;
            this.cofProdNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.cofProdNo.Location = new System.Drawing.Point(56, 109);
            this.cofProdNo.Multiline = true;
            this.cofProdNo.Name = "cofProdNo";
            this.cofProdNo.Size = new System.Drawing.Size(580, 64);
            this.cofProdNo.TabIndex = 0;
            this.cofProdNo.TextChanged += new System.EventHandler(this.cofProdNo_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(120)))), ((int)(((byte)(115)))));
            this.label5.Location = new System.Drawing.Point(402, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 21);
            this.label5.TabIndex = 19;
            this.label5.Text = "PRICE";
            // 
            // textBox4
            // 
            this.textBox4.AcceptsReturn = true;
            this.textBox4.BackColor = System.Drawing.Color.White;
            this.textBox4.Enabled = false;
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(406, 174);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(230, 41);
            this.textBox4.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(120)))), ((int)(((byte)(115)))));
            this.label4.Location = new System.Drawing.Point(52, 299);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 21);
            this.label4.TabIndex = 17;
            this.label4.Text = "PRODUCT #";
            // 
            // textBox3
            // 
            this.textBox3.AcceptsReturn = true;
            this.textBox3.BackColor = System.Drawing.Color.White;
            this.textBox3.Enabled = false;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(56, 323);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(315, 41);
            this.textBox3.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(120)))), ((int)(((byte)(115)))));
            this.label2.Location = new System.Drawing.Point(52, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 21);
            this.label2.TabIndex = 15;
            this.label2.Text = "PRODUCT #";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(120)))), ((int)(((byte)(115)))));
            this.label1.Location = new System.Drawing.Point(52, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 21);
            this.label1.TabIndex = 14;
            this.label1.Text = "PRODUCT #";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(120)))), ((int)(((byte)(115)))));
            this.label3.Location = new System.Drawing.Point(52, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 21);
            this.label3.TabIndex = 13;
            this.label3.Text = "PRODUCT #";
            // 
            // textBox2
            // 
            this.textBox2.AcceptsReturn = true;
            this.textBox2.BackColor = System.Drawing.Color.White;
            this.textBox2.Enabled = false;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(56, 247);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(315, 41);
            this.textBox2.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.AcceptsReturn = true;
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(56, 174);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(315, 41);
            this.textBox1.TabIndex = 2;
            // 
            // prodAddNo
            // 
            this.prodAddNo.AcceptsReturn = true;
            this.prodAddNo.BackColor = System.Drawing.Color.White;
            this.prodAddNo.Enabled = false;
            this.prodAddNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prodAddNo.Location = new System.Drawing.Point(56, 75);
            this.prodAddNo.Multiline = true;
            this.prodAddNo.Name = "prodAddNo";
            this.prodAddNo.Size = new System.Drawing.Size(580, 64);
            this.prodAddNo.TabIndex = 1;
            // 
            // cofTotalAll
            // 
            this.cofTotalAll.AcceptsReturn = true;
            this.cofTotalAll.BackColor = System.Drawing.Color.White;
            this.cofTotalAll.Enabled = false;
            this.cofTotalAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cofTotalAll.Location = new System.Drawing.Point(56, 536);
            this.cofTotalAll.Multiline = true;
            this.cofTotalAll.Name = "cofTotalAll";
            this.cofTotalAll.Size = new System.Drawing.Size(580, 64);
            this.cofTotalAll.TabIndex = 24;
            // 
            // CheckOutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 631);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "CheckOutForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CheckOutForm";
            this.Load += new System.EventHandler(this.CheckOutForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.cofPrice.ResumeLayout(false);
            this.cofPrice.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox prodAddNo;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel cofPrice;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox cofTotal;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox cofProdQty;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox cofProdPrice;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox cofProdBrand;
        private System.Windows.Forms.TextBox cofProdItem;
        private System.Windows.Forms.TextBox cofProdNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnNewRcpt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSalesRefresh;
        private System.Windows.Forms.ListView listViewReceipt;
        private System.Windows.Forms.ColumnHeader rcptNo;
        private System.Windows.Forms.ColumnHeader rcptItem;
        private System.Windows.Forms.ColumnHeader rcptPrice;
        private System.Windows.Forms.ColumnHeader rcptQty;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox cofTotalAll;
    }
}