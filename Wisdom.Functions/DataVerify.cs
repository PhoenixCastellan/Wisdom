using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Web;

namespace Wisdom.Functions
{
    /// <summary>
    /// 用户信息验证
    /// </summary>
    public abstract class DataVerify
    {
        public static object GetResult(string apiUrl, Dictionary<string, string> parmates)
        {
            #region 调取第三方接口
            string userId = GlobalInfo.UserId;//用户名
            string userPwd = GlobalInfo.UserPwd;//密码
            string secretKey = HttpUtility.UrlEncode(RsaHelper.GetScretKey());
            #region &方式拼接
            //公共参数
            string parmate = "userId=" + HttpUtility.UrlEncode(userId) + "&userPwd=" + HttpUtility.UrlEncode(RsaHelper.getEncString(userPwd)) + "&secretKey=" + secretKey;
            //接口对应参数
            string apiParmate = "";
            foreach (var par in parmates)
            {
                string val;
                if (!string.IsNullOrEmpty(par.Value))
                {
                    val = HttpUtility.UrlEncode(RsaHelper.getEncString(par.Value));
                }
                else
                {
                    val = par.Value;
                }
                apiParmate = $"{apiParmate}&{par.Key}={val}";
            }
            parmate = parmate + apiParmate;
            #endregion &方式拼接
            string result = HttpPost(apiUrl, parmate);
            return null;// WrsCreResult.JsonParse(result);
            #endregion 调取第三方接口

        }

        protected static string HttpPost(string url, string param)
        {
            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(url);
            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded";
            request.Accept = "*/*";
            request.Timeout = 15000;
            request.AllowAutoRedirect = false;

            StreamWriter requestStream = null;
            WebResponse response = null;
            string responseStr = null;

            try
            {
                requestStream = new StreamWriter(request.GetRequestStream());
                requestStream.Write(param);
                requestStream.Close();

                response = request.GetResponse();
                if (response != null)
                {
                    StreamReader reader = new StreamReader(response.GetResponseStream(), Encoding.UTF8);
                    responseStr = reader.ReadToEnd();
                    reader.Close();
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                request = null;
                requestStream = null;
                response = null;
            }

            return responseStr;
        }
    }
}
