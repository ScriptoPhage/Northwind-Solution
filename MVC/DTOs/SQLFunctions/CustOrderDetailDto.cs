﻿namespace MVC.DTOs.SQLFunctions
{
    public class CustOrderDetailDto
    {
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }

        public short Quantity { get; set; }

        public int Discount { get; set; }

        public decimal ExtendedPrice { get; set; }
    }
}
