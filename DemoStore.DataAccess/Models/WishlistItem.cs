using System;
using System.Collections.Generic;

namespace DemoStore.DataAccess.Models;

public partial class WishlistItem
{
    public long Id { get; set; }

    public long? WishlistId { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public int? ProductId { get; set; }

    public DateTime? DeletedAt { get; set; }
}
