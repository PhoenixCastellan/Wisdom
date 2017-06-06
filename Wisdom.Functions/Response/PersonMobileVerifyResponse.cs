using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wisdom.Functions.Response
{
    public class PersonMobileVerifyResponse
    {
        /// <summary>
        /// 调用结果代码
        /// </summary>
        public string CODE { get; set; }

        /// <summary>
        /// 调用描述信息
        /// </summary>
        public string MESSAGE { get; set; }

        /// <summary>
        /// 返回结果
        /// </summary>
        public PersonMobileVerifyData data { get; set; }

    }

    public class PersonMobileVerifyData
    {
        /// <summary>
        /// T   验证信息通过
        /// F 验证信息不一致
        /// N 系统无记录
        /// </summary>
        public string result { get; set; }

        /// <summary>
        /// 结果说明
        /// </summary>
        public string MESSAGE { get; set; }

    }
}
