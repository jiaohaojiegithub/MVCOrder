using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 报表.Models.Model
{
    public class 用户资料
    {
        public long 序号 { get; set; }
        public int 车位号 { get; set; }
        public string 层别 { get; set; }
        public string 停车类别 { get; set; }
        public string 房间号 { get; set; }
        public string 用户姓名 { get; set; }
        public string 性别 { get; set; }
        public string 用户编号 { get; set; }
        public DateTime 有效期 { get; set; }
        public string 车牌号 { get; set; }
        public string 联系电话 { get; set; }
        public string 身份证号 { get; set; }
        public string 备注 { get; set; }
    }
}
