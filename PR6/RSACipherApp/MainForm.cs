using System;
using System.Windows.Forms;
using RSACipherApp.Core;

namespace RSACipherApp
{
    public partial class MainForm : Form
    {
        private RSACipher _rsa;

        public MainForm()
        {
            InitializeComponent();
            _rsa = new RSACipher();
            UpdateKeyDisplays();
        }

        private void UpdateKeyDisplays()
        {
            txtPublicKey.Text = _rsa.GetPublicKeyXml();
            txtPrivateKey.Text = _rsa.GetPrivateKeyXml();
        }

        private void btnGenerateKeys_Click(object sender, EventArgs e)
        {
            try
            {
                _rsa.GenerateKeys();
                UpdateKeyDisplays();
                MessageBox.Show("New keys generated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error generating keys: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            try
            {
                string plainText = txtInput.Text;
                string publicKeyXml = txtPublicKey.Text;

                if (string.IsNullOrWhiteSpace(plainText))
                {
                    MessageBox.Show("Please enter text to encrypt.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string encryptedBase64 = _rsa.Encrypt(plainText, publicKeyXml);
                txtOutput.Text = encryptedBase64;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error encrypting: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            try
            {
                string cipherTextBase64 = txtInput.Text;
                string privateKeyXml = txtPrivateKey.Text;

                if (string.IsNullOrWhiteSpace(cipherTextBase64))
                {
                    MessageBox.Show("Please enter ciphertext to decrypt.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string decryptedText = _rsa.Decrypt(cipherTextBase64, privateKeyXml);
                txtOutput.Text = decryptedText;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error decrypting: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtInput.Text = FileManager.ReadText(openFileDialog1.FileName);
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FileManager.WriteText(saveFileDialog1.FileName, txtOutput.Text);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
