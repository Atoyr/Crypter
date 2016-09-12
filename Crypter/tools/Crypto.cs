using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace tools
{
    abstract class Crypto
    {
        protected SymmetricAlgorithm algorithm;

        public abstract SymmetricAlgorithm Algorithm { get; }

        public int BlockSize
        {
            set
            {
                if (algorithm != null)
                {
                    bool success = false;
                    foreach (KeySizes k in algorithm.LegalBlockSizes)
                    {
                        if (k.MinSize <= value && value <= k.MaxSize)
                        {
                            algorithm.BlockSize = value;
                            success = true;
                            break;
                        }
                    }
                    if (!success)
                    {
                        throw new CryptographicException("ブロック サイズが無効です。");
                    }
                }
                else
                {
                    throw new NullReferenceException("Algorithm is Null.");
                }
            }

            get
            {
                if (algorithm != null)
                {
                    return algorithm.BlockSize;
                }
                else
                {
                    throw new NullReferenceException("Algorithm is Null.");
                }
            }
        }

        public int KeySize
        {
            set
            {
                if (algorithm != null)
                {
                    bool success = false;
                    foreach (KeySizes k in algorithm.LegalKeySizes)
                    {
                        if (k.MinSize <= value && value <= k.MaxSize)
                        {
                            algorithm.KeySize = value;
                            success = true;
                            break;
                        }
                    }
                    if (!success)
                    {
                        throw new CryptographicException("キー サイズが有効ではありません。");
                    }
                }
                else
                {
                    throw new NullReferenceException("Algorithm is Null.");
                }
            }

            get
            {
                if (algorithm != null)
                {
                    return algorithm.BlockSize;
                }
                else
                {
                    throw new NullReferenceException("Algorithm is Null.");
                }
            }
        }

        public int FeedbackSize
        {
            set
            {
                if (algorithm != null)
                {
                    if (0 <= value && value <= algorithm.BlockSize)
                    {
                        algorithm.FeedbackSize = value;
                    }
                    else
                    {
                        throw new CryptographicException("フィードバック サイズがブロック サイズを超えています。");
                    }
                }
                else
                {
                    throw new NullReferenceException("Algorithm is Null.");
                }
            }

            get
            {
                if (algorithm != null)
                {
                    return algorithm.FeedbackSize;
                }
                else
                {
                    throw new NullReferenceException("Algorithm is Null.");
                }
            }
        }

        public CipherMode Mode
        {
            set
            {
                if (algorithm != null)
                {
                    algorithm.Mode = value;
                }
                else
                {
                    throw new NullReferenceException("Algorithm is Null.");
                }
            }

            get
            {
                if (algorithm != null)
                {
                    return algorithm.Mode;
                }
                else
                {
                    throw new NullReferenceException("Algorithm is Null.");
                }
            }
        }

        public PaddingMode Padding
        {
            set
            {
                if (algorithm != null)
                {
                    algorithm.Padding = value;
                }
                else
                {
                    throw new NullReferenceException("Algorithm is Null.");
                }
            }

            get
            {
                if (algorithm != null)
                {
                    return algorithm.Padding;
                }
                else
                {
                    throw new NullReferenceException("Algorithm is Null.");
                }
            }
        }

        public byte[] Key
        {
            //TODO:Exception
            set
            {
                algorithm.Key = value;
            }

            get
            {
                return algorithm.Key;
            }
        }

        public byte[] IV
        {
            //TODO:Exception
            set
            {
                algorithm.IV = value;
            }

            get
            {
                return algorithm.IV;
            }
        }
    }
}
