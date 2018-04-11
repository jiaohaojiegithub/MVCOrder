namespace MVCOrder.Models.YKT
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("customer")]
    public partial class customer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int cust_no { get; set; }

        [StringLength(20)]
        public string cust_name { get; set; }

        [StringLength(20)]
        public string cust_password { get; set; }

        [StringLength(10)]
        public string cust_nick { get; set; }

        public int? sex { get; set; }

        [StringLength(15)]
        public string phone_no { get; set; }

        [StringLength(15)]
        public string mobile { get; set; }

        [StringLength(18)]
        public string idcard { get; set; }

        [StringLength(60)]
        public string address { get; set; }

        [StringLength(60)]
        public string remark { get; set; }

        [Column("operator")]
        [StringLength(10)]
        public string _operator { get; set; }

        public DateTime? createdt { get; set; }

        public int? wrkNo { get; set; }

        public int? deptNo { get; set; }

        [StringLength(100)]
        public string photo { get; set; }

        public int? cust_level { get; set; }
    }
}
