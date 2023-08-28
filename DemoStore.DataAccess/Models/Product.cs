using System;
using System.Collections.Generic;

namespace DemoStore.DataAccess.Models;

public partial class Product
{
    public long Id { get; set; }

    public string? Name { get; set; }

    public decimal? SellPrice { get; set; }

    public decimal? ComparePrice { get; set; }

    public decimal? CostPrice { get; set; }

    public string? Description { get; set; }

    public string? HsnCode { get; set; }

    public string? Sku { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public int? BrandId { get; set; }

    public int? StockQty { get; set; }

    public int? TaxId { get; set; }

    public int? TaxType { get; set; }

    public decimal? TaxAmount { get; set; }

    public decimal? PriceWithTax { get; set; }

    public decimal? PriceWithoutTax { get; set; }

    public decimal? AverageRating { get; set; }

    public string? BarCode { get; set; }

    public DateTime? DeletedAt { get; set; }
}
