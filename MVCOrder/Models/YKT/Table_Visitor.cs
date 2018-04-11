namespace MVCOrder.Models.YKT
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Table_Visitor
    {
        public int card_no { get; set; }

        public int status { get; set; }

        public int card_type { get; set; }

        [Key]
        [Column(Order = 0)]
        [StringLength(15)]
        public string carno { get; set; }

        public int car_type { get; set; }

        [Required]
        [StringLength(20)]
        public string cust_name { get; set; }

        [Key]
        [Column(Order = 1)]
        public DateTime validdt { get; set; }

        public int park_stall { get; set; }

        [Required]
        [StringLength(255)]
        public string matchDevStr { get; set; }

        [Key]
        [Column(Order = 2)]
        public DateTime parkStartDT { get; set; }

        [StringLength(20)]
        public string passcode { get; set; }

        [StringLength(20)]
        public string visitor_desc { get; set; }

        [StringLength(60)]
        public string cid { get; set; }

        [StringLength(50)]
        public string block_name { get; set; }

        [StringLength(20)]
        public string plate_number { get; set; }

        [StringLength(20)]
        public string password { get; set; }

        [StringLength(20)]
        public string arrive_at { get; set; }

        [StringLength(20)]
        public string leave_at { get; set; }
    }
}
