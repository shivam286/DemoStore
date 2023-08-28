using System;
using System.Collections.Generic;

namespace DemoStore.DataAccess.Models;

public partial class City
{
    public long Id { get; set; }

    public string? Name { get; set; }

    public int? StateId { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }
}
