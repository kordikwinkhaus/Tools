namespace Winkhaus.RtfEditor
{
	partial class RtfEditControl
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RtfEditControl));
            this.rtfBox = new System.Windows.Forms.RichTextBox();
            this.toolbar = new System.Windows.Forms.ToolStrip();
            this.tbOpen = new System.Windows.Forms.ToolStripButton();
            this.tbSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tbCut = new System.Windows.Forms.ToolStripButton();
            this.tbCopy = new System.Windows.Forms.ToolStripButton();
            this.tbPaste = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.cmbFont = new System.Windows.Forms.ToolStripComboBox();
            this.cmbSize = new System.Windows.Forms.ToolStripComboBox();
            this.cmbColor = new System.Windows.Forms.ToolStripComboBox();
            this.tbBold = new System.Windows.Forms.ToolStripButton();
            this.tbItalic = new System.Windows.Forms.ToolStripButton();
            this.tbUnderline = new System.Windows.Forms.ToolStripButton();
            this.tbStrikeout = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tbAlignLeft = new System.Windows.Forms.ToolStripButton();
            this.tbAlignCenter = new System.Windows.Forms.ToolStripButton();
            this.tbAlignRight = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tbSaveDefaults = new System.Windows.Forms.ToolStripButton();
            this.tbRestoreDefaults = new System.Windows.Forms.ToolStripButton();
            this.lblDebug = new System.Windows.Forms.ToolStripLabel();
            this.toolbar.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtfBox
            // 
            this.rtfBox.AcceptsTab = true;
            resources.ApplyResources(this.rtfBox, "rtfBox");
            this.rtfBox.HideSelection = false;
            this.rtfBox.Name = "rtfBox";
            this.rtfBox.ShortcutsEnabled = false;
            this.rtfBox.SelectionChanged += new System.EventHandler(this.rtfBox_SelectionChanged);
            this.rtfBox.Click += new System.EventHandler(this.rtfBox_Click);
            this.rtfBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rtfBox_KeyDown);
            // 
            // toolbar
            // 
            resources.ApplyResources(this.toolbar, "toolbar");
            this.toolbar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbOpen,
            this.tbSave,
            this.toolStripSeparator1,
            this.tbCut,
            this.tbCopy,
            this.tbPaste,
            this.toolStripSeparator2,
            this.cmbFont,
            this.cmbSize,
            this.cmbColor,
            this.tbBold,
            this.tbItalic,
            this.tbUnderline,
            this.tbStrikeout,
            this.toolStripSeparator3,
            this.tbAlignLeft,
            this.tbAlignCenter,
            this.tbAlignRight,
            this.toolStripSeparator4,
            this.tbSaveDefaults,
            this.tbRestoreDefaults,
            this.lblDebug});
            this.toolbar.Name = "toolbar";
            // 
            // tbOpen
            // 
            resources.ApplyResources(this.tbOpen, "tbOpen");
            this.tbOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbOpen.Name = "tbOpen";
            this.tbOpen.Click += new System.EventHandler(this.tbOpen_Click);
            // 
            // tbSave
            // 
            resources.ApplyResources(this.tbSave, "tbSave");
            this.tbSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbSave.Name = "tbSave";
            this.tbSave.Click += new System.EventHandler(this.tbSave_Click);
            // 
            // toolStripSeparator1
            // 
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            // 
            // tbCut
            // 
            resources.ApplyResources(this.tbCut, "tbCut");
            this.tbCut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbCut.Name = "tbCut";
            this.tbCut.Click += new System.EventHandler(this.tbCut_Click);
            // 
            // tbCopy
            // 
            resources.ApplyResources(this.tbCopy, "tbCopy");
            this.tbCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbCopy.Name = "tbCopy";
            this.tbCopy.Click += new System.EventHandler(this.tbCopy_Click);
            // 
            // tbPaste
            // 
            resources.ApplyResources(this.tbPaste, "tbPaste");
            this.tbPaste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbPaste.Name = "tbPaste";
            this.tbPaste.Click += new System.EventHandler(this.tbPaste_Click);
            // 
            // toolStripSeparator2
            // 
            resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            // 
            // cmbFont
            // 
            resources.ApplyResources(this.cmbFont, "cmbFont");
            this.cmbFont.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFont.Name = "cmbFont";
            this.cmbFont.DropDownClosed += new System.EventHandler(this.cmbFont_DropDownClosed);
            // 
            // cmbSize
            // 
            resources.ApplyResources(this.cmbSize, "cmbSize");
            this.cmbSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSize.DropDownWidth = 40;
            this.cmbSize.Name = "cmbSize";
            this.cmbSize.DropDownClosed += new System.EventHandler(this.cmbSize_DropDownClosed);
            // 
            // cmbColor
            // 
            resources.ApplyResources(this.cmbColor, "cmbColor");
            this.cmbColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbColor.Name = "cmbColor";
            this.cmbColor.DropDownClosed += new System.EventHandler(this.cmbColor_DropDownClosed);
            // 
            // tbBold
            // 
            resources.ApplyResources(this.tbBold, "tbBold");
            this.tbBold.CheckOnClick = true;
            this.tbBold.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbBold.Name = "tbBold";
            this.tbBold.Tag = "";
            this.tbBold.Click += new System.EventHandler(this.ChangeFontStyle_Click);
            // 
            // tbItalic
            // 
            resources.ApplyResources(this.tbItalic, "tbItalic");
            this.tbItalic.CheckOnClick = true;
            this.tbItalic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbItalic.Name = "tbItalic";
            this.tbItalic.Tag = "";
            this.tbItalic.Click += new System.EventHandler(this.ChangeFontStyle_Click);
            // 
            // tbUnderline
            // 
            resources.ApplyResources(this.tbUnderline, "tbUnderline");
            this.tbUnderline.CheckOnClick = true;
            this.tbUnderline.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbUnderline.Name = "tbUnderline";
            this.tbUnderline.Tag = "";
            this.tbUnderline.Click += new System.EventHandler(this.ChangeFontStyle_Click);
            // 
            // tbStrikeout
            // 
            resources.ApplyResources(this.tbStrikeout, "tbStrikeout");
            this.tbStrikeout.CheckOnClick = true;
            this.tbStrikeout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbStrikeout.Name = "tbStrikeout";
            this.tbStrikeout.Click += new System.EventHandler(this.ChangeFontStyle_Click);
            // 
            // toolStripSeparator3
            // 
            resources.ApplyResources(this.toolStripSeparator3, "toolStripSeparator3");
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            // 
            // tbAlignLeft
            // 
            resources.ApplyResources(this.tbAlignLeft, "tbAlignLeft");
            this.tbAlignLeft.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbAlignLeft.Name = "tbAlignLeft";
            this.tbAlignLeft.Click += new System.EventHandler(this.tbAlignLeft_Click);
            // 
            // tbAlignCenter
            // 
            resources.ApplyResources(this.tbAlignCenter, "tbAlignCenter");
            this.tbAlignCenter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbAlignCenter.Name = "tbAlignCenter";
            this.tbAlignCenter.Click += new System.EventHandler(this.tbAlignCenter_Click);
            // 
            // tbAlignRight
            // 
            resources.ApplyResources(this.tbAlignRight, "tbAlignRight");
            this.tbAlignRight.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbAlignRight.Name = "tbAlignRight";
            this.tbAlignRight.Click += new System.EventHandler(this.tbAlignRight_Click);
            // 
            // toolStripSeparator4
            // 
            resources.ApplyResources(this.toolStripSeparator4, "toolStripSeparator4");
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            // 
            // tbSaveDefaults
            // 
            resources.ApplyResources(this.tbSaveDefaults, "tbSaveDefaults");
            this.tbSaveDefaults.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbSaveDefaults.Name = "tbSaveDefaults";
            this.tbSaveDefaults.Click += new System.EventHandler(this.tbSaveDefaults_Click);
            // 
            // tbRestoreDefaults
            // 
            resources.ApplyResources(this.tbRestoreDefaults, "tbRestoreDefaults");
            this.tbRestoreDefaults.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbRestoreDefaults.Name = "tbRestoreDefaults";
            this.tbRestoreDefaults.Click += new System.EventHandler(this.tbRestoreDefaults_Click);
            // 
            // lblDebug
            // 
            resources.ApplyResources(this.lblDebug, "lblDebug");
            this.lblDebug.Name = "lblDebug";
            // 
            // RtfEditControl
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rtfBox);
            this.Controls.Add(this.toolbar);
            this.Name = "RtfEditControl";
            this.toolbar.ResumeLayout(false);
            this.toolbar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

        private System.Windows.Forms.RichTextBox rtfBox;
        private System.Windows.Forms.ToolStrip toolbar;
        private System.Windows.Forms.ToolStripButton tbOpen;
        private System.Windows.Forms.ToolStripButton tbSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tbCut;
        private System.Windows.Forms.ToolStripButton tbCopy;
        private System.Windows.Forms.ToolStripButton tbPaste;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripComboBox cmbFont;
        private System.Windows.Forms.ToolStripComboBox cmbSize;
        private System.Windows.Forms.ToolStripComboBox cmbColor;
        private System.Windows.Forms.ToolStripButton tbBold;
        private System.Windows.Forms.ToolStripButton tbItalic;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tbAlignLeft;
        private System.Windows.Forms.ToolStripButton tbAlignCenter;
        private System.Windows.Forms.ToolStripButton tbAlignRight;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton tbSaveDefaults;
        private System.Windows.Forms.ToolStripButton tbRestoreDefaults;
        private System.Windows.Forms.ToolStripLabel lblDebug;
        private System.Windows.Forms.ToolStripButton tbUnderline;
        private System.Windows.Forms.ToolStripButton tbStrikeout;
	}
}
