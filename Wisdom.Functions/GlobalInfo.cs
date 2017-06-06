namespace Wisdom.Functions
{
    public class GlobalInfo
    {
        public const string UserId = "qiudaoyu";
        public const string UserPwd = "12345678";
        public const string Host = "http://shandu.yqicha.com:8035/";
        public const string Pbkey = "MIGfMA0GCSqGSIb3DQEBAQUAA4GNADCBiQKBgQCJfTvFrDo2H5pSvrm0ijCnciljtjCwKn+yj8i8HaFi3BYkiniipFJwJLzOTr5VxL74nUcqNsF1syjv7FfCfE18JNy65bH+6cHmitKYEKxIe4Qc9uZ2KEjTwqJmSR7ECLa/lGp7p1Ld24oiOz5FMQS+lt5HDKm1Wz1ONkuClO13yQIDAQAB";

        /// <summary>
        /// 根据被查询人手机号码查询个人贷款申请详情信息
        /// </summary>
        /// <returns></returns>
        public static string getLonApplicationDetialUrl()
        {
            return Host + "wescr_api/loan/getLonApplicationDetial";
        }

        /// <summary>
        /// 身份证实名验证
        /// </summary>
        /// <returns></returns>
        public static string GetCheckPersonInfoUrl()
        {
            return Host + "wescr_api/person/getCheckPersonInfo";
        }


        /// <summary>
        /// 银行卡实名验证 4要素
        /// </summary>
        /// <returns></returns>
        public static string GetFFBankCard()
        {
            return Host + "wescr_api/personBankCard/getBankCardFour";
        }


        /// <summary>
        /// 银行卡三要素实名认证接口
        /// </summary>
        /// <returns></returns>
        public static string GetThrBankCard()
        {
            return Host + "wescr_api/personBankCard/getBankCardThree";
        }

        public static string GetHouseEvaluateInfo()
        {
            return Host + "wescr_api/house/getHouseEvaluateInfo";
        }

        /// <summary>
        /// 查询人手机号码查询个人贷款申请详情信息
        /// </summary>
        /// <returns></returns>
        public static string GetLonApplicationDetial()
        {
            return Host + "wescr_api/loan/getLonApplicationDetial";
        }

        /// <summary>
        /// 根据被查询人的 姓名 身份证号 手机号 查询多头借贷信息
        /// </summary>
        /// <returns></returns>
        public static string GetLendingDataInfo()
        {
            return Host + "wescr_api/data/getLendingDataInfo";
        }

        /// <summary>
        /// 地址查询房屋信息-下单请求
        /// </summary>
        /// <returns></returns>
        public static string GethousePlaceOrder()
        {
            return Host + "wescr_api/person/housePlaceOrder";
        }

        /// <summary>
        /// 地址查询房屋信息-下单请求
        /// </summary>
        /// <returns></returns>
        public static string GetHouseInfo()
        {
            return Host + "wescr_api/person/getHouseInfo";
        }

        /// <summary>
        /// 地址查询房屋信息-下单请求
        /// </summary>
        /// <returns></returns>
        public static string GetPersonBadInfo()
        {
            return Host + "wescr_api/personalBadInfo/getPersonBadInfo";
        }

        /// <summary>
        /// 通过姓名、身份证、手机号 查询实现查询个人车辆信息
        /// </summary>
        /// <returns></returns>
        public static string queryPersonalCar()
        {
            return Host + "wescr_api/queryPersonalCar";
        }


        /// <summary>
        /// 通过姓名、身份证、手机号 查询实现查询个人婚姻信息
        /// </summary>
        /// <returns></returns>
        public static string queryPersonalMarriage()
        {
            return Host + "wescr_api/queryPersonalMarriage";
        }

        /// <summary>
        /// 查询人姓名、身份号、手机号进行手机号验证
        /// </summary>
        /// <returns></returns>
        public static string GetPersonMobileVerify()
        {
            return Host + "wescr_api/person/getPersonMobileVerify";
        }

        /// <summary>
        /// 通过姓名、身份证查询实现查询个人黑名单信息
        /// </summary>
        /// <returns></returns>
        public static string GetBlackListByIdentityCard()
        {
            return Host + "wescr_api/blackList/getBlackListByIdentityCard";
        }

        /// <summary>
        /// 通过姓名、身份证、手机号码查询实现查询个人公积金信息
        /// </summary>
        /// <returns></returns>
        public static string QueryPersonalfundInfo()
        {
            return Host + "wescr_api/queryPersonalfundInfo";
        }
    }
}
