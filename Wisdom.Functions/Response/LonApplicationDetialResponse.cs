using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wisdom.Functions.Request;

namespace Wisdom.Functions.Response
{
    /// <summary>
    /// 
    /// </summary>
    public class LonApplicationDetialResponse : Response<LonApplicationDetialData>
    {
        /// <summary>
        /// 查新时间段
        /// </summary>
        public string CYCLE { get; set; }
    }

    public class LonApplicationDetialData
    {
        /// <summary>
        /// 平台类型（1 银行 2 非银行）
        /// </summary>
        public string P_TYPE { get; set; }

        /// <summary>
        /// 平台代码
        /// </summary>
        public string PLATFORMCODE { get; set; }

        /// <summary>
        /// 申请时间
        /// </summary>
        public string APPLICATIONTIME { get; set; }

        /// <summary>
        /// 申请金额区间
        /// </summary>
        public string APPLICATIONAMOUNT { get; set; }

        /// <summary>
        /// 申请结果
        /// </summary>
        public string APPLICATIONRESULT { get; set; }
    }
}
