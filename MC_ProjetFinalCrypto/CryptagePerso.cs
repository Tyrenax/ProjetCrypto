using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MC_ProjetFinalCrypto
{
    class CryptagePerso
    {
        public int[] encrypted;
        public int[,] key;

        public string EncryptMessage(string message)
        {
            int[] col = Fonction.GetColumnVector(message);

            key = Fonction.GenerateMatrix(col.Length);
            int keyRow = key.GetLength(0);
            int keyCol = key.GetLength(1);

            // Initialize the encrypted array as a class field
            encrypted = new int[col.Length];

            for (int i = 0; i < col.Length; i++)
            {
                for (int j = 0; j < col.Length; j++)
                {
                    encrypted[i] += key[i, j] * col[j];
                }
            }

            string finalEncryptedMessage = "";
            foreach (int num in encrypted)
            {
                finalEncryptedMessage += (char)(num % 26 + 'A');
            }
            return finalEncryptedMessage;

            //System.Console.WriteLine("This is the encrypted message : ");
            //System.Console.WriteLine(finalEncryptedMessage);
        }

        /*Console.WriteLine("Key matrix:");
        for (int i = 0; i < key.GetLength(0); i++)
        {
            for (int j = 0; j < key.GetLength(1); j++)
            {
                Console.Write(key[i, j] + " ");
            }
            Console.WriteLine();
        }*/
    }
 }

