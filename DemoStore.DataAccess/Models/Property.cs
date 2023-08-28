using System;
using System.Collections.Generic;

namespace DemoStore.DataAccess.Models;

public partial class Property
{
    public long Id { get; set; }

    public string? Name { get; set; }

    public string? Value { get; set; }

    public bool? ShowProperty { get; set; }

    public int? ProductId { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }
}
