namespace CaesarCipherApp
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelControls = new System.Windows.Forms.Panel();
            this.lblKey = new System.Windows.Forms.Label();
            this.numKey = new System.Windows.Forms.NumericUpDown();
            this.lblLang = new System.Windows.Forms.Label();
            this.cmbLanguage = new System.Windows.Forms.ComboBox();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.btnBruteForce = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.lblInput = new System.Windows.Forms.Label();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.lblOutput = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();

            this.menuStrip1.SuspendLayout();
            this.panelControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numKey)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();

            // menuStrip1
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";

            // fileToolStripMenuItem
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Text = "File";

            // openToolStripMenuItem
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Text = "Open...";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);

            // saveToolStripMenuItem
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Text = "Save...";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);

            // exitToolStripMenuItem
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);

            // panelControls
            this.panelControls.Controls.Add(this.btnBruteForce);
            this.panelControls.Controls.Add(this.btnDecrypt);
            this.panelControls.Controls.Add(this.btnEncrypt);
            this.panelControls.Controls.Add(this.cmbLanguage);
            this.panelControls.Controls.Add(this.lblLang);
            this.panelControls.Controls.Add(this.numKey);
            this.panelControls.Controls.Add(this.lblKey);
            this.panelControls.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControls.Location = new System.Drawing.Point(0, 24);
            this.panelControls.Name = "panelControls";
            this.panelControls.Size = new System.Drawing.Size(800, 50);
            this.panelControls.TabIndex = 1;

            // lblKey
            this.lblKey.AutoSize = true;
            this.lblKey.Location = new System.Drawing.Point(12, 15);
            this.lblKey.Name = "lblKey";
            this.lblKey.Text = "Key:";

            // numKey
            this.numKey.Location = new System.Drawing.Point(45, 13);
            this.numKey.Name = "numKey";
            this.numKey.Size = new System.Drawing.Size(60, 23);
            this.numKey.TabIndex = 0;
            this.numKey.Value = new decimal(new int[] { 3, 0, 0, 0 });

            // lblLang
            this.lblLang.AutoSize = true;
            this.lblLang.Location = new System.Drawing.Point(120, 15);
            this.lblLang.Name = "lblLang";
            this.lblLang.Text = "Lang:";

            // cmbLanguage
            this.cmbLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLanguage.FormattingEnabled = true;
            this.cmbLanguage.Items.AddRange(new object[] { "ENG", "UKR" });
            this.cmbLanguage.Location = new System.Drawing.Point(160, 12);
            this.cmbLanguage.Name = "cmbLanguage";
            this.cmbLanguage.Size = new System.Drawing.Size(80, 23);
            this.cmbLanguage.TabIndex = 1;
            this.cmbLanguage.SelectedIndex = 0;

            // btnEncrypt
            this.btnEncrypt.Location = new System.Drawing.Point(260, 11);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(75, 25);
            this.btnEncrypt.TabIndex = 2;
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);

            // btnDecrypt
            this.btnDecrypt.Location = new System.Drawing.Point(341, 11);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(75, 25);
            this.btnDecrypt.TabIndex = 3;
            this.btnDecrypt.Text = "Decrypt";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);

            // btnBruteForce
            this.btnBruteForce.Location = new System.Drawing.Point(422, 11);
            this.btnBruteForce.Name = "btnBruteForce";
            this.btnBruteForce.Size = new System.Drawing.Size(85, 25);
            this.btnBruteForce.TabIndex = 4;
            this.btnBruteForce.Text = "Brute Force";
            this.btnBruteForce.UseVisualStyleBackColor = true;
            this.btnBruteForce.Click += new System.EventHandler(this.btnBruteForce_Click);

            // splitContainer1
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 74);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            
            // splitContainer1.Panel1
            this.splitContainer1.Panel1.Controls.Add(this.txtInput);
            this.splitContainer1.Panel1.Controls.Add(this.lblInput);
            
            // splitContainer1.Panel2
            this.splitContainer1.Panel2.Controls.Add(this.txtOutput);
            this.splitContainer1.Panel2.Controls.Add(this.lblOutput);
            this.splitContainer1.Size = new System.Drawing.Size(800, 376);
            this.splitContainer1.SplitterDistance = 180;
            this.splitContainer1.TabIndex = 2;

            // lblInput
            this.lblInput.AutoSize = true;
            this.lblInput.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblInput.Location = new System.Drawing.Point(0, 0);
            this.lblInput.Name = "lblInput";
            this.lblInput.Padding = new System.Windows.Forms.Padding(5);
            this.lblInput.Text = "Input Text:";

            // txtInput
            this.txtInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtInput.Location = new System.Drawing.Point(0, 25);
            this.txtInput.Multiline = true;
            this.txtInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(800, 155);
            this.txtInput.TabIndex = 0;

            // lblOutput
            this.lblOutput.AutoSize = true;
            this.lblOutput.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblOutput.Location = new System.Drawing.Point(0, 0);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Padding = new System.Windows.Forms.Padding(5);
            this.lblOutput.Text = "Output Text:";

            // txtOutput
            this.txtOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtOutput.Location = new System.Drawing.Point(0, 25);
            this.txtOutput.Multiline = true;
            this.txtOutput.ReadOnly = true;
            this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(800, 167);
            this.txtOutput.TabIndex = 0;

            // MainForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panelControls);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Caesar Cipher App";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelControls.ResumeLayout(false);
            this.panelControls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numKey)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Panel panelControls;
        private System.Windows.Forms.Label lblKey;
        private System.Windows.Forms.NumericUpDown numKey;
        private System.Windows.Forms.Label lblLang;
        private System.Windows.Forms.ComboBox cmbLanguage;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.Button btnBruteForce;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}
