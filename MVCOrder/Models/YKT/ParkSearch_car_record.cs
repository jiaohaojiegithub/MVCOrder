namespace MVCOrder.Models.YKT
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ParkSearch_car_record
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int devID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(40)]
        public string devName { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(15)]
        public string plateName { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(15)]
        public string devIP { get; set; }

        [StringLength(100)]
        public string smallPicPath { get; set; }

        [StringLength(100)]
        public string picPath { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int areaID { get; set; }

        [Key]
        [Column(Order = 5)]
        public DateTime stamp { get; set; }

        public bool? inPark { get; set; }

        public bool? newFlag { get; set; }

        [StringLength(250)]
        public string Remark { get; set; }
    }
}
