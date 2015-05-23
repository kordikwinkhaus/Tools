namespace Winkhaus.Whokna.OutputManager.RTFControl
{
	partial class Pad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pad));
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
            this.rtfBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtfBox.HideSelection = false;
            this.rtfBox.Location = new System.Drawing.Point(0, 25);
            this.rtfBox.Margin = new System.Windows.Forms.Padding(0);
            this.rtfBox.Name = "rtfBox";
            this.rtfBox.ShortcutsEnabled = false;
            this.rtfBox.Size = new System.Drawing.Size(634, 213);
            this.rtfBox.TabIndex = 0;
            this.rtfBox.Text = "";
            this.rtfBox.SelectionChanged += new System.EventHandler(this.rtfBox_SelectionChanged);
            this.rtfBox.Click += new System.EventHandler(this.rtfBox_Click);
            this.rtfBox.TextChanged += new System.EventHandler(this.rtfBox_TextChanged);
            this.rtfBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rtfBox_KeyDown);
            // 
            // toolbar
            // 
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
            this.toolbar.Location = new System.Drawing.Point(0, 0);
            this.toolbar.Name = "toolbar";
            this.toolbar.Size = new System.Drawing.Size(634, 25);
            this.toolbar.TabIndex = 1;
            this.toolbar.Text = "toolStrip1";
            // 
            // tbOpen
            // 
            this.tbOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbOpen.Image = ((System.Drawing.Image)(resources.GetObject("tbOpen.Image")));
            this.tbOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbOpen.Name = "tbOpen";
            this.tbOpen.Size = new System.Drawing.Size(23, 22);
            this.tbOpen.Text = "Vložit soubor RTF";
            this.tbOpen.Click += new System.EventHandler(this.tbOpen_Click);
            // 
            // tbSave
            // 
            this.tbSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbSave.Image = ((System.Drawing.Image)(resources.GetObject("tbSave.Image")));
            this.tbSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbSave.Name = "tbSave";
            this.tbSave.Size = new System.Drawing.Size(23, 22);
            this.tbSave.Text = "Uložit poznámku jako soubor RTF";
            this.tbSave.Click += new System.EventHandler(this.tbSave_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tbCut
            // 
            this.tbCut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbCut.Image = ((System.Drawing.Image)(resources.GetObject("tbCut.Image")));
            this.tbCut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbCut.Name = "tbCut";
            this.tbCut.Size = new System.Drawing.Size(23, 22);
            this.tbCut.Text = "Vyjmout";
            this.tbCut.Click += new System.EventHandler(this.tbCut_Click);
            // 
            // tbCopy
            // 
            this.tbCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbCopy.Image = ((System.Drawing.Image)(resources.GetObject("tbCopy.Image")));
            this.tbCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbCopy.Name = "tbCopy";
            this.tbCopy.Size = new System.Drawing.Size(23, 22);
            this.tbCopy.Text = "Kopírovat";
            this.tbCopy.Click += new System.EventHandler(this.tbCopy_Click);
            // 
            // tbPaste
            // 
            this.tbPaste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbPaste.Image = ((System.Drawing.Image)(resources.GetObject("tbPaste.Image")));
            this.tbPaste.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbPaste.Name = "tbPaste";
            this.tbPaste.Size = new System.Drawing.Size(23, 22);
            this.tbPaste.Text = "Vložit";
            this.tbPaste.Click += new System.EventHandler(this.tbPaste_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // cmbFont
            // 
            this.cmbFont.AutoSize = false;
            this.cmbFont.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFont.Name = "cmbFont";
            this.cmbFont.Size = new System.Drawing.Size(135, 23);
            this.cmbFont.ToolTipText = "Písmo";
            this.cmbFont.DropDownClosed += new System.EventHandler(this.cmbFont_DropDownClosed);
            // 
            // cmbSize
            // 
            this.cmbSize.AutoSize = false;
            this.cmbSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSize.DropDownWidth = 40;
            this.cmbSize.Name = "cmbSize";
            this.cmbSize.Size = new System.Drawing.Size(40, 23);
            this.cmbSize.ToolTipText = "Velikost";
            this.cmbSize.DropDownClosed += new System.EventHandler(this.cmbSize_DropDownClosed);
            // 
            // cmbColor
            // 
            this.cmbColor.AutoSize = false;
            this.cmbColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbColor.Name = "cmbColor";
            this.cmbColor.Size = new System.Drawing.Size(50, 23);
            this.cmbColor.ToolTipText = "Barva";
            this.cmbColor.DropDownClosed += new System.EventHandler(this.cmbColor_DropDownClosed);
            // 
            // tbBold
            // 
            this.tbBold.CheckOnClick = true;
            this.tbBold.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbBold.Image = ((System.Drawing.Image)(resources.GetObject("tbBold.Image")));
            this.tbBold.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbBold.Name = "tbBold";
            this.tbBold.Size = new System.Drawing.Size(23, 22);
            this.tbBold.Tag = "";
            this.tbBold.Text = "Tučné";
            this.tbBold.Click += new System.EventHandler(this.ChangeFontStyle_Click);
            // 
            // tbItalic
            // 
            this.tbItalic.CheckOnClick = true;
            this.tbItalic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbItalic.Image = ((System.Drawing.Image)(resources.GetObject("tbItalic.Image")));
            this.tbItalic.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbItalic.Name = "tbItalic";
            this.tbItalic.Size = new System.Drawing.Size(23, 22);
            this.tbItalic.Tag = "";
            this.tbItalic.Text = "Skloněné";
            this.tbItalic.Click += new System.EventHandler(this.ChangeFontStyle_Click);
            // 
            // tbUnderline
            // 
            this.tbUnderline.CheckOnClick = true;
            this.tbUnderline.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbUnderline.Image = ((System.Drawing.Image)(resources.GetObject("tbUnderline.Image")));
            this.tbUnderline.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbUnderline.Name = "tbUnderline";
            this.tbUnderline.Size = new System.Drawing.Size(23, 22);
            this.tbUnderline.Tag = "";
            this.tbUnderline.Text = "Podtržené";
            this.tbUnderline.Click += new System.EventHandler(this.ChangeFontStyle_Click);
            // 
            // tbStrikeout
            // 
            this.tbStrikeout.CheckOnClick = true;
            this.tbStrikeout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbStrikeout.Image = ((System.Drawing.Image)(resources.GetObject("tbStrikeout.Image")));
            this.tbStrikeout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbStrikeout.Name = "tbStrikeout";
            this.tbStrikeout.Size = new System.Drawing.Size(23, 22);
            this.tbStrikeout.Text = "Přeškrtnuté";
            this.tbStrikeout.Click += new System.EventHandler(this.ChangeFontStyle_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // tbAlignLeft
            // 
            this.tbAlignLeft.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbAlignLeft.Image = ((System.Drawing.Image)(resources.GetObject("tbAlignLeft.Image")));
            this.tbAlignLeft.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbAlignLeft.Name = "tbAlignLeft";
            this.tbAlignLeft.Size = new System.Drawing.Size(23, 22);
            this.tbAlignLeft.Text = "Zarovnat doleva";
            this.tbAlignLeft.Click += new System.EventHandler(this.tbAlignLeft_Click);
            // 
            // tbAlignCenter
            // 
            this.tbAlignCenter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbAlignCenter.Image = ((System.Drawing.Image)(resources.GetObject("tbAlignCenter.Image")));
            this.tbAlignCenter.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbAlignCenter.Name = "tbAlignCenter";
            this.tbAlignCenter.Size = new System.Drawing.Size(23, 22);
            this.tbAlignCenter.Text = "Zarovnat na střed";
            this.tbAlignCenter.Click += new System.EventHandler(this.tbAlignCenter_Click);
            // 
            // tbAlignRight
            // 
            this.tbAlignRight.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbAlignRight.Image = ((System.Drawing.Image)(resources.GetObject("tbAlignRight.Image")));
            this.tbAlignRight.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbAlignRight.Name = "tbAlignRight";
            this.tbAlignRight.Size = new System.Drawing.Size(23, 22);
            this.tbAlignRight.Text = "Zarovnat doprava";
            this.tbAlignRight.Click += new System.EventHandler(this.tbAlignRight_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // tbSaveDefaults
            // 
            this.tbSaveDefaults.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbSaveDefaults.Image = ((System.Drawing.Image)(resources.GetObject("tbSaveDefaults.Image")));
            this.tbSaveDefaults.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbSaveDefaults.Name = "tbSaveDefaults";
            this.tbSaveDefaults.Size = new System.Drawing.Size(23, 22);
            this.tbSaveDefaults.Text = "Uložit nastavení jako výchozí";
            this.tbSaveDefaults.Click += new System.EventHandler(this.tbSaveDefaults_Click);
            // 
            // tbRestoreDefaults
            // 
            this.tbRestoreDefaults.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbRestoreDefaults.Image = ((System.Drawing.Image)(resources.GetObject("tbRestoreDefaults.Image")));
            this.tbRestoreDefaults.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbRestoreDefaults.Name = "tbRestoreDefaults";
            this.tbRestoreDefaults.Size = new System.Drawing.Size(23, 22);
            this.tbRestoreDefaults.Text = "Obnovit výchozí nastavení";
            this.tbRestoreDefaults.Click += new System.EventHandler(this.tbRestoreDefaults_Click);
            // 
            // lblDebug
            // 
            this.lblDebug.Name = "lblDebug";
            this.lblDebug.Size = new System.Drawing.Size(0, 22);
            // 
            // Pad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rtfBox);
            this.Controls.Add(this.toolbar);
            this.Name = "Pad";
            this.Size = new System.Drawing.Size(634, 238);
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
