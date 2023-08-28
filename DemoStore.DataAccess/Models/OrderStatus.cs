using System;
using System.Collections.Generic;

namespace DemoStore.DataAccess.Models;

public partial class OrderStatus
{
    public long Id { get; set; }

    public string? Name { get; set; }

    public string? DisplayName { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }
}
