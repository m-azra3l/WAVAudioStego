namespace WAVAudioStego
{
    partial class Main
    {
        // <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.decodeTab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblWarning = new System.Windows.Forms.Label();
            this.txtAudioPathEncode = new System.Windows.Forms.TextBox();
            this.txtPublicKeyEncode = new System.Windows.Forms.TextBox();
            this.btnUploadAudioEncode = new System.Windows.Forms.Button();
            this.lblMaxTextLength = new System.Windows.Forms.Label();
            this.lblTextLength = new System.Windows.Forms.Label();
            this.btnUploadPublicKeyEncode = new System.Windows.Forms.Button();
            this.txtTextFilePathEncode = new System.Windows.Forms.TextBox();
            this.btnUploadTextFileEncode = new System.Windows.Forms.Button();
            this.btnEncode = new System.Windows.Forms.Button();
            this.progressEncode = new System.Windows.Forms.ProgressBar();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnUploadPrivateKeyDecode = new System.Windows.Forms.Button();
            this.btnUploadAudioDecode = new System.Windows.Forms.Button();
            this.txtAudioPathDecode = new System.Windows.Forms.TextBox();
            this.txtPrivateKeyDecode = new System.Windows.Forms.TextBox();
            this.btnDecode = new System.Windows.Forms.Button();
            this.progressDecode = new System.Windows.Forms.ProgressBar();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.generateKeys = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.decodeTab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.SuspendLayout();
            // 
            // decodeTab
            // 
            this.decodeTab.Controls.Add(this.tabPage1);
            this.decodeTab.Controls.Add(this.tabPage2);
            this.decodeTab.Controls.Add(this.tabPage3);
            this.decodeTab.Controls.Add(this.tabPage4);
            this.decodeTab.Location = new System.Drawing.Point(-1, 3);
            this.decodeTab.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.decodeTab.Name = "decodeTab";
            this.decodeTab.SelectedIndex = 0;
            this.decodeTab.Size = new System.Drawing.Size(490, 421);
            this.decodeTab.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblWarning);
            this.tabPage1.Controls.Add(this.txtAudioPathEncode);
            this.tabPage1.Controls.Add(this.txtPublicKeyEncode);
            this.tabPage1.Controls.Add(this.btnUploadAudioEncode);
            this.tabPage1.Controls.Add(this.lblMaxTextLength);
            this.tabPage1.Controls.Add(this.lblTextLength);
            this.tabPage1.Controls.Add(this.btnUploadPublicKeyEncode);
            this.tabPage1.Controls.Add(this.txtTextFilePathEncode);
            this.tabPage1.Controls.Add(this.btnUploadTextFileEncode);
            this.tabPage1.Controls.Add(this.btnEncode);
            this.tabPage1.Controls.Add(this.progressEncode);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Size = new System.Drawing.Size(482, 388);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Embed";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblWarning
            // 
            this.lblWarning.AutoSize = true;
            this.lblWarning.ForeColor = System.Drawing.Color.Black;
            this.lblWarning.Location = new System.Drawing.Point(13, 264);
            this.lblWarning.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(0, 20);
            this.lblWarning.TabIndex = 19;
            // 
            // txtAudioPathEncode
            // 
            this.txtAudioPathEncode.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAudioPathEncode.Location = new System.Drawing.Point(12, 34);
            this.txtAudioPathEncode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAudioPathEncode.Name = "txtAudioPathEncode";
            this.txtAudioPathEncode.PlaceholderText = "Audio file (.wav)";
            this.txtAudioPathEncode.ReadOnly = true;
            this.txtAudioPathEncode.Size = new System.Drawing.Size(325, 27);
            this.txtAudioPathEncode.TabIndex = 2;
            // 
            // txtPublicKeyEncode
            // 
            this.txtPublicKeyEncode.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPublicKeyEncode.Location = new System.Drawing.Point(11, 127);
            this.txtPublicKeyEncode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPublicKeyEncode.Name = "txtPublicKeyEncode";
            this.txtPublicKeyEncode.PlaceholderText = "Public embed key (.xml)";
            this.txtPublicKeyEncode.ReadOnly = true;
            this.txtPublicKeyEncode.Size = new System.Drawing.Size(326, 27);
            this.txtPublicKeyEncode.TabIndex = 11;
            // 
            // btnUploadAudioEncode
            // 
            this.btnUploadAudioEncode.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUploadAudioEncode.Location = new System.Drawing.Point(341, 34);
            this.btnUploadAudioEncode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUploadAudioEncode.Name = "btnUploadAudioEncode";
            this.btnUploadAudioEncode.Size = new System.Drawing.Size(128, 27);
            this.btnUploadAudioEncode.TabIndex = 0;
            this.btnUploadAudioEncode.Text = "Select audio";
            this.btnUploadAudioEncode.UseVisualStyleBackColor = true;
            this.btnUploadAudioEncode.Click += new System.EventHandler(this.btnUploadAudioEncode_Click);
            // 
            // lblMaxTextLength
            // 
            this.lblMaxTextLength.AutoSize = true;
            this.lblMaxTextLength.Location = new System.Drawing.Point(13, 10);
            this.lblMaxTextLength.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaxTextLength.Name = "lblMaxTextLength";
            this.lblMaxTextLength.Size = new System.Drawing.Size(179, 20);
            this.lblMaxTextLength.TabIndex = 17;
            this.lblMaxTextLength.Text = "Max available text length:";
            // 
            // lblTextLength
            // 
            this.lblTextLength.AutoSize = true;
            this.lblTextLength.Location = new System.Drawing.Point(11, 209);
            this.lblTextLength.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTextLength.Name = "lblTextLength";
            this.lblTextLength.Size = new System.Drawing.Size(144, 20);
            this.lblTextLength.TabIndex = 18;
            this.lblTextLength.Text = "Encryted text length:";
            // 
            // btnUploadPublicKeyEncode
            // 
            this.btnUploadPublicKeyEncode.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUploadPublicKeyEncode.Location = new System.Drawing.Point(343, 127);
            this.btnUploadPublicKeyEncode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUploadPublicKeyEncode.Name = "btnUploadPublicKeyEncode";
            this.btnUploadPublicKeyEncode.Size = new System.Drawing.Size(128, 27);
            this.btnUploadPublicKeyEncode.TabIndex = 14;
            this.btnUploadPublicKeyEncode.Text = "Select key";
            this.btnUploadPublicKeyEncode.UseVisualStyleBackColor = true;
            this.btnUploadPublicKeyEncode.Click += new System.EventHandler(this.btnUploadPublicKeyEncode_Click);
            // 
            // txtTextFilePathEncode
            // 
            this.txtTextFilePathEncode.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTextFilePathEncode.Location = new System.Drawing.Point(10, 233);
            this.txtTextFilePathEncode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTextFilePathEncode.Name = "txtTextFilePathEncode";
            this.txtTextFilePathEncode.PlaceholderText = "Text file (.txt)";
            this.txtTextFilePathEncode.ReadOnly = true;
            this.txtTextFilePathEncode.Size = new System.Drawing.Size(325, 27);
            this.txtTextFilePathEncode.TabIndex = 8;
            // 
            // btnUploadTextFileEncode
            // 
            this.btnUploadTextFileEncode.Enabled = false;
            this.btnUploadTextFileEncode.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUploadTextFileEncode.Location = new System.Drawing.Point(341, 233);
            this.btnUploadTextFileEncode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUploadTextFileEncode.Name = "btnUploadTextFileEncode";
            this.btnUploadTextFileEncode.Size = new System.Drawing.Size(128, 27);
            this.btnUploadTextFileEncode.TabIndex = 7;
            this.btnUploadTextFileEncode.Text = "Select file";
            this.btnUploadTextFileEncode.UseVisualStyleBackColor = true;
            this.btnUploadTextFileEncode.Click += new System.EventHandler(this.btnUploadTextFile_Click);
            // 
            // btnEncode
            // 
            this.btnEncode.Enabled = false;
            this.btnEncode.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEncode.Location = new System.Drawing.Point(341, 344);
            this.btnEncode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEncode.Name = "btnEncode";
            this.btnEncode.Size = new System.Drawing.Size(128, 27);
            this.btnEncode.TabIndex = 6;
            this.btnEncode.Text = "Embed";
            this.btnEncode.UseVisualStyleBackColor = true;
            this.btnEncode.Click += new System.EventHandler(this.btnEncode_Click);
            // 
            // progressEncode
            // 
            this.progressEncode.Location = new System.Drawing.Point(11, 344);
            this.progressEncode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.progressEncode.Name = "progressEncode";
            this.progressEncode.Size = new System.Drawing.Size(324, 27);
            this.progressEncode.Step = 1;
            this.progressEncode.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnUploadPrivateKeyDecode);
            this.tabPage2.Controls.Add(this.btnUploadAudioDecode);
            this.tabPage2.Controls.Add(this.txtAudioPathDecode);
            this.tabPage2.Controls.Add(this.txtPrivateKeyDecode);
            this.tabPage2.Controls.Add(this.btnDecode);
            this.tabPage2.Controls.Add(this.progressDecode);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Size = new System.Drawing.Size(482, 388);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Extract";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnUploadPrivateKeyDecode
            // 
            this.btnUploadPrivateKeyDecode.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUploadPrivateKeyDecode.Location = new System.Drawing.Point(339, 177);
            this.btnUploadPrivateKeyDecode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUploadPrivateKeyDecode.Name = "btnUploadPrivateKeyDecode";
            this.btnUploadPrivateKeyDecode.Size = new System.Drawing.Size(128, 27);
            this.btnUploadPrivateKeyDecode.TabIndex = 16;
            this.btnUploadPrivateKeyDecode.Text = "Select key";
            this.btnUploadPrivateKeyDecode.UseVisualStyleBackColor = true;
            this.btnUploadPrivateKeyDecode.Click += new System.EventHandler(this.btnUploadPrivateKeyDecode_Click);
            // 
            // btnUploadAudioDecode
            // 
            this.btnUploadAudioDecode.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUploadAudioDecode.Location = new System.Drawing.Point(339, 22);
            this.btnUploadAudioDecode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUploadAudioDecode.Name = "btnUploadAudioDecode";
            this.btnUploadAudioDecode.Size = new System.Drawing.Size(128, 27);
            this.btnUploadAudioDecode.TabIndex = 3;
            this.btnUploadAudioDecode.Text = "Select  audio";
            this.btnUploadAudioDecode.UseVisualStyleBackColor = true;
            this.btnUploadAudioDecode.Click += new System.EventHandler(this.btnUploadAudioDecode_Click);
            // 
            // txtAudioPathDecode
            // 
            this.txtAudioPathDecode.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAudioPathDecode.Location = new System.Drawing.Point(10, 22);
            this.txtAudioPathDecode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAudioPathDecode.Name = "txtAudioPathDecode";
            this.txtAudioPathDecode.PlaceholderText = "Audio file (.wav)";
            this.txtAudioPathDecode.ReadOnly = true;
            this.txtAudioPathDecode.Size = new System.Drawing.Size(325, 27);
            this.txtAudioPathDecode.TabIndex = 4;
            // 
            // txtPrivateKeyDecode
            // 
            this.txtPrivateKeyDecode.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPrivateKeyDecode.Location = new System.Drawing.Point(10, 177);
            this.txtPrivateKeyDecode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPrivateKeyDecode.Name = "txtPrivateKeyDecode";
            this.txtPrivateKeyDecode.PlaceholderText = "Extraction key (.xml)";
            this.txtPrivateKeyDecode.ReadOnly = true;
            this.txtPrivateKeyDecode.Size = new System.Drawing.Size(325, 27);
            this.txtPrivateKeyDecode.TabIndex = 13;
            // 
            // btnDecode
            // 
            this.btnDecode.Enabled = false;
            this.btnDecode.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDecode.Location = new System.Drawing.Point(339, 338);
            this.btnDecode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDecode.Name = "btnDecode";
            this.btnDecode.Size = new System.Drawing.Size(128, 27);
            this.btnDecode.TabIndex = 7;
            this.btnDecode.Text = "Extract";
            this.btnDecode.UseVisualStyleBackColor = true;
            this.btnDecode.Click += new System.EventHandler(this.btnDecode_Click);
            // 
            // progressDecode
            // 
            this.progressDecode.Location = new System.Drawing.Point(11, 338);
            this.progressDecode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.progressDecode.Name = "progressDecode";
            this.progressDecode.Size = new System.Drawing.Size(324, 27);
            this.progressDecode.Step = 1;
            this.progressDecode.TabIndex = 5;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.textBox3);
            this.tabPage3.Controls.Add(this.progressBar);
            this.tabPage3.Controls.Add(this.generateKeys);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(482, 388);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Generate Keys";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(20, 21);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox3.Size = new System.Drawing.Size(438, 294);
            this.textBox3.TabIndex = 18;
            this.textBox3.Text = resources.GetString("textBox3.Text");
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(20, 334);
            this.progressBar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(350, 34);
            this.progressBar.Step = 1;
            this.progressBar.TabIndex = 17;
            // 
            // generateKeys
            // 
            this.generateKeys.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.generateKeys.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.generateKeys.Location = new System.Drawing.Point(376, 334);
            this.generateKeys.Name = "generateKeys";
            this.generateKeys.Size = new System.Drawing.Size(82, 34);
            this.generateKeys.TabIndex = 16;
            this.generateKeys.Text = "Generate";
            this.generateKeys.UseVisualStyleBackColor = true;
            this.generateKeys.Click += new System.EventHandler(this.generateKeys_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.tabControl1);
            this.tabPage4.Location = new System.Drawing.Point(4, 29);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(482, 388);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "About/Help";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Location = new System.Drawing.Point(0, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(482, 388);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.textBox1);
            this.tabPage5.Location = new System.Drawing.Point(4, 29);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(474, 355);
            this.tabPage5.TabIndex = 0;
            this.tabPage5.Text = "About";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 6);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(462, 342);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.textBox2);
            this.tabPage6.Location = new System.Drawing.Point(4, 29);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(474, 355);
            this.tabPage6.TabIndex = 1;
            this.tabPage6.Text = "Help";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(6, 6);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox2.Size = new System.Drawing.Size(462, 342);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = resources.GetString("textBox2.Text");
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 422);
            this.Controls.Add(this.decodeTab);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WAVAudioStego";
            this.decodeTab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl decodeTab;
        private TabPage tabPage1;
        private TextBox txtTextFilePathEncode;
        private Button btnUploadTextFileEncode;
        private Button btnEncode;
        private TextBox txtAudioPathEncode;
        private Button btnUploadAudioEncode;
        private TabPage tabPage2;
        private Button btnDecode;
        private TextBox txtAudioPathDecode;
        private Button btnUploadAudioDecode;
        private TextBox txtPublicKeyEncode;
        private TextBox txtPrivateKeyDecode;
        private Button btnUploadPublicKeyEncode;
        private Button btnUploadPrivateKeyDecode;
        private TabPage tabPage3;
        private TextBox textBox3;
        private ProgressBar progressBar;
        private Button generateKeys;
        private TabPage tabPage4;
        private TabControl tabControl1;
        private TabPage tabPage5;
        private TextBox textBox1;
        private TabPage tabPage6;
        private TextBox textBox2;
        private Label lblTextLength;
        private Label lblMaxTextLength;
        private Label lblWarning;
        public ProgressBar progressEncode;
        public ProgressBar progressDecode;
    }
}