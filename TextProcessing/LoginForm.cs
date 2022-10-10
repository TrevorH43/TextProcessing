using System;
using RVCUtilityLibrary;
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
    public partial class LoginForm : Form
    {
        public bool UserLoggedIn { get; set; }      
        public LoginForm()
        {
            InitializeComponent();

            this.AutoValidate = AutoValidate.Disable;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void userNameTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (userNameTextBox.Text.Length == 0)
            {
                errorProvider1.SetError(userNameTextBox, "User Name entry is required.");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(userNameTextBox, "");
                e.Cancel = false;
            }
        }
        private bool IsPasswordValid(string password, out string message)
        {
            bool isValid = false;
            message = "";
            int upperCount = 0, lowerCount = 0, numberCount = 0, specialCharacterCount = 0;

            const int MIN_LENGTH = 8;

            if (password.Length < MIN_LENGTH)
                message = $"Password must be at least {MIN_LENGTH} characters in length";
            else
            {
                // check for upper, lower, numbers, and special characters by incrementing a counter for each
                foreach (char passwordCharacter in password)
                {
                    if (char.IsUpper(passwordCharacter)) upperCount++;
                    if (char.IsLower(passwordCharacter)) lowerCount++;
                    if (char.IsDigit(passwordCharacter)) numberCount++;
                    if (!char.IsLetterOrDigit(passwordCharacter) &&
                        !char.IsWhiteSpace(passwordCharacter)) specialCharacterCount++;
                }

                // Now check to see if all counts are greater than 0, which means that the at least 1 requirement is satisfied
                if (upperCount > 0 && lowerCount > 0 && numberCount > 0 && specialCharacterCount > 0)
                    isValid = true;
                else if (upperCount == 0)   // Missing Upper Case Letter
                    message = "Password entry requires at least 1 uppercase letter.";
                else if (lowerCount == 0)   // Missing Lower Case Letter
                    message = "Password entry requires at least 1 lowercase letter.";
                else if (numberCount == 0)  // Missing Digit, i.e., Number
                    message = "Password entry requires at least 1 digit.";
                else                       // Missing Special Character
                    message = "Password entry requires at least 1 special character.";
            }

            return isValid;
        }

        private void passwordTextBox_Validating(object sender, CancelEventArgs e)
        {
            string message = null;
            e.Cancel = !IsPasswordValid(passwordTextBox.Text, out message);
            errorProvider1.SetError(passwordTextBox, message);
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            // Based on the Password Validation set the property
            UserLoggedIn = ValidateChildren();

            /* We only want to close the window when a password entry is successful.  
                Otherwise, the user should be getting validation messages from the error provider to
                guide correction of the password value
            */
            if (UserLoggedIn)
                this.Close();
        }

        private void passwordTextBox_Validating1(object sender, CancelEventArgs e)
        {
            string message = null;
            e.Cancel = !RVCUserLib.IsPasswordValid(passwordTextBox.Text, out message);
            errorProvider1.SetError(passwordTextBox, message);
        }

    }
}
