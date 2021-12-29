using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EZ_Notes
{
    public partial class MenuPrincipal : Form
    {
        public List<Note> listNotes;
        private SQLiteConnection conn;
        private UserInfo authenticatedUser;
        public bool init;

        public MenuPrincipal()
        {
            InitializeComponent();
            this.init = true;
            listNotes = new List<Note>();
            this.conn = CreateConnection();
            ConnexionForm formulaireConn = new ConnexionForm(this.conn, this);
            formulaireConn.ShowDialog();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        /*  ### TRAY NOTIF ###
         * Gestion de la barre de notification et
         * du comportement de la fênetre (resizing)
         */
        private void Form1_Resize(object sender, EventArgs e)
        {
            //if the form is minimized  
            //hide it from the task bar  
            //and show the system tray icon (represented by the NotifyIcon control)  
            if (this.WindowState == FormWindowState.Minimized)
            {
                Hide();
                trayIcon.Visible = true;
            }
        }

        private void trayIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
            trayIcon.Visible = false;
        }

        private void trayNotifQuitter_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void trayNotifAfficher_Click(object sender, EventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
            trayIcon.Visible = false;
        }

        /* ### SQLite Methods ###
         * Méthodes pour communiquer avec la base de donnée :
         *  - CreateConnection --> Créé la connexion avec la DB
         *  - UserConnexion --> Authentifie l'utilisateur sur la DB
         *  - ParseNotes --> Récupère les notes d'un utilisateur enregistré dans la DB
         *  - SaveNote --> Sauvegarde une note dans la DB
         *  - DeleteNote --> Supprime une note de la DB
         *  
         */

        static SQLiteConnection CreateConnection()
        {

            SQLiteConnection conn;
            // Create a new database connection:
            conn = new SQLiteConnection(@"Data Source=../../../assets/db/database.sqlite");
            // Open the connection:
            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(String.Format(
                    "Impossible d'accéder à la base de donnée.\n(Erreur: {0})", ex));
            }
            return conn;
        }

        public int UserConnexion(string username, string pwd, SQLiteConnection conn)
        {
            int errorCode;
            SQLiteDataReader sqlite_datareader;
            SQLiteCommand cmd;
            int userIdDB = 0;
            string usernameDB = null;
            string passwordDB = null;
            string emailDB = null;

            cmd = new SQLiteCommand(String.Format(@"SELECT * FROM Users
                WHERE Users.name='{0}' AND Users.password='{1}'", username, pwd), conn);
            sqlite_datareader = cmd.ExecuteReader();

            while (sqlite_datareader.Read())
            {
                userIdDB = sqlite_datareader.GetInt32(0);
                usernameDB = sqlite_datareader.GetString(1);
                passwordDB = sqlite_datareader.GetString(2);
                emailDB = sqlite_datareader.GetString(3);
            }
            if ((usernameDB != null && passwordDB != null) &&
                (usernameDB.Equals(username) && passwordDB.Equals(pwd)))
            {
                errorCode = 0;
                SetUserInfo(userIdDB, usernameDB, emailDB);
                menuStripPrincipalCompte.ForeColor = Color.Green;
                menuStripPrincipalCompte.Text = String.Format("Compte ({0})", this.authenticatedUser.GetName());
                ParseNotes();
            }
            else
                errorCode = 1;
            return errorCode;
        }

        private void ParseNotes()
        {
            SQLiteDataReader sqlite_datareader;
            SQLiteCommand cmd;

            cmd = new SQLiteCommand(String.Format(@"SELECT * FROM Notes 
                INNER JOIN UserToNote on Notes.id = UserToNote.idNote 
                INNER JOIN Users on UserToNote.idUser = Users.id
                WHERE Users.id={0}", this.authenticatedUser.GetId()), this.conn);
            sqlite_datareader = cmd.ExecuteReader();

            while (sqlite_datareader.Read())
            {
                this.listNotes.Add(new Note(this, sqlite_datareader.GetInt32(0),
                    sqlite_datareader.GetString(1), sqlite_datareader.GetString(2),
                    sqlite_datareader.GetString(3)));
            }
            foreach (Note note in this.listNotes)
            {
                ViewNotes.Rows.Add(note.GetTitle(), note.GetContenu(), note.GetDate());
            }
            this.init = false;
        }

        public void UpdateNoteTitle(int id, string title)
        {
            SQLiteCommand cmd;

            cmd = new SQLiteCommand(String.Format(@"
                    UPDATE Notes
                    SET name='{0}'
                    WHERE id='{1}'", title, id), this.conn);
            cmd.ExecuteNonQuery();
        }

        public void UpdateNoteContent(int id, string content)
        {
            SQLiteCommand cmd;

            cmd = new SQLiteCommand(String.Format(@"
                    UPDATE Notes
                    SET content='{0}'
                    WHERE id='{1}'", content, id), this.conn);
            cmd.ExecuteNonQuery();
        }

        public void UpdateNoteDate(int id, string date)
        {
            SQLiteCommand cmd;

            cmd = new SQLiteCommand(String.Format(@"
                    UPDATE Notes
                    SET date='{0}'
                    WHERE id='{1}'", date, id), this.conn);
            cmd.ExecuteNonQuery();
        }

        public void AddNote()
        {
            SQLiteCommand cmd;
            SQLiteDataReader sqlite_datareader;
            Note note;
            int id = 0;

            // Génération nom aléatoire unique
            string date = DateTime.Now.ToString("HH:mm:ss");
            Random random = new Random();
            string rdmName = date + random.Next().ToString();

            if (this.authenticatedUser == null)
                return;
            
            // Création d'une nouvelle note dans la base
            cmd = new SQLiteCommand(String.Format(@"
                INSERT INTO Notes(name, content, date)
                VALUES('{0}','{1}', '{2}')",
                rdmName, "", "", date), this.conn);
            cmd.ExecuteNonQuery();

            // Récupération de l'id de la note généré par la base
            cmd = new SQLiteCommand(String.Format(@"
                SELECT id FROM Notes
                WHERE name='{0}'", rdmName), this.conn);
            sqlite_datareader = cmd.ExecuteReader();

            while (sqlite_datareader.Read())
                id = sqlite_datareader.GetInt32(0);

            // Assignation de la note à l'utilisateur connecté
            cmd = new SQLiteCommand(String.Format(@"
                INSERT INTO UserToNote(idUser, idNote)
                VALUES('{0}','{1}')",
                this.authenticatedUser.GetId(), id), this.conn);
            cmd.ExecuteNonQuery();

            // Instanciation de la note et récupération de son nom
            note = new Note(this, id);
            string title = note.GetTitle();

            // Changement du nom de la note dans la base
            UpdateNoteTitle(id, title);

            // Ajout de la note à la liste de note, au DataGridView et affichage
            listNotes.Add(note);
            ViewNotes.Rows.Add(note.GetTitle(), note.GetContenu(), note.GetDate());
            note.Show();
        }

        public void SaveNote(Note note)
        {
            SQLiteCommand cmd;

            if (this.authenticatedUser == null)
                return;
            cmd = new SQLiteCommand(String.Format("UPDATE Notes " +
                "SET name='{0}', "+
                "content='{1}', "+
                "date='{2}' "+
                "WHERE id='{3}';",
                note.GetTitle(), note.FormatContentToDB(), note.GetDate(), note.GetId()),
                this.conn);
            cmd.ExecuteNonQuery();
        }

        public void DeleteNote(int id)
        {
            SQLiteCommand cmd;

            cmd = new SQLiteCommand(String.Format(@"
                DELETE FROM UserToNote
                WHERE idUser='{0}' AND idNote='{1}'",
                this.authenticatedUser.GetId(), id), this.conn);
            cmd.ExecuteNonQuery();
            cmd = new SQLiteCommand(String.Format(@"
                DELETE FROM Notes
                WHERE id='{0}'", id), this.conn);
            cmd.ExecuteNonQuery();
        }

        /* ### Main Methods ###
         * Principales méthodes de la classe MenuPrincipal :
         *  - menuStripPrincipalAddNote_Click --> créé une nouvelle note
         *  - menuStripPrincipalConnexion_Click --> Lance le formulaire de connexion
         */
        public void menuStripPrincipalAddNote_Click(object sender=null, EventArgs e=null)
        {
            AddNote();
        }    

        public void SetUserInfo(int userId, string userName, string userEmail)
        {
            this.authenticatedUser = new UserInfo(userId, userName, userEmail);
        }

        private void ViewNotes_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int pos = 0;

            if (e.ColumnIndex == 0 && e.RowIndex > 0)
            {
                pos = e.RowIndex;
                Note note = listNotes[pos];
                note.SetTitle(ViewNotes[e.ColumnIndex, e.RowIndex].Value.ToString());
                note.Text = ViewNotes[e.ColumnIndex, e.RowIndex].Value.ToString();
                UpdateNoteTitle(note.GetId(), note.GetTitle());
            }
        }

        private void menuStripPrincipalOuvrir_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow viewRow in ViewNotes.Rows)
            {
                if (viewRow.Selected == true)
                {
                    int pos = viewRow.Index;
                    listNotes[pos].Show();
                }
            }
        }

        private void menuStripPrincipalSupprimer_Click(object sender, EventArgs e)
        {
            List<Note> toSuppr = new List<Note>();
            string msgConfirm = "";

            foreach (DataGridViewRow viewRow in ViewNotes.Rows)
            {
                if (viewRow.Selected == true)
                {
                    int pos = viewRow.Index;
                    Note note = listNotes[pos];
                    toSuppr.Insert(0, note); // on ajoute la dernière note à supprimer au début de la liste
                                             // pour ne pas décaler l'index du DataGridViewRow
                }
            }
            if (toSuppr.Count > 1)
            {
                msgConfirm = "Êtes-vous sûr de vouloir supprimer ces notes ?";
            }
            else
            {
                msgConfirm = "Êtes-vous sûr de vouloir supprimer cette note ?";
            }
            var confirmResult = MessageBox.Show(msgConfirm,
                                     "Confirmer la suppression.",
                                     MessageBoxButtons.OKCancel);
            if (confirmResult == DialogResult.OK)
            {
                foreach (Note noteToSuppr in toSuppr)
                {
                    foreach (Note note in listNotes)
                    {
                        if (noteToSuppr.GetId() == note.GetId())
                        {
                            foreach (DataGridViewRow viewRow in ViewNotes.Rows)
                            {
                                if (viewRow.Index == listNotes.IndexOf(note))
                                    ViewNotes.Rows.Remove(viewRow);
                            }
                            DeleteNote(note.GetId());
                            note.Close();
                        }
                    }
                    listNotes.Remove(noteToSuppr);
                }
            }
        }

        private void ViewNotes_SelectionChanged(object sender, EventArgs e)
        {
            if (ViewNotes.SelectedRows.Count > 0)
            {
                menuStripPrincipalOuvrir.Enabled = true;
                menuStripPrincipalOuvrir.Visible = true;
                menuStripPrincipalSupprimer.Enabled = true;
                menuStripPrincipalSupprimer.Visible = true;
            }
            else
            {
                menuStripPrincipalOuvrir.Enabled = false;
                menuStripPrincipalOuvrir.Visible = false;
                menuStripPrincipalSupprimer.Enabled = false;
                menuStripPrincipalSupprimer.Visible = false;
            }
        }
        private void ViewNotes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int pos = e.RowIndex;

            listNotes[pos].Show();
        }
        public DataGridView GetViewNotes() { return ViewNotes; }
    }

    public class UserInfo
    {
        private int id;
        private string name;
        private string email;

        public UserInfo(int userId, string username, string email)
        {
            this.id = userId;
            this.name = username;
            this.email = email;
        }

        public int GetId() { return id; }
        public string GetName() { return name; }
        public string GetEmail() { return email; }

    }
}
