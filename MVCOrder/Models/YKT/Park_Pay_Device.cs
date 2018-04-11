namespace MVCOrder.Models.YKT
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Park_Pay_Device
    {
        [Key]
        public int device_ID { get; set; }

        [StringLength(50)]
        public string device_name { get; set; }

        [StringLength(50)]
        public string device_title { get; set; }

        [StringLength(50)]
        public string device_type { get; set; }

        [StringLength(15)]
        public string device_IP { get; set; }

        public int? income_money { get; set; }

        public int? cash_count { get; set; }

        public int? ten_count { get; set; }

        public int? twenty_count { get; set; }

        public int? coin_count { get; set; }

        [StringLength(100)]
        public string remark { get; set; }
    }
}
