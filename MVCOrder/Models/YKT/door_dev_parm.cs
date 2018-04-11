namespace MVCOrder.Models.YKT
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class door_dev_parm
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int dev_id { get; set; }

        public int? left_rec_alarm { get; set; }

        public int? open_door_delay { get; set; }

        public int? buzzer { get; set; }

        public int? open_mode { get; set; }

        public int? multi_interval { get; set; }

        public int? multi_num { get; set; }

        public int? fire_alarm { get; set; }

        public int? fire_delay { get; set; }

        public int? riot_alarm { get; set; }

        public int? riot_delay { get; set; }

        public int? riot_close { get; set; }

        public int? riot_card { get; set; }

        public int? magnet { get; set; }

        public int? close_delay1 { get; set; }

        public int? close_delay2 { get; set; }

        public int? work_mode { get; set; }

        public int? isdeleted { get; set; }

        public int? doors { get; set; }
    }
}
