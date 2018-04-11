namespace MVCOrder.Models.YKT
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EateryCustLevel")]
    public partial class EateryCustLevel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CustNo { get; set; }

        public int LevelNo { get; set; }

        public int AccessMode { get; set; }

        [Required]
        [StringLength(400)]
        public string dinner { get; set; }

        [StringLength(400)]
        public string MatchDevStr { get; set; }
    }
}
