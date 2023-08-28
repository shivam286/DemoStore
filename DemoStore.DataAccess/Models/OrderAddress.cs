using System;
using System.Collections.Generic;

namespace DemoStore.DataAccess.Models;

public partial class OrderAddress
{
    public long Id { get; set; }

    public int? OrderId { get; set; }

    public string? FullName { get; set; }

    public string? MobileNumber { get; set; }

    public string? Pincode { get; set; }

    public string? AddressLine1 { get; set; }

    public string? AddressLine2 { get; set; }

    public string? Landmark { get; set; }

    public string? City { get; set; }

    public string? State { get; set; }

    public string? Country { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public int? StateId { get; set; }
}
