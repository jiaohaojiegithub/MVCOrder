namespace MVCOrder.Models.YKT
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ParkSearch_map
    {
        [Key]
        [Column(Order = 0)]
        public int mapID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(40)]
        public string mapName { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(250)]
        public string mapPath { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int devID { get; set; }
    }
}
