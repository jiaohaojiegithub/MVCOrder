namespace MVCOrder.Models.YKT
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EateryWhitelist")]
    public partial class EateryWhitelist
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int devNo { get; set; }

        [StringLength(50)]
        public string cust_name { get; set; }

        public int? LevelNo { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int card_no { get; set; }

        public int? cust_no { get; set; }

        public decimal? balance { get; set; }

        public DateTime? validdt { get; set; }

        public DateTime? createdt { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int status { get; set; }

        public int? flag { get; set; }
    }
}
