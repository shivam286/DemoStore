using System;
using System.Collections.Generic;

namespace DemoStore.DataAccess.Models;

public partial class Wishlist
{
    public long Id { get; set; }

    public long? UserId { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public long? PosUserId { get; set; }

    public virtual PosUser? PosUser { get; set; }
}
