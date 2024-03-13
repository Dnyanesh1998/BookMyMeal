using System.ComponentModel.DataAnnotations;
using System.Data;

namespace BookMyMeal.Model
{
 
    public class CouponDetails
    {
        public DateTime Date { get; set; }
        public string Day {  get; set; }    
        public string EmployeeName { get; set; }
        public int EmployeeId { get; set; }
        public string CouponNo { get; set; }
        public string RedemptionStatus { get; set; }
        public string MealType { get; set; }
    }
    
}
