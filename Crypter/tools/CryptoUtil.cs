using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace tools
{
    public class CryptoUtil
    {

        //TODO:Exception
        public static byte[] GetRandomNumber(int bitSize,string password)
        {
            Rfc2898DeriveBytes deriveBytes = new Rfc2898DeriveBytes(password, bitSize);
            return deriveBytes.GetBytes(bitSize);
        }

        public static byte[] GetRandomSalt(int bitSize, string password)
        {
            Rfc2898DeriveBytes deriveBytes = new Rfc2898DeriveBytes(password, bitSize);
            return deriveBytes.Salt;
        }

    }
}
