using System;
using System.Collections.Generic;

namespace DemoStore.DataAccess.Models;

public partial class Coupon
{
    public long Id { get; set; }

    public string? Name { get; set; }

    public string? Code { get; set; }

    public int? CouponType { get; set; }

    public string? Amount { get; set; }

    public string? Description { get; set; }

    public int? UsageLimit { get; set; }

    public int? UsageCount { get; set; }

    public DateTime? StartAt { get; set; }

    public DateTime? ExpireAt { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public int? PerUserUsage { get; set; }

    public decimal? MinCartValue { get; set; }

    public decimal? MaxCartValue { get; set; }

    public long? PosUserId { get; set; }

    public virtual PosUser? PosUser { get; set; }
}
