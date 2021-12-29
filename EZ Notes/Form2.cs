using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.IO;

namespace EZ_Notes
{
    public partial class Note : Form
    {
        // note vars
        private int id;
        private string title;
        private string contenu;
        private string date;
        private MenuPrincipal menu;

        // editor vars
        private List<string> colorList = new List<string>();
        private const int MIDDLE = 382;    // middle sum of RGB - max is 765
        private int sumRGB;    // sum of the selected colors RGB
        private int pos, line, column;    // for detecting line and column numbers

        public Note(MenuPrincipal menu, int id, string title="", string contenu="", string date="")
        {
            InitializeComponent();
            this.menu = menu;
            this.id = id;
            FormatContentToString(contenu);
            if (title != "")
                this.title = title;
            else
                this.title = String.Format("Note n°{0}", menu.listNotes.Count()+1);
            if (date != null)
                this.date = date;
            else
                this.date = DateTime.Now.ToString("HH:mm:ss dd/MM/yyyy");
            this.Text = this.title;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // fill zoomDropDownButton item list
            zoomDropDownButton.DropDown.Items.Add("20%");
            zoomDropDownButton.DropDown.Items.Add("50%");
            zoomDropDownButton.DropDown.Items.Add("70%");
            zoomDropDownButton.DropDown.Items.Add("100%");
            zoomDropDownButton.DropDown.Items.Add("150%");
            zoomDropDownButton.DropDown.Items.Add("200%");
            zoomDropDownButton.DropDown.Items.Add("300%");
            zoomDropDownButton.DropDown.Items.Add("400%");
            zoomDropDownButton.DropDown.Items.Add("500%");

            // fill font sizes in combo box
            for (int i = 8; i < 80; i += 2)
            {
                fontSizeComboBox.Items.Add(i);
            }

            // fill colors in color drop down list
            foreach (System.Reflection.PropertyInfo prop in typeof(Color).GetProperties())
            {
                if (prop.PropertyType.FullName == "System.Drawing.Color")
                {
                    colorList.Add(prop.Name);
                }
            }

            // fill the drop down items list
            foreach (string color in colorList)
            {
                colorStripDropDownButton.DropDownItems.Add(color);
            }

            // fill BackColor for each color in the DropDownItems list
            for (int i = 0; i < colorStripDropDownButton.DropDownItems.Count; i++)
            {
                // Create KnownColor object
                KnownColor selectedColor;
                selectedColor = (KnownColor)System.Enum.Parse(typeof(KnownColor), colorList[i]);    // parse to a KnownColor
                colorStripDropDownButton.DropDownItems[i].BackColor = Color.FromKnownColor(selectedColor);    // set the BackColor to its appropriate list item

                // Set the text color depending on if the barkground is darker or lighter
                // create Color object
                Color col = Color.FromName(colorList[i]);

                // 255,255,255 = White and 0,0,0 = Black
                // Max sum of RGB values is 765 -> (255 + 255 + 255)
                // Middle sum of RGB values is 382 -> (765/2)
                // Color is considered darker if its <= 382
                // Color is considered lighter if its > 382
                sumRGB = ConvertToRGB(col);    // get the color objects sum of the RGB value
                if (sumRGB <= MIDDLE)    // Darker Background
                {
                    colorStripDropDownButton.DropDownItems[i].ForeColor = Color.White;    // set to White text
                }
                else if (sumRGB > MIDDLE)    // Lighter Background
                {
                    colorStripDropDownButton.DropDownItems[i].ForeColor = Color.Black;    // set to Black text
                }

                // fill fonts in font combo box
                InstalledFontCollection fonts = new InstalledFontCollection();
                foreach (FontFamily family in fonts.Families)
                {
                    fontStripComboBox.Items.Add(family.Name);
                }

                // determines the line and column numbers of mouse position on the richTextBox
                int pos = noteContent.SelectionStart;
                int line = noteContent.GetLineFromCharIndex(pos);
                int column = noteContent.SelectionStart - noteContent.GetFirstCharIndexFromLine(line);
                lineColumnStatusLabel.Text = "Line " + (line + 1) + ", Column " + (column + 1);
            }
        }

