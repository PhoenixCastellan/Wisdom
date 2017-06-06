using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wisdom.Functions.Response
{
    public class PersonalfundInfoResponse
    {
        /// <summary>
        /// 调用结果代码
        /// </summary>
        public string CODE { get; set; }

        /// <summary>
        /// 调用结果信息
        /// </summary>
        public string MESSAGE { get; set; }

        /// <summary>
        /// 公积金缴纳信息列表
        /// </summary>
        public List<PersonalfundInfo> PersonalfundInfo { get; set; }

    }

    public class PersonalfundInfo
    {
        /// <summary>
        /// 姓名
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// 身份证号
        /// </summary>
        public string idCard { get; set; }

        /// <summary>
        /// 手机号
        /// </summary>
        public string mobile { get; set; }

        /// <summary>
        /// 当前账户状态
        /// </summary>
        public string accountStatus { get; set; }

        /// <summary>
        /// 开户日期
        /// </summary>
        public string openDate { get; set; }

        /// <summary>
        /// 账户所在单位名称
        /// </summary>
        public string unit { get; set; }


    }
}
