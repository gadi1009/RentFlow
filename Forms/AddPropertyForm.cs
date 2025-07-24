using System;
using System.Windows.Forms;
namespace RealEstateManagementSystem.Forms {
    public partial class AddPropertyForm : Form
    {
        private string propertyType;

        public Property NewProperty { get; private set; }

        public AddPropertyForm()
        {
            InitializeComponent();
            cmbStatus.SelectedIndexChanged += cmbStatus_SelectedIndexChanged; // הוסף מאזין לאירוע שינוי
        }

        public AddPropertyForm(string propertyType)
        {
            this.propertyType = propertyType;
        }

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbStatus.SelectedItem.ToString() == "מושכר")
            {
                txtRentalPrice.Enabled = true;
                dtpContractEndDate.Enabled = true;
                txtSalePrice.Enabled = false;
                txtSalePrice.Clear();
            }
            else if (cmbStatus.SelectedItem.ToString() == "למכירה")
            {
                txtRentalPrice.Enabled = false;
                dtpContractEndDate.Enabled = false;
                txtRentalPrice.Clear();
                dtpContractEndDate.Value = DateTime.Now;
                txtSalePrice.Enabled = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // בדיקת תוקף נתונים
            if (string.IsNullOrEmpty(txtAddress.Text) || string.IsNullOrEmpty(txtOwnerName.Text) || string.IsNullOrEmpty(cmbStatus.Text))
            {
                MessageBox.Show("נא למלא את כל השדות.");
                return;
            }

            try
            {
                NewProperty = new Property
                {
                    Address = txtAddress.Text,
                    Status = cmbStatus.SelectedItem.ToString(),
                    RentalPrice = txtRentalPrice.Enabled ? double.Parse(txtRentalPrice.Text) : 0,
                    Size = int.Parse(txtSize.Text),
                    OwnerName = txtOwnerName.Text,
                    OwnerID = txtOwnerID.Text,
                    OwnerPhone = txtOwnerPhone.Text,
                    ContractEndDate = dtpContractEndDate.Enabled ? dtpContractEndDate.Value : DateTime.MinValue,
                    PropertyType = txtPropertyType.Text,
                    SalePrice = txtSalePrice.Enabled ? double.Parse(txtSalePrice.Text) : 0
                };

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (FormatException)
            {
                MessageBox.Show("נא להכניס ערכים תקינים עבור המחיר והגודל.");
            }
        }
    }
}
