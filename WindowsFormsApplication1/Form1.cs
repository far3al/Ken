using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class frmPOS : Form
    {
        public frmPOS()
        {
            InitializeComponent();
        }

        decimal TOtal = 0;

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            int qty = 0;
            if (cboItem.SelectedIndex == -1)
            {
                MessageBox.Show(" An item ");
                cboItem.Focus();
                return;
            }

            if (!string.IsNullOrEmpty(txtQty.Text))
            {
                try
                {
                    qty = int.Parse(txtQty.Text);
                    TOtal = TOtal + decimal.Parse((3.5 * qty) + "");
                    txtDue.Text = TOtal.ToString();
                }
                catch (Exception eex)
                {
                    MessageBox.Show("Quantity Not Aceeptable ",
                        this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Console.WriteLine(eex.Message + " occurred in btnAddtoCart");
                    return;
                }

                 }
            else if (string.IsNullOrEmpty(txtQty.Text))
            {
                MessageBox.Show("Select the Quantity");
                txtQty.Focus();
                return;
            }

            string Iten = cboItem.Text;
            decimal Prce = 5m;
            int Qnty =0;
            int.TryParse(txtQty.Text, out Qnty);
            decimal ExtPrice = Prce * Qnty;

            string[] cartline = {
                                     Iten, 
                                     Prce.ToString("F2"),
                                     Qnty.ToString(),
                                     ExtPrice.ToString("F2")
                                 };

            dgvCart.Rows.Add(cartline);

            ClearEntry();

        }

        private void ClearEntry()
        {
            cboItem.SelectedIndex = -1;
            txtQty.Text = "";
        }

        private void txtDue_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int qty = int.Parse(txtQty.Text);
                string item = cboItem.Text;
                decimal price = 3.5m;
                decimal ExtPrice = price * qty;
            }

            catch (Exception ex)
            {
                MessageBox.Show("You Have Entered Wong Information");
            }
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            decimal paid = decimal.Parse((txtPaid.Text) + "");
            if (paid >= TOtal)
            {

                decimal change = paid - TOtal;
                txtChange.Text = change.ToString();
                MessageBox.Show("You Have Completed This Transaction");
            }
            else
            {

                MessageBox.Show("You Are Still Owing");
            }
        }
       

    
    
    
    }
        
    

}
