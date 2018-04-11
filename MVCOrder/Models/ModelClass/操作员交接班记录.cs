using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 报表.Models.Model
{
    public class 操作员交接班记录
    {
        //[StringLength(60,MinimumLength =3)]
        public string 交班人 { get; set; }
        public string 接班人 { get; set; }
        public string 上班时间 { get; set; }
        public string 下班时间 { get; set; }
        public decimal 实收金额 { get; set; }
        public decimal 应收金额 { get; set; }
        public int 接班时场内停车 { get; set; }
        public int 交班时场内停车 { get; set; }
        public int 接班时场内临时停车 { get; set; }
        public int 交班时场内临时停车 { get; set; }
        public int 出场车辆数 { get; set; }
        public int 入场车辆数 { get; set; }
        public int 手工出场车辆数 { get; set; }
        public int 手工入场车辆数 { get; set; }
        public int 免费出场车次 { get; set; }
    }
}
