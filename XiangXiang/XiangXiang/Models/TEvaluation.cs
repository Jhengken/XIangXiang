using System;
using System.Collections.Generic;

namespace XiangXiang.Models
{
    public partial class TEvaluation
    {
        public int EvaluationId { get; set; }
        public int? CustomerId { get; set; }
        public int? RoomId { get; set; }
        public DateTime? Date { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? Response { get; set; }
        public int? Star { get; set; }

        public virtual TCustomer? Customer { get; set; }
        public virtual TPsiteRoom? Room { get; set; }
    }
}
