using System;
using System.Collections.Generic;

namespace DemoStore.DataAccess.Models;

public partial class SchemaMigration
{
    public string Version { get; set; } = null!;
}
