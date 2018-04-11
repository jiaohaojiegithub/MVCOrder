namespace MVCOrder.Models.YKT
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EateryDinnerAdd")]
    public partial class EateryDinnerAdd
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public int? DinNo { get; set; }

        [StringLength(10)]
        public string DayName { get; set; }

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

        public decimal? BreakfastAmt { get; set; }

        public decimal? LunchAmt { get; set; }

        public decimal? SupperAmt { get; set; }

        [Column("operator")]
        [StringLength(10)]
        public string _operator { get; set; }

        public DateTime? createdt { get; set; }

        [StringLength(5)]
        public string Start4 { get; set; }

        [StringLength(5)]
        public string End4 { get; set; }

        public decimal? NightAmt { get; set; }
    }
}
