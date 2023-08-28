using System;
using System.Collections.Generic;

namespace DemoStore.DataAccess.Models;

public partial class OptionValuesVariant
{
    public long Id { get; set; }

    public int? OptionValueId { get; set; }

    public int? VariantId { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }
}
