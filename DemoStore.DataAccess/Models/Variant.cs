using System;
using System.Collections.Generic;

namespace DemoStore.DataAccess.Models;

public partial class Variant
{
    public long Id { get; set; }

    public string? Sku { get; set; }

    public string? HsnCode { get; set; }

    public decimal? SellPrice { get; set; }

    public decimal? ComparePrice { get; set; }

    public decimal? CostPrice { get; set; }

    public int? ProductId { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public int? StockQty { get; set; }

    public decimal? TaxAmount { get; set; }

    public decimal? PriceWithTax { get; set; }

    public decimal? PriceWithoutTax { get; set; }

    public string? BarCode { get; set; }

    public DateTime? DeletedAt { get; set; }
}
