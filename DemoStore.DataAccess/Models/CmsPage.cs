using System;
using System.Collections.Generic;

namespace DemoStore.DataAccess.Models;

public partial class CmsPage
{
    public long Id { get; set; }

    public string? Title { get; set; }

    public string? Slug { get; set; }

    public string? Content { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }
}
