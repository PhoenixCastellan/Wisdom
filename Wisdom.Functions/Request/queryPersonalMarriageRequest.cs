using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wisdom.Functions.Request
{
    public class queryPersonalMarriageRequest
    {
        /// <summary>
        /// 被查询姓名加密
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// 被查询人身份证加密
        /// </summary>
        public string card { get; set; }

        /// <summary>
        /// 手机号码 加密
        /// </summary>
        public string mobile { get; set; }

    }
}
