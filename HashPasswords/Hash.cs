using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace HashPasswords
{
    public class Hash
    {
       public static string ConvertTo_SHA256(string password)
        {
            using (SHA256 mySHA256 = SHA256.Create())
            {
                byte[] sourceBytePassw = Encoding.UTF8.GetBytes(password);
                byte[] hashSourceBytePassw = mySHA256.ComputeHash(sourceBytePassw);
                string hassPassw = BitConverter.ToString(hashSourceBytePassw).Replace("-", String.Empty);
                return hassPassw;
            }
        }
    }
}
