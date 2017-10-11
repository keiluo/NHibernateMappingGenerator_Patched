using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace NHibernateMappingGenerator
{
    /**/
    /// <summary>
    /// DataCrypto 的摘要说明
    /// </summary>
    public class EnDecodeHelper
    {
        private SymmetricAlgorithm mobjCryptoService;
        private string Key;
        /**/
        /// <summary>
        /// 对称加密类的构造函数
        /// </summary>
        public EnDecodeHelper()
        {
            mobjCryptoService = new RijndaelManaged();
            Key = "zly2017keiluo";
        }
        /**/
        /// <summary>
        /// 对称加密类的构造函数
        /// </summary>
        public EnDecodeHelper(string key)
        {
            mobjCryptoService = new RijndaelManaged();
            Key = key;
        }

        /**/
        /// <summary>
        /// 获得密钥
        /// </summary>
        /// <returns>密钥</returns>
        private byte[] GetLegalKey()
        {
            string sTemp = Key;
            mobjCryptoService.GenerateKey();
            byte[] bytTemp = mobjCryptoService.Key;
            int keyLength = bytTemp.Length;
            if (sTemp.Length > keyLength)
                sTemp = sTemp.Substring(0, keyLength);
            else if (sTemp.Length < keyLength)
                sTemp = sTemp.PadRight(keyLength, ' ');
            return ASCIIEncoding.ASCII.GetBytes(sTemp);
        }
        /**/
        /// <summary>
        /// 获得初始向量IV
        /// </summary>
        /// <returns>初试向量IV</returns>
        private byte[] GetLegalIv()
        {
            string sTemp = "keiluo2017zly";
            mobjCryptoService.GenerateIV();
            byte[] bytTemp = mobjCryptoService.IV;
            int ivLength = bytTemp.Length;
            if (sTemp.Length > ivLength)
                sTemp = sTemp.Substring(0, ivLength);
            else if (sTemp.Length < ivLength)
                sTemp = sTemp.PadRight(ivLength, ' ');
            return ASCIIEncoding.ASCII.GetBytes(sTemp);
        }
        /**/
        /// <summary>
        /// 加密方法
        /// </summary>
        /// <param name="Source">待加密的串</param>
        /// <returns>经过加密的串</returns>
        public string Encode(string Source)
        {
            byte[] bytIn = UTF8Encoding.UTF8.GetBytes(Source);
            MemoryStream ms = new MemoryStream();
            mobjCryptoService.Key = GetLegalKey();
            mobjCryptoService.IV = GetLegalIv();
            ICryptoTransform encrypto = mobjCryptoService.CreateEncryptor();
            CryptoStream cs = new CryptoStream(ms, encrypto, CryptoStreamMode.Write);
            cs.Write(bytIn, 0, bytIn.Length);
            cs.FlushFinalBlock();
            ms.Close();
            byte[] bytOut = ms.ToArray();
            return Convert.ToBase64String(bytOut);
        }
        /**/
        /// <summary>
        /// 解密方法
        /// </summary>
        /// <param name="source">待解密的串，必须是已经过本类加密过的字符串，否则将会失败</param>
        /// <returns>经过解密的串</returns>
        public string Decode(string source)
        {
            byte[] bytIn = Convert.FromBase64String(source);
            MemoryStream ms = new MemoryStream(bytIn, 0, bytIn.Length);
            mobjCryptoService.Key = GetLegalKey();
            mobjCryptoService.IV = GetLegalIv();
            ICryptoTransform encrypto = mobjCryptoService.CreateDecryptor();
            CryptoStream cs = new CryptoStream(ms, encrypto, CryptoStreamMode.Read);
            StreamReader sr = new StreamReader(cs);
            return sr.ReadToEnd();
        }
    }
}
