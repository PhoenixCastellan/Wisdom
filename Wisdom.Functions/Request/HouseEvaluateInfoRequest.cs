using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Wisdom.Functions.Request
{
    public class HouseEvaluateInfoRequest: Request
    {
        public string city { get; set; }
        public string district { get; set; }
        public string name { get; set; }
        public string size { get; set; }
        public string buildingNumber { get; set; }
        public string unitNumber { get; set; }
        public string floor { get; set; }
        public string maxFloor { get; set; }
        //public override object GetRequestData()
        //{
        //    return new
        //    {
        //        userId,
        //        userPwd = HttpUtility.UrlEncode(RsaHelper.getEncString(userPwd)),
        //        secretKey,
        //        city = HttpUtility.UrlEncode(RsaHelper.getEncString(city)),
        //        district = HttpUtility.UrlEncode(RsaHelper.getEncString(district)),
        //        name = HttpUtility.UrlEncode(RsaHelper.getEncString(name)),
        //        size = HttpUtility.UrlEncode(RsaHelper.getEncString(size)),
        //        buildingNumber = HttpUtility.UrlEncode(RsaHelper.getEncString(buildingNumber)),
        //        unitNumber = HttpUtility.UrlEncode(RsaHelper.getEncString(unitNumber)),
        //        floor = HttpUtility.UrlEncode(RsaHelper.getEncString(floor)),
        //        maxFloor = HttpUtility.UrlEncode(RsaHelper.getEncString(maxFloor))
        //    };
        //}

        //public override string GetRequestString()
        //{
        //    return $"userId={HttpUtility.UrlEncode(userId)}" +
        //           $"&userPwd={HttpUtility.UrlEncode(RsaHelper.getEncString(userPwd))}" +
        //           $"&secretKey={HttpUtility.UrlEncode(secretKey)}" +
        //           $"&city={HttpUtility.UrlEncode(RsaHelper.getEncString(city))}" +
        //           $"&district={HttpUtility.UrlEncode(RsaHelper.getEncString(district))}" +
        //           $"&name={HttpUtility.UrlEncode(RsaHelper.getEncString(name))}" +
        //           $"&size={HttpUtility.UrlEncode(RsaHelper.getEncString(size))}" +
        //           $"&buildingNumber={HttpUtility.UrlEncode(RsaHelper.getEncString(buildingNumber))}" +
        //           $"&unitNumber={HttpUtility.UrlEncode(RsaHelper.getEncString(unitNumber))}" +
        //           $"&floor={HttpUtility.UrlEncode(RsaHelper.getEncString(floor))}" +
        //           $"&maxFloor={HttpUtility.UrlEncode(RsaHelper.getEncString(maxFloor))}";
        //}
    }
}
