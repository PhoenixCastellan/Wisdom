using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wisdom.Functions.Response
{
    public class queryPersonalCarResponse
    {
        /// <summary>
        /// 调用结果代码
        /// </summary>
        public string CODE { get; set; }

        /// <summary>
        /// 调用结果信息
        /// </summary>
        public string MESSAGE { get; set; }

        public List<PersonalCarInfo> carList { get; set; }
    }

    public class PersonalCarInfo
    {
        /// <summary>
        /// 号牌种类
        /// </summary>
        public string hpzl { get; set; }

        /// <summary>
        /// 号牌号码
        /// </summary>
        public string hphm { get; set; }

        /// <summary>
        /// 初次登记时间
        /// </summary>
        public string ccdjrq { get; set; }

        /// <summary>
        /// 检验有效期止
        /// </summary>
        public string yxqz { get; set; }

        /// <summary>
        /// 最近定检日期
        /// </summary>
        public string djrq { get; set; }

        /// <summary>
        /// 身份证号码
        /// </summary>
        public string idCard { get; set; }

        /// <summary>
        /// 手机号码
        /// </summary>
        public string mobile { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// 强制报废期止
        /// </summary>
        public string qzbfqz { get; set; }

        /// <summary>
        /// 保修终止日期
        /// </summary>
        public string bxzzrq { get; set; }

        /// <summary>
        /// 管理辖区
        /// </summary>
        public string xzqh { get; set; }

        /// <summary>
        /// 机动车状态
        /// </summary>
        public string zthz { get; set; }

        /// <summary>
        /// 是否抵押
        /// </summary>
        public string dybjhz { get; set; }


    }
}
