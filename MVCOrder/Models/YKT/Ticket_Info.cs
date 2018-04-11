namespace MVCOrder.Models.YKT
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Ticket_Info
    {
        public long? ID { get; set; }

        [StringLength(80)]
        public string qp_Code { get; set; }

        public DateTime? use_Time { get; set; }

        [StringLength(20)]
        public string vip_Code { get; set; }

        [StringLength(20)]
        public string merchant { get; set; }

        [StringLength(20)]
        public string ticket_Number { get; set; }

        public decimal? money { get; set; }

        public int? point { get; set; }

        public decimal? deductible_money { get; set; }

        public int? deductible_mode { get; set; }

        [Key]
        public DateTime create_Time { get; set; }
    }
}
