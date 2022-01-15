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
    public partial class Login : Form
    {
        ApplicationDbContext db = new ApplicationDbContext();
        public Login()
        {
            InitializeComponent();
            
        }

        public User LoginProcess(string email, string password)
        {
            return db.Users.FirstOrDefault(x => x.EMail == email && x.Password == password);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (!db.Users.Any(x => x.EMail == email && x.Password == password))
            {
                MessageBox.Show("Wrong email/password!");
                return;
            }

            User userLog = LoginProcess(email, password);
            UserView userView = new UserView(db, userLog);
            this.Hide();
            userView.ShowDialog();
            this.Show();
        }

        private void lnkSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Sign_Up sign_Up = new Sign_Up(db);
            this.Hide();
            sign_Up.ShowDialog();
            this.Show();
        }
    }
}
