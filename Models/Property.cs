using System;
namespace RealEstateManagementSystem.Models {
    public class Property
    {
        public string Address { get; set; }
        public string Status { get; set; } // "מושכר" או "למכירה"
        public double RentalPrice { get; set; } // מחיר שכירות לנכסים להשכרה
        public double SalePrice { get; set; } // מחיר מכירה לנכסים למכירה
        public int Size { get; set; } // גודל הנכס במ"ר
        public string OwnerName { get; set; }
        public string OwnerID { get; set; } // תעודת זהות של בעל הנכס
        public string OwnerPhone { get; set; } // מספר טלפון של בעל הנכס
        public DateTime ContractEndDate { get; set; } // תאריך סיום חוזה לנכסים להשכרה
        public string PropertyType { get; set; } // סוג הנכס: דירה, וילה, מחסן, וכו'
        public DateTime CheckInDate { get; internal set; }
        public DateTime CheckOutDate { get; internal set; }

        // מתודה לחישוב מספר הימים שנותרו עד סיום החוזה
        public int DaysUntilContractEnds()
        {
            if (ContractEndDate != DateTime.MinValue)
            {
                return (ContractEndDate - DateTime.Now).Days;
            }
            return int.MaxValue; // אם אין תאריך סיום חוזה, החזרה על מספר גדול
        }
    }
}
