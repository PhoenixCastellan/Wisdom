using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wisdom.Functions.Response
{
    public class queryPersonalMarriageResponse
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
        /// 结婚信息
        /// </summary>
        public List<PersonalMarriage> marriageList { get; set; }

        /// <summary>
        /// 离婚信息
        /// </summary>
        public List<PersonalDivorce> divorceList { get; set; }
    }


    public class PersonalMarriage
    {
        /// <summary>
        /// 登记机关
        /// </summary>
        public string djjg { get; set; }

        /// <summary>
        /// 登记日期
        /// </summary>
        public string djrq { get; set; }

        /// <summary>
        /// 身份证号
        /// </summary>
        public string idCard { get; set; }

        /// <summary>
        /// 手机号
        /// </summary>
        public string mobile { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// 配偶姓名
        /// </summary>
        public string poxm { get; set; }

        /// <summary>
        /// 证书编号
        /// </summary>
        public string zsbh { get; set; }

    }

    public class PersonalDivorce
    {
        /// <summary>
        /// 登记机关
        /// </summary>
        public string djjg { get; set; }

        /// <summary>
        /// 登记日期
        /// </summary>
        public string djrq { get; set; }

        /// <summary>
        /// 证书编号
        /// </summary>
        public string zsbh { get; set; }

        /// <summary>
        /// 身份证号
        /// </summary>
        public string idCard { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// 手机号
        /// </summary>
        public string mobile { get; set; }

        /// <summary>
        /// 配偶姓名
        /// </summary>
        public string poxm { get; set; }

    }
}
