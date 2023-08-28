using System;
using System.Collections.Generic;

namespace DemoStore.DataAccess.Models;

public partial class ShipRocketRaw
{
    public long Id { get; set; }

    public string? Payload { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }
}
