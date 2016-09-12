using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace tools
{
    class AesCrypto : Crypto
    {
        public override SymmetricAlgorithm Algorithm
        {
            get
            {
                if(algorithm == null || algorithm.GetType() != typeof(AesCryptoServiceProvider))
                {
                    algorithm = new AesCryptoServiceProvider();
                }

                return algorithm;
            }
        }
    }
}
