namespace MVCOrder.Models.YKT
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class park_card_make
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int card_no { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int cust_no { get; set; }

        public int? card_type { get; set; }

        public int? car_type { get; set; }

        public int? car_color { get; set; }

        [StringLength(15)]
        public string carno { get; set; }

        public int? park { get; set; }

        public int? park_stall { get; set; }

        public int? park_stall1 { get; set; }

        public int? park_stall2 { get; set; }

        public int? timesec { get; set; }

        [StringLength(60)]
        public string remark { get; set; }

        [StringLength(255)]
        public string matchDevStr { get; set; }
    }
}
