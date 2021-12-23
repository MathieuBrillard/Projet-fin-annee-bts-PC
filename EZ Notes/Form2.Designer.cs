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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.collerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vScrollBar2 = new System.Windows.Forms.VScrollBar();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.noteToolStripMenuAccueil = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.renommerLaNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copierToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.collerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sauvegarderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nouvelleNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paramètresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // noteContent
            // 
            this.noteContent.AcceptsTab = true;
            this.noteContent.BulletIndent = 4;
            this.noteContent.ContextMenuStrip = this.contextMenuStrip1;
            this.noteContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.noteContent.EnableAutoDragDrop = true;
            this.noteContent.Location = new System.Drawing.Point(0, 24);
            this.noteContent.Name = "noteContent";
            this.noteContent.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.noteContent.Size = new System.Drawing.Size(898, 364);
            this.noteContent.TabIndex = 4;
            this.noteContent.Text = "";
            this.noteContent.TextChanged += new System.EventHandler(this.noteContent_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copierToolStripMenuItem,
            this.collerToolStripMenuItem,
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(146, 92);
            // 
            // copierToolStripMenuItem
            // 
            this.copierToolStripMenuItem.Name = "copierToolStripMenuItem";
            this.copierToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.copierToolStripMenuItem.Text = "Copier";
            // 
            // collerToolStripMenuItem
            // 
            this.collerToolStripMenuItem.Name = "collerToolStripMenuItem";
            this.collerToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.collerToolStripMenuItem.Text = "Coller";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.undoToolStripMenuItem.Text = "Retour arrière";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.redoToolStripMenuItem.Text = "Retour avant";
            // 
            // vScrollBar2
            // 
            this.vScrollBar2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.vScrollBar2.Location = new System.Drawing.Point(882, 0);
            this.vScrollBar2.Name = "vScrollBar2";
            this.vScrollBar2.Size = new System.Drawing.Size(17, 387);
            this.vScrollBar2.TabIndex = 1;
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.noteToolStripMenuAccueil,
            this.toolStripMenuItem2,
            this.nouvelleNoteToolStripMenuItem,
            this.paramètresToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(898, 24);
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
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.renommerLaNoteToolStripMenuItem,
            this.copierToolStripMenuItem1,
            this.collerToolStripMenuItem1,
            this.sauvegarderToolStripMenuItem});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(56, 20);
            this.toolStripMenuItem2.Text = "Edition";
            // 
            // renommerLaNoteToolStripMenuItem
            // 
            this.renommerLaNoteToolStripMenuItem.Name = "renommerLaNoteToolStripMenuItem";
            this.renommerLaNoteToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.renommerLaNoteToolStripMenuItem.Text = "Renommer la note";
            this.renommerLaNoteToolStripMenuItem.Click += new System.EventHandler(this.renommerLaNoteToolStripMenuItem_Click);
            // 
            // copierToolStripMenuItem1
            // 
            this.copierToolStripMenuItem1.Name = "copierToolStripMenuItem1";
            this.copierToolStripMenuItem1.Size = new System.Drawing.Size(172, 22);
            this.copierToolStripMenuItem1.Text = "Copier";
            // 
            // collerToolStripMenuItem1
            // 
            this.collerToolStripMenuItem1.Name = "collerToolStripMenuItem1";
            this.collerToolStripMenuItem1.Size = new System.Drawing.Size(172, 22);
            this.collerToolStripMenuItem1.Text = "Coller";
            // 
            // sauvegarderToolStripMenuItem
            // 
            this.sauvegarderToolStripMenuItem.Name = "sauvegarderToolStripMenuItem";
            this.sauvegarderToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.sauvegarderToolStripMenuItem.Text = "Sauvegarder";
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
            // Note
            // 
            this.ClientSize = new System.Drawing.Size(898, 388);
            this.ControlBox = false;
            this.Controls.Add(this.vScrollBar2);
            this.Controls.Add(this.noteContent);
            this.Controls.Add(this.menuStrip2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip2;
            this.Name = "Note";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Load += new System.EventHandler(this.Form2_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Note_KeyPress);
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
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
        private System.Windows.Forms.VScrollBar vScrollBar2;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem noteToolStripMenuAccueil;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem nouvelleNoteToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem copierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem collerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renommerLaNoteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copierToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem collerToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sauvegarderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paramètresToolStripMenuItem;
    }
}