using System;
using System.Collections.Generic;

namespace DemoStore.DataAccess.Models;

public partial class SubCategory
{
    public long Id { get; set; }

    public string? Name { get; set; }

    public int? CategoryId { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }
}
