using System;
using System.Collections.Generic;

namespace DemoStore.DataAccess.Models;

public partial class OrderItem
{
    public long Id { get; set; }

    public int? OrderId { get; set; }

    public string? ProductName { get; set; }

    public decimal? UnitPrice { get; set; }

    public int? Quantity { get; set; }

    public decimal? TotalPrice { get; set; }

    public long? ProductableId { get; set; }

    public string? ProductableType { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public decimal? TaxAmount { get; set; }

    public decimal? PriceWithoutTax { get; set; }
}
