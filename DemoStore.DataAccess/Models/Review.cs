using System;
using System.Collections.Generic;

namespace DemoStore.DataAccess.Models;

public partial class Review
{
    public long Id { get; set; }

    public int? UserId { get; set; }

    public int? ProductId { get; set; }

    public decimal? Rating { get; set; }

    public string? Comment { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public int? OrderItemId { get; set; }

    public DateTime? DeletedAt { get; set; }
}
