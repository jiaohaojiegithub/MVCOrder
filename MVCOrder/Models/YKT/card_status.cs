namespace MVCOrder.Models.YKT
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class card_status
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int card_tid { get; set; }

        [StringLength(50)]
        public string card_statusname { get; set; }
    }
}
