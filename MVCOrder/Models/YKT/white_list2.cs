namespace MVCOrder.Models.YKT
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class white_list2
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int devID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int card_no { get; set; }

        public int? status { get; set; }

        public DateTime? bDate { get; set; }

        public DateTime? eDate { get; set; }

        public int? TimeNo { get; set; }

        [StringLength(10)]
        public string Pwd { get; set; }

        public DateTime? FxDate { get; set; }
    }
}
