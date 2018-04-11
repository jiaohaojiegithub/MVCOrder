namespace MVCOrder.Models.YKT
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("wkczyq")]
    public partial class wkczyq
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int cardno { get; set; }

        public int? address { get; set; }

        public int? card_type { get; set; }

        [Column(TypeName = "money")]
        public decimal? balance { get; set; }

        public DateTime? startdate { get; set; }

        public DateTime? enddate { get; set; }

        public int? downloadflag { get; set; }
    }
}
