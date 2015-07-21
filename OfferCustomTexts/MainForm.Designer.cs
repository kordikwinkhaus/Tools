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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cmdNew = new System.Windows.Forms.Button();
            this.cmdEdit = new System.Windows.Forms.Button();
            this.cmdClose = new System.Windows.Forms.Button();
            this.cmdDelete = new System.Windows.Forms.Button();
            this.dgvTexts = new System.Windows.Forms.DataGridView();
            this.colProfileType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTextOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLangID = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colIsHeader = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colKeepTogether = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colPageBreak = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colLastFooter = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colOnceKey = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCustomText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsTexts = new System.Windows.Forms.BindingSource(this.components);
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
            this.cmdExport = new System.Windows.Forms.Button();
            this.cmdImport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTexts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTexts)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdNew
            // 
            resources.ApplyResources(this.cmdNew, "cmdNew");
            this.cmdNew.Name = "cmdNew";
            this.cmdNew.UseVisualStyleBackColor = true;
            this.cmdNew.Click += new System.EventHandler(this.cmdNew_Click);
            // 
            // cmdEdit
            // 
            resources.ApplyResources(this.cmdEdit, "cmdEdit");
            this.cmdEdit.Name = "cmdEdit";
            this.cmdEdit.UseVisualStyleBackColor = true;
            this.cmdEdit.Click += new System.EventHandler(this.cmdEdit_Click);
            // 
            // cmdClose
            // 
            resources.ApplyResources(this.cmdClose, "cmdClose");
            this.cmdClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.UseVisualStyleBackColor = true;
            // 
            // cmdDelete
            // 
            resources.ApplyResources(this.cmdDelete, "cmdDelete");
            this.cmdDelete.Name = "cmdDelete";
            this.cmdDelete.UseVisualStyleBackColor = true;
            this.cmdDelete.Click += new System.EventHandler(this.cmdDelete_Click);
            // 
            // dgvTexts
            // 
            this.dgvTexts.AllowUserToAddRows = false;
            this.dgvTexts.AllowUserToDeleteRows = false;
            resources.ApplyResources(this.dgvTexts, "dgvTexts");
            this.dgvTexts.AutoGenerateColumns = false;
            this.dgvTexts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTexts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colProfileType,
            this.colTextOrder,
            this.colLangID,
            this.colIsHeader,
            this.colKeepTogether,
            this.colPageBreak,
            this.colLastFooter,
            this.colOnceKey,
            this.colCustomText});
            this.dgvTexts.DataSource = this.bsTexts;
            this.dgvTexts.MultiSelect = false;
            this.dgvTexts.Name = "dgvTexts";
            this.dgvTexts.ReadOnly = true;
            this.dgvTexts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTexts.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTexts_CellDoubleClick);
            // 
            // colProfileType
            // 
            this.colProfileType.DataPropertyName = "TypProf";
            resources.ApplyResources(this.colProfileType, "colProfileType");
            this.colProfileType.Name = "colProfileType";
            this.colProfileType.ReadOnly = true;
            // 
            // colTextOrder
            // 
            this.colTextOrder.DataPropertyName = "TextOrder";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colTextOrder.DefaultCellStyle = dataGridViewCellStyle5;
            resources.ApplyResources(this.colTextOrder, "colTextOrder");
            this.colTextOrder.Name = "colTextOrder";
            this.colTextOrder.ReadOnly = true;
            // 
            // colLangID
            // 
            this.colLangID.DataPropertyName = "LangID";
            resources.ApplyResources(this.colLangID, "colLangID");
            this.colLangID.Name = "colLangID";
            this.colLangID.ReadOnly = true;
            this.colLangID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // colIsHeader
            // 
            this.colIsHeader.DataPropertyName = "IsHeader";
            resources.ApplyResources(this.colIsHeader, "colIsHeader");
            this.colIsHeader.Name = "colIsHeader";
            this.colIsHeader.ReadOnly = true;
            this.colIsHeader.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // colKeepTogether
            // 
            this.colKeepTogether.DataPropertyName = "KeepTogether";
            resources.ApplyResources(this.colKeepTogether, "colKeepTogether");
            this.colKeepTogether.Name = "colKeepTogether";
            this.colKeepTogether.ReadOnly = true;
            this.colKeepTogether.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colKeepTogether.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // colPageBreak
            // 
            this.colPageBreak.DataPropertyName = "PageBreak";
            resources.ApplyResources(this.colPageBreak, "colPageBreak");
            this.colPageBreak.Name = "colPageBreak";
            this.colPageBreak.ReadOnly = true;
            // 
            // colLastFooter
            // 
            this.colLastFooter.DataPropertyName = "LastFooter";
            resources.ApplyResources(this.colLastFooter, "colLastFooter");
            this.colLastFooter.Name = "colLastFooter";
            this.colLastFooter.ReadOnly = true;
            // 
            // colOnceKey
            // 
            this.colOnceKey.DataPropertyName = "OnceKey";
            resources.ApplyResources(this.colOnceKey, "colOnceKey");
            this.colOnceKey.Name = "colOnceKey";
            this.colOnceKey.ReadOnly = true;
            // 
            // colCustomText
            // 
            this.colCustomText.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colCustomText.DataPropertyName = "CustomText";
            resources.ApplyResources(this.colCustomText, "colCustomText");
            this.colCustomText.Name = "colCustomText";
            this.colCustomText.ReadOnly = true;
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.cmdClearFilter);
            this.groupBox1.Controls.Add(this.cmdApplyFilter);
            this.groupBox1.Controls.Add(this.cmbLanguage);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmbProfileType);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbFooterTexts);
            this.groupBox2.Controls.Add(this.rbHeaderTexts);
            this.groupBox2.Controls.Add(this.rbAllTexts);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // rbFooterTexts
            // 
            resources.ApplyResources(this.rbFooterTexts, "rbFooterTexts");
            this.rbFooterTexts.Name = "rbFooterTexts";
            this.rbFooterTexts.UseVisualStyleBackColor = true;
            // 
            // rbHeaderTexts
            // 
            resources.ApplyResources(this.rbHeaderTexts, "rbHeaderTexts");
            this.rbHeaderTexts.Name = "rbHeaderTexts";
            this.rbHeaderTexts.UseVisualStyleBackColor = true;
            // 
            // rbAllTexts
            // 
            resources.ApplyResources(this.rbAllTexts, "rbAllTexts");
            this.rbAllTexts.Checked = true;
            this.rbAllTexts.Name = "rbAllTexts";
            this.rbAllTexts.TabStop = true;
            this.rbAllTexts.UseVisualStyleBackColor = true;
            // 
            // cmdClearFilter
            // 
            resources.ApplyResources(this.cmdClearFilter, "cmdClearFilter");
            this.cmdClearFilter.Name = "cmdClearFilter";
            this.cmdClearFilter.UseVisualStyleBackColor = true;
            this.cmdClearFilter.Click += new System.EventHandler(this.cmdClearFilter_Click);
            // 
            // cmdApplyFilter
            // 
            resources.ApplyResources(this.cmdApplyFilter, "cmdApplyFilter");
            this.cmdApplyFilter.Name = "cmdApplyFilter";
            this.cmdApplyFilter.UseVisualStyleBackColor = true;
            this.cmdApplyFilter.Click += new System.EventHandler(this.cmdApplyFilter_Click);
            // 
            // cmbLanguage
            // 
            resources.ApplyResources(this.cmbLanguage, "cmbLanguage");
            this.cmbLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLanguage.FormattingEnabled = true;
            this.cmbLanguage.Name = "cmbLanguage";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // cmbProfileType
            // 
            resources.ApplyResources(this.cmbProfileType, "cmbProfileType");
            this.cmbProfileType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProfileType.FormattingEnabled = true;
            this.cmbProfileType.Name = "cmbProfileType";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // cmdExport
            // 
            resources.ApplyResources(this.cmdExport, "cmdExport");
            this.cmdExport.Name = "cmdExport";
            this.cmdExport.UseVisualStyleBackColor = true;
            this.cmdExport.Click += new System.EventHandler(this.cmdExport_Click);
            // 
            // cmdImport
            // 
            resources.ApplyResources(this.cmdImport, "cmdImport");
            this.cmdImport.Name = "cmdImport";
            this.cmdImport.UseVisualStyleBackColor = true;
            this.cmdImport.Click += new System.EventHandler(this.cmdImport_Click);
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cmdClose;
            this.Controls.Add(this.cmdImport);
            this.Controls.Add(this.cmdExport);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvTexts);
            this.Controls.Add(this.cmdDelete);
            this.Controls.Add(this.cmdClose);
            this.Controls.Add(this.cmdEdit);
            this.Controls.Add(this.cmdNew);
            this.Name = "MainForm";
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTexts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTexts)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
        private System.Windows.Forms.BindingSource bsTexts;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProfileType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTextOrder;
        private System.Windows.Forms.DataGridViewComboBoxColumn colLangID;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colIsHeader;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colKeepTogether;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colPageBreak;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colLastFooter;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOnceKey;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCustomText;
        private System.Windows.Forms.Button cmdExport;
        private System.Windows.Forms.Button cmdImport;
    }
}