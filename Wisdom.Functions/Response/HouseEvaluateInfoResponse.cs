using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wisdom.Functions.Response
{
    public class HouseEvaluateInfoResponse
    {
        /// <summary>
        /// 响应码
        /// </summary>
        public string CODE { get; set; }

        /// <summary>
        /// 响应消息
        /// </summary>
        public string MESSAGE { get; set; }

        /// <summary>
        /// 响应数据
        /// </summary>
        public HouseEvaluateInfoData data { set; get; }
    }

    public class HouseEvaluateInfoData
    {

        /// <summary>
        /// 均价（单位：元/平米）
        /// </summary>
        public string avgPrice { get; set; }

        /// <summary>
        /// 总价（单位：元）
        /// </summary>
        public string totalPrice { get; set; }
    }
}
