using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wisdom.Functions.Request
{
    public class LonApplicationDetialRequest
    {
        /// <summary>
        /// 被查询人手机号码加密
        /// </summary>
        public string phone { get; set; }

        /// <summary>
        /// 段时间段(1,3,6,9,12,24)单位:月加密
        /// </summary>
        public string cycle { get; set; }

        /// <summary>
        /// 平台类型(0 全部 1 银行 2 非银行)加密
        /// </summary>
        public string platform { get; set; }    

    }
}
