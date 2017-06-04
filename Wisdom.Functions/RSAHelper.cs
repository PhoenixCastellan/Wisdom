using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace Wisdom.Functions
{
    public class RsaHelper
    {


        public static string RSAEncryptStr(string encryptString)
        {
            System.Security.Cryptography.RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
            //rsa.FromXmlString(xmlPublicKey);
            //string path = System.IO.Path.Combine(HttpRuntime.AppDomainAppPath, "Config\\publicKey.key");
            RSAParameters paraPub = ConvertFromPublicKey(GlobalInfo.Pbkey);
            rsa.ImportParameters(paraPub);
            var plainTextBArray = System.Text.Encoding.UTF8.GetBytes(encryptString);
            var cypherTextBArray = rsa.Encrypt(plainTextBArray, false);
            var result = Convert.ToBase64String(cypherTextBArray);
            return result;
        }

        private static RSAParameters ConvertFromPublicKey(string pemFileConent)
        {
            byte[] keyData = Convert.FromBase64String(pemFileConent);
            if (keyData.Length < 162)
            {
                throw new ArgumentException("pem file content is incorrect.");
            }
            byte[] pemModulus = new byte[128];
            byte[] pemPublicExponent = new byte[3];
            Array.Copy(keyData, 29, pemModulus, 0, 128);
            Array.Copy(keyData, 159, pemPublicExponent, 0, 3);
            RSAParameters para = new RSAParameters();
            para.Modulus = pemModulus;
            para.Exponent = pemPublicExponent;
            return para;
        }

        /// <summary>
        /// 获取密钥
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static string ReadPublicKey(string path)
        {
            using (System.IO.StreamReader reader = new StreamReader(path))
            {
                string publickey = reader.ReadToEnd();
                return publickey;
            }
        }


        public static string GetScretKey()
        {
            return RSAEncryptStr("hurongclub");  
        }

        #region AES加密

        public static String getEncString(String strContent)
        {
            //实际应该是调用java Demo 中的getKey("随机密码")，但是该函数在c#中暂时无法实现
            //所以我们将临时密钥固定写死为"hurongclub"，在测试环境调用java中getkey("hurongclub")，并将返回值用base64编码后写死在程序里      	

            Byte[] rr = Convert.FromBase64String("xyhhm1b6KEV37aOKYK/GTA==");
            //这个java函数目前在c#中无法实现	 
            /*	 public static SecretKey getKey(String strKey) {
                try {
                    KeyGenerator _generator = KeyGenerator.getInstance("AES");
                    SecureRandom secureRandom = SecureRandom.getInstance("SHA1PRNG");
                    secureRandom.setSeed(strKey.getBytes());
                    _generator.init(128, secureRandom);
                    return _generator.generateKey();
                } catch (Exception e) {
                    throw new RuntimeException("初始化密钥出现异常");
                }
            }  */
            Byte[] toEncryptArray = Encoding.UTF8.GetBytes(strContent);
            System.Security.Cryptography.RijndaelManaged rm = new System.Security.Cryptography.RijndaelManaged
            {
                Key = rr,
                Mode = System.Security.Cryptography.CipherMode.ECB,
                Padding = System.Security.Cryptography.PaddingMode.PKCS7
            };

            System.Security.Cryptography.ICryptoTransform cTransform = rm.CreateEncryptor();
            Byte[] resultArray = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);
            return Convert.ToBase64String(resultArray, 0, resultArray.Length);
        }

        //private string GetBase64String()
        //{
        //    return 
        //}

        //public static SecretKey getKey(String strKey)
        //{
        //    try
        //    {
        //        KeyGenerator _generator = KeyGenerator.getInstance("AES");
        //        SecureRandom secureRandom = SecureRandom.getInstance("SHA1PRNG");
        //        secureRandom.setSeed(strKey.getBytes());
        //        _generator.init(128, secureRandom);
        //        return _generator.generateKey();
        //    }
        //    catch (Exception e)
        //    {
        //        throw new RuntimeException("初始化密钥出现异常");
        //    }
        //}
        #endregion
    }
}
