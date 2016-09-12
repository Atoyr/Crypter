using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tools
{
    partial class Crypto
    {
        private System.Security.Cryptography.SymmetricAlgorithm algorithm;

        public int BlockSize
        {
            set
            {
                if (algorithm != null)
                {

                    algorithm.BlockSize = value;
                }
            }
            get
            {
                if (algorithm != null)
                {
                    return algorithm.BlockSize;
                }
                return -1;
            }
        }
        public int KeySize;
        public System.Security.Cryptography.CipherMode mode;

    }

    /// <summary>
    /// いらないんじゃない？？？
    /// 
    /// </summary>
    class CryptoType
    {
        private System.Security.Cryptography.SymmetricAlgorithm algorithm;

        public int BlockSize
        {
            set {
                if (algorithm != null )
                {
                    algorithm.BlockSize = value;
                }
            }
            gey { }
        }
        public int KeySize;
        public System.Security.Cryptography.CipherMode mode;



    }
}
