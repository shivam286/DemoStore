using System;
using System.Collections.Generic;

namespace DemoStore.DataAccess.Models;

public partial class BannerItem
{
    public long Id { get; set; }

    public int? BannerId { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }
}
