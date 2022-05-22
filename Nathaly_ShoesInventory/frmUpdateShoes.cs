using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShoeClasses;

namespace Nathaly_ShoesInventory
{
    public partial class frmUpdateShoes : Form
    {
        public static ShoeList shoeList;

        public frmUpdateShoes()
        {
            InitializeComponent();
            shoeList = new ShoeList();
            cmbShoeStyles.DataSource = shoeList.GetStyle();
            
        }

        private void cmbShoeStyles_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Shoe> shoeInfo = new List<Shoe>();
            string styleComboBox = cmbShoeStyles.SelectedItem.ToString();
            string imageTitle = shoeList.GetImage(styleComboBox);

            picShoes.Image = Image.FromFile(@"Images\" + imageTitle);

            shoeInfo = shoeList.PopListBox(styleComboBox);
            
            //To clear the list before it displays the item info
            lstShoesStock.Items.Clear();
           
            foreach (Shoe shoe in shoeInfo)
            {
                lstShoesStock.Items.Add(shoe.ToString());
            }
            
        }

        private void mnuUpdateShoe_Click(object sender, EventArgs e)
        {
            string styleComboBox = cmbShoeStyles.SelectedItem.ToString();
            frmShoeInfo shoeInfo = new frmShoeInfo(styleComboBox);
            shoeInfo.ShowDialog();
        }

        private void mnuOptionsChangeFC_Click(object sender, EventArgs e)
        {
            ColorDialog color = new ColorDialog();
            if (color.ShowDialog() == DialogResult.OK)
            {
                lstShoesStock.ForeColor = color.Color;
            }
        }

        private void mnuOptionsExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
