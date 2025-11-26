using System;
using System.Numerics;
using System.Text;
using System.Windows.Forms;
using KnapsackCipherApp.Core;

namespace KnapsackCipherApp
{
    public partial class MainForm : Form
    {
        private KnapsackCipher _cipher = new KnapsackCipher();

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnGenerateKeys_Click(object sender, EventArgs e)
        {
            try
            {
                int n = (int)numBlockSize.Value;
                _cipher.GenerateKeys(n);

                // Display Private Key
                StringBuilder sbPrivate = new StringBuilder();
                sbPrivate.AppendLine("Superincreasing Sequence (B):");
                sbPrivate.AppendLine(string.Join(", ", _cipher.B));
                sbPrivate.AppendLine($"Modulus (m): {_cipher.m}");
                sbPrivate.AppendLine($"Multiplier (t): {_cipher.t}");
                sbPrivate.AppendLine($"Inverse (t^-1): {_cipher.tInverse}");
                txtPrivateKey.Text = sbPrivate.ToString();

                // Display Public Key
                StringBuilder sbPublic = new StringBuilder();
                sbPublic.AppendLine("Public Key Sequence (A):");
                sbPublic.AppendLine(string.Join(", ", _cipher.A));
                txtPublicKey.Text = sbPublic.ToString();

                MessageBox.Show("Keys generated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                if (_cipher.A == null)
                {
                    MessageBox.Show("Please generate keys first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string message = txtInput.Text;
                BigInteger[] encrypted = _cipher.Encrypt(message);
                
                txtOutput.Text = string.Join(", ", encrypted);
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
                if (_cipher.B == null)
                {
                    MessageBox.Show("Please generate keys first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string cipherTextStr = txtInput.Text;
                string[] parts = cipherTextStr.Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
                
                BigInteger[] cipherText = new BigInteger[parts.Length];
                for (int i = 0; i < parts.Length; i++)
                {
                    cipherText[i] = BigInteger.Parse(parts[i]);
                }

                string decrypted = _cipher.Decrypt(cipherText);
                txtOutput.Text = decrypted;
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
