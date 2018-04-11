namespace MVCOrder.Models.YKT
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class M_ControlDefine
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SN { get; set; }

        public int? ControlNo { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(2)]
        public string ReadNo { get; set; }

        [StringLength(50)]
        public string DoorName { get; set; }

        [StringLength(15)]
        public string IP { get; set; }

        [StringLength(10)]
        public string Port { get; set; }

        [StringLength(1)]
        public string Watch { get; set; }

        public int xPos { get; set; }

        public int yPos { get; set; }

        public int IsKq { get; set; }

        public int? StallNO { get; set; }

        public int? Type { get; set; }

        [StringLength(50)]
        public string Pwd { get; set; }

        public int id { get; set; }

        public int? BelongToSN { get; set; }

        [StringLength(50)]
        public string op_name { get; set; }
    }
}
