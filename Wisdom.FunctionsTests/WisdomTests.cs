using Microsoft.VisualStudio.TestTools.UnitTesting;
using Wisdom.Functions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using Wisdom.Functions.Request;
using Wisdom.Functions.Response;

namespace Wisdom.Functions.Tests
{
    [TestClass()]
    public class WisdomTests
    {
        [TestMethod()]
        public void GetHouseEvaluateInfoTest()
        {
            var request = new HouseEvaluateInfoRequest()
            {
                city = "上海",
                district = "宝山区",
                name = "保利叶语",
                size = "130",
                buildingNumber = "107",
                unitNumber = "901",
                floor = "9",
                maxFloor = "23"
            };

            var result = new Wisdom().GetHouseEvaluateInfo(request);
            Assert.IsNotNull(result);
            Assert.IsNotNull(result.data);
            Assert.IsTrue(Convert.ToDecimal(result.data.avgPrice) > 0);
        }

        [TestMethod()]
        public void GetCheckPersonInfoTest()
        {
            var request = new CheckPersonInfoRequest()
            {
                idNumber = "362322197401082431",
                name = "吕献日"
            };
            var response = new Wisdom().GetCheckPersonInfo(request);

            Assert.IsTrue(response.MESSAGE.Contains("成功"));
        }

        [TestMethod()]
        public void GetLonApplicationDetialTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetLendingDataInfoTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GethousePlaceOrderTest()
        {
            var request = new HousePlaceOrderRequest()
            {
                address = "上海市嘉定区南翔镇南华路101弄南华小区45号402",
                email = "836102291@qq.com"
            };
            var response = new Wisdom().GethousePlaceOrder(request);

            Assert.IsTrue(response.MESSAGE.Contains("成功"));
        }

        [TestMethod()]
        public void GethouseInfoTest()
        {
            var request = new HouseInfoRequest()
            {
                orderNumber = "WEH2017060613532454a-99d"
            };
            var response = new Wisdom().GethouseInfo(request);


            //var param = $"userId={HttpUtility.UrlEncode("123")}" +
            //            $"&userPwd={HttpUtility.UrlEncode("6uzNhW3vsYq5HtKofhKDgA==")}" +
            //            $"&OrderNumber={HttpUtility.UrlEncode("ddsIQk/gqZThITiTm6WgUiwy95M0/eiAYnzjClbbpnI=")}" +
            //            $"&secretKey={HttpUtility.UrlEncode("p6Hhet5fKJjJ9+PZ0SvSQSGa/+ZkXpbdc3kfB/4yIwoBs+rd2qv/puwSfTyMxPWk3WAfenruWVG0NkHNsHpYIIn2zJogVie+rtSFq4+EfztSoKh6HS2oWTIM5Ggxv4LnWg6d/RoQNlFWLXSxMwJBNEnU0vjxLT67fuIB74VGOto=")}";

            //var result = Utils.HttpPost(GlobalInfo.GetHouseInfo(), param);

            //return JsonConvert.DeserializeObject<HouseInfoResponse>(result);

            Assert.IsTrue(response.MESSAGE.Contains("成功"));
        }

        [TestMethod()]
        public void GetHouseEvaluateInfoTest1()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetPersonBadInfoTest()
        {
            var request = new PersonBadInfoRequest()
            {
                idNumber = "330325198208095130",
                name = "彭纪孟"
            };
            var response = new Wisdom().GetPersonBadInfo(request);

            Assert.IsTrue(response.MESSAGE.Contains("成功"));
        }

        [TestMethod()]
        public void GetPersonalCarInfoTest()
        {
            var request = new queryPersonalCarRequest()
            {
                card = "362322197401082431",
                mobile = "13818063250",
                name = "吕献日"
            };
            var response = new Wisdom().GetPersonalCarInfo(request);

            Assert.IsTrue(response.CODE.Equals("200"));
        }

        [TestMethod()]
        public void queryPersonalMarriageTest()
        {
            var request = new queryPersonalMarriageRequest()
            {
                name = "吕日辉",
                card = "362322198811072433",
                mobile = "13971170724"
            };
            var response = new Wisdom().queryPersonalMarriage(request);

            Assert.IsTrue(response.MESSAGE.Contains("成功"));
        }

        [TestMethod()]
        public void getPersonMobileVerifyTest()
        {
            var request = new PersonMobileVerifyRequest()
            {
                name = "张京军",
                idcard = "320681197906061211",
                mobile = "13661761004"
            };
            var request1 = new PersonMobileVerifyRequest()
            {
                name = "吕红芳",
                idcard = "362322198907242468",
                mobile = "15946809593"
            };
            var response = new Wisdom().getPersonMobileVerify(request1);

            Assert.IsTrue(response.MESSAGE.Contains("成功"));
        }

        [TestMethod()]
        public void GetBlackListByIdentityCardTest()
        {
            var request = new BlackListByIdentityCardRequest()
            {
                idNumber = "330325198208095130",
                name = "彭纪孟"
            };
            var response = new Wisdom().GetBlackListByIdentityCard(request);

            Assert.IsTrue(response.MESSAGE.Contains("成功"));
        }

        [TestMethod()]
        public void QueryPersonalfundInfoTest()
        {
            var request = new PersonalfundInfoRequest()
            {
                name = "吕日辉",
                card = "362322198811072433",
                mobile = "18079339866"
            };
            var response = new Wisdom().QueryPersonalfundInfo(request);

            Assert.IsTrue(response.MESSAGE.Contains("成功"));
        }
    }
}
