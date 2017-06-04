using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wisdom.Functions.Response
{
    public class HousePlaceOrderResponse
    {
        /// <summary>
        /// 返回结果的状态码
        /// </summary>
        public string CODE { get; set; }

        /// <summary>
        /// 返回结果的描述
        /// </summary>
        public string MESSAGE { get; set; }

        /// <summary>
        /// 返回结果
        /// </summary>
        public HousePlaceOrderResult result { get; set; }


    }

    public class HousePlaceOrderResult
    {
        /// <summary>
        /// 地址信息
        /// </summary>
        public string address { get; set; }

        /// <summary>
        /// 订单号
        /// </summary>
        public string orderNumber { get; set; }

    }
}
