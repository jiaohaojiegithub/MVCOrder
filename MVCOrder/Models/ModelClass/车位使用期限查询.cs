using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 报表.Models.Model
{
    public class 车位使用期限查询
    {
        public long 序号 { get; set; }
        public string 使用期限 { get; set; }
        public int 车位号 { get; set; }
        public string 房号 { get; set; }
        public string 层别 { get; set; }
        public string 有效期 { get; set; }
        public string 用户姓名 { get; set; }
        public string 联系电话 { get; set; }
    }
}
