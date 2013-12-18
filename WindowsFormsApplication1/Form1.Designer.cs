namespace WindowsFormsApplication1
{
    partial class frmPOS
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
            this.cboItem = new System.Windows.Forms.ComboBox();
            this.lblDue = new System.Windows.Forms.Label();
            this.txtDue = new System.Windows.Forms.TextBox();
            this.lblQty = new System.Windows.Forms.Label();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.lblPaid = new System.Windows.Forms.Label();
            this.txtPaid = new System.Windows.Forms.TextBox();
            this.btnAddToCart = new System.Windows.Forms.Button();
            this.lblChange = new System.Windows.Forms.Label();
            this.txtChange = new System.Windows.Forms.TextBox();
            this.btnFinish = new System.Windows.Forms.Button();
            this.Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCart = new System.Windows.Forms.DataGridView();
            this.Iten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prce = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qnty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ttl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).BeginInit();
            this.SuspendLayout();
            // 
            // cboItem
            // 
            this.cboItem.FormattingEnabled = true;
            this.cboItem.Items.AddRange(new object[] {
            "Milk",
            "Sugar",
            "Nido",
            "Gari",
            "Bournvita",
            "VitaMilk",
            "PeakMilk",
            "Ideal Milk"});
            this.cboItem.Location = new System.Drawing.Point(6, 15);
            this.cboItem.Name = "cboItem";
            this.cboItem.Size = new System.Drawing.Size(115, 21);
            this.cboItem.TabIndex = 0;
            this.cboItem.Text = "Items";
            // 
            // lblDue
            // 
            this.lblDue.AutoSize = true;
            this.lblDue.Location = new System.Drawing.Point(275, 20);
            this.lblDue.Name = "lblDue";
            this.lblDue.Size = new System.Drawing.Size(27, 13);
            this.lblDue.TabIndex = 1;
            this.lblDue.Text = "Due";
            // 
            // txtDue
            // 
            this.txtDue.Location = new System.Drawing.Point(324, 12);
            this.txtDue.Name = "txtDue";
            this.txtDue.Size = new System.Drawing.Size(81, 20);
            this.txtDue.TabIndex = 2;
            this.txtDue.TextChanged += new System.EventHandler(this.txtDue_TextChanged);
            // 
            // lblQty
            // 
            this.lblQty.AutoSize = true;
            this.lblQty.Location = new System.Drawing.Point(3, 64);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(46, 13);
            this.lblQty.TabIndex = 3;
            this.lblQty.Text = "Quantity";
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(53, 60);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(68, 20);
            this.txtQty.TabIndex = 4;
            // 
            // lblPaid
            // 
            this.lblPaid.AutoSize = true;
            this.lblPaid.Location = new System.Drawing.Point(275, 61);
            this.lblPaid.Name = "lblPaid";
            this.lblPaid.Size = new System.Drawing.Size(28, 13);
            this.lblPaid.TabIndex = 5;
            this.lblPaid.Text = "Paid";
            // 
            // txtPaid
            // 
            this.txtPaid.Location = new System.Drawing.Point(327, 57);
            this.txtPaid.Name = "txtPaid";
            this.txtPaid.Size = new System.Drawing.Size(78, 20);
            this.txtPaid.TabIndex = 6;
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.Location = new System.Drawing.Point(49, 103);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(72, 26);
            this.btnAddToCart.TabIndex = 7;
            this.btnAddToCart.Text = "Add To Cart";
            this.btnAddToCart.UseVisualStyleBackColor = true;
            this.btnAddToCart.Click += new System.EventHandler(this.btnAddToCart_Click);
            // 
            // lblChange
            // 
            this.lblChange.AutoSize = true;
            this.lblChange.Location = new System.Drawing.Point(275, 110);
            this.lblChange.Name = "lblChange";
            this.lblChange.Size = new System.Drawing.Size(44, 13);
            this.lblChange.TabIndex = 8;
            this.lblChange.Text = "Change";
            // 
            // txtChange
            // 
            this.txtChange.Location = new System.Drawing.Point(330, 103);
            this.txtChange.Name = "txtChange";
            this.txtChange.Size = new System.Drawing.Size(75, 20);
            this.txtChange.TabIndex = 9;
            // 
            // btnFinish
            // 
            this.btnFinish.Location = new System.Drawing.Point(333, 268);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(72, 32);
            this.btnFinish.TabIndex = 11;
            this.btnFinish.Text = "Finish";
            this.btnFinish.UseVisualStyleBackColor = true;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // Item
            // 
            this.Item.HeaderText = "Item";
            this.Item.Name = "Item";
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            // 
            // Qty
            // 
            this.Qty.HeaderText = "Quantity";
            this.Qty.Name = "Qty";
            this.Qty.Width = 50;
            // 
            // dgvCart
            // 
            this.dgvCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Iten,
            this.Prce,
            this.Qnty,
            this.Ttl});
            this.dgvCart.Location = new System.Drawing.Point(12, 135);
            this.dgvCart.Name = "dgvCart";
            this.dgvCart.Size = new System.Drawing.Size(393, 127);
            this.dgvCart.TabIndex = 12;
            // 
            // Iten
            // 
            this.Iten.HeaderText = "Item";
            this.Iten.Name = "Iten";
            // 
            // Prce
            // 
            this.Prce.HeaderText = "Price";
            this.Prce.Name = "Prce";
            // 
            // Qnty
            // 
            this.Qnty.HeaderText = "Quantity";
            this.Qnty.Name = "Qnty";
            this.Qnty.Width = 50;
            // 
            // Ttl
            // 
            this.Ttl.HeaderText = "Total";
            this.Ttl.Name = "Ttl";
            // 
            // frmPOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 309);
            this.Controls.Add(this.dgvCart);
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.txtChange);
            this.Controls.Add(this.lblChange);
            this.Controls.Add(this.btnAddToCart);
            this.Controls.Add(this.txtPaid);
            this.Controls.Add(this.lblPaid);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.lblQty);
            this.Controls.Add(this.txtDue);
            this.Controls.Add(this.lblDue);
            this.Controls.Add(this.cboItem);
            this.Name = "frmPOS";
            this.Text = "POS";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboItem;
        private System.Windows.Forms.Label lblDue;
        private System.Windows.Forms.TextBox txtDue;
        internal System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.Label lblPaid;
        private System.Windows.Forms.TextBox txtPaid;
        private System.Windows.Forms.Button btnAddToCart;
        private System.Windows.Forms.Label lblChange;
        private System.Windows.Forms.TextBox txtChange;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
        private System.Windows.Forms.DataGridView dgvCart;
        private System.Windows.Forms.DataGridViewTextBoxColumn Iten;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prce;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qnty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ttl;
    }
}

