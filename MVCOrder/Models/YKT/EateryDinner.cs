namespace MVCOrder.Models.YKT
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EateryDinner")]
    public partial class EateryDinner
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DinNo { get; set; }

        [StringLength(30)]
        public string DinName { get; set; }

        [Column("operator")]
        [StringLength(10)]
        public string _operator { get; set; }

        public DateTime? CreateDT { get; set; }

        [StringLength(50)]
        public string remark { get; set; }
    }
}
