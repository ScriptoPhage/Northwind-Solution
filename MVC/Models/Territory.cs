﻿using System;
using System.Collections.Generic;

namespace MVC.Models;

public partial class Territory
{
    public string TerritoryId { get; set; } = null!;

    public string? TerritoryDescription { get; set; }

    public int RegionId { get; set; }
}
