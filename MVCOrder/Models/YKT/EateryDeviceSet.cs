namespace MVCOrder.Models.YKT
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EateryDeviceSet")]
    public partial class EateryDeviceSet
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DevNo { get; set; }

        public int? MaxAmt { get; set; }

        public int? MinAmt { get; set; }

        public int? DelayTime { get; set; }

        public int? ISDevTime { get; set; }

        public int? ISOpenDev { get; set; }

        public int? ISOverMaxAmt { get; set; }

        public int? ISOverBlance { get; set; }
    }
}
