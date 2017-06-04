using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wisdom.Functions.Response
{
    public class HouseInfoResponse
    {
        /// <summary>
        /// 调用结果代码
        /// </summary>
        public string CODE { get; set; }

        /// <summary>
        /// 调用结果信息
        /// </summary>
        public string MESSAGE { get; set; }

        public HouseInfoResult RESULT { get; set; }
    }

    public class HouseInfoResult
    {
        /// <summary>
        /// 照片（Base64格式）
        /// </summary>
        public string photo { get; set; }

        /// <summary>
        /// 地址
        /// </summary>
        public string address { get; set; }

    }
}
