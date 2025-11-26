using System;
using System.IO;
using System.Windows.Forms;
using TrithemiusApp.Core;

namespace TrithemiusApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            cmbKeyType.SelectedIndex = 0; // Default to Linear
            cmbLanguage.SelectedIndex = 0; // Default to ENG
        }

        private void cmbKeyType_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 0 = Linear, 1 = Non-Linear, 2 = Motto
            int index = cmbKeyType.SelectedIndex;
            
            // Linear: A, B
            // Non-Linear: A, B, C
            // Motto: Motto Text

            lblA.Visible = numA.Visible = (index == 0 || index == 1);
            lblB.Visible = numB.Visible = (index == 0 || index == 1);
            lblC.Visible = numC.Visible = (index == 1);
            
            lblMotto.Visible = txtMotto.Visible = (index == 2);
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            Process(true);
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            Process(false);
        }

        private void Process(bool encrypt)
        {
            try
            {
                string input = txtInput.Text;
                string lang = cmbLanguage.SelectedItem?.ToString() ?? "ENG";
                KeyType type = (KeyType)cmbKeyType.SelectedIndex;
                object[] keyParams = GetKeyParams(type);

                string output = encrypt 
                    ? TrithemiusCipher.Encrypt(input, type, keyParams, lang)
                    : TrithemiusCipher.Decrypt(input, type, keyParams, lang);

                txtOutput.Text = output;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private object[] GetKeyParams(KeyType type)
        {
            switch (type)
            {
                case KeyType.Linear:
                    return new object[] { (int)numA.Value, (int)numB.Value };
                case KeyType.NonLinear:
                    return new object[] { (int)numA.Value, (int)numB.Value, (int)numC.Value };
                case KeyType.Motto:
                    return new object[] { txtMotto.Text };
                default:
                    return new object[] { };
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
