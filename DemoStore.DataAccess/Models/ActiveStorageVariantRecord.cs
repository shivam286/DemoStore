using System;
using System.Collections.Generic;

namespace DemoStore.DataAccess.Models;

public partial class ActiveStorageVariantRecord
{
    public long Id { get; set; }

    public long BlobId { get; set; }

    public string VariationDigest { get; set; } = null!;

    public virtual ActiveStorageBlob Blob { get; set; } = null!;
}
