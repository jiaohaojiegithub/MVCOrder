using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 报表.Models.Model
{
    public class 入场车流量日报表
    {
        public string 时间 { get; set; }
        public int 私家车 { get; set; }
        public int 月租车 { get; set; }
        public int 时租车 { get; set; }
        public int 特免车 { get; set; }
        public int 优惠车 { get; set; }
        public int 员工车 { get; set; }
        public int 其他车 { get; set; }
        public int 小计 { get; set; }
    }
}
