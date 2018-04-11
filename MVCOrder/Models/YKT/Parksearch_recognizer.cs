namespace MVCOrder.Models.YKT
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Parksearch_recognizer
    {
        [Key]
        [Column(Order = 0)]
        public int devID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string devName { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string devIP { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int areaID { get; set; }

        [StringLength(50)]
        public string fixLocation { get; set; }

        [StringLength(250)]
        public string Remark { get; set; }
    }
}
