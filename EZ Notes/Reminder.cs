using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using Microsoft.Toolkit.Uwp.Notifications;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace EZ_Notes
{
    public class Rappel
    {
        private string title;
        private string description;
        private string date;
        private Note note;

        public Rappel(Note note, string title, string desc, string date)
        {
            this.note = note;
            this.title = title;
            this.description = desc;
            this.date = date;
        }

        private void NotificationEvent(int idRappel, Note note)
        {
           new ToastContentBuilder()
                // info
                .SetToastScenario(ToastScenario.Reminder)
                .AddArgument("reminderId", idRappel)
                .AddText(this.title)
                .AddText(this.description)
                // combobox postpone
                .AddToastInput(new ToastSelectionBox("postponeTime")
                {
                    DefaultSelectionBoxItemId = "15",
                    Items =
                    {
                        new ToastSelectionBoxItem("5", "5 minutes"),
                        new ToastSelectionBoxItem("15", "15 minutes"),
                        new ToastSelectionBoxItem("30", "30 minutes"),
                        new ToastSelectionBoxItem("60", "1 heure"),
                        new ToastSelectionBoxItem("240", "4 heures"),
                        new ToastSelectionBoxItem("1440", "1 jour")
                    }
                })
                // controls
                .AddButton(new ToastButtonSnooze("Reporter") { SelectionBoxId = "postponeTime" }) // postpone button
                .AddButton(new ToastButton() // done button
                    .SetContent("Fait")
                    .AddArgument("action", "done")
                    .SetBackgroundActivation())
                .Show();
        }

        /*protected override void OnActivated(IActivatedEventArgs e)
        {

        }*/
    }
}
