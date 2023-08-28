using System;
using System.Collections.Generic;

namespace DemoStore.DataAccess.Models;

public partial class CategoriesProduct
{
    public long Id { get; set; }

    public long? CategoryId { get; set; }

    public long? ProductId { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }
}
