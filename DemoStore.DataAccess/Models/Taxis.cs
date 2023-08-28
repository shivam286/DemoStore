using System;
using System.Collections.Generic;

namespace DemoStore.DataAccess.Models;

public partial class Taxis
{
    public long Id { get; set; }

    public decimal? TaxPercentage { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }
}
