using System;
using System.Collections.Generic;

namespace DemoStore.DataAccess.Models;

public partial class Cart
{
    public long Id { get; set; }

    public decimal? SubTotal { get; set; }

    public decimal? Total { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public int? AddressId { get; set; }

    public decimal? TotalTax { get; set; }

    public decimal? ShippingCharge { get; set; }

    public decimal? AppliedDiscount { get; set; }

    public int? CouponId { get; set; }

    public string? CartToken { get; set; }

    public string? TransactionId { get; set; }

    public decimal? TotalWithTax { get; set; }

    public string? CartableType { get; set; }

    public long? CartableId { get; set; }

    public long? UserId { get; set; }

    public decimal? DiscountPercent { get; set; }

    public string? DiscountType { get; set; }

    public decimal? TotalWithoutDiscount { get; set; }

    public virtual User? User { get; set; }
}
