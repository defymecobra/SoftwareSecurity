using System;
using System.Windows.Forms;
using DigitalSignatureApp.Core;

namespace DigitalSignatureApp
{
    public partial class MainForm : Form
    {
        private DigitalSignature _digitalSignature;

        public MainForm()
        {
            InitializeComponent();
            _digitalSignature = new DigitalSignature();
            UpdateKeyDisplays();
        }

        private void UpdateKeyDisplays()
        {
            txtPublicKey.Text = _digitalSignature.GetPublicKeyXml();
            txtPrivateKey.Text = _digitalSignature.GetPrivateKeyXml();
        }

        private void btnGenerateKeys_Click(object sender, EventArgs e)
        {
            try
            {
                _digitalSignature.GenerateKeys();
                UpdateKeyDisplays();
                MessageBox.Show("New keys generated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error generating keys: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSign_Click(object sender, EventArgs e)
        {
            try
            {
                string message = txtMessage.Text;
                string privateKeyXml = txtPrivateKey.Text;

                if (string.IsNullOrWhiteSpace(message))
                {
                    MessageBox.Show("Please enter a message to sign.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string signature = _digitalSignature.SignMessage(message, privateKeyXml);
                txtSignature.Text = signature;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error signing message: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            try
            {
                string message = txtMessage.Text;
                string signatureHex = txtSignature.Text;
                string publicKeyXml = txtPublicKey.Text;

                if (string.IsNullOrWhiteSpace(message) || string.IsNullOrWhiteSpace(signatureHex))
                {
                    MessageBox.Show("Please enter both message and signature.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                bool isValid = _digitalSignature.VerifySignature(message, signatureHex, publicKeyXml);
                
                if (isValid)
                {
                    MessageBox.Show("Signature is VALID ✓", "Verification Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Signature is INVALID ✗", "Verification Result", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error verifying signature: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtMessage.Text = FileManager.ReadText(openFileDialog1.FileName);
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FileManager.WriteText(saveFileDialog1.FileName, txtSignature.Text);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
