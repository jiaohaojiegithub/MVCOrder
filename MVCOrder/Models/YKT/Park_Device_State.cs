namespace MVCOrder.Models.YKT
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Park_Device_State
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int device_ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string Printer { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string scanner { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(50)]
        public string cashIn { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(50)]
        public string cashOut { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(50)]
        public string coinIn { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(50)]
        public string coinOut { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(50)]
        public string cardRead { get; set; }
    }
}
