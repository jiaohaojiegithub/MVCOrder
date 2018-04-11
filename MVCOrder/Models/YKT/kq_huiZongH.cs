namespace MVCOrder.Models.YKT
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class kq_huiZongH
    {
        public int ID { get; set; }

        public int? riqi { get; set; }

        public int? custNo { get; set; }

        public int? deptNO { get; set; }

        public int? wrkNO { get; set; }

        public int? actDays { get; set; }

        public int? wrkDays { get; set; }

        public int? ciDao { get; set; }

        public int? zaoTui { get; set; }

        public int? JiaBan { get; set; }

        public int? kuangGong { get; set; }

        public int? qinJia { get; set; }

        public int? chuCai { get; set; }

        public int? ciDao2 { get; set; }

        public int? zaoTui2 { get; set; }

        public int? kuangGong2 { get; set; }
    }
}
