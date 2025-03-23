using System;
using System.Collections.Generic;

namespace MVC.Models;

public partial class CustomerDemographic
{
    public string CustomerTypeId { get; set; } = null!;

    public string? CustomerDesc { get; set; }
}
