using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wisdom.Functions.Response
{
    public class BlackListByIdentityCardResponse
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
        public List<BlackListByIdentityData> data { get; set; }

    }

    public class BlackListByIdentityData
    {
        /// <summary>
        /// 逾期时间 （天）
        /// 0-6 ； 7-29 ； 30-89 ； 90-179  ；180-364  365-1000 ； >1000
        ///  </summary>
        public string overdue_date { get; set; }

        /// <summary>
        /// 法律状态(未知,已结案,执行中)  
        /// </summary>
        public string legal_state { get; set; }

        /// <summary>
        /// 黑名单类型 (借款违约,失信网名单,人法网名单)
        /// </summary>
        public string type { get; set; }

        /// <summary>
        /// 逾期金额 （元）
        /// 0-500 ； 500-1000 ； 1000-5000  ；5000-10000  ；10000-50000  ；50000-100000  ；>100000 
        /// </summary>
        public string overdue_amount { get; set; }

        /// <summary>
        /// 数据入库时间 （天）
        /// 0-6 ； 7-29 ； 30-89 ； 90-179 ； 180-364  ；365-1000 ； >1000 
        /// </summary>
        public string overdue_days { get; set; }
    }
}
