namespace MVCOrder.Models.YKT
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Park_Auto_Pay_Record
    {
        [StringLength(21)]
        public string serial_number { get; set; }

        public int? device_ID { get; set; }

        public int? pay_teminal { get; set; }

        [StringLength(50)]
        public string card_no { get; set; }

        public DateTime? inPark_time { get; set; }

        public DateTime? outPark_time { get; set; }

        [StringLength(50)]
        public string pay_type { get; set; }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int deserve_money { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int real_money { get; set; }

        public int? dispense_money { get; set; }

        public int? operate_flag { get; set; }

        [Key]
        [Column(Order = 2)]
        public DateTime operate_time { get; set; }

        [StringLength(100)]
        public string remark { get; set; }
    }
}
