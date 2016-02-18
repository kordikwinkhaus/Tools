namespace OfferCustomTexts
{
    partial class CustomTextEditor
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomTextEditor));
            this.lblTypProfilu = new System.Windows.Forms.Label();
            this.cmbTypProfilu = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nudPoradi = new System.Windows.Forms.NumericUpDown();
            this.lblLanguage = new System.Windows.Forms.Label();
            this.cmbLanguages = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkLastFooter = new System.Windows.Forms.CheckBox();
            this.rbKoncovyText = new System.Windows.Forms.RadioButton();
            this.rbUvodniText = new System.Windows.Forms.RadioButton();
            this.cmdOK = new System.Windows.Forms.Button();
            this.cmdStorno = new System.Windows.Forms.Button();
            this.rtfCustomText = new Winkhaus.RtfEditor.RtfEditControl();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtOptDesc = new System.Windows.Forms.TextBox();
            this.lblOptDesc = new System.Windows.Forms.Label();
            this.chkOptional = new System.Windows.Forms.CheckBox();
            this.chkPageBreak = new System.Windows.Forms.CheckBox();
            this.chkKeepTogether = new System.Windows.Forms.CheckBox();
            this.lblOnceKey = new System.Windows.Forms.Label();
            this.txtOnceKey = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudPoradi)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTypProfilu
            // 
            resources.ApplyResources(this.lblTypProfilu, "lblTypProfilu");
            this.lblTypProfilu.Name = "lblTypProfilu";
            this.toolTip1.SetToolTip(this.lblTypProfilu, resources.GetString("lblTypProfilu.ToolTip"));
            // 
            // cmbTypProfilu
            // 
            resources.ApplyResources(this.cmbTypProfilu, "cmbTypProfilu");
            this.cmbTypProfilu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTypProfilu.FormattingEnabled = true;
            this.cmbTypProfilu.Name = "cmbTypProfilu";
            this.toolTip1.SetToolTip(this.cmbTypProfilu, resources.GetString("cmbTypProfilu.ToolTip"));
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            this.toolTip1.SetToolTip(this.label2, resources.GetString("label2.ToolTip"));
            // 
            // nudPoradi
            // 
            resources.ApplyResources(this.nudPoradi, "nudPoradi");
            this.nudPoradi.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudPoradi.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.nudPoradi.Name = "nudPoradi";
            this.toolTip1.SetToolTip(this.nudPoradi, resources.GetString("nudPoradi.ToolTip"));
            // 
            // lblLanguage
            // 
            resources.ApplyResources(this.lblLanguage, "lblLanguage");
            this.lblLanguage.Name = "lblLanguage";
            this.toolTip1.SetToolTip(this.lblLanguage, resources.GetString("lblLanguage.ToolTip"));
            // 
            // cmbLanguages
            // 
            resources.ApplyResources(this.cmbLanguages, "cmbLanguages");
            this.cmbLanguages.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLanguages.FormattingEnabled = true;
            this.cmbLanguages.Name = "cmbLanguages";
            this.toolTip1.SetToolTip(this.cmbLanguages, resources.GetString("cmbLanguages.ToolTip"));
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.chkLastFooter);
            this.groupBox1.Controls.Add(this.rbKoncovyText);
            this.groupBox1.Controls.Add(this.rbUvodniText);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            this.toolTip1.SetToolTip(this.groupBox1, resources.GetString("groupBox1.ToolTip"));
            // 
            // chkLastFooter
            // 
            resources.ApplyResources(this.chkLastFooter, "chkLastFooter");
            this.chkLastFooter.Name = "chkLastFooter";
            this.toolTip1.SetToolTip(this.chkLastFooter, resources.GetString("chkLastFooter.ToolTip"));
            this.chkLastFooter.UseVisualStyleBackColor = true;
            // 
            // rbKoncovyText
            // 
            resources.ApplyResources(this.rbKoncovyText, "rbKoncovyText");
            this.rbKoncovyText.Name = "rbKoncovyText";
            this.rbKoncovyText.TabStop = true;
            this.toolTip1.SetToolTip(this.rbKoncovyText, resources.GetString("rbKoncovyText.ToolTip"));
            this.rbKoncovyText.UseVisualStyleBackColor = true;
            this.rbKoncovyText.CheckedChanged += new System.EventHandler(this.rbKoncovyText_CheckedChanged);
            // 
            // rbUvodniText
            // 
            resources.ApplyResources(this.rbUvodniText, "rbUvodniText");
            this.rbUvodniText.Name = "rbUvodniText";
            this.rbUvodniText.TabStop = true;
            this.toolTip1.SetToolTip(this.rbUvodniText, resources.GetString("rbUvodniText.ToolTip"));
            this.rbUvodniText.UseVisualStyleBackColor = true;
            // 
            // cmdOK
            // 
            resources.ApplyResources(this.cmdOK, "cmdOK");
            this.cmdOK.Name = "cmdOK";
            this.toolTip1.SetToolTip(this.cmdOK, resources.GetString("cmdOK.ToolTip"));
            this.cmdOK.UseVisualStyleBackColor = true;
            this.cmdOK.Click += new System.EventHandler(this.cmdOK_Click);
            // 
            // cmdStorno
            // 
            resources.ApplyResources(this.cmdStorno, "cmdStorno");
            this.cmdStorno.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdStorno.Name = "cmdStorno";
            this.toolTip1.SetToolTip(this.cmdStorno, resources.GetString("cmdStorno.ToolTip"));
            this.cmdStorno.UseVisualStyleBackColor = true;
            // 
            // rtfCustomText
            // 
            resources.ApplyResources(this.rtfCustomText, "rtfCustomText");
            this.rtfCustomText.Name = "rtfCustomText";
            this.rtfCustomText.Rtf = "{\\rtf1\\ansi\\ansicpg1250\\deff0\\deflang1029{\\fonttbl{\\f0\\fnil\\fcharset238{\\*\\fname " +
    "Arial;}Arial CE;}}\r\n\\viewkind4\\uc1\\pard\\f0\\fs20\\par\r\n}\r\n";
            this.rtfCustomText.ShowSettingsControls = false;
            this.toolTip1.SetToolTip(this.rtfCustomText, resources.GetString("rtfCustomText.ToolTip"));
            // 
            // groupBox2
            // 
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Controls.Add(this.txtOptDesc);
            this.groupBox2.Controls.Add(this.lblOptDesc);
            this.groupBox2.Controls.Add(this.chkOptional);
            this.groupBox2.Controls.Add(this.chkPageBreak);
            this.groupBox2.Controls.Add(this.chkKeepTogether);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            this.toolTip1.SetToolTip(this.groupBox2, resources.GetString("groupBox2.ToolTip"));
            // 
            // txtOptDesc
            // 
            resources.ApplyResources(this.txtOptDesc, "txtOptDesc");
            this.txtOptDesc.Name = "txtOptDesc";
            this.toolTip1.SetToolTip(this.txtOptDesc, resources.GetString("txtOptDesc.ToolTip"));
            // 
            // lblOptDesc
            // 
            resources.ApplyResources(this.lblOptDesc, "lblOptDesc");
            this.lblOptDesc.Name = "lblOptDesc";
            this.toolTip1.SetToolTip(this.lblOptDesc, resources.GetString("lblOptDesc.ToolTip"));
            // 
            // chkOptional
            // 
            resources.ApplyResources(this.chkOptional, "chkOptional");
            this.chkOptional.Name = "chkOptional";
            this.toolTip1.SetToolTip(this.chkOptional, resources.GetString("chkOptional.ToolTip"));
            this.chkOptional.UseVisualStyleBackColor = true;
            this.chkOptional.CheckedChanged += new System.EventHandler(this.chkOptional_CheckedChanged);
            // 
            // chkPageBreak
            // 
            resources.ApplyResources(this.chkPageBreak, "chkPageBreak");
            this.chkPageBreak.Name = "chkPageBreak";
            this.toolTip1.SetToolTip(this.chkPageBreak, resources.GetString("chkPageBreak.ToolTip"));
            this.chkPageBreak.UseVisualStyleBackColor = true;
            // 
            // chkKeepTogether
            // 
            resources.ApplyResources(this.chkKeepTogether, "chkKeepTogether");
            this.chkKeepTogether.Name = "chkKeepTogether";
            this.toolTip1.SetToolTip(this.chkKeepTogether, resources.GetString("chkKeepTogether.ToolTip"));
            this.chkKeepTogether.UseVisualStyleBackColor = true;
            // 
            // lblOnceKey
            // 
            resources.ApplyResources(this.lblOnceKey, "lblOnceKey");
            this.lblOnceKey.Name = "lblOnceKey";
            this.toolTip1.SetToolTip(this.lblOnceKey, resources.GetString("lblOnceKey.ToolTip"));
            // 
            // txtOnceKey
            // 
            resources.ApplyResources(this.txtOnceKey, "txtOnceKey");
            this.txtOnceKey.Name = "txtOnceKey";
            this.toolTip1.SetToolTip(this.txtOnceKey, resources.GetString("txtOnceKey.ToolTip"));
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            this.toolTip1.SetToolTip(this.label1, resources.GetString("label1.ToolTip"));
            // 
            // CustomTextEditor
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cmdStorno;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtOnceKey);
            this.Controls.Add(this.lblOnceKey);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.rtfCustomText);
            this.Controls.Add(this.cmdStorno);
            this.Controls.Add(this.cmdOK);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmbLanguages);
            this.Controls.Add(this.lblLanguage);
            this.Controls.Add(this.nudPoradi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbTypProfilu);
            this.Controls.Add(this.lblTypProfilu);
            this.Name = "CustomTextEditor";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.toolTip1.SetToolTip(this, resources.GetString("$this.ToolTip"));
            ((System.ComponentModel.ISupportInitialize)(this.nudPoradi)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTypProfilu;
        private System.Windows.Forms.ComboBox cmbTypProfilu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudPoradi;
        private System.Windows.Forms.Label lblLanguage;
        private System.Windows.Forms.ComboBox cmbLanguages;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbKoncovyText;
        private System.Windows.Forms.RadioButton rbUvodniText;
        private System.Windows.Forms.Button cmdOK;
        private System.Windows.Forms.Button cmdStorno;
        private Winkhaus.RtfEditor.RtfEditControl rtfCustomText;
        private System.Windows.Forms.CheckBox chkLastFooter;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkPageBreak;
        private System.Windows.Forms.CheckBox chkKeepTogether;
        private System.Windows.Forms.Label lblOnceKey;
        private System.Windows.Forms.TextBox txtOnceKey;
        private System.Windows.Forms.TextBox txtOptDesc;
        private System.Windows.Forms.Label lblOptDesc;
        private System.Windows.Forms.CheckBox chkOptional;
        private System.Windows.Forms.Label label1;
    }
}