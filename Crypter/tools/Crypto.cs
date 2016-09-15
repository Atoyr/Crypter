using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace tools
{
    public abstract class Crypto
    {
        private bool isSettingBlockSize = false;
        private bool isSettingKeySize = false;
        private bool isSettingFeedbackSize = false;
        private bool isSettingMode = false;
        private bool isSettingPadding = false;
        private bool isSettingKey = false;
        private bool isSettingIV = false;

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
                            isSettingBlockSize = true;
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
                            isSettingKeySize = true;
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
                        isSettingFeedbackSize = true;
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
                    isSettingMode = true;
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
                    isSettingPadding = true;
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

        public int GenerateKey()
        {
            algorithm.GenerateKey();
            return 0;
        }

        public int GenerateIV()
        {
            algorithm.GenerateIV();
            return 0;
        }

        public ICryptoTransform GetEncryptor()
        {
            return algorithm.CreateEncryptor();
        }

        public ICryptoTransform GetEncryptor(byte[] key, byte[] iv)
        {
            return algorithm.CreateEncryptor(key, iv);
        }

        public ICryptoTransform GetDecryptor()
        {
            return algorithm.CreateDecryptor();
        }

        public ICryptoTransform GetDecryptor(byte[] key, byte[] iv)
        {
            return algorithm.CreateDecryptor(key, iv);
        }

        public abstract int GenerateEncryptFile();
        public abstract int GenerateDecryptFile();

    }
}
