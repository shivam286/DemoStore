using System;
using System.Collections.Generic;

namespace DemoStore.DataAccess.Models;

public partial class Payment
{
    public long Id { get; set; }

    public int? OrderId { get; set; }

    public decimal? Amount { get; set; }

    public string? PaymentMethod { get; set; }

    public string? TransactionId { get; set; }

    public string? Status { get; set; }

    public DateTime? CompletedAt { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public string? PaymentMerchant { get; set; }
}
