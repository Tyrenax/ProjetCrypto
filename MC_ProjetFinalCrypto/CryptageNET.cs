using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography;

namespace MC_ProjetFinalCrypto
{
    class CryptageNET
    {
        public byte[] Encrypt(string messageToEncrypt, string password)
        {
            //randArray est un 'salt'
            byte[] randArray = new byte[16];
            using (var rngTemp = RandomNumberGenerator.Create())
            {
                rngTemp.GetBytes(randArray);
            }

            // Cela va crée une clé de 32 octets utilisant l'algo PBKDF2
            var pbkdf2 = new Rfc2898DeriveBytes(password, randArray, 10000);
            byte[] key = pbkdf2.GetBytes(32);

            // AES cipher
            var aes = Aes.Create();
            aes.KeySize = 256; //ici on met =256 car ici la mesure est en bit pas en octet
            aes.Key = key; // clé plus élaborée
            aes.GenerateIV(); //genère un vecteur aléatoire (utlisé pour decrypt)

            // Encrypt le message
            /*using*/
            var encryptor = aes.CreateEncryptor();//utilise la clé
            /*using*/
            var ms = new MemoryStream();
            ms.Write(randArray, 0, randArray.Length);
            ms.Write(aes.IV, 0, aes.IV.Length);

            using (var cs = new CryptoStream(ms, encryptor, CryptoStreamMode.Write))
            using (var sw = new StreamWriter(cs))
            {
                sw.Write(messageToEncrypt);
            }

            return ms.ToArray();
        }
    }
}
