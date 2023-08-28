using System;
using System.Collections.Generic;

namespace DemoStore.DataAccess.Models;

public partial class Subscription
{
    public long Id { get; set; }

    public long? SubscriptionPlanId { get; set; }

    public long? StoreDetailId { get; set; }

    public string? RazorpaySubsId { get; set; }

    public string? RazorpayPaymentId { get; set; }

    public DateOnly? StartAt { get; set; }

    public DateOnly? ExpireAt { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public string? Status { get; set; }
}
