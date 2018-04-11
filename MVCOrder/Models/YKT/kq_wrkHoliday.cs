namespace MVCOrder.Models.YKT
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class kq_wrkHoliday
    {
        public int ID { get; set; }

        public int? deptNo { get; set; }

        public DateTime? Holiday { get; set; }

        public int? IsHoliday { get; set; }

        [StringLength(10)]
        public string Operator { get; set; }

        public DateTime? createDT { get; set; }

        [StringLength(100)]
        public string Remark { get; set; }
    }
}
