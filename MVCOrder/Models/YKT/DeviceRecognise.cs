namespace MVCOrder.Models.YKT
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DeviceRecognise")]
    public partial class DeviceRecognise
    {
        public int ID { get; set; }

        [StringLength(50)]
        public string Name { get; set; }
    }
}
