using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nathaly_ShoesInventory
{
    public partial class frmShoeInfo : Form
    {
        public frmShoeInfo(string style)
        {
            InitializeComponent();
            txtStyle.Text = style;
        }

        private void mnuSave_Click(object sender, EventArgs e)
        {
            string style = txtStyle.Text;
            double price;

            if (txtPrice.Text != "")
                price = Convert.ToDouble(txtPrice.Text);
            else
                price = 0;

            frmUpdateShoes.shoeList.ChangeShoePrice(style, price);
            
            Close();
        }
    }
}
