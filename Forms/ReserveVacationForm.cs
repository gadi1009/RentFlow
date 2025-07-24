using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
namespace RealEstateManagementSystem.Forms {
    public partial class ReserveVacationForm : Form
    {
        private List<Property> vacationProperties = new List<Property>();

        public ReserveVacationForm()
        {
            InitializeComponent();
            AddRandomVacationProperties(20); // אתחול נכסי נופש
            LoadVacationProperties();       // טעינת נכסי נופש
        }

        private void AddRandomVacationProperties(int count)
        {
            Random random = new Random();
            List<string> cities = new List<string> { "תל אביב", "ירושלים", "חיפה", "אילת", "נתניה", "הרצליה", "אשדוד", "בת ים", "רעננה", "כפר סבא" };
            List<string> streetNames = new List<string> { "אבן גבירול", "דיזנגוף", "הירקון", "רוטשילד", "הרצל", "שדרות חן", "המלך ג'ורג'", "השלום", "הבנים", "הכובשים" };
            List<string> ownerNames = new List<string> { "יוסי כהן", "רונית לוי", "משה ישראלי", "דנה לוי", "עדי שיר", "אריאל חן", "נעמי דוד", "שלמה מור", "הילה בנאי", "יגאל רון" };

            for (int i = 0; i < count; i++)
            {
                string city = cities[random.Next(cities.Count)];
                string street = streetNames[random.Next(streetNames.Count)];
                string address = $"רחוב {street} {random.Next(1, 100)}, {city}";

                DateTime checkInDate = DateTime.Now.AddDays(random.Next(1, 10));
                DateTime checkOutDate = checkInDate.AddDays(random.Next(1, 7));

                Property newProperty = new Property
                {
                    Address = address,
                    Status = random.Next(2) == 0 ? "זמין" : "תפוס",
                    RentalPrice = random.Next(300, 1000),
                    Size = random.Next(30, 100),
                    OwnerName = ownerNames[random.Next(ownerNames.Count)],
                    OwnerPhone = $"05{random.Next(0, 9)}-{random.Next(1000000, 9999999)}",
                    OwnerID = $"{random.Next(100000000, 999999999)}",
                    CheckInDate = checkInDate,
                    CheckOutDate = checkOutDate
                };

                vacationProperties.Add(newProperty);
            }
        }


        private void LoadVacationProperties()
        {
            // הצגת נכסי נופש ב-DataGridView
            dataGridViewVacation.Rows.Clear();

            foreach (var property in vacationProperties)
            {
                int index = dataGridViewVacation.Rows.Add();
                dataGridViewVacation.Rows[index].Cells["Address"].Value = property.Address;
                dataGridViewVacation.Rows[index].Cells["Status"].Value = property.Status;
                dataGridViewVacation.Rows[index].Cells["RentalPrice"].Value = property.RentalPrice;
                dataGridViewVacation.Rows[index].Cells["Size"].Value = property.Size;

                // צביעת שורות לפי סטטוס
                if (property.Status == "תפוס")
                {
                    dataGridViewVacation.Rows[index].DefaultCellStyle.BackColor = Color.Red;
                }
                else if (property.Status == "זמין")
                {
                    dataGridViewVacation.Rows[index].DefaultCellStyle.BackColor = Color.Green;
                }
            }
        }

        private void btnReserve_Click(object sender, EventArgs e)
        {
            // בדיקת זמינות תאריכים והזמנה
            DateTime checkInDate = dtpCheckIn.Value;
            DateTime checkOutDate = dtpCheckOut.Value;

            if (checkInDate >= checkOutDate)
            {
                MessageBox.Show("תאריך הצ'ק-אין חייב להיות לפני תאריך הצ'ק-אאוט.");
                return;
            }

            // בדיקה אם התאריכים תפוסים
            foreach (var property in vacationProperties)
            {
                if (property.Status == "תפוס" &&
                    (checkInDate <= property.ContractEndDate && checkOutDate >= property.ContractEndDate))
                {
                    MessageBox.Show("התאריכים שנבחרו תפוסים עבור נכס זה.");
                    return;
                }
            }

            // פתיחת טופס פרטי הלקוח
            CustomerDetailsForm customerForm = new CustomerDetailsForm();
            if (customerForm.ShowDialog() == DialogResult.OK && customerForm.IsConfirmed)
            {
                // הצגת פרטי ההזמנה הסופיים
                int selectedRowIndex = dataGridViewVacation.CurrentCell.RowIndex;
                var selectedProperty = vacationProperties[selectedRowIndex];

                // חישוב מספר הלילות - יש להוסיף 1 כדי לכלול את יום הכניסה
                int totalDays = (checkOutDate - checkInDate).Days;

                // עדכון: חישוב לילות כולל כניסה אך לא יציאה
                if (totalDays > 0)
                {
                    totalDays += 1;
                }

                double totalPrice = totalDays * selectedProperty.RentalPrice;

                string message = $"הזמנת נכס:\n" +
                                 $"כתובת: {selectedProperty.Address}\n" +
                                 $"שם הלקוח: {customerForm.CustomerFirstName} {customerForm.CustomerLastName}\n" +
                                 $"אימייל: {customerForm.CustomerEmail}\n" +
                                 $"תאריך כניסה: {checkInDate.ToShortDateString()}\n" +
                                 $"תאריך יציאה: {checkOutDate.ToShortDateString()}\n" +
                                 $"מספר לילות: {totalDays}\n" +
                                 $"סכום כולל: {totalPrice} ש\"ח";

                MessageBox.Show(message, "סיכום הזמנה", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
