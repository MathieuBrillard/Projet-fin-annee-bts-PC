namespace EZ_Notes
{
    partial class MenuPrincipal
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.trayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.trayMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.trayNotifAfficher = new System.Windows.Forms.ToolStripMenuItem();
            this.trayNotifMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.trayNotifQuitter = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripPrincipal = new System.Windows.Forms.MenuStrip();
            this.menuStripPrincipalSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripPrincipalAddNote = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripPrincipalOuvrir = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripPrincipalSupprimer = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripPrincipalParam = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewNotes = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.content = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStripPrincipalCompte = new System.Windows.Forms.ToolStripMenuItem();
            this.trayMenu.SuspendLayout();
            this.menuStripPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ViewNotes)).BeginInit();
            this.SuspendLayout();
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.vScrollBar1.Location = new System.Drawing.Point(792, 0);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(18, 452);
            this.vScrollBar1.TabIndex = 0;
            // 
            // trayIcon
            // 
            this.trayIcon.BalloonTipText = "EZ Notes application (fonctionne en arrière-plan)";
            this.trayIcon.BalloonTipTitle = "EZ Notes";
            this.trayIcon.ContextMenuStrip = this.trayMenu;
            this.trayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("trayIcon.Icon")));
            this.trayIcon.Text = "Application EZ Notes\r\n(fonctionne en arrière-plan)";
            this.trayIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.trayIcon_MouseDoubleClick);
            // 
            // trayMenu
            // 
            this.trayMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trayNotifAfficher,
            this.trayNotifMenu,
            this.trayNotifQuitter});
            this.trayMenu.Name = "trayMenu";
            this.trayMenu.Size = new System.Drawing.Size(117, 70);
            // 
            // trayNotifAfficher
            // 
            this.trayNotifAfficher.Name = "trayNotifAfficher";
            this.trayNotifAfficher.Size = new System.Drawing.Size(116, 22);
            this.trayNotifAfficher.Text = "Afficher";
            this.trayNotifAfficher.Click += new System.EventHandler(this.trayNotifAfficher_Click);
            // 
            // trayNotifMenu
            // 
            this.trayNotifMenu.Name = "trayNotifMenu";
            this.trayNotifMenu.Size = new System.Drawing.Size(116, 22);
            this.trayNotifMenu.Text = "Menu";
            // 
            // trayNotifQuitter
            // 
            this.trayNotifQuitter.Name = "trayNotifQuitter";
            this.trayNotifQuitter.Size = new System.Drawing.Size(116, 22);
            this.trayNotifQuitter.Text = "Quitter";
            this.trayNotifQuitter.Click += new System.EventHandler(this.trayNotifQuitter_Click);
            // 
            // menuStripPrincipal
            // 
            this.menuStripPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStripPrincipalSearch,
            this.menuStripPrincipalAddNote,
            this.menuStripPrincipalOuvrir,
            this.menuStripPrincipalSupprimer,
            this.menuStripPrincipalParam,
            this.menuStripPrincipalCompte});
            this.menuStripPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menuStripPrincipal.Name = "menuStripPrincipal";
            this.menuStripPrincipal.Size = new System.Drawing.Size(810, 24);
            this.menuStripPrincipal.TabIndex = 4;
            this.menuStripPrincipal.Text = "menuStrip1";
            // 
            // menuStripPrincipalSearch
            // 
            this.menuStripPrincipalSearch.Name = "menuStripPrincipalSearch";
            this.menuStripPrincipalSearch.Size = new System.Drawing.Size(78, 20);
            this.menuStripPrincipalSearch.Text = "Rechercher";
            // 
            // menuStripPrincipalAddNote
            // 
            this.menuStripPrincipalAddNote.Name = "menuStripPrincipalAddNote";
            this.menuStripPrincipalAddNote.Size = new System.Drawing.Size(95, 20);
            this.menuStripPrincipalAddNote.Text = "Nouvelle Note";
            this.menuStripPrincipalAddNote.Click += new System.EventHandler(this.menuStripPrincipalAddNote_Click);
            // 
            // menuStripPrincipalOuvrir
            // 
            this.menuStripPrincipalOuvrir.Enabled = false;
            this.menuStripPrincipalOuvrir.Name = "menuStripPrincipalOuvrir";
            this.menuStripPrincipalOuvrir.Size = new System.Drawing.Size(52, 20);
            this.menuStripPrincipalOuvrir.Text = "Ouvrir";
            this.menuStripPrincipalOuvrir.Visible = false;
            this.menuStripPrincipalOuvrir.Click += new System.EventHandler(this.menuStripPrincipalOuvrir_Click);
            // 
            // menuStripPrincipalSupprimer
            // 
            this.menuStripPrincipalSupprimer.Enabled = false;
            this.menuStripPrincipalSupprimer.Name = "menuStripPrincipalSupprimer";
            this.menuStripPrincipalSupprimer.Size = new System.Drawing.Size(74, 20);
            this.menuStripPrincipalSupprimer.Text = "Supprimer";
            this.menuStripPrincipalSupprimer.Visible = false;
            this.menuStripPrincipalSupprimer.Click += new System.EventHandler(this.menuStripPrincipalSupprimer_Click);
            // 
            // menuStripPrincipalParam
            // 
            this.menuStripPrincipalParam.Name = "menuStripPrincipalParam";
            this.menuStripPrincipalParam.Size = new System.Drawing.Size(78, 20);
            this.menuStripPrincipalParam.Text = "Paramètres";
            // 
            // ViewNotes
            // 
            this.ViewNotes.AllowUserToAddRows = false;
            this.ViewNotes.AllowUserToDeleteRows = false;
            this.ViewNotes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ViewNotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ViewNotes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.content,
            this.date});
            this.ViewNotes.Location = new System.Drawing.Point(0, 27);
            this.ViewNotes.Name = "ViewNotes";
            this.ViewNotes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ViewNotes.Size = new System.Drawing.Size(789, 231);
            this.ViewNotes.TabIndex = 5;
            this.ViewNotes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ViewNotes_CellDoubleClick);
            this.ViewNotes.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.ViewNotes_CellValueChanged);
            this.ViewNotes.SelectionChanged += new System.EventHandler(this.ViewNotes_SelectionChanged);
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.name.HeaderText = "Titre";
            this.name.Name = "name";
            this.name.Width = 150;
            // 
            // content
            // 
            this.content.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.content.HeaderText = "Contenu";
            this.content.Name = "content";
            this.content.ReadOnly = true;
            // 
            // date
            // 
            this.date.HeaderText = "Date";
            this.date.Name = "date";
            this.date.ReadOnly = true;
            // 
            // menuStripPrincipalCompte
            // 
            this.menuStripPrincipalCompte.Name = "menuStripPrincipalCompte";
            this.menuStripPrincipalCompte.Size = new System.Drawing.Size(62, 20);
            this.menuStripPrincipalCompte.Text = "Compte";
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 258);
            this.Controls.Add(this.ViewNotes);
            this.Controls.Add(this.menuStripPrincipal);
            this.Controls.Add(this.vScrollBar1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStripPrincipal;
            this.Name = "MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Menu Principal";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.trayMenu.ResumeLayout(false);
            this.menuStripPrincipal.ResumeLayout(false);
            this.menuStripPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ViewNotes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.NotifyIcon trayIcon;
        private System.Windows.Forms.ContextMenuStrip trayMenu;
        private System.Windows.Forms.ToolStripMenuItem trayNotifMenu;
        private System.Windows.Forms.ToolStripMenuItem trayNotifQuitter;
        private System.Windows.Forms.ToolStripMenuItem trayNotifAfficher;
        private System.Windows.Forms.MenuStrip menuStripPrincipal;
        private System.Windows.Forms.ToolStripMenuItem menuStripPrincipalSearch;
        private System.Windows.Forms.ToolStripMenuItem menuStripPrincipalAddNote;
        private System.Windows.Forms.DataGridView ViewNotes;
        private System.Windows.Forms.ToolStripMenuItem menuStripPrincipalOuvrir;
        private System.Windows.Forms.ToolStripMenuItem menuStripPrincipalSupprimer;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn content;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.ToolStripMenuItem menuStripPrincipalParam;
        private System.Windows.Forms.ToolStripMenuItem menuStripPrincipalCompte;
    }
}

