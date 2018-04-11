namespace MVCOrder.Models.YKT
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SystemSet")]
    public partial class SystemSet
    {
        [StringLength(200)]
        public string UnitName { get; set; }

        [Key]
        [StringLength(10)]
        public string Mode { get; set; }
    }
}
