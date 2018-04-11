using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 报表.Models.Model
{
    public class 停车场收费日报表
    {
        public string 日期 { get; set; }
        public decimal 私家车 { get; set; }
        public decimal 月租车 { get; set; }
        public decimal 时租车 { get; set; }
        public decimal 特免车 { get; set; }
        public decimal 优惠车 { get; set; }
        public decimal 员工车 { get; set; }
        public decimal 其他车 { get; set; }
        public decimal 小计金额 { get; set; }
    }
}
