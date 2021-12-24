using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EZ_Notes
{
    public partial class Note : Form
    {
        private int id;
        private string title;
        private string contenu;
        private string date;
        private MenuPrincipal menu;

        public Note(MenuPrincipal menu, int id, string title="", string contenu="", string date="")
        {
            InitializeComponent();
            this.menu = menu;
            this.id = id;
            this.contenu = contenu;
            noteContent.Text = contenu;
            if (title != "")
                this.title = title;
            else
                this.title = String.Format("Note n°{0}", menu.listNotes.Count()+1);
            if (date != null)
                this.date = DateTime.Now.ToString("HH:mm:ss");
            else
                this.date = date;
            this.Text = this.title;
        }

        public int GetId() { return this.id; }
        public string GetTitle() { return this.title; }
        public string GetContenu() { return this.contenu; }
        public string GetDate() { return this.date; }

        public void SetTitle(string title) { this.title = title; }

        private void accueilToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void renommerLaNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void noteToolStripMenuAccueil_Click(object sender=null, EventArgs e=null)
        {
            this.Hide();
            menu.UpdateNoteContent(this.id, this.contenu);
        }

        private void nouvelleNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menu.menuStripPrincipalAddNote_Click();
        }

        private void noteContent_TextChanged(object sender, EventArgs e)
        {
            contenu = noteContent.Text;
            DataGridView viewNotes = menu.GetViewNotes();
            foreach (DataGridViewRow row in viewNotes.Rows)
            {
                if (row.Index == this.menu.listNotes.IndexOf(this))
                    row.Cells[1].Value = contenu;
            }
        }

        private void Note_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '')
                noteToolStripMenuAccueil_Click();
        }
    }
}
