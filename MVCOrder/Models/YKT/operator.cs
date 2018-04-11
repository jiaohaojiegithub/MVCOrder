namespace MVCOrder.Models.YKT
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("operator")]
    public partial class _operator
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int op_code { get; set; }

        [StringLength(10)]
        public string op_name { get; set; }

        [StringLength(20)]
        public string op_pass { get; set; }

        public int? op_cardno { get; set; }

        [StringLength(60)]
        public string remark { get; set; }

        [StringLength(10)]
        public string creator { get; set; }

        public DateTime? creatdt { get; set; }

        public int? deptno { get; set; }
    }
}
