using System;
using System.Collections.Generic;

namespace DemoStore.DataAccess.Models;

public partial class AraskJob
{
    public long Id { get; set; }

    public string? Job { get; set; }

    public DateTime? ExecuteAt { get; set; }

    public string? Interval { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }
}
