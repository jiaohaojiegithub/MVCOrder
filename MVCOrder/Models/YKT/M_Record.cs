namespace MVCOrder.Models.YKT
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class M_Record
    {
        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string CardNo { get; set; }

        [StringLength(50)]
        public string Cust_nick { get; set; }

        [StringLength(50)]
        public string Cust_name { get; set; }

        [Required]
        [StringLength(100)]
        public string State { get; set; }

        [Required]
        [StringLength(50)]
        public string SN { get; set; }

        [Required]
        [StringLength(50)]
        public string ControlNo { get; set; }

        [Required]
        [StringLength(50)]
        public string ReadNo { get; set; }

        [Required]
        [StringLength(50)]
        public string DoorName { get; set; }

        public DateTime KaiTime { get; set; }
    }
}
