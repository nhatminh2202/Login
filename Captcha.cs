using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace WinFormsApp
{
    internal class Captcha
    {
        public string captchaText;
        public Captcha() { }


        // Hàm mã hóa MD5
        public static byte[] encryptData(string data)
        {
            MD5CryptoServiceProvider md5Hasher = new MD5CryptoServiceProvider();
            byte[] hashedBytes;
            UTF8Encoding encoder = new UTF8Encoding();
            hashedBytes = md5Hasher.ComputeHash(encoder.GetBytes(data));
            return hashedBytes;
        }
        public static string md5(string data)
        {
            return BitConverter.ToString(encryptData(data)).Replace("-", "").ToLower();
        }



        // Hàm tạo chuỗi captcha ngẫu

        public string randomString()
        {
            Random rd = new Random();
            int number = rd.Next(10000, 99999);
            string text = md5(number.ToString());
            text = text.ToUpper();
            text = text.Substring(0, 6);
            return text;
        }

        public void Reset()
        {
            captchaText = randomString();
        }

    }
}
