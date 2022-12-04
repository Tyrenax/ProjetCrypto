using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MC_ProjetFinalCrypto
{
    public partial class Form1 : Form
    {
        private CryptagePerso crypt;
        private byte[] cipher;
       

        public Form1()
        {
            InitializeComponent();



            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial", 12, FontStyle.Bold);
            label1.ForeColor = Color.LightBlue;

            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial", 12, FontStyle.Bold);
            label2.ForeColor = Color.LightBlue;

            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Arial", 12, FontStyle.Bold);
            label3.ForeColor = Color.LightBlue;

            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Arial", 12, FontStyle.Bold);
            label4.ForeColor = Color.LightBlue;

            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Arial", 12, FontStyle.Bold);
            label5.ForeColor = Color.LightBlue;

            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Arial", 12, FontStyle.Bold);
            label6.ForeColor = Color.LightBlue;



        }
        

            private void encrypt_Click(object sender, EventArgs e)
        {
            string message = MessageInitial.Text;
            crypt = new CryptagePerso();
            string encryptedMessage = crypt.EncryptMessage(message);
            MessagePersoEncypt.Text = encryptedMessage;


        }

        private void MessageInitial_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void MessagePersoEncypt_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void decrypt_Click(object sender, EventArgs e)
        {
            var decrypt = new DecryptagePerso();
            int[] encrypt = crypt.encrypted;
            int[,] key = crypt.key;
            string decryptedMessage = decrypt.DecryptMessage(key, encrypt);
            MessagePersoDecrypt.Text = decryptedMessage;


        }

        private void MessagePersoDecrypt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void MessageDecryptNET_TextChanged(object sender, EventArgs e)
        {

        }

        private void MessageEncryptNET_TextChanged(object sender, EventArgs e)
        {

        }

        private void encryptNET_Click(object sender, EventArgs e)
        {
            string message = MessageInitial.Text;
            var cryptNET = new CryptageNET();
            string password = TextPassword.Text;
            cipher =cryptNET.Encrypt(message,password);
            MessageEncryptNET.Text = Convert.ToBase64String(cipher);

        }

        private void decryptNET_Click(object sender, EventArgs e)
        {
            var decryptNET = new DecryptageNET();
            string password = TextPassword.Text;
            var cipherdecrypt = decryptNET.Decrypt(cipher, password);
            MessageDecryptNET.Text = cipherdecrypt;

        }

        private void TextPassword_TextChanged(object sender, EventArgs e)
        {
            TextPassword.PasswordChar= '*';
        }

    }
}
