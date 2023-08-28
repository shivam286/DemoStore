using System;
using System.Collections.Generic;

namespace DemoStore.DataAccess.Models;

public partial class State
{
    public long Id { get; set; }

    public string? Name { get; set; }

    public string? Code { get; set; }

    public string? GstCode { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }
}
