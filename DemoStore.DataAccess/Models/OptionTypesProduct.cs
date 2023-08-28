using System;
using System.Collections.Generic;

namespace DemoStore.DataAccess.Models;

public partial class OptionTypesProduct
{
    public long Id { get; set; }

    public int? ProductId { get; set; }

    public int? OptionTypeId { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }
}
