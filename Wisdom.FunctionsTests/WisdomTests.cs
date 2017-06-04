using Microsoft.VisualStudio.TestTools.UnitTesting;
using Wisdom.Functions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wisdom.Functions.Request;

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

            Assert.IsTrue(response.MESSAGE.Equals("成功"));
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
            Assert.Fail();
        }

        [TestMethod()]
        public void GethouseInfoTest()
        {
            Assert.Fail();
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

            Assert.IsTrue(response.MESSAGE.Equals("成功"));
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
                name="吕日辉",
                card = "362322198811072433",
                mobile = "13971170724"
            };
            var response = new Wisdom().queryPersonalMarriage(request);

            Assert.IsTrue(response.MESSAGE.Equals("成功"));
        }
    }
}