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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cmdNew = new System.Windows.Forms.Button();
            this.cmdEdit = new System.Windows.Forms.Button();
            this.cmdClose = new System.Windows.Forms.Button();
            this.cmdDelete = new System.Windows.Forms.Button();
            this.dgvTexts = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbFooterTexts = new System.Windows.Forms.RadioButton();
            this.rbHeaderTexts = new System.Windows.Forms.RadioButton();
            this.rbAllTexts = new System.Windows.Forms.RadioButton();
            this.cmdClearFilter = new System.Windows.Forms.Button();
            this.cmdApplyFilter = new System.Windows.Forms.Button();
            this.cmbLanguage = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbProfileType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.colProfileType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTextOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLangID = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colIsHeader = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colCustomText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsTexts = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTexts)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsTexts)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdNew
            // 
            this.cmdNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdNew.Location = new System.Drawing.Point(783, 28);
            this.cmdNew.Name = "cmdNew";
            this.cmdNew.Size = new System.Drawing.Size(75, 23);
            this.cmdNew.TabIndex = 2;
            this.cmdNew.Text = "New...";
            this.cmdNew.UseVisualStyleBackColor = true;
            this.cmdNew.Click += new System.EventHandler(this.cmdNew_Click);
            // 
            // cmdEdit
            // 
            this.cmdEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdEdit.Location = new System.Drawing.Point(783, 57);
            this.cmdEdit.Name = "cmdEdit";
            this.cmdEdit.Size = new System.Drawing.Size(75, 23);
            this.cmdEdit.TabIndex = 3;
            this.cmdEdit.Text = "Edit...";
            this.cmdEdit.UseVisualStyleBackColor = true;
            this.cmdEdit.Click += new System.EventHandler(this.cmdEdit_Click);
            // 
            // cmdClose
            // 
            this.cmdClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdClose.Location = new System.Drawing.Point(783, 371);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Size = new System.Drawing.Size(75, 23);
            this.cmdClose.TabIndex = 7;
            this.cmdClose.Text = "Close";
            this.cmdClose.UseVisualStyleBackColor = true;
            // 
            // cmdDelete
            // 
            this.cmdDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdDelete.Location = new System.Drawing.Point(783, 86);
            this.cmdDelete.Name = "cmdDelete";
            this.cmdDelete.Size = new System.Drawing.Size(75, 23);
            this.cmdDelete.TabIndex = 5;
            this.cmdDelete.Text = "Delete";
            this.cmdDelete.UseVisualStyleBackColor = true;
            this.cmdDelete.Click += new System.EventHandler(this.cmdDelete_Click);
            // 
            // dgvTexts
            // 
            this.dgvTexts.AllowUserToAddRows = false;
            this.dgvTexts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTexts.AutoGenerateColumns = false;
            this.dgvTexts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTexts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colProfileType,
            this.colTextOrder,
            this.colLangID,
            this.colIsHeader,
            this.colCustomText});
            this.dgvTexts.DataSource = this.bsTexts;
            this.dgvTexts.Location = new System.Drawing.Point(176, 28);
            this.dgvTexts.MultiSelect = false;
            this.dgvTexts.Name = "dgvTexts";
            this.dgvTexts.ReadOnly = true;
            this.dgvTexts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTexts.Size = new System.Drawing.Size(601, 365);
            this.dgvTexts.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.cmdClearFilter);
            this.groupBox1.Controls.Add(this.cmdApplyFilter);
            this.groupBox1.Controls.Add(this.cmbLanguage);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmbProfileType);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(155, 381);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbFooterTexts);
            this.groupBox2.Controls.Add(this.rbHeaderTexts);
            this.groupBox2.Controls.Add(this.rbAllTexts);
            this.groupBox2.Location = new System.Drawing.Point(9, 113);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(140, 91);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Text type";
            // 
            // rbFooterTexts
            // 
            this.rbFooterTexts.AutoSize = true;
            this.rbFooterTexts.Location = new System.Drawing.Point(6, 65);
            this.rbFooterTexts.Name = "rbFooterTexts";
            this.rbFooterTexts.Size = new System.Drawing.Size(80, 17);
            this.rbFooterTexts.TabIndex = 2;
            this.rbFooterTexts.Text = "Footer texts";
            this.rbFooterTexts.UseVisualStyleBackColor = true;
            // 
            // rbHeaderTexts
            // 
            this.rbHeaderTexts.AutoSize = true;
            this.rbHeaderTexts.Location = new System.Drawing.Point(6, 42);
            this.rbHeaderTexts.Name = "rbHeaderTexts";
            this.rbHeaderTexts.Size = new System.Drawing.Size(85, 17);
            this.rbHeaderTexts.TabIndex = 1;
            this.rbHeaderTexts.Text = "Header texts";
            this.rbHeaderTexts.UseVisualStyleBackColor = true;
            // 
            // rbAllTexts
            // 
            this.rbAllTexts.AutoSize = true;
            this.rbAllTexts.Checked = true;
            this.rbAllTexts.Location = new System.Drawing.Point(6, 19);
            this.rbAllTexts.Name = "rbAllTexts";
            this.rbAllTexts.Size = new System.Drawing.Size(61, 17);
            this.rbAllTexts.TabIndex = 0;
            this.rbAllTexts.TabStop = true;
            this.rbAllTexts.Text = "All texts";
            this.rbAllTexts.UseVisualStyleBackColor = true;
            // 
            // cmdClearFilter
            // 
            this.cmdClearFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdClearFilter.Location = new System.Drawing.Point(9, 256);
            this.cmdClearFilter.Name = "cmdClearFilter";
            this.cmdClearFilter.Size = new System.Drawing.Size(140, 23);
            this.cmdClearFilter.TabIndex = 5;
            this.cmdClearFilter.Text = "Clear filter";
            this.cmdClearFilter.UseVisualStyleBackColor = true;
            this.cmdClearFilter.Click += new System.EventHandler(this.cmdClearFilter_Click);
            // 
            // cmdApplyFilter
            // 
            this.cmdApplyFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdApplyFilter.Location = new System.Drawing.Point(9, 227);
            this.cmdApplyFilter.Name = "cmdApplyFilter";
            this.cmdApplyFilter.Size = new System.Drawing.Size(140, 23);
            this.cmdApplyFilter.TabIndex = 4;
            this.cmdApplyFilter.Text = "Apply filter";
            this.cmdApplyFilter.UseVisualStyleBackColor = true;
            this.cmdApplyFilter.Click += new System.EventHandler(this.cmdApplyFilter_Click);
            // 
            // cmbLanguage
            // 
            this.cmbLanguage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLanguage.FormattingEnabled = true;
            this.cmbLanguage.Location = new System.Drawing.Point(9, 82);
            this.cmbLanguage.Name = "cmbLanguage";
            this.cmbLanguage.Size = new System.Drawing.Size(140, 21);
            this.cmbLanguage.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Language";
            // 
            // cmbProfileType
            // 
            this.cmbProfileType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbProfileType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProfileType.FormattingEnabled = true;
            this.cmbProfileType.Location = new System.Drawing.Point(9, 37);
            this.cmbProfileType.Name = "cmbProfileType";
            this.cmbProfileType.Size = new System.Drawing.Size(140, 21);
            this.cmbProfileType.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Profile type";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(173, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Available texts:";
            // 
            // colProfileType
            // 
            this.colProfileType.DataPropertyName = "TypProf";
            this.colProfileType.HeaderText = "Profile type";
            this.colProfileType.MinimumWidth = 70;
            this.colProfileType.Name = "colProfileType";
            this.colProfileType.ReadOnly = true;
            // 
            // colTextOrder
            // 
            this.colTextOrder.DataPropertyName = "TextOrder";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colTextOrder.DefaultCellStyle = dataGridViewCellStyle4;
            this.colTextOrder.HeaderText = "Order";
            this.colTextOrder.MinimumWidth = 40;
            this.colTextOrder.Name = "colTextOrder";
            this.colTextOrder.ReadOnly = true;
            this.colTextOrder.Width = 70;
            // 
            // colLangID
            // 
            this.colLangID.DataPropertyName = "LangID";
            this.colLangID.HeaderText = "Language";
            this.colLangID.Name = "colLangID";
            this.colLangID.ReadOnly = true;
            this.colLangID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // colIsHeader
            // 
            this.colIsHeader.DataPropertyName = "IsHeader";
            this.colIsHeader.HeaderText = "Is header";
            this.colIsHeader.MinimumWidth = 30;
            this.colIsHeader.Name = "colIsHeader";
            this.colIsHeader.ReadOnly = true;
            this.colIsHeader.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colIsHeader.Width = 50;
            // 
            // colCustomText
            // 
            this.colCustomText.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colCustomText.DataPropertyName = "CustomText";
            this.colCustomText.HeaderText = "Text";
            this.colCustomText.Name = "colCustomText";
            this.colCustomText.ReadOnly = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cmdClose;
            this.ClientSize = new System.Drawing.Size(866, 406);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvTexts);
            this.Controls.Add(this.cmdDelete);
            this.Controls.Add(this.cmdClose);
            this.Controls.Add(this.cmdEdit);
            this.Controls.Add(this.cmdNew);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Custom texts";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTexts)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsTexts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdNew;
        private System.Windows.Forms.Button cmdEdit;
        private System.Windows.Forms.Button cmdClose;
        private System.Windows.Forms.Button cmdDelete;
        private System.Windows.Forms.DataGridView dgvTexts;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdClearFilter;
        private System.Windows.Forms.Button cmdApplyFilter;
        private System.Windows.Forms.ComboBox cmbLanguage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbProfileType;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbFooterTexts;
        private System.Windows.Forms.RadioButton rbHeaderTexts;
        private System.Windows.Forms.RadioButton rbAllTexts;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProfileType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTextOrder;
        private System.Windows.Forms.DataGridViewComboBoxColumn colLangID;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colIsHeader;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCustomText;
        private System.Windows.Forms.BindingSource bsTexts;
    }
}