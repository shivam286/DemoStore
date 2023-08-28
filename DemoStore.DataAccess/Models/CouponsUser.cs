using System;
using System.Collections.Generic;

namespace DemoStore.DataAccess.Models;

public partial class CouponsUser
{
    public long? UserId { get; set; }

    public long? CouponId { get; set; }
}
