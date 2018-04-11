using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 报表.Models.Model
{
    public class ParkingCard
    {
        public long 车辆编号 { get; set; }
        public string 用户名 { get; set; }
        public int 车位号 { get; set; }
        public string 层别 { get; set; }
        public int 用户编号 { get; set; }
        public string 房间号 { get; set; }
        public DateTime 有效日期 { get; set; }
        public string 状态 { get; set; }
        public string 车牌 { get; set; }
        public string 车型 { get; set; }
        public string 颜色 { get; set; }
        public string 卡类别 { get; set; }
        public string 操作员 { get; set; }
        public DateTime 操作时间 { get; set; }
        public string 部门 { get; set; }
    }
}
