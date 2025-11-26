namespace TrithemiusApp
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
            this.grpKey = new System.Windows.Forms.GroupBox();
            this.lblC = new System.Windows.Forms.Label();
            this.numC = new System.Windows.Forms.NumericUpDown();
            this.lblB = new System.Windows.Forms.Label();
            this.numB = new System.Windows.Forms.NumericUpDown();
            this.lblA = new System.Windows.Forms.Label();
            this.numA = new System.Windows.Forms.NumericUpDown();
            this.txtMotto = new System.Windows.Forms.TextBox();
            this.lblMotto = new System.Windows.Forms.Label();
            this.cmbKeyType = new System.Windows.Forms.ComboBox();
            this.lblKeyType = new System.Windows.Forms.Label();
            this.lblLang = new System.Windows.Forms.Label();
            this.cmbLanguage = new System.Windows.Forms.ComboBox();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.lblInput = new System.Windows.Forms.Label();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.lblOutput = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();

            this.menuStrip1.SuspendLayout();
            this.panelControls.SuspendLayout();
            this.grpKey.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numA)).BeginInit();
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
            this.panelControls.Controls.Add(this.grpKey);
            this.panelControls.Controls.Add(this.cmbKeyType);
            this.panelControls.Controls.Add(this.lblKeyType);
            this.panelControls.Controls.Add(this.btnDecrypt);
            this.panelControls.Controls.Add(this.btnEncrypt);
            this.panelControls.Controls.Add(this.cmbLanguage);
            this.panelControls.Controls.Add(this.lblLang);
            this.panelControls.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControls.Location = new System.Drawing.Point(0, 24);
            this.panelControls.Name = "panelControls";
            this.panelControls.Size = new System.Drawing.Size(800, 100);
            this.panelControls.TabIndex = 1;

            // lblKeyType
            this.lblKeyType.AutoSize = true;
            this.lblKeyType.Location = new System.Drawing.Point(12, 15);
            this.lblKeyType.Name = "lblKeyType";
            this.lblKeyType.Text = "Key Type:";

            // cmbKeyType
            this.cmbKeyType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKeyType.FormattingEnabled = true;
            this.cmbKeyType.Items.AddRange(new object[] { "Linear (A*p + B)", "Non-Linear (A*p^2 + B*p + C)", "Motto" });
            this.cmbKeyType.Location = new System.Drawing.Point(75, 12);
            this.cmbKeyType.Name = "cmbKeyType";
            this.cmbKeyType.Size = new System.Drawing.Size(200, 23);
            this.cmbKeyType.TabIndex = 0;
            this.cmbKeyType.SelectedIndexChanged += new System.EventHandler(this.cmbKeyType_SelectedIndexChanged);

            // grpKey
            this.grpKey.Controls.Add(this.lblC);
            this.grpKey.Controls.Add(this.numC);
            this.grpKey.Controls.Add(this.lblB);
            this.grpKey.Controls.Add(this.numB);
            this.grpKey.Controls.Add(this.lblA);
            this.grpKey.Controls.Add(this.numA);
            this.grpKey.Controls.Add(this.txtMotto);
            this.grpKey.Controls.Add(this.lblMotto);
            this.grpKey.Location = new System.Drawing.Point(12, 41);
            this.grpKey.Name = "grpKey";
            this.grpKey.Size = new System.Drawing.Size(776, 50);
            this.grpKey.TabIndex = 5;
            this.grpKey.TabStop = false;
            this.grpKey.Text = "Key Parameters";

            // lblA
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(10, 22);
            this.lblA.Name = "lblA";
            this.lblA.Text = "A:";
            
            // numA
            this.numA.Location = new System.Drawing.Point(30, 20);
            this.numA.Name = "numA";
            this.numA.Size = new System.Drawing.Size(50, 23);
            this.numA.TabIndex = 0;

            // lblB
            this.lblB.AutoSize = true;
            this.lblB.Location = new System.Drawing.Point(90, 22);
            this.lblB.Name = "lblB";
            this.lblB.Text = "B:";

            // numB
            this.numB.Location = new System.Drawing.Point(110, 20);
            this.numB.Name = "numB";
            this.numB.Size = new System.Drawing.Size(50, 23);
            this.numB.TabIndex = 1;

            // lblC
            this.lblC.AutoSize = true;
            this.lblC.Location = new System.Drawing.Point(170, 22);
            this.lblC.Name = "lblC";
            this.lblC.Text = "C:";

            // numC
            this.numC.Location = new System.Drawing.Point(190, 20);
            this.numC.Name = "numC";
            this.numC.Size = new System.Drawing.Size(50, 23);
            this.numC.TabIndex = 2;

            // lblMotto
            this.lblMotto.AutoSize = true;
            this.lblMotto.Location = new System.Drawing.Point(10, 22);
            this.lblMotto.Name = "lblMotto";
            this.lblMotto.Text = "Motto:";
            this.lblMotto.Visible = false;

            // txtMotto
            this.txtMotto.Location = new System.Drawing.Point(60, 19);
            this.txtMotto.Name = "txtMotto";
            this.txtMotto.Size = new System.Drawing.Size(200, 23);
            this.txtMotto.TabIndex = 3;
            this.txtMotto.Visible = false;

            // lblLang
            this.lblLang.AutoSize = true;
            this.lblLang.Location = new System.Drawing.Point(300, 15);
            this.lblLang.Name = "lblLang";
            this.lblLang.Text = "Lang:";

            // cmbLanguage
            this.cmbLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLanguage.FormattingEnabled = true;
            this.cmbLanguage.Items.AddRange(new object[] { "ENG", "UKR" });
            this.cmbLanguage.Location = new System.Drawing.Point(340, 12);
            this.cmbLanguage.Name = "cmbLanguage";
            this.cmbLanguage.Size = new System.Drawing.Size(80, 23);
            this.cmbLanguage.TabIndex = 1;
            this.cmbLanguage.SelectedIndex = 0;

            // btnEncrypt
            this.btnEncrypt.Location = new System.Drawing.Point(440, 11);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(75, 25);
            this.btnEncrypt.TabIndex = 2;
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);

            // btnDecrypt
            this.btnDecrypt.Location = new System.Drawing.Point(521, 11);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(75, 25);
            this.btnDecrypt.TabIndex = 3;
            this.btnDecrypt.Text = "Decrypt";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);

            // splitContainer1
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 124);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            
            // splitContainer1.Panel1
            this.splitContainer1.Panel1.Controls.Add(this.txtInput);
            this.splitContainer1.Panel1.Controls.Add(this.lblInput);
            
            // splitContainer1.Panel2
            this.splitContainer1.Panel2.Controls.Add(this.txtOutput);
            this.splitContainer1.Panel2.Controls.Add(this.lblOutput);
            this.splitContainer1.Size = new System.Drawing.Size(800, 326);
            this.splitContainer1.SplitterDistance = 150;
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
            this.txtInput.Size = new System.Drawing.Size(800, 125);
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
            this.txtOutput.Size = new System.Drawing.Size(800, 147);
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
            this.Text = "Trithemius Cipher App";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelControls.ResumeLayout(false);
            this.panelControls.PerformLayout();
            this.grpKey.ResumeLayout(false);
            this.grpKey.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numA)).EndInit();
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
        private System.Windows.Forms.Label lblKeyType;
        private System.Windows.Forms.ComboBox cmbKeyType;
        private System.Windows.Forms.GroupBox grpKey;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.NumericUpDown numA;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.NumericUpDown numB;
        private System.Windows.Forms.Label lblC;
        private System.Windows.Forms.NumericUpDown numC;
        private System.Windows.Forms.Label lblMotto;
        private System.Windows.Forms.TextBox txtMotto;
        private System.Windows.Forms.Label lblLang;
        private System.Windows.Forms.ComboBox cmbLanguage;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}
