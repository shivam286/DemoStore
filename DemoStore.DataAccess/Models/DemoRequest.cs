using System;
using System.Collections.Generic;

namespace DemoStore.DataAccess.Models;

public partial class DemoRequest
{
    public long Id { get; set; }

    public string? Name { get; set; }

    public string? MobileNumber { get; set; }

    public string? BuisnessName { get; set; }

    public string? City { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }
}
