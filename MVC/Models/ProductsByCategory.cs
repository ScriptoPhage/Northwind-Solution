using System;
using System.Collections;
using System.Collections.Generic;

namespace MVC.Models;

public partial class ProductsByCategory
{
    public string? CategoryName { get; set; }

    public string? ProductName { get; set; }

    public string? QuantityPerUnit { get; set; }

    public short? UnitsInStock { get; set; }

    public BitArray? Discontinued { get; set; }
}
