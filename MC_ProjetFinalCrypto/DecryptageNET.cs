using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MC_ProjetFinalCrypto
{
    class DecryptageNET
    {
        public string Decrypt(byte[] ciphertext, string password)
        {
            // Extract the randArray and IV from the ciphertext
            byte[] randArray = new byte[16];
            byte[] iv = new byte[16];
            Array.Copy(ciphertext, 0, randArray, 0, 16);
            Array.Copy(ciphertext, 16, iv, 0, 16);

            // Derive the key using PBKDF2
            var pbkdf2 = new Rfc2898DeriveBytes(password, randArray, 10000);
            byte[] key = pbkdf2.GetBytes(32);

            // Create an AES-256 cipher
            var aes = Aes.Create();
            aes.KeySize = 256;
            aes.Key = key;
            aes.IV = iv;

            // Decrypt the ciphertext using the cipher
            /*using*/ var decryptor = aes.CreateDecryptor();
            /*using*/ var ms = new MemoryStream(ciphertext, 32, ciphertext.Length - 32);
            /*using*/ var cs = new CryptoStream(ms, decryptor, CryptoStreamMode.Read);
            /*using*/ var sr = new StreamReader(cs);
            return sr.ReadToEnd();
        }

    }
}
