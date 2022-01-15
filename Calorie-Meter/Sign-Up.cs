using Calori_Meter.Data;
using Calorie_Meter.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calorie_Meter
{
    public partial class Sign_Up : Form
    {
        private readonly ApplicationDbContext db;

        public Sign_Up(ApplicationDbContext db)
        {
            InitializeComponent();
            this.db = db;
           
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string eMail = txtMail.Text.Trim();
            string password = txtPassword.Text.Trim();
            string passwordAgain = txtPasswordAgain.Text.Trim();
            if (name == "" || eMail == "" || password == "" || passwordAgain =="")
            {
                MessageBox.Show("Please fill in all the blanks!");
                return;
            }
            SignUp(name, eMail, password);
        }

        private void SignUp(string name, string eMail, string password)
        {
            User user = new User()
            {
                Name = name,
                EMail = eMail,
                Password = password
            };

            if (LevelOfPassword(password) == "Weak Password.." || LevelOfPassword(password) == "Middle Password..")
            {
                MessageBox.Show("Password must be minimum 6 character. You should use letter, number and special character.");
                txtPassword.Clear();
                txtPasswordAgain.Clear();
                lblCheck.Text = "";
                lblStrongPassword.Text = "";
                return;
            }
            else if (PasswordCheck() == true)
            {
                MessageBox.Show("Passwords do not match! Please check passwords!");
                return;
            }

            else
            {
                if (db.Users.Any(x => x.EMail == user.EMail))
                {
                    MessageBox.Show("This email is already used.");
                    ClearForm();
                }
                else
                {
                    db.Users.Add(user);
                    MessageBox.Show("Registration Successful. You can enter the system with this email and password.");
                    db.SaveChanges();
                    Close();
                }
            }
        }
        private void ClearForm()
        {
            txtName.Clear();
            txtMail.Clear();
            txtPassword.Clear();
            txtPasswordAgain.Clear();
        }
        private bool PasswordCheck()
        {
            return (txtPassword.Text != txtPasswordAgain.Text || string.IsNullOrEmpty(txtPassword.Text) || string.IsNullOrEmpty(txtPasswordAgain.Text));
        }
        private void txtPasswordAgain_TextChanged(object sender, EventArgs e)
        {
            if (txtPasswordAgain.Text == "")
            {
                lblCheck.Text = "";
            }
            if (txtPassword.Text == "")
            {
                lblStrongPassword.Text = "";
                return;
            }

            lblStrongPassword.Text = LevelOfPassword(txtPassword.Text);
            if (LevelOfPassword(txtPassword.Text) == "Weak Password..")
            {
                lblStrongPassword.ForeColor = Color.Red;
            }
            else if (LevelOfPassword(txtPassword.Text) == "Middle Password..")
            {
                lblStrongPassword.ForeColor = Color.Orange;
            }
            else if (LevelOfPassword(txtPassword.Text) == "Strong Password..")
            {
                lblStrongPassword.ForeColor = Color.Green;
            }
            if (PasswordCheck())
            {
                lblCheck.Text = "Passwords do not match!";
                lblCheck.ForeColor = Color.Red;
            }
            else
            {
                lblCheck.Text = "Passwords match.";
                lblCheck.ForeColor = Color.Green;
            }
        }
        private string LevelOfPassword(string password)
        {
            int length = password.Length;
            if (length < 6)
            {
                return "Weak Password..";
            }
            bool isSpecialChar = false;
            string specialCharacters = "*?+#&!é/-.:\\";
            bool isLetter = false;
            bool isNumber = false;
            for (int n = 0; n < password.Length; n++)
            {
                char a = Convert.ToChar(password.Substring(n, 1));
                if (Char.IsLetter(a))
                {
                    isLetter = true;
                }
                else if (Char.IsDigit(a))
                {
                    isNumber = true;
                }
                else if (specialCharacters.Contains(a))
                {
                    isSpecialChar = true;
                }
            }
            if (isSpecialChar == true && isLetter == true && isNumber == true)
            {
                return "Strong Password..";
            }
            else if (isNumber == true && isLetter == true)
            {
                return "Middle Password..";
            }
            else
            {
                return "Weak Password..";
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

            if (txtPasswordAgain.Text == "")
            {
                lblCheck.Text = "";
            }
            if (txtPassword.Text == "")
            {
                lblStrongPassword.Text = "";
                return;
            }
            lblStrongPassword.Text = LevelOfPassword(txtPassword.Text);
            if (LevelOfPassword(txtPassword.Text) == "Weak Password..")
            {
                lblStrongPassword.ForeColor = Color.Red;
            }
            else if (LevelOfPassword(txtPassword.Text) == "Middle Password..")
            {
                lblStrongPassword.ForeColor = Color.Orange;
            }
            else if (LevelOfPassword(txtPassword.Text) == "Strong Password..")
            {
                lblStrongPassword.ForeColor = Color.Green;
            }
            if (PasswordCheck())
            {
                lblCheck.Text = "Passwords do not match!";
                lblCheck.ForeColor = Color.Red;
            }
            else
            {
                lblCheck.Text = "Passwords match.";
                lblCheck.ForeColor = Color.Green;
            }
        }
    }
}
