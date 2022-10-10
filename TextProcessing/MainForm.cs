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
    
    public partial class MainForm : Form
    {
        private bool userLoggedIn;
        public MainForm()
        {
            InitializeComponent();
        }


        private bool CheckIfFormCreated(Type formType, out Form formInstance)
        {
            bool formCreated = false;
            formInstance = null;

            // Check all open forms to see if this form has already been instantiated
            foreach (Form form in Application.OpenForms)
            {
                // If the type matches, then activate the form instance
                if (form.GetType() == formType)
                {
                    formCreated = true;
                    formInstance = form;
                    form.Activate();
                    break;
                }
            }

            return formCreated;
        }
        private void OnLoggedInUpdate(bool didUserLogIn)
        {
            Form form;
            const string shoppingCartButton = "shoppingCartButton";

            // Set the parent class attribute value
            userLoggedIn = didUserLogIn;

            // Set the Menu Option 1 state to enabled or disabled depending on whether login was successful
            menuOption1ToolStripMenuItem.Enabled = userLoggedIn;

            // Check to see if the Shopping Cart Form was launched previously.  If it was,
            // then we need to grab the instance, locate the button in its form controls and set 
            // the value of the button's enabled property based on the password validation results.
            if (CheckIfFormCreated(typeof(CartForm), out form))
            {
                if (form != null)
                {
                    if (form.Controls.ContainsKey(shoppingCartButton))
                    {
                        var control = form.Controls[shoppingCartButton];
                        control.Enabled = userLoggedIn;
                    }
                }
            }
        }



        private void logoutToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            OnLoggedInUpdate(false);
        }

        private void loginToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            // Set the child's property value with the current value stored in the parent
            loginForm.UserLoggedIn = userLoggedIn;
            // Show the form as a dialog instead of as a normal window
            loginForm.ShowDialog();
            OnLoggedInUpdate(loginForm.UserLoggedIn);
        }

        private void menuOption2ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form form;
            if (!CheckIfFormCreated(typeof(CartForm), out form))
            {
                CartForm cartForm = new CartForm();
                cartForm.MdiParent = this;
                cartForm.WindowState = FormWindowState.Maximized;
                cartForm.Show();
            }
        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MainForm_Load_1(object sender, EventArgs e)
        {
            // Responsible for setting our property value to false and disabling Menu Option 1.
            OnLoggedInUpdate(false);
        }

        private void cSVDisplayToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form form;
            if (!CheckIfFormCreated(typeof(CSVDisplayForm), out form))
            {
                CSVDisplayForm csvForm = new CSVDisplayForm();
                csvForm.MdiParent = this;
                csvForm.WindowState = FormWindowState.Maximized;
                csvForm.Show();
            }
        }
    }
}