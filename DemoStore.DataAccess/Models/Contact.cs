using System;
using System.Collections.Generic;

namespace DemoStore.DataAccess.Models;

public partial class Contact
{
    public long Id { get; set; }

    public string? Name { get; set; }

    public string? Email { get; set; }

    public string? FullPhoneNumber { get; set; }

    public string? Message { get; set; }

    public int? UserId { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }
}
