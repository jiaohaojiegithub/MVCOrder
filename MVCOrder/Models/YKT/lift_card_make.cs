namespace MVCOrder.Models.YKT
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class lift_card_make
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int card_no { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int cust_no { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int card_tid { get; set; }

        [StringLength(30)]
        public string door_no { get; set; }

        [StringLength(30)]
        public string room_no { get; set; }

        public int? calltype { get; set; }

        [StringLength(30)]
        public string allowlift { get; set; }

        [StringLength(168)]
        public string allowfloor { get; set; }

        [StringLength(30)]
        public string allowlift2 { get; set; }

        [StringLength(168)]
        public string allowfloor2 { get; set; }

        [StringLength(30)]
        public string allowlift3 { get; set; }

        [StringLength(168)]
        public string allowfloor3 { get; set; }

        public decimal? floorPrice { get; set; }

        public DateTime? startDate { get; set; }

        public DateTime? endDate { get; set; }

        public DateTime? startTime { get; set; }

        public DateTime? endTime { get; set; }

        [StringLength(7)]
        public string weekStr { get; set; }

        public int? allowNumber { get; set; }
    }
}
