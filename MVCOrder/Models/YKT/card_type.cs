namespace MVCOrder.Models.YKT
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class card_type
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int card_tid { get; set; }

        [StringLength(30)]
        public string card_tname { get; set; }

        [StringLength(50)]
        public string card_showname { get; set; }
    }
}
