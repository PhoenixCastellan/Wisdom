using System.Web;

namespace Wisdom.Functions.Request
{
    public class BaseRequest:Request
    {
        /// <summary>
        /// 用户名
        /// </summary>
        public string userId { get; set; }

        /// <summary>
        /// 加密后密码
        /// </summary>
        public string userPwd { get; set; }

        /// <summary>
        /// RSA公钥加密明文
        /// </summary>
        public string secretKey { get; set; }
        
    }
}
