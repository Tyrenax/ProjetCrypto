
namespace MC_ProjetFinalCrypto
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.encrypt = new System.Windows.Forms.Button();
            this.MessageInitial = new System.Windows.Forms.TextBox();
            this.MessagePersoEncypt = new System.Windows.Forms.TextBox();
            this.decrypt = new System.Windows.Forms.Button();
            this.MessagePersoDecrypt = new System.Windows.Forms.TextBox();
            this.encryptNET = new System.Windows.Forms.Button();
            this.decryptNET = new System.Windows.Forms.Button();
            this.MessageEncryptNET = new System.Windows.Forms.TextBox();
            this.MessageDecryptNET = new System.Windows.Forms.TextBox();
            this.TextPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // encrypt
            // 
            this.encrypt.BackColor = System.Drawing.SystemColors.Control;
            this.encrypt.ForeColor = System.Drawing.SystemColors.ControlText;
            this.encrypt.Location = new System.Drawing.Point(110, 320);
            this.encrypt.Name = "encrypt";
            this.encrypt.Size = new System.Drawing.Size(150, 30);
            this.encrypt.TabIndex = 0;
            this.encrypt.Text = "Encrypt";
            this.encrypt.UseVisualStyleBackColor = false;
            this.encrypt.Click += new System.EventHandler(this.encrypt_Click);
            // 
            // MessageInitial
            // 
            this.MessageInitial.Location = new System.Drawing.Point(540, 96);
            this.MessageInitial.Name = "MessageInitial";
            this.MessageInitial.Size = new System.Drawing.Size(150, 20);
            this.MessageInitial.TabIndex = 1;
            this.MessageInitial.TextChanged += new System.EventHandler(this.MessageInitial_TextChanged);
            // 
            // MessagePersoEncypt
            // 
            this.MessagePersoEncypt.Location = new System.Drawing.Point(275, 407);
            this.MessagePersoEncypt.Name = "MessagePersoEncypt";
            this.MessagePersoEncypt.Size = new System.Drawing.Size(150, 20);
            this.MessagePersoEncypt.TabIndex = 2;
            this.MessagePersoEncypt.TextChanged += new System.EventHandler(this.MessagePersoEncypt_TextChanged);
            // 
            // decrypt
            // 
            this.decrypt.Location = new System.Drawing.Point(330, 320);
            this.decrypt.Name = "decrypt";
            this.decrypt.Size = new System.Drawing.Size(150, 30);
            this.decrypt.TabIndex = 3;
            this.decrypt.Text = "Decrypt";
            this.decrypt.UseVisualStyleBackColor = true;
            this.decrypt.Click += new System.EventHandler(this.decrypt_Click);
            // 
            // MessagePersoDecrypt
            // 
            this.MessagePersoDecrypt.Location = new System.Drawing.Point(284, 562);
            this.MessagePersoDecrypt.Name = "MessagePersoDecrypt";
            this.MessagePersoDecrypt.Size = new System.Drawing.Size(150, 20);
            this.MessagePersoDecrypt.TabIndex = 4;
            this.MessagePersoDecrypt.TextChanged += new System.EventHandler(this.MessagePersoDecrypt_TextChanged);
            // 
            // encryptNET
            // 
            this.encryptNET.Location = new System.Drawing.Point(770, 320);
            this.encryptNET.Name = "encryptNET";
            this.encryptNET.Size = new System.Drawing.Size(150, 30);
            this.encryptNET.TabIndex = 5;
            this.encryptNET.Text = "EncryptNET";
            this.encryptNET.UseVisualStyleBackColor = true;
            this.encryptNET.Click += new System.EventHandler(this.encryptNET_Click);
            // 
            // decryptNET
            // 
            this.decryptNET.Location = new System.Drawing.Point(1100, 320);
            this.decryptNET.Name = "decryptNET";
            this.decryptNET.Size = new System.Drawing.Size(150, 30);
            this.decryptNET.TabIndex = 6;
            this.decryptNET.Text = "DecryptNET";
            this.decryptNET.UseVisualStyleBackColor = true;
            this.decryptNET.Click += new System.EventHandler(this.decryptNET_Click);
            // 
            // MessageEncryptNET
            // 
            this.MessageEncryptNET.Location = new System.Drawing.Point(977, 414);
            this.MessageEncryptNET.Name = "MessageEncryptNET";
            this.MessageEncryptNET.Size = new System.Drawing.Size(345, 20);
            this.MessageEncryptNET.TabIndex = 7;
            this.MessageEncryptNET.TextChanged += new System.EventHandler(this.MessageEncryptNET_TextChanged);
            // 
            // MessageDecryptNET
            // 
            this.MessageDecryptNET.Location = new System.Drawing.Point(977, 562);
            this.MessageDecryptNET.Name = "MessageDecryptNET";
            this.MessageDecryptNET.Size = new System.Drawing.Size(150, 20);
            this.MessageDecryptNET.TabIndex = 8;
            this.MessageDecryptNET.TextChanged += new System.EventHandler(this.MessageDecryptNET_TextChanged);
            // 
            // TextPassword
            // 
            this.TextPassword.Location = new System.Drawing.Point(924, 195);
            this.TextPassword.Name = "TextPassword";
            this.TextPassword.Size = new System.Drawing.Size(153, 20);
            this.TextPassword.TabIndex = 9;
            this.TextPassword.TextChanged += new System.EventHandler(this.TextPassword_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.label1.Location = new System.Drawing.Point(367, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Message à crypter :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 407);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Message encryptage perso :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 565);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Message decryptage perso :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(719, 414);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Message encrypté avec NET :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(719, 562);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Message décrypté avec NET :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(784, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Mot de passe :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1384, 761);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextPassword);
            this.Controls.Add(this.MessageDecryptNET);
            this.Controls.Add(this.MessageEncryptNET);
            this.Controls.Add(this.decryptNET);
            this.Controls.Add(this.encryptNET);
            this.Controls.Add(this.MessagePersoDecrypt);
            this.Controls.Add(this.decrypt);
            this.Controls.Add(this.MessagePersoEncypt);
            this.Controls.Add(this.MessageInitial);
            this.Controls.Add(this.encrypt);
            this.Name = "Form1";
            this.Text = "Crypto app";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button encrypt;
        private System.Windows.Forms.TextBox MessageInitial;
        private System.Windows.Forms.TextBox MessagePersoEncypt;
        private System.Windows.Forms.Button decrypt;
        private System.Windows.Forms.TextBox MessagePersoDecrypt;
        private System.Windows.Forms.Button encryptNET;
        private System.Windows.Forms.Button decryptNET;
        private System.Windows.Forms.TextBox MessageEncryptNET;
        private System.Windows.Forms.TextBox MessageDecryptNET;
        private System.Windows.Forms.TextBox TextPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

