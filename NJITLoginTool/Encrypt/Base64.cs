using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NJITLoginTool.Encrypt
{
    class Base64
    {
        public static string Encrypt(byte[] bytedata)
        {
            return Convert.ToBase64String(bytedata);
        }

        public static byte[] Decrypt(string str)
        {
            return Convert.FromBase64String(str);
        }
    }
}
