using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RSATest
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "{\"sc\":\"his51\",\"no\":\"1\",\"na\":\"管理员\"}{\"sc\":\"@his51\",\"no\":\"1\",\"na\":\"管理员\"}{\"sc\":\"his51\",\"no\":\"1\",\"na\":\"管员\"}{\"sc\":\"his522";
            RSAHelper.RSAKey keyPair = RSAHelper.GetRASKey();
            Console.WriteLine("公钥:" + keyPair.PublicKey + "\r\n");
            Console.WriteLine("私钥:" + keyPair.PrivateKey + "\r\n");
            string en = RSAHelper.EncryptString(str, keyPair.PrivateKey);
            Console.WriteLine("加密后："+en + "\r\n");
            Console.WriteLine("解密："+RSAHelper.DecryptString(en, keyPair.PublicKey) + "\r\n");
            Console.ReadKey();
        }
    }
}
