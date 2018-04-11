namespace MVCOrder.Models.YKT
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class door_card_make
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int card_no { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int cust_no { get; set; }

        public int? CardState { get; set; }

        public DateTime? bDate { get; set; }

        public DateTime? eDate { get; set; }

        [StringLength(3)]
        public string TimeNo { get; set; }

        [StringLength(256)]
        public string MachNo { get; set; }

        [StringLength(256)]
        public string DownMachNo { get; set; }

        public DateTime? FxDate { get; set; }
    }
}
