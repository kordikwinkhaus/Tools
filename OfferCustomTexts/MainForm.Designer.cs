namespace OfferCustomTexts
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvTexty = new System.Windows.Forms.DataGridView();
            this.cmdNovy = new System.Windows.Forms.Button();
            this.cmdEditovat = new System.Windows.Forms.Button();
            this.cmdClose = new System.Windows.Forms.Button();
            this.cmdOdstranit = new System.Windows.Forms.Button();
            this.bsTexty = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTexty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTexty)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Definované texty:";
            // 
            // dgvTexty
            // 
            this.dgvTexty.AllowUserToAddRows = false;
            this.dgvTexty.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTexty.AutoGenerateColumns = false;
            this.dgvTexty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTexty.DataSource = this.bsTexty;
            this.dgvTexty.Location = new System.Drawing.Point(12, 25);
            this.dgvTexty.Name = "dgvTexty";
            this.dgvTexty.ReadOnly = true;
            this.dgvTexty.Size = new System.Drawing.Size(597, 397);
            this.dgvTexty.TabIndex = 1;
            // 
            // cmdNovy
            // 
            this.cmdNovy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdNovy.Location = new System.Drawing.Point(615, 25);
            this.cmdNovy.Name = "cmdNovy";
            this.cmdNovy.Size = new System.Drawing.Size(75, 23);
            this.cmdNovy.TabIndex = 2;
            this.cmdNovy.Text = "Nový";
            this.cmdNovy.UseVisualStyleBackColor = true;
            this.cmdNovy.Click += new System.EventHandler(this.cmdNovy_Click);
            // 
            // cmdEditovat
            // 
            this.cmdEditovat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdEditovat.Location = new System.Drawing.Point(615, 54);
            this.cmdEditovat.Name = "cmdEditovat";
            this.cmdEditovat.Size = new System.Drawing.Size(75, 23);
            this.cmdEditovat.TabIndex = 3;
            this.cmdEditovat.Text = "Editovat";
            this.cmdEditovat.UseVisualStyleBackColor = true;
            // 
            // cmdClose
            // 
            this.cmdClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdClose.Location = new System.Drawing.Point(615, 399);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Size = new System.Drawing.Size(75, 23);
            this.cmdClose.TabIndex = 7;
            this.cmdClose.Text = "Zavřít";
            this.cmdClose.UseVisualStyleBackColor = true;
            // 
            // cmdOdstranit
            // 
            this.cmdOdstranit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdOdstranit.Location = new System.Drawing.Point(615, 83);
            this.cmdOdstranit.Name = "cmdOdstranit";
            this.cmdOdstranit.Size = new System.Drawing.Size(75, 23);
            this.cmdOdstranit.TabIndex = 5;
            this.cmdOdstranit.Text = "Odstranit";
            this.cmdOdstranit.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cmdClose;
            this.ClientSize = new System.Drawing.Size(698, 434);
            this.Controls.Add(this.cmdOdstranit);
            this.Controls.Add(this.cmdClose);
            this.Controls.Add(this.cmdEditovat);
            this.Controls.Add(this.cmdNovy);
            this.Controls.Add(this.dgvTexty);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Uživatelské texty";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTexty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTexty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvTexty;
        private System.Windows.Forms.Button cmdNovy;
        private System.Windows.Forms.Button cmdEditovat;
        private System.Windows.Forms.Button cmdClose;
        private System.Windows.Forms.Button cmdOdstranit;
        private System.Windows.Forms.BindingSource bsTexty;
    }
}