using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 报表.Models.Model
{
    public class 车辆入场记录报表
    {
        public long 序号 { get; set; }
        public string 停车类别 { get; set; }
        public string 层别 { get; set; }
        public string 车牌号 { get; set; }
        public DateTime 入场时间 { get; set; }
        public string 入场图象 { get; set; }
        public string 入场地址 { get; set; }
        public string 操作员 { get; set; }
    }
}
