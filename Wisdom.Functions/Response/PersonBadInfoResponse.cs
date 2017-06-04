using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wisdom.Functions.Response
{
    public class PersonBadInfoResponse
    {
        /// <summary>
        /// 调用结果代码
        /// </summary>
        public string CODE { get; set; }

        /// <summary>
        /// 调用结果信息
        /// </summary>
        public string MESSAGE { get; set; }

        public PersonBadInfoResult RESULT { get; set; }
    }

    public class PersonBadInfoResult
    {
        /// <summary>
        /// 姓名
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// 犯案时间
        /// </summary>
        public string crimetime { get; set; }

        /// <summary>
        /// 犯案记录(比中前科， 在逃， 吸毒 , 涉毒，比中在逃和前科)
        /// </summary>
        public string hethercrime { get; set; }

        /// <summary>
        /// 被查询人身份证号
        /// </summary>
        public string idNumber { get; set; }
    }
}
