using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathNet.Numerics.LinearAlgebra;

namespace MC_ProjetFinalCrypto
{
    class DecryptagePerso
    {
        public string DecryptMessage(int[,] key, int[] encrypted)
        {
            
            int keyRow = key.GetLength(0);
            int keyCol = key.GetLength(1);

            double[,] keyArray = new double[keyRow, keyCol];
            for (int i = 0; i < keyRow; i++)
            {
                for (int j = 0; j < keyCol; j++)
                {
                    keyArray[i, j] = (double)key[i, j];
                }
            }
            Matrix<double> inverseKey = Matrix<double>.Build.DenseOfArray(keyArray).Inverse();

            double[] decrypted = new double[encrypted.Length];
            for (int i = 0; i < inverseKey.RowCount; i++)
            {
                for (int j = 0; j < encrypted.Length; j++)
                {
                    decrypted[i] += inverseKey[i, j] * encrypted[j];
                }
            }
            int[] decrypted2 = Array.ConvertAll(decrypted, x => (int)x);

            string finalDecryptedMessage = "";
            foreach (int num in decrypted2)
            {
                finalDecryptedMessage += (char)(num % 26 + 'A' + 32);
            }
            return finalDecryptedMessage;
            //System.Console.WriteLine("This is the decrypted message :");
            //System.Console.WriteLine(finalDecryptedMessage);
        }

    }
}
