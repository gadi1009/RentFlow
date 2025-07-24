using System;
using System.Windows.Forms;
namespace RealEstateManagementSystem.Forms {
    public partial class CustomerDetailsForm : Form
    {
        public string CustomerFirstName { get; private set; }
        public string CustomerLastName { get; private set; }
        public string CustomerEmail { get; private set; }
        public string CustomerCreditCard { get; private set; }
        public bool IsConfirmed { get; private set; }

        public CustomerDetailsForm()
        {
            InitializeComponent();
            IsConfirmed = false;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            // איסוף פרטי הלקוח מהשדות
            CustomerFirstName = txtFirstName.Text;
            CustomerLastName = txtLastName.Text;
            CustomerEmail = txtEmail.Text;
            CustomerCreditCard = txtCreditCard.Text;

            // בדיקה שהשדות אינם ריקים
            if (string.IsNullOrEmpty(CustomerFirstName) || string.IsNullOrEmpty(CustomerLastName) ||
                string.IsNullOrEmpty(CustomerEmail) || string.IsNullOrEmpty(CustomerCreditCard))
            {
                MessageBox.Show("נא למלא את כל השדות.", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // בדיקת פורמט אימייל (פשטני)
            if (!CustomerEmail.Contains("@"))
            {
                MessageBox.Show("כתובת המייל אינה תקינה.", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // ביצוע ההזמנה ואישור
            IsConfirmed = true;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
