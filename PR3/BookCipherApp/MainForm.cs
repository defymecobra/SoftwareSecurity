using System;
using System.Windows.Forms;
using BookCipherApp.Core;

namespace BookCipherApp
{
    public partial class MainForm : Form
    {
        private BookCipher _cipher = new BookCipher();

        public MainForm()
        {
            InitializeComponent();
            UpdateGrid();
        }

        private void GridSizeChanged(object sender, EventArgs e)
        {
            UpdateGrid();
        }

        private void txtKey_TextChanged(object sender, EventArgs e)
        {
            UpdateGrid();
        }

        private void UpdateGrid()
        {
            int rows = (int)numRows.Value;
            int cols = (int)numCols.Value;
            string key = txtKey.Text;

            _cipher.LoadKey(key, rows, cols);

            // Update DataGridView
            gridKey.RowCount = rows;
            gridKey.ColumnCount = cols;

            for (int i = 0; i < cols; i++)
            {
                gridKey.Columns[i].Width = 30;
                gridKey.Columns[i].HeaderText = (i + 1).ToString();
            }

            for (int i = 0; i < rows; i++)
            {
                gridKey.Rows[i].HeaderCell.Value = (i + 1).ToString();
                for (int j = 0; j < cols; j++)
                {
                    gridKey.Rows[i].Cells[j].Value = _cipher.Grid[i, j];
                }
            }
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            try
            {
                txtOutput.Text = _cipher.Encrypt(txtInput.Text);
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
                txtOutput.Text = _cipher.Decrypt(txtInput.Text);
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
