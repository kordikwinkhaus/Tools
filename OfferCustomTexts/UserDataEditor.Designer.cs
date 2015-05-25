namespace OfferCustomTexts
{
    partial class UserDataEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserDataEditor));
            this.dgvUserData = new System.Windows.Forms.DataGridView();
            this.cmdSaveChanges = new System.Windows.Forms.Button();
            this.cmdClose = new System.Windows.Forms.Button();
            this.cmdAutoResize = new System.Windows.Forms.Button();
            this.cmdAddColumn = new System.Windows.Forms.Button();
            this.cmdOK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserData)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUserData
            // 
            resources.ApplyResources(this.dgvUserData, "dgvUserData");
            this.dgvUserData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUserData.Name = "dgvUserData";
            // 
            // cmdSaveChanges
            // 
            resources.ApplyResources(this.cmdSaveChanges, "cmdSaveChanges");
            this.cmdSaveChanges.Name = "cmdSaveChanges";
            this.cmdSaveChanges.UseVisualStyleBackColor = true;
            this.cmdSaveChanges.Click += new System.EventHandler(this.cmdSaveChanges_Click);
            // 
            // cmdClose
            // 
            resources.ApplyResources(this.cmdClose, "cmdClose");
            this.cmdClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.UseVisualStyleBackColor = true;
            // 
            // cmdAutoResize
            // 
            resources.ApplyResources(this.cmdAutoResize, "cmdAutoResize");
            this.cmdAutoResize.Name = "cmdAutoResize";
            this.cmdAutoResize.UseVisualStyleBackColor = true;
            this.cmdAutoResize.Click += new System.EventHandler(this.cmdAutoResize_Click);
            // 
            // cmdAddColumn
            // 
            resources.ApplyResources(this.cmdAddColumn, "cmdAddColumn");
            this.cmdAddColumn.Name = "cmdAddColumn";
            this.cmdAddColumn.UseVisualStyleBackColor = true;
            this.cmdAddColumn.Click += new System.EventHandler(this.cmdAddColumn_Click);
            // 
            // cmdOK
            // 
            resources.ApplyResources(this.cmdOK, "cmdOK");
            this.cmdOK.Name = "cmdOK";
            this.cmdOK.UseVisualStyleBackColor = true;
            this.cmdOK.Click += new System.EventHandler(this.cmdOK_Click);
            // 
            // UserDataEditor
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cmdClose;
            this.Controls.Add(this.cmdOK);
            this.Controls.Add(this.cmdAddColumn);
            this.Controls.Add(this.cmdAutoResize);
            this.Controls.Add(this.cmdClose);
            this.Controls.Add(this.cmdSaveChanges);
            this.Controls.Add(this.dgvUserData);
            this.Name = "UserDataEditor";
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUserData;
        private System.Windows.Forms.Button cmdSaveChanges;
        private System.Windows.Forms.Button cmdClose;
        private System.Windows.Forms.Button cmdAutoResize;
        private System.Windows.Forms.Button cmdAddColumn;
        private System.Windows.Forms.Button cmdOK;
    }
}