namespace MVCOrder.Models.YKT
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class kq_mingXiH
    {
        public int ID { get; set; }

        public DateTime? wrkDate { get; set; }

        public int? deptNo { get; set; }

        public int? custNo { get; set; }

        public int? wrkNo { get; set; }

        public int? wrkType { get; set; }

        public int? IsHoliday { get; set; }

        public DateTime? wrkStart1 { get; set; }

        public DateTime? wrkEnd1 { get; set; }

        public DateTime? wrkStart2 { get; set; }

        public DateTime? wrkEnd2 { get; set; }

        public DateTime? wrkStart3 { get; set; }

        public DateTime? wrkEnd3 { get; set; }

        public DateTime? JB_Start { get; set; }

        public DateTime? JB_End { get; set; }

        public int? ciDao { get; set; }

        public int? zaoTui { get; set; }

        public int? kuangGong { get; set; }

        public int? JiaBan { get; set; }

        public int? qinJia { get; set; }

        public int? chuCai { get; set; }

        public int? ciDao2 { get; set; }

        public int? zaoTui2 { get; set; }

        public int? kuangGong2 { get; set; }
    }
}
