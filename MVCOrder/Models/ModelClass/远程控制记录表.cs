using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 报表.Models.Model
{
    public class 远程控制记录表
    {
        public string 操作时间 { get; set; }
        public string 操作人员 { get; set; }
        public int 命令类型 { get; set; }
        public string 下发地址 { get; set; }
        public string 标志 { get; set; }
        public string 图象 { get; set; }
    }
}
