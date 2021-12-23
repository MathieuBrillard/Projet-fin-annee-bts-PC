using System;
using System.Data.SQLite;
using System.Drawing;
using System.Windows.Forms;

namespace EZ_Notes
{
    public partial class ConnexionForm : Form
    {
        private SQLiteConnection conn;
        private MenuPrincipal menuPrincipal;

        public ConnexionForm(SQLiteConnection conn, MenuPrincipal menuPrincipal)
        {
            InitializeComponent();
            this.conn = conn;
            this.menuPrincipal = menuPrincipal;
        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            string username = UsernameBox.Text;
            string pwd = PasswordBox.Text;
            int connectResult;

            connectResult = menuPrincipal.UserConnexion(username, pwd, this.conn);
            if (connectResult != 0)
            {
                ResultLabel.ForeColor = Color.Red;
                ResultLabel.Text = String.Format("La connexion a échouée (Code d'erreur: {0}).", connectResult);
            }
            else
                Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
