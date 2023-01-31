using System;
using System.Collections.Generic;

namespace XiangXiang.Models
{
    public partial class TCorderDetail
    {
        public int OrderId { get; set; }
        public int? CouponId { get; set; }
        public int? RoomId { get; set; }
        public decimal? Price { get; set; }

        public virtual TCoupon? Coupon { get; set; }
        public virtual TPsiteRoom? Room { get; set; }
    }
}
