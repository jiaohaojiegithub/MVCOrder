namespace MVCOrder.Models.YKT
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("subsystem")]
    public partial class subsystem
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int systemid { get; set; }

        [StringLength(4)]
        public string sysflag { get; set; }

        [StringLength(4)]
        public string commpass { get; set; }

        [StringLength(6)]
        public string syspass { get; set; }

        [StringLength(6)]
        public string userpass { get; set; }

        public int? accesstype { get; set; }

        public int? cardarea1 { get; set; }

        public int? cardarea2 { get; set; }
    }
}
