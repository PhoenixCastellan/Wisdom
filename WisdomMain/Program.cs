using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Wisdom.Functions;
using Wisdom.Functions.Request;

namespace WisdomMain
{
    class Program
    {
        static void Main(string[] args)
        {

            var request = new CheckPersonInfoRequest()
            {
                name = "吕日辉",
                idNumber = "362322198811072433"
                //city = "上海",
                //district = "宝山区",
                //name = "保利叶语",
                //size = "130",
                //buildingNumber = "107",
                //unitNumber = "901",
                //floor = "9",
                //maxFloor = "23"
            };
            //ForeachClassProperties<CheckPersonInfoRequest>(request);

            var result1 = new Wisdom.Functions.Wisdom().GetCheckPersonInfo(request);

            //Console.WriteLine(result1.MESSAGE);
            //Console.WriteLine(result2.MESSAGE);

            var x = RsaHelper.GetScretKey();

            byte[] b = System.Text.Encoding.Default.GetBytes(x);

            var a= Convert.ToBase64String(b);



            Console.ReadLine();
        }
    }
}
