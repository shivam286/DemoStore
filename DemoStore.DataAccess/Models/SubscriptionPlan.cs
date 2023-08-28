using System;
using System.Collections.Generic;

namespace DemoStore.DataAccess.Models;

public partial class SubscriptionPlan
{
    public long Id { get; set; }

    public string? PlanName { get; set; }

    public string? Description { get; set; }

    public string? Period { get; set; }

    public int? BillingCycle { get; set; }

    public double? Amount { get; set; }

    public string? RazorpayPlanId { get; set; }

    public bool? Active { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public int? OrdersAllowed { get; set; }
}
