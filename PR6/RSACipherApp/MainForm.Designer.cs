namespace RSACipherApp
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
            this.panelTop = new System.Windows.Forms.Panel();
            this.btnGenerateKeys = new System.Windows.Forms.Button();
            this.splitContainerKeys = new System.Windows.Forms.SplitContainer();
            this.grpPublicKey = new System.Windows.Forms.GroupBox();
            this.txtPublicKey = new System.Windows.Forms.TextBox();
            this.grpPrivateKey = new System.Windows.Forms.GroupBox();
            this.txtPrivateKey = new System.Windows.Forms.TextBox();
            this.panelOperations = new System.Windows.Forms.Panel();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.splitContainerIO = new System.Windows.Forms.SplitContainer();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.lblInput = new System.Windows.Forms.Label();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.lblOutput = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();

            this.menuStrip1.SuspendLayout();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerKeys)).BeginInit();
            this.splitContainerKeys.Panel1.SuspendLayout();
            this.splitContainerKeys.Panel2.SuspendLayout();
            this.splitContainerKeys.SuspendLayout();
            this.grpPublicKey.SuspendLayout();
            this.grpPrivateKey.SuspendLayout();
            this.panelOperations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerIO)).BeginInit();
            this.splitContainerIO.Panel1.SuspendLayout();
            this.splitContainerIO.Panel2.SuspendLayout();
            this.splitContainerIO.SuspendLayout();
            this.SuspendLayout();

            // menuStrip1
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(900, 24);
            this.menuStrip1.TabIndex = 0;

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

            // panelTop (Key Generation)
            this.panelTop.Controls.Add(this.splitContainerKeys);
            this.panelTop.Controls.Add(this.btnGenerateKeys);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 24);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(900, 250);
            this.panelTop.TabIndex = 1;

            // btnGenerateKeys
            this.btnGenerateKeys.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGenerateKeys.Location = new System.Drawing.Point(0, 0);
            this.btnGenerateKeys.Name = "btnGenerateKeys";
            this.btnGenerateKeys.Size = new System.Drawing.Size(900, 30);
            this.btnGenerateKeys.TabIndex = 0;
            this.btnGenerateKeys.Text = "Generate New Keys (2048 bit)";
            this.btnGenerateKeys.UseVisualStyleBackColor = true;
            this.btnGenerateKeys.Click += new System.EventHandler(this.btnGenerateKeys_Click);

            // splitContainerKeys
            this.splitContainerKeys.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerKeys.Location = new System.Drawing.Point(0, 30);
            this.splitContainerKeys.Name = "splitContainerKeys";
            
            // splitContainerKeys.Panel1 (Public Key)
            this.splitContainerKeys.Panel1.Controls.Add(this.grpPublicKey);
            
            // splitContainerKeys.Panel2 (Private Key)
            this.splitContainerKeys.Panel2.Controls.Add(this.grpPrivateKey);
            this.splitContainerKeys.Size = new System.Drawing.Size(900, 220);
            this.splitContainerKeys.SplitterDistance = 450;
            this.splitContainerKeys.TabIndex = 1;

            // grpPublicKey
            this.grpPublicKey.Controls.Add(this.txtPublicKey);
            this.grpPublicKey.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpPublicKey.Location = new System.Drawing.Point(0, 0);
            this.grpPublicKey.Name = "grpPublicKey";
            this.grpPublicKey.Size = new System.Drawing.Size(450, 220);
            this.grpPublicKey.TabIndex = 0;
            this.grpPublicKey.TabStop = false;
            this.grpPublicKey.Text = "Public Key (XML)";

            // txtPublicKey
            this.txtPublicKey.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPublicKey.Location = new System.Drawing.Point(3, 19);
            this.txtPublicKey.Multiline = true;
            this.txtPublicKey.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPublicKey.Name = "txtPublicKey";
            this.txtPublicKey.Size = new System.Drawing.Size(444, 198);
            this.txtPublicKey.TabIndex = 0;

            // grpPrivateKey
            this.grpPrivateKey.Controls.Add(this.txtPrivateKey);
            this.grpPrivateKey.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpPrivateKey.Location = new System.Drawing.Point(0, 0);
            this.grpPrivateKey.Name = "grpPrivateKey";
            this.grpPrivateKey.Size = new System.Drawing.Size(446, 220);
            this.grpPrivateKey.TabIndex = 0;
            this.grpPrivateKey.TabStop = false;
            this.grpPrivateKey.Text = "Private Key (XML)";

            // txtPrivateKey
            this.txtPrivateKey.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPrivateKey.Location = new System.Drawing.Point(3, 19);
            this.txtPrivateKey.Multiline = true;
            this.txtPrivateKey.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPrivateKey.Name = "txtPrivateKey";
            this.txtPrivateKey.Size = new System.Drawing.Size(440, 198);
            this.txtPrivateKey.TabIndex = 0;

            // panelOperations
            this.panelOperations.Controls.Add(this.btnDecrypt);
            this.panelOperations.Controls.Add(this.btnEncrypt);
            this.panelOperations.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelOperations.Location = new System.Drawing.Point(0, 274);
            this.panelOperations.Name = "panelOperations";
            this.panelOperations.Size = new System.Drawing.Size(900, 50);
            this.panelOperations.TabIndex = 2;

            // btnEncrypt
            this.btnEncrypt.Location = new System.Drawing.Point(150, 10);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(150, 30);
            this.btnEncrypt.TabIndex = 0;
            this.btnEncrypt.Text = "Encrypt (with Public Key)";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);

            // btnDecrypt
            this.btnDecrypt.Location = new System.Drawing.Point(320, 10);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(150, 30);
            this.btnDecrypt.TabIndex = 1;
            this.btnDecrypt.Text = "Decrypt (with Private Key)";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);

            // splitContainerIO
            this.splitContainerIO.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerIO.Location = new System.Drawing.Point(0, 324);
            this.splitContainerIO.Name = "splitContainerIO";
            this.splitContainerIO.Orientation = System.Windows.Forms.Orientation.Horizontal;
            
            // splitContainerIO.Panel1 (Input)
            this.splitContainerIO.Panel1.Controls.Add(this.txtInput);
            this.splitContainerIO.Panel1.Controls.Add(this.lblInput);
            
            // splitContainerIO.Panel2 (Output)
            this.splitContainerIO.Panel2.Controls.Add(this.txtOutput);
            this.splitContainerIO.Panel2.Controls.Add(this.lblOutput);
            this.splitContainerIO.Size = new System.Drawing.Size(900, 276);
            this.splitContainerIO.SplitterDistance = 130;
            this.splitContainerIO.TabIndex = 3;

            // lblInput
            this.lblInput.AutoSize = true;
            this.lblInput.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblInput.Location = new System.Drawing.Point(0, 0);
            this.lblInput.Name = "lblInput";
            this.lblInput.Padding = new System.Windows.Forms.Padding(5);
            this.lblInput.Text = "Input Text (or Base64 Ciphertext):";

            // txtInput
            this.txtInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtInput.Location = new System.Drawing.Point(0, 25);
            this.txtInput.Multiline = true;
            this.txtInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(900, 105);
            this.txtInput.TabIndex = 0;

            // lblOutput
            this.lblOutput.AutoSize = true;
            this.lblOutput.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblOutput.Location = new System.Drawing.Point(0, 0);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Padding = new System.Windows.Forms.Padding(5);
            this.lblOutput.Text = "Output:";

            // txtOutput
            this.txtOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtOutput.Location = new System.Drawing.Point(0, 25);
            this.txtOutput.Multiline = true;
            this.txtOutput.ReadOnly = true;
            this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(900, 117);
            this.txtOutput.TabIndex = 0;

            // MainForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.splitContainerIO);
            this.Controls.Add(this.panelOperations);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "RSA Cipher App";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelTop.ResumeLayout(false);
            this.splitContainerKeys.Panel1.ResumeLayout(false);
            this.splitContainerKeys.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerKeys)).EndInit();
            this.splitContainerKeys.ResumeLayout(false);
            this.grpPublicKey.ResumeLayout(false);
            this.grpPublicKey.PerformLayout();
            this.grpPrivateKey.ResumeLayout(false);
            this.grpPrivateKey.PerformLayout();
            this.panelOperations.ResumeLayout(false);
            this.splitContainerIO.Panel1.ResumeLayout(false);
            this.splitContainerIO.Panel1.PerformLayout();
            this.splitContainerIO.Panel2.ResumeLayout(false);
            this.splitContainerIO.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerIO)).EndInit();
            this.splitContainerIO.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Button btnGenerateKeys;
        private System.Windows.Forms.SplitContainer splitContainerKeys;
        private System.Windows.Forms.GroupBox grpPublicKey;
        private System.Windows.Forms.TextBox txtPublicKey;
        private System.Windows.Forms.GroupBox grpPrivateKey;
        private System.Windows.Forms.TextBox txtPrivateKey;
        private System.Windows.Forms.Panel panelOperations;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.SplitContainer splitContainerIO;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}
