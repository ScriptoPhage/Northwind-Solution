namespace MVC.DTOs.SQLFunctions
{
    public class EmployeeSalesByCountryDto
    {
        public string Country { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public DateTime ShippedDate { get; set; }
        public int OrderID { get; set; }
        public decimal SaleAmount { get; set; }
    }
}
