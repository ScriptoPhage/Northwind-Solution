namespace MVC.DTOs.SQLFunctions
{
    public class SalesByYearDto
    {
        public DateTime ShippedDate { get; set; }
        public int OrderID { get; set; }
        public decimal Subtotal { get; set; }
        public int year { get; set; }
    }
}
