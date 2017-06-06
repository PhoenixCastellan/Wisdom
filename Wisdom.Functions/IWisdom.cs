using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wisdom.Functions.Request;
using Wisdom.Functions.Response;

namespace Wisdom.Functions
{
    interface IWisdom
    {

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        CheckPersonInfo GetCheckPersonInfo(CheckPersonInfoRequest request);

        /// <summary>
        /// 查询人手机号码查询个人贷款申请详情信息
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        LonApplicationDetialResponse GetLonApplicationDetial(LonApplicationDetialRequest request);

        /// <summary>
        /// 根据被查询人的 姓名 身份证号 手机号 查询多头借贷信息
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        LendingDataInfoResponse GetLendingDataInfo(LendingDataInfoRequest request);

        /// <summary>
        /// 地址查询房屋信息-下单请求
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        HousePlaceOrderResponse GethousePlaceOrder(HousePlaceOrderRequest request);

        /// <summary>
        /// 地址查询房屋信息-房屋产调信息
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        HouseInfoResponse GethouseInfo(HouseInfoRequest request);

        /// <summary>
        /// 根据被查询人城市、区域、小区名、面积查询房屋估价信息
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        HouseEvaluateInfoResponse GetHouseEvaluateInfo(HouseEvaluateInfoRequest request);

        /// <summary>
        /// 根据被查询人姓名、身份号查询个人不良信息查询信息
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        PersonBadInfoResponse GetPersonBadInfo(PersonBadInfoRequest request);

        /// <summary>
        /// 通过姓名、身份证、手机号 查询实现查询个人车辆信息
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        queryPersonalCarResponse GetPersonalCarInfo(queryPersonalCarRequest request);

        /// <summary>
        /// 通过姓名、身份证、手机号 查询实现查询个人车辆信息
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        queryPersonalMarriageResponse queryPersonalMarriage(queryPersonalMarriageRequest request);

        /// <summary>
        /// 查询人姓名、身份号、手机号进行手机号验证
        /// </summary>
        /// <returns></returns>
        PersonMobileVerifyResponse getPersonMobileVerify(PersonMobileVerifyRequest request);

        /// <summary>
        /// 通过姓名、身份证查询实现查询个人黑名单信息
        /// </summary>
        /// <returns></returns>
        BlackListByIdentityCardResponse GetBlackListByIdentityCard(BlackListByIdentityCardRequest request);


        /// <summary>
        /// 通过姓名、身份证、手机号码查询实现查询个人公积金信息
        /// </summary>
        /// <returns></returns>
        PersonalfundInfoResponse QueryPersonalfundInfo(PersonalfundInfoRequest request);
    }
}
