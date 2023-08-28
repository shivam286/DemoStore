using System;
using System.Collections.Generic;

namespace DemoStore.DataAccess.Models;

public partial class StoreDetail
{
    public long Id { get; set; }

    public string? StoreName { get; set; }

    public string? Subdomain { get; set; }

    public string? Phone { get; set; }

    public int? AdminUserId { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public string? RazorpayCustId { get; set; }

    public int? OrderBalance { get; set; }

    public DateOnly? SubscriptionDate { get; set; }
}
