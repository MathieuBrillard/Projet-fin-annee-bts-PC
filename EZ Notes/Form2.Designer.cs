namespace EZ_Notes
{
    partial class Note
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Note));
            this.noteContent = new System.Windows.Forms.RichTextBox();
            this.richContextStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.noteToolStripMenuAccueil = new System.Windows.Forms.ToolStripMenuItem();
            this.nouvelleNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paramètresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.saveStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.printStripButton = new System.Windows.Forms.ToolStripButton();
            this.printPreviewStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.undoStripButton = new System.Windows.Forms.ToolStripButton();
            this.redoStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.fontStripComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.fontSizeComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.increaseStripButton = new System.Windows.Forms.ToolStripButton();
            this.decreaseStripButton = new System.Windows.Forms.ToolStripButton();
            this.colorStripDropDownButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.changeCaseDropDownButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.lowercaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uppercaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.clearFormattingStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.boldStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.italicStripButton = new System.Windows.Forms.ToolStripButton();
            this.underlineStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.leftAlignStripButton = new System.Windows.Forms.ToolStripButton();
            this.centerAlignStripButton = new System.Windows.Forms.ToolStripButton();
            this.rightAlignStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.bulletListStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.zoomDropDownButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lineColumnStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.printDialog = new System.Windows.Forms.PrintDialog();
            this.printPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.nouveauRappelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.richContextStrip.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // noteContent
            // 
            this.noteContent.AcceptsTab = true;
            this.noteContent.BulletIndent = 4;
            this.noteContent.ContextMenuStrip = this.richContextStrip;
            this.noteContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.noteContent.EnableAutoDragDrop = true;
            this.noteContent.Location = new System.Drawing.Point(0, 24);
            this.noteContent.Name = "noteContent";
            this.noteContent.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.noteContent.Size = new System.Drawing.Size(977, 362);
            this.noteContent.TabIndex = 4;
            this.noteContent.Text = "";
            this.noteContent.SelectionChanged += new System.EventHandler(this.noteContent_SelectionChanged);
            this.noteContent.TextChanged += new System.EventHandler(this.noteContent_TextChanged);
            this.noteContent.KeyUp += new System.Windows.Forms.KeyEventHandler(this.noteContent_KeyUp);
            this.noteContent.MouseDown += new System.Windows.Forms.MouseEventHandler(this.noteContent_MouseDown);
            // 
            // richContextStrip
            // 
            this.richContextStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.richContextStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.deleteStripMenuItem,
            this.selectAllToolStripMenuItem,
            this.clearToolStripMenuItem});
            this.richContextStrip.Name = "richContextStrip";
            this.richContextStrip.Size = new System.Drawing.Size(173, 184);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cutToolStripMenuItem.Image")));
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(172, 30);
            this.cutToolStripMenuItem.Text = "Cut";
            this.cutToolStripMenuItem.Click += new System.EventHandler(this.cutToolStripMenuItem1_Click);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripMenuItem.Image")));
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(172, 30);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem1_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pasteToolStripMenuItem.Image")));
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(172, 30);
            this.pasteToolStripMenuItem.Text = "Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem1_Click);
            // 
            // deleteStripMenuItem
            // 
            this.deleteStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("deleteStripMenuItem.Image")));
            this.deleteStripMenuItem.Name = "deleteStripMenuItem";
            this.deleteStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.deleteStripMenuItem.Size = new System.Drawing.Size(172, 30);
            this.deleteStripMenuItem.Text = "Delete";
            this.deleteStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("selectAllToolStripMenuItem.Image")));
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(172, 30);
            this.selectAllToolStripMenuItem.Text = "Select All";
            this.selectAllToolStripMenuItem.Click += new System.EventHandler(this.selectAllToolStripMenuItem1_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("clearToolStripMenuItem.Image")));
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(172, 30);
            this.clearToolStripMenuItem.Text = "Clear All";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearAllToolStripMenuItem_Click);
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.noteToolStripMenuAccueil,
            this.nouvelleNoteToolStripMenuItem,
            this.nouveauRappelToolStripMenuItem,
            this.paramètresToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(977, 24);
            this.menuStrip2.TabIndex = 2;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // noteToolStripMenuAccueil
            // 
            this.noteToolStripMenuAccueil.Name = "noteToolStripMenuAccueil";
            this.noteToolStripMenuAccueil.Size = new System.Drawing.Size(56, 20);
            this.noteToolStripMenuAccueil.Text = "Fermer";
            this.noteToolStripMenuAccueil.Click += new System.EventHandler(this.noteToolStripMenuAccueil_Click);
            // 
            // nouvelleNoteToolStripMenuItem
            // 
            this.nouvelleNoteToolStripMenuItem.Name = "nouvelleNoteToolStripMenuItem";
            this.nouvelleNoteToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.nouvelleNoteToolStripMenuItem.Text = "Nouvelle Note";
            this.nouvelleNoteToolStripMenuItem.Click += new System.EventHandler(this.nouvelleNoteToolStripMenuItem_Click);
            // 
            // paramètresToolStripMenuItem
            // 
            this.paramètresToolStripMenuItem.Name = "paramètresToolStripMenuItem";
            this.paramètresToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.paramètresToolStripMenuItem.Text = "Paramètres";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveStripButton,
            this.toolStripSeparator10,
            this.printStripButton,
            this.printPreviewStripButton,
            this.toolStripSeparator5,
            this.undoStripButton,
            this.redoStripButton,
            this.toolStripSeparator1,
            this.fontStripComboBox,
            this.fontSizeComboBox,
            this.increaseStripButton,
            this.decreaseStripButton,
            this.colorStripDropDownButton,
            this.changeCaseDropDownButton,
            this.toolStripSeparator9,
            this.clearFormattingStripButton,
            this.toolStripSeparator2,
            this.boldStripButton3,
            this.italicStripButton,
            this.underlineStripButton,
            this.toolStripSeparator3,
            this.leftAlignStripButton,
            this.centerAlignStripButton,
            this.rightAlignStripButton,
            this.toolStripSeparator4,
            this.bulletListStripButton,
            this.toolStripSeparator8,
            this.zoomDropDownButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 355);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(977, 31);
            this.toolStrip1.TabIndex = 17;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // saveStripButton
            // 
            this.saveStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveStripButton.Image")));
            this.saveStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveStripButton.Name = "saveStripButton";
            this.saveStripButton.Size = new System.Drawing.Size(28, 28);
            this.saveStripButton.Text = "Sauvegarder";
            this.saveStripButton.Click += new System.EventHandler(this.saveStripButton_Click);
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(6, 31);
            // 
            // printStripButton
            // 
            this.printStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.printStripButton.Image = ((System.Drawing.Image)(resources.GetObject("printStripButton.Image")));
            this.printStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printStripButton.Name = "printStripButton";
            this.printStripButton.Size = new System.Drawing.Size(28, 28);
            this.printStripButton.Text = "Imprimer";
            this.printStripButton.Click += new System.EventHandler(this.printStripButton_Click);
            // 
            // printPreviewStripButton
            // 
            this.printPreviewStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.printPreviewStripButton.Image = ((System.Drawing.Image)(resources.GetObject("printPreviewStripButton.Image")));
            this.printPreviewStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printPreviewStripButton.Name = "printPreviewStripButton";
            this.printPreviewStripButton.Size = new System.Drawing.Size(28, 28);
            this.printPreviewStripButton.Text = "Aperçu Impression";
            this.printPreviewStripButton.Click += new System.EventHandler(this.printPreviewStripButton_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 31);
            // 
            // undoStripButton
            // 
            this.undoStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.undoStripButton.Image = ((System.Drawing.Image)(resources.GetObject("undoStripButton.Image")));
            this.undoStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.undoStripButton.Name = "undoStripButton";
            this.undoStripButton.Size = new System.Drawing.Size(28, 28);
            this.undoStripButton.Text = "Undo";
            this.undoStripButton.Click += new System.EventHandler(this.undoStripButton_Click);
            // 
            // redoStripButton
            // 
            this.redoStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.redoStripButton.Image = ((System.Drawing.Image)(resources.GetObject("redoStripButton.Image")));
            this.redoStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.redoStripButton.Name = "redoStripButton";
            this.redoStripButton.Size = new System.Drawing.Size(28, 28);
            this.redoStripButton.Text = "Redo";
            this.redoStripButton.Click += new System.EventHandler(this.redoStripButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // fontStripComboBox
            // 
            this.fontStripComboBox.Name = "fontStripComboBox";
            this.fontStripComboBox.Size = new System.Drawing.Size(155, 31);
            this.fontStripComboBox.Sorted = true;
            this.fontStripComboBox.Text = "Police";
            this.fontStripComboBox.ToolTipText = "Font Family";
            this.fontStripComboBox.SelectedIndexChanged += new System.EventHandler(this.fontStripComboBox_SelectedIndexChanged);
            // 
            // fontSizeComboBox
            // 
            this.fontSizeComboBox.AutoSize = false;
            this.fontSizeComboBox.Name = "fontSizeComboBox";
            this.fontSizeComboBox.Size = new System.Drawing.Size(73, 23);
            this.fontSizeComboBox.Text = "Taille";
            this.fontSizeComboBox.ToolTipText = "Font Size";
            this.fontSizeComboBox.SelectedIndexChanged += new System.EventHandler(this.fontSizeComboBox_SelectedIndexChanged);
            // 
            // increaseStripButton
            // 
            this.increaseStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.increaseStripButton.Image = ((System.Drawing.Image)(resources.GetObject("increaseStripButton.Image")));
            this.increaseStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.increaseStripButton.Name = "increaseStripButton";
            this.increaseStripButton.Size = new System.Drawing.Size(28, 28);
            this.increaseStripButton.Text = "Augmenter Taille";
            this.increaseStripButton.Click += new System.EventHandler(this.increaseStripButton_Click);
            // 
            // decreaseStripButton
            // 
            this.decreaseStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.decreaseStripButton.Image = ((System.Drawing.Image)(resources.GetObject("decreaseStripButton.Image")));
            this.decreaseStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.decreaseStripButton.Name = "decreaseStripButton";
            this.decreaseStripButton.Size = new System.Drawing.Size(28, 28);
            this.decreaseStripButton.Text = "Réduire Taille";
            this.decreaseStripButton.Click += new System.EventHandler(this.decreaseStripButton_Click);
            // 
            // colorStripDropDownButton
            // 
            this.colorStripDropDownButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.colorStripDropDownButton.Image = ((System.Drawing.Image)(resources.GetObject("colorStripDropDownButton.Image")));
            this.colorStripDropDownButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.colorStripDropDownButton.Name = "colorStripDropDownButton";
            this.colorStripDropDownButton.Size = new System.Drawing.Size(37, 28);
            this.colorStripDropDownButton.Text = "Couleur";
            this.colorStripDropDownButton.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.colorStripDropDownButton_DropDownItemClicked);
            // 
            // changeCaseDropDownButton
            // 
            this.changeCaseDropDownButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.changeCaseDropDownButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lowercaseToolStripMenuItem,
            this.uppercaseToolStripMenuItem});
            this.changeCaseDropDownButton.Image = ((System.Drawing.Image)(resources.GetObject("changeCaseDropDownButton.Image")));
            this.changeCaseDropDownButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.changeCaseDropDownButton.Name = "changeCaseDropDownButton";
            this.changeCaseDropDownButton.Size = new System.Drawing.Size(37, 28);
            this.changeCaseDropDownButton.Text = "Changer la casse";
            // 
            // lowercaseToolStripMenuItem
            // 
            this.lowercaseToolStripMenuItem.Name = "lowercaseToolStripMenuItem";
            this.lowercaseToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.lowercaseToolStripMenuItem.Text = "&minuscule";
            this.lowercaseToolStripMenuItem.Click += new System.EventHandler(this.lowercaseToolStripMenuItem_Click);
            // 
            // uppercaseToolStripMenuItem
            // 
            this.uppercaseToolStripMenuItem.Name = "uppercaseToolStripMenuItem";
            this.uppercaseToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.uppercaseToolStripMenuItem.Text = "&MAJUSCULE";
            this.uppercaseToolStripMenuItem.Click += new System.EventHandler(this.uppercaseToolStripMenuItem_Click);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(6, 31);
            // 
            // clearFormattingStripButton
            // 
            this.clearFormattingStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.clearFormattingStripButton.Image = ((System.Drawing.Image)(resources.GetObject("clearFormattingStripButton.Image")));
            this.clearFormattingStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.clearFormattingStripButton.Name = "clearFormattingStripButton";
            this.clearFormattingStripButton.Size = new System.Drawing.Size(28, 28);
            this.clearFormattingStripButton.Text = "Enlever tous les effets";
            this.clearFormattingStripButton.Click += new System.EventHandler(this.clearFormattingStripButton_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // boldStripButton3
            // 
            this.boldStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.boldStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("boldStripButton3.Image")));
            this.boldStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.boldStripButton3.Name = "boldStripButton3";
            this.boldStripButton3.Size = new System.Drawing.Size(28, 28);
            this.boldStripButton3.Text = "Gras";
            this.boldStripButton3.Click += new System.EventHandler(this.boldStripButton_Click);
            // 
            // italicStripButton
            // 
            this.italicStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.italicStripButton.Image = ((System.Drawing.Image)(resources.GetObject("italicStripButton.Image")));
            this.italicStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.italicStripButton.Name = "italicStripButton";
            this.italicStripButton.Size = new System.Drawing.Size(28, 28);
            this.italicStripButton.Text = "Italique";
            this.italicStripButton.Click += new System.EventHandler(this.italicStripButton_Click);
            // 
            // underlineStripButton
            // 
            this.underlineStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.underlineStripButton.Image = ((System.Drawing.Image)(resources.GetObject("underlineStripButton.Image")));
            this.underlineStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.underlineStripButton.Name = "underlineStripButton";
            this.underlineStripButton.Size = new System.Drawing.Size(28, 28);
            this.underlineStripButton.Text = "Souligné";
            this.underlineStripButton.Click += new System.EventHandler(this.underlineStripButton_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 31);
            // 
            // leftAlignStripButton
            // 
            this.leftAlignStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.leftAlignStripButton.Image = ((System.Drawing.Image)(resources.GetObject("leftAlignStripButton.Image")));
            this.leftAlignStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.leftAlignStripButton.Name = "leftAlignStripButton";
            this.leftAlignStripButton.Size = new System.Drawing.Size(28, 28);
            this.leftAlignStripButton.Text = "Alignement Gauche";
            this.leftAlignStripButton.Click += new System.EventHandler(this.leftAlignStripButton_Click);
            // 
            // centerAlignStripButton
            // 
            this.centerAlignStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.centerAlignStripButton.Image = ((System.Drawing.Image)(resources.GetObject("centerAlignStripButton.Image")));
            this.centerAlignStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.centerAlignStripButton.Name = "centerAlignStripButton";
            this.centerAlignStripButton.Size = new System.Drawing.Size(28, 28);
            this.centerAlignStripButton.Text = "Alignement Milieu";
            this.centerAlignStripButton.Click += new System.EventHandler(this.centerAlignStripButton_Click);
            // 
            // rightAlignStripButton
            // 
            this.rightAlignStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.rightAlignStripButton.Image = ((System.Drawing.Image)(resources.GetObject("rightAlignStripButton.Image")));
            this.rightAlignStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.rightAlignStripButton.Name = "rightAlignStripButton";
            this.rightAlignStripButton.Size = new System.Drawing.Size(28, 28);
            this.rightAlignStripButton.Text = "Alignement Droit";
            this.rightAlignStripButton.Click += new System.EventHandler(this.rightAlignStripButton_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 31);
            // 
            // bulletListStripButton
            // 
            this.bulletListStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bulletListStripButton.Image = ((System.Drawing.Image)(resources.GetObject("bulletListStripButton.Image")));
            this.bulletListStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bulletListStripButton.Name = "bulletListStripButton";
            this.bulletListStripButton.Size = new System.Drawing.Size(28, 28);
            this.bulletListStripButton.Text = "Liste à puce";
            this.bulletListStripButton.Click += new System.EventHandler(this.bulletListStripButton_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(6, 31);
            // 
            // zoomDropDownButton
            // 
            this.zoomDropDownButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.zoomDropDownButton.Image = ((System.Drawing.Image)(resources.GetObject("zoomDropDownButton.Image")));
            this.zoomDropDownButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.zoomDropDownButton.Name = "zoomDropDownButton";
            this.zoomDropDownButton.Size = new System.Drawing.Size(37, 28);
            this.zoomDropDownButton.Text = "Facteur de zoom";
            this.zoomDropDownButton.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.zoomDropDownButton_DropDownItemClicked);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lineColumnStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 333);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(977, 22);
            this.statusStrip1.TabIndex = 20;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lineColumnStatusLabel
            // 
            this.lineColumnStatusLabel.Name = "lineColumnStatusLabel";
            this.lineColumnStatusLabel.Size = new System.Drawing.Size(962, 17);
            this.lineColumnStatusLabel.Spring = true;
            this.lineColumnStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // printDocument
            // 
            this.printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument_PrintPage);
            // 
            // printDialog
            // 
            this.printDialog.UseEXDialog = true;
            // 
            // printPreviewDialog
            // 
            this.printPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog.Enabled = true;
            this.printPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog.Icon")));
            this.printPreviewDialog.Name = "printPreviewDialog";
            this.printPreviewDialog.Visible = false;
            // 
            // nouveauRappelToolStripMenuItem
            // 
            this.nouveauRappelToolStripMenuItem.Name = "nouveauRappelToolStripMenuItem";
            this.nouveauRappelToolStripMenuItem.Size = new System.Drawing.Size(106, 20);
            this.nouveauRappelToolStripMenuItem.Text = "Nouveau Rappel";
            this.nouveauRappelToolStripMenuItem.Click += new System.EventHandler(this.nouveauRappelToolStripMenuItem_Click);
            // 
            // Note
            // 
            this.ClientSize = new System.Drawing.Size(977, 386);
            this.ControlBox = false;
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.noteContent);
            this.Controls.Add(this.menuStrip2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip2;
            this.Name = "Note";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Load += new System.EventHandler(this.Form2_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Note_KeyPress);
            this.richContextStrip.ResumeLayout(false);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.ContextMenuStrip MenuNote;
        private System.Windows.Forms.ToolStripMenuItem accueilToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem accueilToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem editionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem créerUneNouvelleNoteToolStripMenuItem;
        private System.Windows.Forms.RichTextBox noteContent;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem noteToolStripMenuAccueil;
        private System.Windows.Forms.ToolStripMenuItem nouvelleNoteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paramètresToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip richContextStrip;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton saveStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
        private System.Windows.Forms.ToolStripButton printStripButton;
        private System.Windows.Forms.ToolStripButton printPreviewStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton undoStripButton;
        private System.Windows.Forms.ToolStripButton redoStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripComboBox fontStripComboBox;
        private System.Windows.Forms.ToolStripComboBox fontSizeComboBox;
        private System.Windows.Forms.ToolStripButton increaseStripButton;
        private System.Windows.Forms.ToolStripButton decreaseStripButton;
        private System.Windows.Forms.ToolStripDropDownButton colorStripDropDownButton;
        private System.Windows.Forms.ToolStripDropDownButton changeCaseDropDownButton;
        private System.Windows.Forms.ToolStripMenuItem lowercaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uppercaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripButton clearFormattingStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton boldStripButton3;
        private System.Windows.Forms.ToolStripButton italicStripButton;
        private System.Windows.Forms.ToolStripButton underlineStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton leftAlignStripButton;
        private System.Windows.Forms.ToolStripButton centerAlignStripButton;
        private System.Windows.Forms.ToolStripButton rightAlignStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton bulletListStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripDropDownButton zoomDropDownButton;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lineColumnStatusLabel;
        private System.Drawing.Printing.PrintDocument printDocument;
        private System.Windows.Forms.PrintDialog printDialog;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog;
        private System.Windows.Forms.ToolStripMenuItem nouveauRappelToolStripMenuItem;
    }
}