        public int GetId() { return this.id; }
        public string GetTitle() { return this.title; }
        public string GetContenu() { return noteContent.Text; }
        public string GetDate() { return this.date; }

        public void SetTitle(string title) { this.title = title; }

        public string FormatContentToDB()
        {
            int i;
            string rtfText = "";

            i = 0;
            if (this.contenu.Equals(""))
                return "";
            rtfText = noteContent.Rtf;
            while (i != rtfText.Length)
            {
                if (rtfText[i] == '\'')
                {
                    rtfText = rtfText.Insert(i + 1, "'");
                    i++; // skip la détection du simple quote ajouté
                }
                i++;
            }
            return rtfText;
        }

        private void FormatContentToString(string contenu)
        {
            int i = 0;

            if (contenu.Equals(""))
            {
                noteContent.Text = "";
                this.contenu = "";
                return;
            }
            while (i != contenu.Length)
            {
                if ((contenu[i] == '\'') && (contenu[i + 1] == '\''))
                    contenu = contenu.Remove(i, 1);
                i++;
            }
            if (contenu[0] == '{')
                noteContent.SelectedRtf = contenu;
            else
                noteContent.Text = contenu;
            this.contenu = contenu;
        }

        private void renommerLaNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void noteToolStripMenuAccueil_Click(object sender=null, EventArgs e=null)
        {
            this.Hide();
            //menu.UpdateNoteContent(this.id, this.contenu);
            menu.SaveNote(this);
        }

        private void nouvelleNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menu.menuStripPrincipalAddNote_Click();
        }

        private void UpdateTime()
        {
            string dateTime = DateTime.Now.ToString("HH:mm:ss dd/MM/yyyy");

            this.date = dateTime;
            DataGridView viewNotes = menu.GetViewNotes();
            foreach (DataGridViewRow row in viewNotes.Rows)
            {
                if (row.Index == this.menu.listNotes.IndexOf(this))
                    row.Cells[2].Value = date;
            }
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
            if (this.menu.init == false)
                UpdateTime();
        }

