using System;
using System.Collections.Generic;

namespace DemoStore.DataAccess.Models;

public partial class ZipCode
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public int? Charge { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public int? PriceLessThan { get; set; }
}
