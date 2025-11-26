using System;
using System.Text;
using System.Windows.Forms;
using DESCipherApp.Core;

namespace DESCipherApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private byte[] GetKeyBytes()
        {
            string key = txtKey.Text;
            if (key.Length != 8)
            {
                throw new ArgumentException("Key must be exactly 8 characters (64 bits).");
            }
            return Encoding.ASCII.GetBytes(key);
        }

        private byte[] GetIVBytes()
        {
            string iv = txtIV.Text;
            if (iv.Length != 8)
            {
                throw new ArgumentException("IV must be exactly 8 characters (64 bits).");
            }
            return Encoding.ASCII.GetBytes(iv);
        }

        private void btnEncryptText_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] key = GetKeyBytes();
                byte[] iv = GetIVBytes();
                string plainText = txtInput.Text;

                string encrypted = DESCipher.EncryptText(plainText, key, iv);
                txtOutput.Text = encrypted;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Encryption Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDecryptText_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] key = GetKeyBytes();
                byte[] iv = GetIVBytes();
                string cipherText = txtInput.Text;

                string decrypted = DESCipher.DecryptText(cipherText, key, iv);
                txtOutput.Text = decrypted;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Decryption Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEncryptFile_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] key = GetKeyBytes();
                byte[] iv = GetIVBytes();

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string inputPath = openFileDialog1.FileName;
                    
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        string outputPath = saveFileDialog1.FileName;
                        DESCipher.EncryptFile(inputPath, outputPath, key, iv);
                        MessageBox.Show("File encrypted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "File Encryption Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDecryptFile_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] key = GetKeyBytes();
                byte[] iv = GetIVBytes();

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string inputPath = openFileDialog1.FileName;
                    
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        string outputPath = saveFileDialog1.FileName;
                        DESCipher.DecryptFile(inputPath, outputPath, key, iv);
                        MessageBox.Show("File decrypted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "File Decryption Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
