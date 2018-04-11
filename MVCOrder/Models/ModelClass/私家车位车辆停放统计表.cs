using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 报表.Models.Model
{
    public class 私家车位车辆停放统计表
    {
        public long 序号 { get; set; }
        public int 车位号 { get; set; }
        public string 用户姓名 { get; set; }
        public string 停车类别 { get; set; }
        public string 用户编号 { get; set; }
        public string 车牌号 { get; set; }
        public string 是否缴费 { get; set; }
        public string 缴费日期 { get; set; }
        public string 停车有效期 { get; set; }
    }
}
