using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 报表.Models.Model
{
    public class 停车注销记录报表
    {
        public Int64 序号 { get; set; }
        public string 用户姓名 { get; set; }
        public string 车牌 { get; set; }
        public int 用户编号 { get; set; }
        public int 车位号 { get; set; }
        public string 房间号 { get; set; }
        public string 退卡方式 { get; set; }
        public decimal 押金 { get; set; }
        public decimal 余额 { get; set; }
        public decimal 退还金额 { get; set; }
        public string 操作员 { get; set; }
        public DateTime 操作时间 { get; set; }
        public string 部门 { get; set; }
    }
}
