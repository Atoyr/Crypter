using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace tools
{
    class CryptoUtil
    {

        public static byte[][] GetRandomNumber(int bitSize,string key)
        {
            //入力されたパスワードをベースに擬似乱数を新たに生成
            Rfc2898DeriveBytes deriveBytes = new Rfc2898DeriveBytes(key, bitSize);
            byte[] salt = new byte[bitSize]; // Rfc2898DeriveBytesが内部生成したなソルトを取得
            salt = deriveBytes.Salt;
            // 生成した擬似乱数から16バイト切り出したデータをパスワードにする
            byte[] bufferKey = deriveBytes.GetBytes(bitSize);

            byte[][] returnByte = { salt, bufferKey };
            return returnByte;
        }

    }
}
