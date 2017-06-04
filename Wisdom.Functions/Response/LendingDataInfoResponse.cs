using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wisdom.Functions.Response
{
    public class LendingDataInfoResponse
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
        /// 结果数据
        /// </summary>
        public LendingDataInfoResponseResult result { get; set; }


    }

    public class LendingDataInfoResponseResult
    {
        public LendingDataInfoResponseBasic basic { get; set; }
        public LendingDataInfoResponseRegist regist { get; set; }
        public LendingDataInfoResponseAppr appr { get; set; }
        public LendingDataInfoResponseApply apply { get; set; }
        public LendingDataInfoResponseOverdue overdue { get; set; }
        public LendingDataInfoResponseDecline decline { get; set; }
    }

    public class LendingDataInfoResponseBasic
    {
        /// <summary>
        /// 姓名
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// 身份证
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// 手机号
        /// </summary>
        public string phone { get; set; }

        /// <summary>
        /// 评语
        /// </summary>
        public string stats_comment { get; set; }

        /// <summary>
        /// 号码归属地
        /// </summary>
        public string belongTo { get; set; }

    }

    public class LendingDataInfoResponseRegist
    {
        /// <summary>
        /// 近1月注册信贷平台数量
        /// </summary>
        public string m1_reg_loan_count { get; set; }

        /// <summary>
        /// 近3月注册信贷平台数量
        /// </summary>
        public string m3_reg_loan_count { get; set; }

        /// <summary>
        /// 近6月注册信贷平台数量
        /// </summary>
        public string m6_reg_loan_count { get; set; }

        /// <summary>
        /// 近12月注册信贷平台数量
        /// </summary>
        public string m12_reg_loan_count { get; set; }

        /// <summary>
        /// 近24月注册信贷平台数量
        /// </summary>
        public string m24_reg_loan_count { get; set; }

        /// <summary>
        /// 最早注册信贷平台时间
        /// </summary>
        public string first_reg_loan_time { get; set; }

        /// <summary>
        /// 最近注册信贷平台时间
        /// </summary>
        public string last_reg_loan_time { get; set; }

        /// <summary>
        /// 迄今为止所有注册信贷平台数量
        /// </summary>
        public string total_reg_loan_count { get; set; }

    }

    public class LendingDataInfoResponseAppr
    {
        /// <summary>
        /// 近1月贷款批准金额
        /// </summary>
        public string m1_appr_loan_amt { get; set; }

        /// <summary>
        /// 近3月贷款批准金额
        /// </summary>
        public string m3_appr_loan_amt { get; set; }

        /// <summary>
        /// 近6月贷款批准金额
        /// </summary>
        public string m6_appr_loan_amt { get; set; }

        /// <summary>
        /// 近12月贷款批准金额
        /// </summary>
        public string m12_appr_loan_amt { get; set; }

        /// <summary>
        /// 近24月贷款批准金额
        /// </summary>
        public string m24_appr_loan_amt { get; set; }

        /// <summary>
        /// 迄今为止所有贷款批准金额
        /// </summary>
        public string total_appr_loan_amt { get; set; }

    }

    public class LendingDataInfoResponseApply
    {
        /// <summary>
        /// 近1月贷款申请平台数量
        /// </summary>
        public string m1_apply_loan_platform_count { get; set; }

        /// <summary>
        /// 近3月贷款申请平台数量
        /// </summary>
        public string m3_apply_loan_platform_count { get; set; }

        /// <summary>
        /// 近6月贷款申请平台数量
        /// </summary>
        public string m6_apply_loan_platform_count { get; set; }

        /// <summary>
        /// 近12月贷款申请平台数量
        /// </summary>
        public string m12_apply_loan_platform_count { get; set; }

        /// <summary>
        /// 近24月贷款申请平台数量
        /// </summary>
        public string m24_apply_loan_platform_count { get; set; }

        /// <summary>
        /// 近3月贷款申请数量
        /// </summary>
        public string m3_apply_loan_count { get; set; }

        /// <summary>
        /// 近6月贷款申请数量
        /// </summary>
        public string m6_apply_loan_count { get; set; }

        /// <summary>
        /// 近12月贷款申请数量
        /// </summary>
        public string m12_apply_loan_count { get; set; }

        /// <summary>
        /// 近24月贷款申请数量
        /// </summary>
        public string m24_apply_loan_count { get; set; }

        /// <summary>
        /// 近3月贷款申请金额
        /// </summary>
        public string m3_apply_loan_amt { get; set; }

        /// <summary>
        /// 近6月贷款申请金额
        /// </summary>
        public string m6_apply_loan_amt { get; set; }

        /// <summary>
        /// 近12月贷款申请金额
        /// </summary>
        public string m12_apply_loan_amt { get; set; }

        /// <summary>
        /// 近24月贷款申请金额
        /// </summary>
        public string m24_apply_loan_amt { get; set; }

        /// <summary>
        /// 迄今为止所有贷款申请金额
        /// </summary>
        public string total_apply_loan_amt { get; set; }

        /// <summary>
        /// 迄今为止所有贷款申请数量
        /// </summary>
        public string total_apply_loan_count { get; set; }

        /// <summary>
        /// 迄今为止所有贷款申请平台数量
        /// </summary>
        public string total_apply_loan_platform_count { get; set; }

        /// <summary>
        /// 最近贷款申请时间
        /// </summary>
        public string last_apply_loan_time { get; set; }

        /// <summary>
        /// 最早贷款申请时间
        /// </summary>
        public string first_apply_loan_time { get; set; }

    }

    public class LendingDataInfoResponseOverdue
    {
        /// <summary>
        /// 迄今为止所有的贷款逾期数量
        /// </summary>
        public string total_overdue_loan_count { get; set; }

        /// <summary>
        /// 迄今为止所有的贷款逾期平台数量
        /// </summary>
        public string total_overdue_loan_platform_count { get; set; }

        /// <summary>
        /// 迄今为止所有贷款逾期的平均逾期期数
        /// </summary>
        public string average_overdue_count { get; set; }

        /// <summary>
        /// 迄今为止所有的贷款总计逾期期数
        /// </summary>
        public string total_sum_overdue_count { get; set; }

        /// <summary>
        /// 迄今为止所有的贷款最高逾期期数
        /// </summary>
        public string total_highest_overdue_count { get; set; }

        /// <summary>
        /// 迄今为止所有的贷款逾期金额
        /// </summary>
        public string total_overdue_loan_amt { get; set; }

    }

    public class LendingDataInfoResponseDecline
    {
        /// <summary>
        /// 迄今为止贷款拒绝数量
        /// </summary>
        public string total_decline_loan_count { get; set; }

    }
}
