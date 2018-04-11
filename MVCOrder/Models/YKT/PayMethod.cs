namespace MVCOrder.Models.YKT
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PayMethod")]
    public partial class PayMethod
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string Name { get; set; }

        [Key]
        [Column(Order = 1)]
        public bool Support { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TimeOut { get; set; }

        [StringLength(500)]
        public string CloudRootAddress { get; set; }

        [StringLength(50)]
        public string CloudInOperate { get; set; }

        [StringLength(50)]
        public string CloudOutOperate { get; set; }

        [StringLength(50)]
        public string CloudQueryPay { get; set; }

        [StringLength(50)]
        public string CloudSyncData { get; set; }

        public int? NetworkTO { get; set; }

        public int? Priority { get; set; }
    }
}
