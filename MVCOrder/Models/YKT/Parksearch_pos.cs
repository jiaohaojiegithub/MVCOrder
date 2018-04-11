namespace MVCOrder.Models.YKT
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Parksearch_pos
    {
        [Key]
        [Column(Order = 0)]
        public int posID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string posName { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(15)]
        public string posIP { get; set; }

        public int? xPos { get; set; }

        public int? yPos { get; set; }

        [StringLength(250)]
        public string areaMapPath { get; set; }

        [StringLength(250)]
        public string Rermark { get; set; }
    }
}
