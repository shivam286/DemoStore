using System;
using System.Collections.Generic;

namespace DemoStore.DataAccess.Models;

public partial class EmailTemplate
{
    public long Id { get; set; }

    public string? Subject { get; set; }

    public string? Body { get; set; }

    public string? TemplateName { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }
}
