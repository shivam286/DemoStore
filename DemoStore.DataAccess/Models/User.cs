using System;
using System.Collections.Generic;

namespace DemoStore.DataAccess.Models;

public partial class User
{
    public long Id { get; set; }

    public string? Email { get; set; }

    public string? PasswordDigest { get; set; }

    public string? FullPhoneNumber { get; set; }

    public bool? Activated { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public string? Pin { get; set; }

    public string? Name { get; set; }

    public string? StripeId { get; set; }

    public DateTime? PasswordResetSentAt { get; set; }

    public virtual ICollection<Cart> Carts { get; set; } = new List<Cart>();
}
