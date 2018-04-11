using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 报表.Models.Model
{
    public class 车辆出场记录报表
    {
        public string 姓名 { get; set; }
        public string 停车类别 { get; set; }
        public string 车型 { get; set; }
        public string 车牌 { get; set; }
        public string 出场图象 { get; set; }
        public DateTime 入场时间 { get; set; }
        public DateTime 出场时间 { get; set; }
        public string 地址 { get; set; }
        public decimal 实收金额 { get; set; }
        public string 操作员 { get; set; }
    }
}
