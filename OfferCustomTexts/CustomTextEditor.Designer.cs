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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbTypProfilu = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nudPoradi = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
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
            this.chkPageBreak = new System.Windows.Forms.CheckBox();
            this.chkKeepTogether = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtOnceKey = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudPoradi)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // cmbTypProfilu
            // 
            this.cmbTypProfilu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTypProfilu.FormattingEnabled = true;
            resources.ApplyResources(this.cmbTypProfilu, "cmbTypProfilu");
            this.cmbTypProfilu.Name = "cmbTypProfilu";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
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
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            this.toolTip1.SetToolTip(this.label3, resources.GetString("label3.ToolTip"));
            // 
            // cmbLanguages
            // 
            this.cmbLanguages.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLanguages.FormattingEnabled = true;
            resources.ApplyResources(this.cmbLanguages, "cmbLanguages");
            this.cmbLanguages.Name = "cmbLanguages";
            this.toolTip1.SetToolTip(this.cmbLanguages, resources.GetString("cmbLanguages.ToolTip"));
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkLastFooter);
            this.groupBox1.Controls.Add(this.rbKoncovyText);
            this.groupBox1.Controls.Add(this.rbUvodniText);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
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
            this.rbKoncovyText.UseVisualStyleBackColor = true;
            this.rbKoncovyText.CheckedChanged += new System.EventHandler(this.rbKoncovyText_CheckedChanged);
            // 
            // rbUvodniText
            // 
            resources.ApplyResources(this.rbUvodniText, "rbUvodniText");
            this.rbUvodniText.Name = "rbUvodniText";
            this.rbUvodniText.TabStop = true;
            this.rbUvodniText.UseVisualStyleBackColor = true;
            // 
            // cmdOK
            // 
            resources.ApplyResources(this.cmdOK, "cmdOK");
            this.cmdOK.Name = "cmdOK";
            this.cmdOK.UseVisualStyleBackColor = true;
            this.cmdOK.Click += new System.EventHandler(this.cmdOK_Click);
            // 
            // cmdStorno
            // 
            resources.ApplyResources(this.cmdStorno, "cmdStorno");
            this.cmdStorno.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdStorno.Name = "cmdStorno";
            this.cmdStorno.UseVisualStyleBackColor = true;
            // 
            // rtfCustomText
            // 
            resources.ApplyResources(this.rtfCustomText, "rtfCustomText");
            this.rtfCustomText.Name = "rtfCustomText";
            this.rtfCustomText.Rtf = "{\\rtf1\\ansi\\ansicpg1250\\deff0\\deflang1029{\\fonttbl{\\f0\\fnil\\fcharset238{\\*\\fname " +
    "Arial;}Arial CE;}}\r\n\\viewkind4\\uc1\\pard\\f0\\fs20\\par\r\n}\r\n";
            this.rtfCustomText.ShowSettingsControls = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkPageBreak);
            this.groupBox2.Controls.Add(this.chkKeepTogether);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // chkPageBreak
            // 
            resources.ApplyResources(this.chkPageBreak, "chkPageBreak");
            this.chkPageBreak.Name = "chkPageBreak";
            this.chkPageBreak.UseVisualStyleBackColor = true;
            // 
            // chkKeepTogether
            // 
            resources.ApplyResources(this.chkKeepTogether, "chkKeepTogether");
            this.chkKeepTogether.Name = "chkKeepTogether";
            this.chkKeepTogether.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // txtOnceKey
            // 
            resources.ApplyResources(this.txtOnceKey, "txtOnceKey");
            this.txtOnceKey.Name = "txtOnceKey";
            // 
            // CustomTextEditor
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cmdStorno;
            this.Controls.Add(this.txtOnceKey);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.rtfCustomText);
            this.Controls.Add(this.cmdStorno);
            this.Controls.Add(this.cmdOK);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmbLanguages);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nudPoradi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbTypProfilu);
            this.Controls.Add(this.label1);
            this.Name = "CustomTextEditor";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            ((System.ComponentModel.ISupportInitialize)(this.nudPoradi)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbTypProfilu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudPoradi;
        private System.Windows.Forms.Label label3;
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtOnceKey;
    }
}