        private void Note_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '')
                noteToolStripMenuAccueil_Click();
        }
        /*  ### TEXT EDITOR ###
         * Gestion des fonctionnalités propre à l'editeur de texte des notes
         */
        private int ConvertToRGB(System.Drawing.Color c)
        {
            int r = c.R, // RED component value
                g = c.G, // GREEN component value
                b = c.B; // BLUE component value
            int sum = 0;

            // calculate sum of RGB
            sum = r + g + b;

            return sum;
        }

        private void cutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            noteContent.Cut();     // cut text
        }

        private void copyToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            noteContent.Copy();     // copy text
        }

        private void pasteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            noteContent.Paste();    // paste text
        }

        private void selectAllToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            noteContent.SelectAll();    // select all text
        }

        private void clearAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // clear the rich text box
            noteContent.Clear();
            noteContent.Focus();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // delete selected text
            noteContent.SelectedText = "";
            noteContent.Focus();
        }

        private void undoStripButton_Click(object sender, EventArgs e)
        {
            noteContent.Undo();     // undo move
        }

        private void redoStripButton_Click(object sender, EventArgs e)
        {
            noteContent.Redo();     // redo move
        }

        private void saveStripButton_Click(object sender, EventArgs e)
        {
            menu.SaveNote(this);
        }

        private void boldStripButton_Click(object sender, EventArgs e)
        {

            if (boldStripButton3.Checked == false)
            {
                boldStripButton3.Checked = true; // BOLD is true
            }
            else if (boldStripButton3.Checked == true)
            {
                boldStripButton3.Checked = false;    // BOLD is false
            }

            if (noteContent.SelectionFont == null)
            {
                return;
            }

            // create fontStyle object
            FontStyle style = noteContent.SelectionFont.Style;

            // determines the font style
            if (noteContent.SelectionFont.Bold)
            {
                style &= ~FontStyle.Bold;
            }
            else
            {
                style |= FontStyle.Bold;

            }
            noteContent.SelectionFont = new Font(noteContent.SelectionFont, style);     // sets the font style
        }

        private void underlineStripButton_Click(object sender, EventArgs e)
        {
            if (underlineStripButton.Checked == false)
            {
                underlineStripButton.Checked = true;     // UNDERLINE is active
            }
            else if (underlineStripButton.Checked == true)
            {
                underlineStripButton.Checked = false;    // UNDERLINE is not active
            }

            if (noteContent.SelectionFont == null)
            {
                return;
            }

            // create fontStyle object
            FontStyle style = noteContent.SelectionFont.Style;

            // determines the font style
            if (noteContent.SelectionFont.Underline)
            {
                style &= ~FontStyle.Underline;
            }
            else
            {
                style |= FontStyle.Underline;
            }
            noteContent.SelectionFont = new Font(noteContent.SelectionFont, style);    // sets the font style
        }

        private void italicStripButton_Click(object sender, EventArgs e)
        {
            if (italicStripButton.Checked == false)
            {
                italicStripButton.Checked = true;    // ITALICS is active
            }
            else if (italicStripButton.Checked == true)
            {
                italicStripButton.Checked = false;    // ITALICS is not active
            }

            if (noteContent.SelectionFont == null)
            {
                return;
            }
            // create fontStyle object
            FontStyle style = noteContent.SelectionFont.Style;

            // determines font style
            if (noteContent.SelectionFont.Italic)
            {
                style &= ~FontStyle.Italic;
            }
            else
            {
                style |= FontStyle.Italic;
            }
            noteContent.SelectionFont = new Font(noteContent.SelectionFont, style);    // sets the font style
        }

        private void fontSizeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (noteContent.SelectionFont == null)
            {
                return;
            }
            // sets the font size when changed
            noteContent.SelectionFont = new Font(noteContent.SelectionFont.FontFamily, Convert.ToInt32(fontSizeComboBox.Text), noteContent.SelectionFont.Style);
        }

        private void fontStripComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (noteContent.SelectionFont == null)
            {
                // sets the Font Family style
                noteContent.SelectionFont = new Font(fontStripComboBox.Text, noteContent.Font.Size);
            }
            // sets the selected font famly style
            noteContent.SelectionFont = new Font(fontStripComboBox.Text, noteContent.SelectionFont.Size);
        }

        private void colorStripDropDownButton_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            // creates a KnownColor object
            KnownColor selectedColor;
            selectedColor = (KnownColor)System.Enum.Parse(typeof(KnownColor), e.ClickedItem.Text);    // converts it to a Color Structure
            noteContent.SelectionColor = Color.FromKnownColor(selectedColor);    // sets the selected color
        }

        private void noteContent_SelectionChanged(object sender, EventArgs e)
        {
            // highlight button border when buttons are true
            if (noteContent.SelectionFont != null)
            {
                boldStripButton3.Checked = noteContent.SelectionFont.Bold;
                italicStripButton.Checked = noteContent.SelectionFont.Italic;
                underlineStripButton.Checked = noteContent.SelectionFont.Underline;
            }
        }

        private void leftAlignStripButton_Click(object sender, EventArgs e)
        {
            // set properties
            centerAlignStripButton.Checked = false;
            rightAlignStripButton.Checked = false;
            if (leftAlignStripButton.Checked == false)
            {
                leftAlignStripButton.Checked = true;    // LEFT ALIGN is active
            }
            else if (leftAlignStripButton.Checked == true)
            {
                leftAlignStripButton.Checked = false;    // LEFT ALIGN is not active
            }
            noteContent.SelectionAlignment = HorizontalAlignment.Left;    // selects left alignment
        }

        private void centerAlignStripButton_Click(object sender, EventArgs e)
        {
            // set properties
            leftAlignStripButton.Checked = false;
            rightAlignStripButton.Checked = false;
            if (centerAlignStripButton.Checked == false)
            {
                centerAlignStripButton.Checked = true;    // CENTER ALIGN is active
            }
            else if (centerAlignStripButton.Checked == true)
            {
                centerAlignStripButton.Checked = false;    // CENTER ALIGN is not active
            }
            noteContent.SelectionAlignment = HorizontalAlignment.Center;     // selects center alignment
        }

        private void rightAlignStripButton_Click(object sender, EventArgs e)
        {
            // set properties
            leftAlignStripButton.Checked = false;
            centerAlignStripButton.Checked = false;

            if (rightAlignStripButton.Checked == false)
            {
                rightAlignStripButton.Checked = true;    // RIGHT ALIGN is active
            }
            else if (rightAlignStripButton.Checked == true)
            {
                rightAlignStripButton.Checked = false;    // RIGHT ALIGN is not active
            }
            noteContent.SelectionAlignment = HorizontalAlignment.Right;    // selects right alignment
        }

        private void bulletListStripButton_Click(object sender, EventArgs e)
        {
            if (bulletListStripButton.Checked == false)
            {
                bulletListStripButton.Checked = true;
                noteContent.SelectionBullet = true;    // BULLET LIST is active
            }
            else if (bulletListStripButton.Checked == true)
            {
                bulletListStripButton.Checked = false;
                noteContent.SelectionBullet = false;    // BULLET LIST is not active
            }
        }

        private void increaseStripButton_Click(object sender, EventArgs e)
        {
            string fontSizeNum = fontSizeComboBox.Text;    // variable to hold selected size         
            try
            {
                int size = Convert.ToInt32(fontSizeNum) + 1;    // convert (fontSizeNum + 1)
                if (noteContent.SelectionFont == null)
                {
                    return;
                }
                // sets the updated font size
                noteContent.SelectionFont = new Font(noteContent.SelectionFont.FontFamily, size, noteContent.SelectionFont.Style);
                fontSizeComboBox.Text = size.ToString();    // update font size
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Information", MessageBoxButtons.OK, MessageBoxIcon.Warning); // show error message
            }
        }

        private void decreaseStripButton_Click(object sender, EventArgs e)
        {
            string fontSizeNum = fontSizeComboBox.Text;    // variable to hold selected size            
            try
            {
                int size = Convert.ToInt32(fontSizeNum) - 1;    // convert (fontSizeNum - 1)
                if (noteContent.SelectionFont == null)
                {
                    return;
                }
                // sets the updated font size
                noteContent.SelectionFont = new Font(noteContent.SelectionFont.FontFamily, size, noteContent.SelectionFont.Style);
                fontSizeComboBox.Text = size.ToString();    // update font size
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Information", MessageBoxButtons.OK, MessageBoxIcon.Warning); // show error message
            }
        }

        private void zoomDropDownButton_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            float zoomPercent = Convert.ToSingle(e.ClickedItem.Text.Trim('%')); // convert
            noteContent.ZoomFactor = zoomPercent / 100;    // set zoom factor

            if (e.ClickedItem.Image == null)
            {
                // sets all the image properties to null - incase one is already selected beforehand
                for (int i = 0; i < zoomDropDownButton.DropDownItems.Count; i++)
                {
                    zoomDropDownButton.DropDownItems[i].Image = null;
                }

                // draw bmp in image property of selected item, while its active
                Bitmap bmp = new Bitmap(5, 5);
                using (Graphics gfx = Graphics.FromImage(bmp))
                {
                    gfx.FillEllipse(Brushes.Black, 1, 1, 3, 3);
                }
                e.ClickedItem.Image = bmp;    // draw ellipse in image property
            }
            else
            {
                e.ClickedItem.Image = null;
                noteContent.ZoomFactor = 1.0f;    // set back to NO ZOOM
            }
        }

        private void uppercaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            noteContent.SelectedText = noteContent.SelectedText.ToUpper();    // text to CAPS
        }

        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            // draws the string onto the print document
            e.Graphics.DrawString(noteContent.Text, noteContent.Font, Brushes.Black, 100, 20);
            e.Graphics.PageUnit = GraphicsUnit.Inch;
        }

        private void printStripButton_Click(object sender, EventArgs e)
        {
            // printDialog associates with PrintDocument
            printDialog.Document = printDocument;
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print(); // Print the document
            }
        }

        private void printPreviewStripButton_Click(object sender, EventArgs e)
        {
            printPreviewDialog.Document = printDocument;
            // Show PrintPreview Dialog 
            printPreviewDialog.ShowDialog();
        }

        private void lowercaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            noteContent.SelectedText = noteContent.SelectedText.ToLower();    // text to lowercase
        }

        private void clearFormattingStripButton_Click(object sender, EventArgs e)
        {
            fontStripComboBox.Text = "Font Family";
            fontSizeComboBox.Text = "Font Size";
            string pureText = noteContent.Text;    // get the current Plain Text     
            noteContent.Clear();    // clear RTB
            noteContent.ForeColor = Color.Black;    // ensure the text color is back to Black
            noteContent.Font = default(Font);    // set default font
            noteContent.Text = pureText;    // Set it back to its orginial text, added as plain text
            rightAlignStripButton.Checked = false;
            centerAlignStripButton.Checked = false;
            leftAlignStripButton.Checked = true;
        }

        //****************************************************************************************************************************************
        // richTextBox1_KeyUp - Determines which key was released and gets the line and column numbers of the current cursor position in the RTB *
        //**************************************************************************************************************************************** 
        private void noteContent_KeyUp(object sender, KeyEventArgs e)
        {
            // determine key released
            switch (e.KeyCode)
            {
                case Keys.Down:
                    pos = noteContent.SelectionStart;    // get starting point
                    line = noteContent.GetLineFromCharIndex(pos);    // get line number
                    column = noteContent.SelectionStart - noteContent.GetFirstCharIndexFromLine(line);    // get column number
                    lineColumnStatusLabel.Text = "Line " + (line + 1) + ", Column " + (column + 1);
                    break;
                case Keys.Right:
                    pos = noteContent.SelectionStart; // get starting point
                    line = noteContent.GetLineFromCharIndex(pos); // get line number
                    column = noteContent.SelectionStart - noteContent.GetFirstCharIndexFromLine(line);    // get column number
                    lineColumnStatusLabel.Text = "Line " + (line + 1) + ", Column " + (column + 1);
                    break;
                case Keys.Up:
                    pos = noteContent.SelectionStart; // get starting point
                    line = noteContent.GetLineFromCharIndex(pos); // get line number
                    column = noteContent.SelectionStart - noteContent.GetFirstCharIndexFromLine(line);    // get column number
                    lineColumnStatusLabel.Text = "Line " + (line + 1) + ", Column " + (column + 1);
                    break;
                case Keys.Left:
                    pos = noteContent.SelectionStart; // get starting point
                    line = noteContent.GetLineFromCharIndex(pos); // get line number
                    column = noteContent.SelectionStart - noteContent.GetFirstCharIndexFromLine(line);    // get column number
                    lineColumnStatusLabel.Text = "Line " + (line + 1) + ", Column " + (column + 1);
                    break;
            }
        }

        //****************************************************************************************************************************
        // richTextBox1_MouseDown - Gets the line and column numbers of the cursor position in the RTB when the mouse clicks an area *
        //****************************************************************************************************************************
        private void noteContent_MouseDown(object sender, MouseEventArgs e)
        {
            int pos = noteContent.SelectionStart;    // get starting point
            int line = noteContent.GetLineFromCharIndex(pos);    // get line number
            int column = noteContent.SelectionStart - noteContent.GetFirstCharIndexFromLine(line);    // get column number
            lineColumnStatusLabel.Text = "Line " + (line + 1) + ", Column " + (column + 1);
        }
    }
}
