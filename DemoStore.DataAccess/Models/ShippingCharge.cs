using System;
using System.Collections.Generic;

namespace DemoStore.DataAccess.Models;

public partial class ShippingCharge
{
    public long Id { get; set; }

    public int? LessThan { get; set; }

    public int? Charge { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }
}
