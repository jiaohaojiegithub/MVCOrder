namespace MVCOrder.Models.YKT
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EateryLevelSet")]
    public partial class EateryLevelSet
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int LevelNo { get; set; }

        [StringLength(20)]
        public string LevelName { get; set; }

        public int? MaxCnt { get; set; }

        public int? MaxAmt { get; set; }

        public int? Percent { get; set; }

        public int? ISOverMaxAmt { get; set; }

        public int? state { get; set; }

        public int? breakTimes { get; set; }

        public int? lunchTimes { get; set; }

        public int? supperTimes { get; set; }

        public int? nightTimes { get; set; }

        public decimal? amt1 { get; set; }

        public decimal? amt2 { get; set; }

        public decimal? amt3 { get; set; }

        public decimal? amt4 { get; set; }

        public decimal? fee1 { get; set; }

        public decimal? fee2 { get; set; }

        public decimal? fee3 { get; set; }

        public decimal? fee4 { get; set; }
    }
}
