namespace DigitalSignatureApp
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
            this.panelMain = new System.Windows.Forms.Panel();
            this.grpMessage = new System.Windows.Forms.GroupBox();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.grpSignature = new System.Windows.Forms.GroupBox();
            this.txtSignature = new System.Windows.Forms.TextBox();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.btnSign = new System.Windows.Forms.Button();
            this.btnVerify = new System.Windows.Forms.Button();
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
            this.panelMain.SuspendLayout();
            this.grpMessage.SuspendLayout();
            this.grpSignature.SuspendLayout();
            this.panelButtons.SuspendLayout();
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
            this.saveToolStripMenuItem.Text = "Save Signature...";
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
            this.panelTop.Size = new System.Drawing.Size(900, 200);
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
            this.splitContainerKeys.Size = new System.Drawing.Size(900, 170);
            this.splitContainerKeys.SplitterDistance = 450;
            this.splitContainerKeys.TabIndex = 1;

            // grpPublicKey
            this.grpPublicKey.Controls.Add(this.txtPublicKey);
            this.grpPublicKey.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpPublicKey.Location = new System.Drawing.Point(0, 0);
            this.grpPublicKey.Name = "grpPublicKey";
            this.grpPublicKey.Size = new System.Drawing.Size(450, 170);
            this.grpPublicKey.TabIndex = 0;
            this.grpPublicKey.TabStop = false;
            this.grpPublicKey.Text = "Public Key (XML)";

            // txtPublicKey
            this.txtPublicKey.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPublicKey.Location = new System.Drawing.Point(3, 19);
            this.txtPublicKey.Multiline = true;
            this.txtPublicKey.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPublicKey.Name = "txtPublicKey";
            this.txtPublicKey.Size = new System.Drawing.Size(444, 148);
            this.txtPublicKey.TabIndex = 0;

            // grpPrivateKey
            this.grpPrivateKey.Controls.Add(this.txtPrivateKey);
            this.grpPrivateKey.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpPrivateKey.Location = new System.Drawing.Point(0, 0);
            this.grpPrivateKey.Name = "grpPrivateKey";
            this.grpPrivateKey.Size = new System.Drawing.Size(446, 170);
            this.grpPrivateKey.TabIndex = 0;
            this.grpPrivateKey.TabStop = false;
            this.grpPrivateKey.Text = "Private Key (XML)";

            // txtPrivateKey
            this.txtPrivateKey.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPrivateKey.Location = new System.Drawing.Point(3, 19);
            this.txtPrivateKey.Multiline = true;
            this.txtPrivateKey.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPrivateKey.Name = "txtPrivateKey";
            this.txtPrivateKey.Size = new System.Drawing.Size(440, 148);
            this.txtPrivateKey.TabIndex = 0;

            // panelButtons
            this.panelButtons.Controls.Add(this.btnVerify);
            this.panelButtons.Controls.Add(this.btnSign);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelButtons.Location = new System.Drawing.Point(0, 224);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(900, 50);
            this.panelButtons.TabIndex = 2;

            // btnSign
            this.btnSign.Location = new System.Drawing.Point(200, 10);
            this.btnSign.Name = "btnSign";
            this.btnSign.Size = new System.Drawing.Size(150, 30);
            this.btnSign.TabIndex = 0;
            this.btnSign.Text = "Sign Message";
            this.btnSign.UseVisualStyleBackColor = true;
            this.btnSign.Click += new System.EventHandler(this.btnSign_Click);

            // btnVerify
            this.btnVerify.Location = new System.Drawing.Point(370, 10);
            this.btnVerify.Name = "btnVerify";
            this.btnVerify.Size = new System.Drawing.Size(150, 30);
            this.btnVerify.TabIndex = 1;
            this.btnVerify.Text = "Verify Signature";
            this.btnVerify.UseVisualStyleBackColor = true;
            this.btnVerify.Click += new System.EventHandler(this.btnVerify_Click);

            // panelMain
            this.panelMain.Controls.Add(this.grpSignature);
            this.panelMain.Controls.Add(this.grpMessage);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 274);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(900, 276);
            this.panelMain.TabIndex = 3;

            // grpMessage
            this.grpMessage.Controls.Add(this.txtMessage);
            this.grpMessage.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpMessage.Location = new System.Drawing.Point(0, 0);
            this.grpMessage.Name = "grpMessage";
            this.grpMessage.Size = new System.Drawing.Size(900, 130);
            this.grpMessage.TabIndex = 0;
            this.grpMessage.TabStop = false;
            this.grpMessage.Text = "Message to Sign/Verify";

            // txtMessage
            this.txtMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMessage.Location = new System.Drawing.Point(3, 19);
            this.txtMessage.Multiline = true;
            this.txtMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(894, 108);
            this.txtMessage.TabIndex = 0;

            // grpSignature
            this.grpSignature.Controls.Add(this.txtSignature);
            this.grpSignature.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpSignature.Location = new System.Drawing.Point(0, 130);
            this.grpSignature.Name = "grpSignature";
            this.grpSignature.Size = new System.Drawing.Size(900, 146);
            this.grpSignature.TabIndex = 1;
            this.grpSignature.TabStop = false;
            this.grpSignature.Text = "Digital Signature (HEX)";

            // txtSignature
            this.txtSignature.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSignature.Location = new System.Drawing.Point(3, 19);
            this.txtSignature.Multiline = true;
            this.txtSignature.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSignature.Name = "txtSignature";
            this.txtSignature.Size = new System.Drawing.Size(894, 124);
            this.txtSignature.TabIndex = 0;

            // MainForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 550);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelButtons);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Digital Signature App (RSA + SHA-1)";
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
            this.panelButtons.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);
            this.grpMessage.ResumeLayout(false);
            this.grpMessage.PerformLayout();
            this.grpSignature.ResumeLayout(false);
            this.grpSignature.PerformLayout();
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
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Button btnSign;
        private System.Windows.Forms.Button btnVerify;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.GroupBox grpMessage;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.GroupBox grpSignature;
        private System.Windows.Forms.TextBox txtSignature;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}
