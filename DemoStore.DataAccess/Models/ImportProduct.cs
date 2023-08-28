using System;
using System.Collections.Generic;

namespace DemoStore.DataAccess.Models;

public partial class ImportProduct
{
    public long Id { get; set; }

    public int? Status { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }
}
