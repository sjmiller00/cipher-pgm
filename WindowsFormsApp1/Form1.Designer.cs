namespace WindowsFormsApp1
{
    partial class frmCryptography
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblCipherText = new System.Windows.Forms.Label();
            this.txtPlainText = new System.Windows.Forms.RichTextBox();
            this.lblPlainText = new System.Windows.Forms.Label();
            this.cboCipher = new System.Windows.Forms.ComboBox();
            this.lblCipher = new System.Windows.Forms.Label();
            this.txtCipherText = new System.Windows.Forms.RichTextBox();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.btnDecrpyt = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblKey = new System.Windows.Forms.Label();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuImport = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuImportPlainText = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuImportCipherText = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExport = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExportPlainText = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExportCipherText = new System.Windows.Forms.ToolStripMenuItem();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCipherText
            // 
            this.lblCipherText.AutoSize = true;
            this.lblCipherText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCipherText.Location = new System.Drawing.Point(342, 139);
            this.lblCipherText.Name = "lblCipherText";
            this.lblCipherText.Size = new System.Drawing.Size(93, 20);
            this.lblCipherText.TabIndex = 11;
            this.lblCipherText.Text = "Cipher Text:";
            // 
            // txtPlainText
            // 
            this.txtPlainText.Enabled = false;
            this.txtPlainText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlainText.Location = new System.Drawing.Point(95, 90);
            this.txtPlainText.Name = "txtPlainText";
            this.txtPlainText.Size = new System.Drawing.Size(209, 125);
            this.txtPlainText.TabIndex = 10;
            this.txtPlainText.Text = "";
            // 
            // lblPlainText
            // 
            this.lblPlainText.AutoSize = true;
            this.lblPlainText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlainText.Location = new System.Drawing.Point(12, 139);
            this.lblPlainText.Name = "lblPlainText";
            this.lblPlainText.Size = new System.Drawing.Size(77, 20);
            this.lblPlainText.TabIndex = 9;
            this.lblPlainText.Text = "Plain text:";
            // 
            // cboCipher
            // 
            this.cboCipher.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCipher.FormattingEnabled = true;
            this.cboCipher.Items.AddRange(new object[] {
            "Cryptographic Hash",
            "Caesar",
            "Rail Fence",
            "Polybius Square",
            "Gronsfeld",
            "Four Square"});
            this.cboCipher.Location = new System.Drawing.Point(276, 33);
            this.cboCipher.Name = "cboCipher";
            this.cboCipher.Size = new System.Drawing.Size(170, 28);
            this.cboCipher.TabIndex = 8;
            this.cboCipher.Text = "Select a Cipher";
            this.cboCipher.SelectedIndexChanged += new System.EventHandler(this.cboCipher_SelectedIndexChanged);
            // 
            // lblCipher
            // 
            this.lblCipher.AutoSize = true;
            this.lblCipher.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCipher.Location = new System.Drawing.Point(216, 36);
            this.lblCipher.Name = "lblCipher";
            this.lblCipher.Size = new System.Drawing.Size(63, 20);
            this.lblCipher.TabIndex = 7;
            this.lblCipher.Text = "Cipher: ";
            // 
            // txtCipherText
            // 
            this.txtCipherText.Enabled = false;
            this.txtCipherText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCipherText.Location = new System.Drawing.Point(441, 90);
            this.txtCipherText.Name = "txtCipherText";
            this.txtCipherText.Size = new System.Drawing.Size(209, 125);
            this.txtCipherText.TabIndex = 10;
            this.txtCipherText.Text = "";
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Enabled = false;
            this.btnEncrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncrypt.Location = new System.Drawing.Point(174, 285);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(131, 32);
            this.btnEncrypt.TabIndex = 12;
            this.btnEncrypt.Text = "Encrypt Text";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // btnDecrpyt
            // 
            this.btnDecrpyt.Enabled = false;
            this.btnDecrpyt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecrpyt.Location = new System.Drawing.Point(357, 285);
            this.btnDecrpyt.Name = "btnDecrpyt";
            this.btnDecrpyt.Size = new System.Drawing.Size(131, 32);
            this.btnDecrpyt.TabIndex = 12;
            this.btnDecrpyt.Text = "Decrypt Text";
            this.btnDecrpyt.UseVisualStyleBackColor = true;
            this.btnDecrpyt.Click += new System.EventHandler(this.btnDecrpyt_Click);
            // 
            // btnClear
            // 
            this.btnClear.Enabled = false;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(174, 323);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(131, 32);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblKey
            // 
            this.lblKey.AutoSize = true;
            this.lblKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKey.Location = new System.Drawing.Point(12, 238);
            this.lblKey.Name = "lblKey";
            this.lblKey.Size = new System.Drawing.Size(39, 20);
            this.lblKey.TabIndex = 13;
            this.lblKey.Text = "Key:";
            // 
            // txtKey
            // 
            this.txtKey.Enabled = false;
            this.txtKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKey.Location = new System.Drawing.Point(57, 235);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(100, 26);
            this.txtKey.TabIndex = 14;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(357, 323);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(131, 32);
            this.btnExit.TabIndex = 15;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(662, 24);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuImport,
            this.mnuExport});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(37, 20);
            this.mnuFile.Text = "File";
            // 
            // mnuImport
            // 
            this.mnuImport.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuImportPlainText,
            this.mnuImportCipherText});
            this.mnuImport.Name = "mnuImport";
            this.mnuImport.Size = new System.Drawing.Size(152, 22);
            this.mnuImport.Text = "Import";
            // 
            // mnuImportPlainText
            // 
            this.mnuImportPlainText.Name = "mnuImportPlainText";
            this.mnuImportPlainText.Size = new System.Drawing.Size(152, 22);
            this.mnuImportPlainText.Text = "Plain Text";
            this.mnuImportPlainText.Click += new System.EventHandler(this.mnuImportPlainText_Click);
            // 
            // mnuImportCipherText
            // 
            this.mnuImportCipherText.Name = "mnuImportCipherText";
            this.mnuImportCipherText.Size = new System.Drawing.Size(152, 22);
            this.mnuImportCipherText.Text = "Cipher Text";
            this.mnuImportCipherText.Click += new System.EventHandler(this.mnuImportCipherText_Click);
            // 
            // mnuExport
            // 
            this.mnuExport.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuExportPlainText,
            this.mnuExportCipherText});
            this.mnuExport.Name = "mnuExport";
            this.mnuExport.Size = new System.Drawing.Size(152, 22);
            this.mnuExport.Text = "Export";
            // 
            // mnuExportPlainText
            // 
            this.mnuExportPlainText.Name = "mnuExportPlainText";
            this.mnuExportPlainText.Size = new System.Drawing.Size(152, 22);
            this.mnuExportPlainText.Text = "Plain Text";
            this.mnuExportPlainText.Click += new System.EventHandler(this.mnuExportPlainText_Click);
            // 
            // mnuExportCipherText
            // 
            this.mnuExportCipherText.Name = "mnuExportCipherText";
            this.mnuExportCipherText.Size = new System.Drawing.Size(152, 22);
            this.mnuExportCipherText.Text = "Cipher Text";
            this.mnuExportCipherText.Click += new System.EventHandler(this.mnuExportCipherText_Click);
            // 
            // openFile
            // 
            this.openFile.FileName = "openFileDialog1";
            // 
            // frmCryptography
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 389);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtKey);
            this.Controls.Add(this.lblKey);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDecrpyt);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.lblCipherText);
            this.Controls.Add(this.txtCipherText);
            this.Controls.Add(this.txtPlainText);
            this.Controls.Add(this.lblPlainText);
            this.Controls.Add(this.cboCipher);
            this.Controls.Add(this.lblCipher);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmCryptography";
            this.Text = "Cryptography Program";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCipherText;
        private System.Windows.Forms.RichTextBox txtPlainText;
        private System.Windows.Forms.Label lblPlainText;
        private System.Windows.Forms.ComboBox cboCipher;
        private System.Windows.Forms.Label lblCipher;
        private System.Windows.Forms.RichTextBox txtCipherText;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Button btnDecrpyt;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblKey;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuImport;
        private System.Windows.Forms.ToolStripMenuItem mnuImportPlainText;
        private System.Windows.Forms.ToolStripMenuItem mnuImportCipherText;
        private System.Windows.Forms.ToolStripMenuItem mnuExport;
        private System.Windows.Forms.ToolStripMenuItem mnuExportPlainText;
        private System.Windows.Forms.ToolStripMenuItem mnuExportCipherText;
        private System.Windows.Forms.OpenFileDialog openFile;
    }
}

