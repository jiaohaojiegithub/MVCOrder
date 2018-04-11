namespace MVCOrder.Models.YKT
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class kq_workQueueH
    {
        public int ID { get; set; }

        public DateTime? wrkDate { get; set; }

        public int? deptNo { get; set; }

        public int? wrkNo { get; set; }

        public int? wrkType { get; set; }

        public int? IsHoliday { get; set; }

        public DateTime? wrkStart1 { get; set; }

        public DateTime? wrkEnd1 { get; set; }

        public DateTime? wrkStart2 { get; set; }

        public DateTime? wrkEnd2 { get; set; }

        public DateTime? wrkStart3 { get; set; }

        public DateTime? wrkEnd3 { get; set; }
    }
}
