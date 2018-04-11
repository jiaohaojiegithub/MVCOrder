namespace MVCOrder.Models.YKT
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class kq_deptWork
    {
        public int ID { get; set; }

        public int? deptNo { get; set; }

        public int? wrkNo { get; set; }
    }
}
