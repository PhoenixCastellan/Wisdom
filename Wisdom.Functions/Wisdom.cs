using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Wisdom.Functions.Request;
using Wisdom.Functions.Response;

namespace Wisdom.Functions
{
    public class Wisdom:IWisdom
    {

        /// <summary>
        /// 根据被查询人姓名、身份号进行身份证验证
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public CheckPersonInfo GetCheckPersonInfo(CheckPersonInfoRequest request)
        {
            var result = Utils.HttpPost(GlobalInfo.GetCheckPersonInfoUrl(), RequestHelper.GetRequestString(request));
            return JsonConvert.DeserializeObject<CheckPersonInfo>(result);
        }

        public LonApplicationDetialResponse GetLonApplicationDetial(LonApplicationDetialRequest request)
        {
            throw new NotImplementedException();
        }

        public LendingDataInfoResponse GetLendingDataInfo(LendingDataInfoRequest request)
        {
            throw new NotImplementedException();
        }

        public HousePlaceOrderResponse GethousePlaceOrder(HousePlaceOrderRequest request)
        {
            var result = Utils.HttpPost(GlobalInfo.GethousePlaceOrder(), RequestHelper.GetRequestString(request));

            return JsonConvert.DeserializeObject<HousePlaceOrderResponse>(result);
        }

        public HouseInfoResponse GethouseInfo(HouseInfoRequest request)
        {
            var result = Utils.HttpPost(GlobalInfo.GetHouseInfo(), RequestHelper.GetRequestString(request));

            return JsonConvert.DeserializeObject<HouseInfoResponse>(result);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public HouseEvaluateInfoResponse GetHouseEvaluateInfo(HouseEvaluateInfoRequest request)
        {
            var result = Utils.HttpPost(GlobalInfo.GetHouseEvaluateInfo(), RequestHelper.GetRequestString(request));

            return JsonConvert.DeserializeObject<HouseEvaluateInfoResponse>(result);
        }

        public PersonBadInfoResponse GetPersonBadInfo(PersonBadInfoRequest request)
        {
            var result = Utils.HttpPost(GlobalInfo.GetPersonBadInfo(), RequestHelper.GetRequestString(request));

            return JsonConvert.DeserializeObject<PersonBadInfoResponse>(result);
        }

        public queryPersonalCarResponse GetPersonalCarInfo(queryPersonalCarRequest request)
        {
            var result = Utils.HttpPost(GlobalInfo.queryPersonalCar(), RequestHelper.GetRequestString(request));

            return JsonConvert.DeserializeObject<queryPersonalCarResponse>(result);
        }

        public queryPersonalMarriageResponse queryPersonalMarriage(queryPersonalMarriageRequest request)
        {
            var result = Utils.HttpPost(GlobalInfo.queryPersonalCar(), RequestHelper.GetRequestString(request));

            return JsonConvert.DeserializeObject<queryPersonalMarriageResponse>(result);
        }

        public PersonMobileVerifyResponse getPersonMobileVerify(PersonMobileVerifyRequest request)
        {
            var result = Utils.HttpPost(GlobalInfo.GetPersonMobileVerify(), RequestHelper.GetRequestString(request));

            return JsonConvert.DeserializeObject<PersonMobileVerifyResponse>(result);
        }

        public BlackListByIdentityCardResponse GetBlackListByIdentityCard(BlackListByIdentityCardRequest request)
        {
            var result = Utils.HttpPost(GlobalInfo.GetBlackListByIdentityCard(), RequestHelper.GetRequestString(request));

            return JsonConvert.DeserializeObject<BlackListByIdentityCardResponse>(result);
        }

        public PersonalfundInfoResponse QueryPersonalfundInfo(PersonalfundInfoRequest request)
        {
            var result = Utils.HttpPost(GlobalInfo.QueryPersonalfundInfo(), RequestHelper.GetRequestString(request));

            return JsonConvert.DeserializeObject<PersonalfundInfoResponse>(result);
        }
    }
}
