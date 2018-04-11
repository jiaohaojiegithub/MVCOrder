using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 报表.Models.Model
{
    public class 远程控制记录日报表
    {
        public string 日期 { get; set; }
        public string 操作员 { get; set; }
        public int 远程开机 { get; set; }
        public int 远程关机 { get; set; }
        public int 远程开闸 { get; set; }
        public int 远程关闸 { get; set; }
        public int 远程复位 { get; set; }
        public int 出临时卡 { get; set; }
        public int 出临免卡 { get; set; }
    }
}
