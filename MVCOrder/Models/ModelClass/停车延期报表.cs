using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 报表.Models.Model
{
    public class 停车延期报表
    {
        public long 序号 { get; set; }
        public string 用户姓名 { get; set; }
        public int 用户编号 { get; set; }
        public string 房间号 { get; set; }
        public DateTime 原有效日期 { get; set; }
        public DateTime 现有效日期 { get; set; }
        public decimal 付款金额 { get; set; }
        public string 操作员 { get; set; }
        public string 部门 { get; set; }
        public string 车牌 { get; set; }
    }
}
