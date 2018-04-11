namespace MVCOrder.Models.YKT
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EateryDeviceTime")]
    public partial class EateryDeviceTime
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DevNo { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string DayName { get; set; }

        public DateTime? StartDT { get; set; }

        public DateTime? EndDT { get; set; }

        [StringLength(5)]
        public string Start1 { get; set; }

        [StringLength(5)]
        public string End1 { get; set; }

        [StringLength(5)]
        public string Start2 { get; set; }

        [StringLength(5)]
        public string End2 { get; set; }

        [StringLength(5)]
        public string Start3 { get; set; }

        [StringLength(5)]
        public string End3 { get; set; }

        [StringLength(5)]
        public string Start4 { get; set; }

        [StringLength(5)]
        public string End4 { get; set; }

        [StringLength(5)]
        public string Start5 { get; set; }

        [StringLength(5)]
        public string End5 { get; set; }

        [StringLength(5)]
        public string Start6 { get; set; }

        [StringLength(5)]
        public string End6 { get; set; }

        [StringLength(5)]
        public string Start7 { get; set; }

        [StringLength(5)]
        public string End7 { get; set; }

        public int? DayNumber { get; set; }
    }
}
