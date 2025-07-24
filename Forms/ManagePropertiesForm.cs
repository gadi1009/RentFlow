using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
namespace RealEstateManagementSystem.Forms {
    public partial class ManagePropertiesForm : Form
    {
        // רשימת הנכסים שתיטען ל-DataGridView
        private List<Property> properties;

        // בנאי המחלקה
        public ManagePropertiesForm()
        {
            InitializeComponent();

            // אתחול רשימת הנכסים עם 2 נתונים לדוגמה
            properties = new List<Property>
            {
                new Property
                {
                    Address = "רחוב דיזנגוף 123, תל אביב",
                    Status = "מושכר",
                    RentalPrice = 4500,
                    Size = 100,
                    OwnerName = "יוסי כהן",
                    OwnerID = "123456789",
                    OwnerPhone = "050-1234567",
                    ContractEndDate = DateTime.Now.AddDays(45),
                    PropertyType = "דירה",
                    SalePrice = 0 // לא למכירה
                },
                new Property
                {
                    Address = "רחוב הרצל 78, ראשון לציון",
                    Status = "למכירה",
                    RentalPrice = 0, // לא להשכרה
                    Size = 150,
                    OwnerName = "אורנה לוי",
                    OwnerID = "987654321",
                    OwnerPhone = "052-9876543",
                    ContractEndDate = DateTime.MinValue, // לא רלוונטי לנכס למכירה
                    PropertyType = "פנטהאוז",
                    SalePrice = 2500000 // מחיר מכירה במיליוני שקלים
                },
            };

            // הוספת 38 נכסים רנדומליים נוספים (סה"כ 40)
            AddRandomProperties(38);

            // קריאה למתודה לטעינת הנכסים ל-DataGridView
            LoadProperties();
        }

        private void AddRandomProperties(int count)
        {
            Random random = new Random();
            List<string> cities = new List<string>
    {
        "תל אביב", "ירושלים", "חיפה", "באר שבע", "אשדוד",
        "רמת גן", "פתח תקווה", "הרצליה", "כפר סבא", "רחובות",
        "נתניה", "חולון", "בת ים", "רעננה", "גבעתיים"
    };
            List<string> streetNames = new List<string>
    {
        "הרצל", "בגין", "רוטשילד", "הנשיא", "אבן גבירול",
        "דיזנגוף", "שדרות חן", "שוקן", "יהודה הלוי", "נורדאו",
        "ויצמן", "העצמאות", "החירות", "השקמה", "התמר"
    };
            List<string> ownerNames = new List<string>
    {
        "יוסי כהן", "רונית לוי", "משה ישראלי", "דנה לוי",
        "עדי שיר", "אריאל חן", "נעמי דוד", "שלמה מור",
        "הילה בנאי", "יגאל רון", "רועי ישראלי", "אביגיל רוזן",
        "אמיר קפלן", "שיר שחר", "ניר בן דוד", "טל רבינוביץ'",
        "אביב חורש", "אורי גל", "גלית אור", "איתן לוי"
    };

            int shortTermContractsCount = 0;

            for (int i = 0; i < count; i++)
            {
                string city = cities[random.Next(cities.Count)];
                string street = streetNames[random.Next(streetNames.Count)];
                string address = $"רחוב {street} {random.Next(1, 100)}, {city}";

                Property newProperty = new Property
                {
                    Address = address,
                    Status = random.Next(2) == 0 ? "למכירה" : "מושכר",
                    Size = random.Next(60, 150),
                    OwnerName = ownerNames[random.Next(ownerNames.Count)],
                    OwnerPhone = $"05{random.Next(0, 9)}-{random.Next(1000000, 9999999)}",
                    OwnerID = $"{random.Next(100000000, 999999999)}",
                    PropertyType = random.Next(2) == 0 ? "דירה" : "פנטהאוז"
                };

                if (newProperty.Status == "מושכר")
                {
                    newProperty.SalePrice = 0; // אם להשכרה, מחיר מכירה ריק
                    newProperty.RentalPrice = random.Next(3000, 8000); // הגדרת מחיר השכרה רנדומלי

                    if (shortTermContractsCount < 5 && random.Next(2) == 0)
                    {
                        newProperty.ContractEndDate = DateTime.Now.AddDays(random.Next(1, 29));
                        shortTermContractsCount++;
                    }
                    else
                    {
                        newProperty.ContractEndDate = DateTime.Now.AddDays(random.Next(30, 365));
                    }
                }
                else if (newProperty.Status == "למכירה")
                {
                    newProperty.RentalPrice = 0; // אם למכירה, מחיר השכרה ריק
                    newProperty.SalePrice = random.Next(1500000, 5000000); // הגדרת מחיר מכירה רנדומלי
                    newProperty.ContractEndDate = DateTime.MinValue; // תאריך סיום חוזה לא רלוונטי לנכס למכירה
                }

                properties.Add(newProperty);
            }
        }


        private void LoadProperties()
        {
            dataGridViewProperties.Rows.Clear();

            foreach (var property in properties)
            {
                int index = dataGridViewProperties.Rows.Add();
                dataGridViewProperties.Rows[index].Cells["Address"].Value = property.Address;
                dataGridViewProperties.Rows[index].Cells["Status"].Value = property.Status;
                dataGridViewProperties.Rows[index].Cells["RentalPrice"].Value = property.RentalPrice > 0 ? property.RentalPrice.ToString("N0") : "N/A";
                dataGridViewProperties.Rows[index].Cells["Size"].Value = property.Size;
                dataGridViewProperties.Rows[index].Cells["OwnerName"].Value = property.OwnerName;
                dataGridViewProperties.Rows[index].Cells["OwnerPhone"].Value = property.OwnerPhone;
                dataGridViewProperties.Rows[index].Cells["OwnerID"].Value = property.OwnerID;
                dataGridViewProperties.Rows[index].Cells["ContractEndDate"].Value = property.ContractEndDate != DateTime.MinValue ? property.ContractEndDate.ToShortDateString() : "N/A";
                dataGridViewProperties.Rows[index].Cells["SalePrice"].Value = property.SalePrice > 0 ? property.SalePrice.ToString("N0") : "N/A";

                // הדגשת שורות אם נותרו 30 ימים או פחות לסיום החוזה
                if (property.Status == "מושכר" && property.ContractEndDate != DateTime.MinValue)
                {
                    int daysRemaining = (property.ContractEndDate - DateTime.Now).Days;
                    if (daysRemaining <= 30)
                    {
                        dataGridViewProperties.Rows[index].DefaultCellStyle.BackColor = Color.Red;
                    }
                }
            }
        }


        private void btnAddProperty_Click(object sender, EventArgs e)
        {
            AddPropertyForm addPropertyForm = new AddPropertyForm();
            if (addPropertyForm.ShowDialog() == DialogResult.OK)
            {
                properties.Add(addPropertyForm.NewProperty);
                LoadProperties(); // טען מחדש את רשימת הנכסים לאחר הוספת נכס חדש
            }
        }

        private void btnDeleteProperty_Click(object sender, EventArgs e)
        {
            if (dataGridViewProperties.SelectedRows.Count > 0)
            {
                int index = dataGridViewProperties.SelectedRows[0].Index;
                properties.RemoveAt(index); // הסר את הנכס מהרשימה
                LoadProperties(); // טען מחדש את רשימת הנכסים לאחר מחיקה
            }
            else
            {
                MessageBox.Show("נא לבחור נכס למחיקה.");
            }
        }
    }
}
