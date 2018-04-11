namespace MVCOrder.Models.YKT
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EateryDevice")]
    public partial class EateryDevice
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DevNo { get; set; }

        public int? CmpNo { get; set; }

        public int? DinNo { get; set; }

        [StringLength(30)]
        public string DevName { get; set; }

        public int? DevType { get; set; }

        public int? DevAddr { get; set; }

        [StringLength(50)]
        public string Remark { get; set; }

        public DateTime? CreateDT { get; set; }

        [Column("operator")]
        [StringLength(10)]
        public string _operator { get; set; }

        [StringLength(16)]
        public string devIP { get; set; }
    }
}
