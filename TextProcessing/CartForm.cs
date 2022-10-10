using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextProcessing
{
    public partial class CartForm : Form
    {
        public bool UserLoggedIn { get; set; }
        public CartForm()
        {
            InitializeComponent();
        }

        private void shoppingCartButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Shopping Cart Button Clicked.");
        }
        private void CartForm_Load(object sender, EventArgs e)
        {
            shoppingCartButton.Enabled = UserLoggedIn;
        }

    }
}
