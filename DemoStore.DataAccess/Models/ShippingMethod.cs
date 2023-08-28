using System;
using System.Collections.Generic;

namespace DemoStore.DataAccess.Models;

public partial class ShippingMethod
{
    public long Id { get; set; }

    public string? Email { get; set; }

    public string? Password { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }
}
