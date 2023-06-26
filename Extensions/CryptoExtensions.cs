using System.Security.Cryptography;
using System.Text;

namespace BoltBit.Core.Extensions;

public class CryptoExtensions
{
    private static string EnDecKey = "6D980A831EC94C98A2AEF8702A8D93F1";

    public static string EncryptString(string plainText)
    {
        byte[] array;
        using (Aes aes = Aes.Create())
        {
            aes.Key = Encoding.UTF8.GetBytes(EnDecKey);
            using (var cryptoServiceProvider = new AesCryptoServiceProvider())
            {
                ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key, cryptoServiceProvider.IV);
                using (MemoryStream memoryStream = new MemoryStream())
                {
                    using (CryptoStream cryptoStream = new CryptoStream((Stream) memoryStream, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter streamWriter = new StreamWriter((Stream) cryptoStream))
                            streamWriter.Write(plainText);
                        array = memoryStream.ToArray();
                    }
                }
            }
        }
        return Convert.ToBase64String(array);
    }

    public static string DecryptString(string cipherText)
    {
        byte[] numArray = new byte[16];
        byte[] buffer = Convert.FromBase64String(cipherText);
        using (Aes aes = Aes.Create())
        {
            aes.Key = Encoding.UTF8.GetBytes(CryptoExtensions.EnDecKey);
            aes.IV = numArray;
            ICryptoTransform decryptor = aes.CreateDecryptor(aes.Key, aes.IV);
            using (MemoryStream memoryStream = new MemoryStream(buffer))
            {
                using (CryptoStream cryptoStream = new CryptoStream((Stream) memoryStream, decryptor, CryptoStreamMode.Read))
                {
                    using (StreamReader streamReader = new StreamReader((Stream) cryptoStream))
                        return streamReader.ReadToEnd();
                }
            }
        }
    }
}