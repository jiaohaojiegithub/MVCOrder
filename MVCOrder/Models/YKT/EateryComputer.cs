namespace MVCOrder.Models.YKT
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EateryComputer")]
    public partial class EateryComputer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CmpNo { get; set; }

        [StringLength(50)]
        public string CmpName { get; set; }

        public int? ComPort { get; set; }

        [StringLength(50)]
        public string Remark { get; set; }

        public DateTime? CreateDT { get; set; }

        [Column("operator")]
        [StringLength(10)]
        public string _operator { get; set; }
    }
}
