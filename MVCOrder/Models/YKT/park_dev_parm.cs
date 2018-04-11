namespace MVCOrder.Models.YKT
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class park_dev_parm
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int dev_id { get; set; }

        [StringLength(4)]
        public string sysflag { get; set; }

        [StringLength(4)]
        public string commpass { get; set; }

        [StringLength(6)]
        public string syspass { get; set; }

        [StringLength(6)]
        public string userpass { get; set; }

        public int? card_left { get; set; }

        public int? stall_num { get; set; }

        public int? user_info { get; set; }

        public int? disp_delay { get; set; }

        public int? temp_card { get; set; }

        public int? currency { get; set; }

        public int? in_overflow { get; set; }

        public int? ext_dev { get; set; }

        public int? allow_go { get; set; }

        public int? dev_attr { get; set; }

        public int? stall_in_use { get; set; }

        public int? allow_card { get; set; }

        public int? gate_select { get; set; }

        public int? valid_days { get; set; }

        public int? balance_left { get; set; }

        public int? united_charge { get; set; }

        public int? inout { get; set; }

        public int? offline { get; set; }

        [StringLength(10)]
        public string light { get; set; }

        public int? reserve_num { get; set; }
    }
}
