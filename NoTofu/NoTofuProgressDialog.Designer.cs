namespace NoTofu
{
    partial class NoTofuProgressDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NoTofuProgressDialog));
            this.cmdStart = new System.Windows.Forms.Button();
            this.lblSearching = new System.Windows.Forms.Label();
            this.pbSearching = new System.Windows.Forms.ProgressBar();
            this.lblFixing = new System.Windows.Forms.Label();
            this.pbFixing = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // cmdStart
            // 
            resources.ApplyResources(this.cmdStart, "cmdStart");
            this.cmdStart.Name = "cmdStart";
            this.cmdStart.UseVisualStyleBackColor = true;
            this.cmdStart.Click += new System.EventHandler(this.cmdStart_Click);
            // 
            // lblSearching
            // 
            resources.ApplyResources(this.lblSearching, "lblSearching");
            this.lblSearching.Name = "lblSearching";
            // 
            // pbSearching
            // 
            resources.ApplyResources(this.pbSearching, "pbSearching");
            this.pbSearching.Name = "pbSearching";
            this.pbSearching.Step = 1;
            // 
            // lblFixing
            // 
            resources.ApplyResources(this.lblFixing, "lblFixing");
            this.lblFixing.Name = "lblFixing";
            // 
            // pbFixing
            // 
            resources.ApplyResources(this.pbFixing, "pbFixing");
            this.pbFixing.Name = "pbFixing";
            this.pbFixing.Step = 1;
            // 
            // NoTofuProgressDialog
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pbFixing);
            this.Controls.Add(this.lblFixing);
            this.Controls.Add(this.pbSearching);
            this.Controls.Add(this.lblSearching);
            this.Controls.Add(this.cmdStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NoTofuProgressDialog";
            this.ShowInTaskbar = false;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdStart;
        private System.Windows.Forms.Label lblSearching;
        private System.Windows.Forms.ProgressBar pbSearching;
        private System.Windows.Forms.Label lblFixing;
        private System.Windows.Forms.ProgressBar pbFixing;
    }
}