using System;
using System.Windows.Forms;
namespace RealEstateManagementSystem.Forms {
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            // בדיקת תוקף בסיסית
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("נא להכניס שם משתמש וסיסמה.");
                return;
            }

            // הדגמה בלבד - ניתן לשלב בדיקת תוקף אמיתית מול מסד נתונים
            if (username == "admin" && password == "password")
            {
                MainForm mainForm = new MainForm();
                mainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("שם משתמש או סיסמה שגויים.");
            }
        }
    }
}
