using System;
using System.Collections.Generic;

namespace DemoStore.DataAccess.Models;

public partial class ActiveAdminComment
{
    public long Id { get; set; }

    public string? Namespace { get; set; }

    public string? Body { get; set; }

    public string? ResourceType { get; set; }

    public int? ResourceId { get; set; }

    public string? AuthorType { get; set; }

    public int? AuthorId { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }
}
