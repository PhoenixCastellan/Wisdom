using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wisdom.Functions.Request
{
    public class BlackListByIdentityCardRequest
    {
        /// <summary>
        /// 被查询姓名加密
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// 被查询人身份证加密
        /// </summary>
        public string idNumber { get; set; }

    }
}
