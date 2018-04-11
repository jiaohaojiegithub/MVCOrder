namespace MVCOrder.Models.YKT
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class kq_dept
    {
        [Key]
        public int deptNo { get; set; }

        public int? parentNo { get; set; }

        [StringLength(20)]
        public string deptName { get; set; }
    }
}
