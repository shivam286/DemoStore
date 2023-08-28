using System;
using System.Collections.Generic;

namespace DemoStore.DataAccess.Models;

public partial class Order
{
    public long Id { get; set; }

    public int? UserId { get; set; }

    public string? Status { get; set; }

    public decimal? TotalTax { get; set; }

    public decimal? ShippingCharge { get; set; }

    public decimal? SubTotal { get; set; }

    public decimal? Total { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public decimal? AppliedDiscount { get; set; }

    public int? CouponId { get; set; }

    public string? TransactionId { get; set; }

    public string? CartId { get; set; }

    public string? PaymentId { get; set; }

    public string? PaymentMethod { get; set; }

    public decimal? TotalWithTax { get; set; }

    public string? ShippmentId { get; set; }

    public int? Length { get; set; }

    public int? Breadth { get; set; }

    public int? Height { get; set; }

    public decimal? Weight { get; set; }

    public string? Awb { get; set; }

    public DateTime? PlacedAt { get; set; }

    public DateTime? ConfirmedAt { get; set; }

    public DateTime? CancelledAt { get; set; }

    public DateTime? ShippedAt { get; set; }

    public DateTime? OutForDeliveryAt { get; set; }

    public DateTime? DeliveredAt { get; set; }

    public DateTime? ReturnedAt { get; set; }

    public DateTime? RefundedAt { get; set; }

    public long? PosUserId { get; set; }

    public bool? PosOrder { get; set; }

    public long? AdminUserId { get; set; }

    public decimal? DiscountPercent { get; set; }

    public string? PaymentMerchant { get; set; }

    public decimal? DueAmount { get; set; }

    public string? DiscountType { get; set; }

    public virtual AdminUser? AdminUser { get; set; }

    public virtual PosUser? PosUser { get; set; }
}
