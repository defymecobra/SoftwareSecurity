using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;
using CaesarCipherApp.Core;

namespace CaesarCipherApp
{
    public partial class MainForm : Form
    {
        private byte[]? _currentBytes; // To store binary data if loaded

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            try
            {
                int key = (int)numKey.Value;
                
                if (_currentBytes != null && string.IsNullOrEmpty(txtInput.Text))
                {
                    // Encrypt binary
                    var encrypted = CaesarCipher.EncryptBytes(_currentBytes, key);
                    // We cannot show binary in text box properly, but we can show hex or just a message
                    txtOutput.Text = $"[Binary Data Encrypted: {encrypted.Length} bytes]";
                    _currentBytes = encrypted; // Update current bytes to encrypted version? 
                    // Better logic: Keep input bytes separate. 
                    // But for simplicity, let's say we just show message and allow save.
                    MessageBox.Show("Binary data encrypted. Use 'File -> Save' to save it.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Encrypt text
                    string lang = cmbLanguage.SelectedItem?.ToString() ?? "ENG";
                    string input = txtInput.Text;
                    string output = CaesarCipher.EncryptText(input, key, lang);
                    txtOutput.Text = output;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            try
            {
                int key = (int)numKey.Value;
                
                if (_currentBytes != null && string.IsNullOrEmpty(txtInput.Text))
                {
                    // Decrypt binary
                    var decrypted = CaesarCipher.DecryptBytes(_currentBytes, key);
                    txtOutput.Text = $"[Binary Data Decrypted: {decrypted.Length} bytes]";
                    _currentBytes = decrypted;
                    MessageBox.Show("Binary data decrypted. Use 'File -> Save' to save it.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Decrypt text
                    string lang = cmbLanguage.SelectedItem?.ToString() ?? "ENG";
                    string input = txtInput.Text; // Or txtOutput.Text? Usually we decrypt what is in input or output. 
                    // Let's assume user puts text to decrypt in Input box.
                    string output = CaesarCipher.DecryptText(input, key, lang);
                    txtOutput.Text = output;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBruteForce_Click(object sender, EventArgs e)
        {
            try
            {
                string lang = cmbLanguage.SelectedItem?.ToString() ?? "ENG";
                string input = txtInput.Text;
                var results = BruteForce.Hack(input, lang);
                txtOutput.Text = string.Join(Environment.NewLine, results);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string path = openFileDialog1.FileName;
                string ext = Path.GetExtension(path).ToLower();

                if (ext == ".txt")
                {
                    txtInput.Text = FileManager.ReadText(path);
                    _currentBytes = null;
                }
                else
                {
                    // Binary mode
                    _currentBytes = FileManager.ReadBytes(path);
                    txtInput.Text = ""; // Clear text
                    txtOutput.Text = $"[Binary File Loaded: {Path.GetFileName(path)}]";
                }
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string path = saveFileDialog1.FileName;
                
                if (_currentBytes != null && string.IsNullOrEmpty(txtInput.Text))
                {
                    FileManager.WriteBytes(path, _currentBytes);
                }
                else
                {
                    FileManager.WriteText(path, txtOutput.Text);
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
