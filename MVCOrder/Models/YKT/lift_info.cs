namespace MVCOrder.Models.YKT
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class lift_info
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int lift_no { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string lift_name { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int totalFloor { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(30)]
        public string lift_type { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int startFloor { get; set; }

        [StringLength(50)]
        public string bureau_no { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(30)]
        public string controlfloor { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int flag { get; set; }
    }
}
