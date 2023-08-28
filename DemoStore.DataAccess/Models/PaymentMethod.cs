using System;
using System.Collections.Generic;

namespace DemoStore.DataAccess.Models;

public partial class PaymentMethod
{
    public long Id { get; set; }

    public int? Name { get; set; }

    public string? ApiKey { get; set; }

    public string? ApiSecret { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }
}
