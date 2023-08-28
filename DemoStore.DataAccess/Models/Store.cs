using System;
using System.Collections.Generic;

namespace DemoStore.DataAccess.Models;

public partial class Store
{
    public long Id { get; set; }

    public string? Name { get; set; }

    public string? Subdomain { get; set; }

    public string? Email { get; set; }

    public long? Phone { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public long? SubscriptionPlanId { get; set; }
}
