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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbTypProfilu = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nudPoradi = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbKoncovyText = new System.Windows.Forms.RadioButton();
            this.rbUvodniText = new System.Windows.Forms.RadioButton();
            this.cmdOK = new System.Windows.Forms.Button();
            this.cmdStorno = new System.Windows.Forms.Button();
            this.rtfCustomText = new Winkhaus.RtfEditor.RtfEditControl();
            ((System.ComponentModel.ISupportInitialize)(this.nudPoradi)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Typ profilu";
            // 
            // cmbTypProfilu
            // 
            this.cmbTypProfilu.FormattingEnabled = true;
            this.cmbTypProfilu.Location = new System.Drawing.Point(104, 12);
            this.cmbTypProfilu.Name = "cmbTypProfilu";
            this.cmbTypProfilu.Size = new System.Drawing.Size(153, 21);
            this.cmbTypProfilu.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Pořadí";
            // 
            // nudPoradi
            // 
            this.nudPoradi.Location = new System.Drawing.Point(104, 39);
            this.nudPoradi.Name = "nudPoradi";
            this.nudPoradi.Size = new System.Drawing.Size(75, 20);
            this.nudPoradi.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Jazyk";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(104, 65);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(153, 21);
            this.comboBox2.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(332, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Pokud nemáte vícejazykovou databázi, ponechte jazyk beze změny.";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbKoncovyText);
            this.groupBox1.Controls.Add(this.rbUvodniText);
            this.groupBox1.Location = new System.Drawing.Point(263, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 74);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Typ textu";
            // 
            // rbKoncovyText
            // 
            this.rbKoncovyText.AutoSize = true;
            this.rbKoncovyText.Location = new System.Drawing.Point(10, 46);
            this.rbKoncovyText.Name = "rbKoncovyText";
            this.rbKoncovyText.Size = new System.Drawing.Size(96, 17);
            this.rbKoncovyText.TabIndex = 1;
            this.rbKoncovyText.TabStop = true;
            this.rbKoncovyText.Text = "Závěrečný text";
            this.rbKoncovyText.UseVisualStyleBackColor = true;
            // 
            // rbUvodniText
            // 
            this.rbUvodniText.AutoSize = true;
            this.rbUvodniText.Location = new System.Drawing.Point(10, 22);
            this.rbUvodniText.Name = "rbUvodniText";
            this.rbUvodniText.Size = new System.Drawing.Size(81, 17);
            this.rbUvodniText.TabIndex = 0;
            this.rbUvodniText.TabStop = true;
            this.rbUvodniText.Text = "Úvodní text";
            this.rbUvodniText.UseVisualStyleBackColor = true;
            // 
            // cmdOK
            // 
            this.cmdOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdOK.Location = new System.Drawing.Point(634, 428);
            this.cmdOK.Name = "cmdOK";
            this.cmdOK.Size = new System.Drawing.Size(75, 23);
            this.cmdOK.TabIndex = 21;
            this.cmdOK.Text = "&OK";
            this.cmdOK.UseVisualStyleBackColor = true;
            this.cmdOK.Click += new System.EventHandler(this.cmdOK_Click);
            // 
            // cmdStorno
            // 
            this.cmdStorno.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdStorno.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdStorno.Location = new System.Drawing.Point(715, 428);
            this.cmdStorno.Name = "cmdStorno";
            this.cmdStorno.Size = new System.Drawing.Size(75, 23);
            this.cmdStorno.TabIndex = 22;
            this.cmdStorno.Text = "&Storno";
            this.cmdStorno.UseVisualStyleBackColor = true;
            // 
            // rtfCustomText
            // 
            this.rtfCustomText.Location = new System.Drawing.Point(12, 115);
            this.rtfCustomText.Name = "rtfCustomText";
            this.rtfCustomText.Size = new System.Drawing.Size(774, 307);
            this.rtfCustomText.TabIndex = 23;
            // 
            // CustomTextEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cmdStorno;
            this.ClientSize = new System.Drawing.Size(798, 459);
            this.Controls.Add(this.rtfCustomText);
            this.Controls.Add(this.cmdStorno);
            this.Controls.Add(this.cmdOK);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nudPoradi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbTypProfilu);
            this.Controls.Add(this.label1);
            this.Name = "CustomTextEditor";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Editor uživatelských textů";
            ((System.ComponentModel.ISupportInitialize)(this.nudPoradi)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbTypProfilu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudPoradi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbKoncovyText;
        private System.Windows.Forms.RadioButton rbUvodniText;
        private System.Windows.Forms.Button cmdOK;
        private System.Windows.Forms.Button cmdStorno;
        private Winkhaus.RtfEditor.RtfEditControl rtfCustomText;
    }
}