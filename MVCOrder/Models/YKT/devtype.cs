namespace MVCOrder.Models.YKT
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("devtype")]
    public partial class devtype
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int dev_tid { get; set; }

        [StringLength(30)]
        public string dev_tname { get; set; }
    }
}
