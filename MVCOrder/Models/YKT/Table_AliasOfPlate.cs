namespace MVCOrder.Models.YKT
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Table_AliasOfPlate
    {
        [Key]
        [StringLength(50)]
        public string Alias { get; set; }
    }
}
