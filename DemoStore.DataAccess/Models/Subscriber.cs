using System;
using System.Collections.Generic;

namespace DemoStore.DataAccess.Models;

public partial class Subscriber
{
    public long Id { get; set; }

    public string? Email { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }
}
