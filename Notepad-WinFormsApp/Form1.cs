using System;
using System.Drawing;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;


namespace Notepad_WinFormsApp
{
    public partial class NotesForm : Form
    {

        public System.Diagnostics.Process p = new System.Diagnostics.Process();
        string fileFilter = "Text File|*.txt|All files |*.* a";
        string defaultExt = ".txt";
        string app_name = " - Notes";

        FontStyle font;
        Font fontStyle;
        Color defaultColor = Color.FromArgb(204, 204, 204);

        // Used to know wether or not the user has saved his file
        // so it doesn't show the save dialog everytime the user saves.
        string saveFile_Name;
        bool fileModified = false;

        public NotesForm()
        {
            InitializeComponent();
            // Sets the app title to "Unnamed"
            this.Text = "Unnamed" + app_name;
            btnClose.Visible = false;
            /*msMenu.Renderer = new HoverRenderer();*/
            lablEncoding.Text = "UTF-8";

            // Setting up font styles
            rtxtbContent.ForeColor = defaultColor;
            btnFontColor.BackColor = defaultColor;
            font = (FontStyle)rtxtbContent.Font.Style;
            fontStyle = new Font(rtxtbContent.Font.FontFamily, (float)nupFontSize.Value, font);

            panlTools.Visible = false;
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // If richTextBox isn't empty,
            // 0 → save current note and create a new one
            // 1 → create a new note and sets the app title to "Unnamed"
            if (!isTextBoxEmpty(rtxtbContent))
            {
                int confirmInt = confirmMessageBox();
                if (confirmInt == 0)
                {
                    saveFile();
                    rtxtbContent.Clear();
                }
                else if (confirmInt == 1)
                {
                    this.Text = "Unnamed" + app_name;
                    rtxtbContent.Clear();
                }
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // If richTextBox isn't empty,
            // 0 → save current note and open another one
            // 1 → open a note and sets the app title to the file name
            if (fileModified)
            {
                int confirmResult = confirmMessageBox();
                if (confirmResult == 0)
                {
                    saveFile();
                    openFile();
                }
                else if (confirmResult == 1)
                {
                    openFile();
                }
            }
            else
            {
                openFile();
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Pretty self explanatory 
            saveFile();
        }

        private int confirmMessageBox()
        {
            // Opens a yes no message box
            var confirmOpen = MessageBox.Show("A note is currently in editing. Do you want to save it ?", "Note", MessageBoxButtons.YesNo);
            // 0 = save and do action
            // 1 = do action
            // 2 = exited message box
            if (confirmOpen == DialogResult.Yes)
            {
                return 0;
            }
            else if (confirmOpen == DialogResult.No)
            {
                return 1;
            }
            return 2;
        }

        private bool isTextBoxEmpty(RichTextBox textBox)
        {
            // Checks if given richTextBox is empty
            if (textBox.Text.Length > 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void openFile()
        {
            // Defines default extension and filter for the openFileDialog
            ofdialOpenFile.FileName = "note.txt";
            ofdialOpenFile.DefaultExt = defaultExt;
            ofdialOpenFile.Filter = fileFilter;
            if (ofdialOpenFile.ShowDialog() == DialogResult.OK)
            {
                // Sets richTextBox content to the file content and change the app title to the file name
                string ofdialOpenFile_Name = ofdialOpenFile.FileName;
                rtxtbContent.Text = File.ReadAllText(ofdialOpenFile_Name);
                this.Text = Path.GetFileNameWithoutExtension(ofdialOpenFile_Name) + app_name;
                saveFile_Name = ofdialOpenFile_Name;
                fileModified = true;
            }
        }

        private void saveFile()
        {
            // Defines default extension and filter for the saveFileDialog
            sfdialSaveFile.FileName = "note.txt";
            sfdialSaveFile.DefaultExt = defaultExt;
            sfdialSaveFile.Filter = fileFilter;
            if (!isTextBoxEmpty(rtxtbContent))
            {
                if (fileModified & saveFile_Name != null)
                {
                    File.WriteAllText(saveFile_Name, rtxtbContent.Text);
                    this.Text = Path.GetFileNameWithoutExtension(saveFile_Name) + app_name;
                }
                else
                {
                    if (sfdialSaveFile.ShowDialog() == DialogResult.OK)
                    {
                        //  Writes the richTextBox content to the file and change the app title to the file name
                        saveFile_Name = sfdialSaveFile.FileName;
                        File.WriteAllText(saveFile_Name, rtxtbContent.Text);
                        this.Text = Path.GetFileNameWithoutExtension(saveFile_Name) + app_name;
                    }
                }
            }
            fileModified = false;
        }

        private void closeApp()
        {
            // Gets the result from the message box
            int confirmResult = confirmMessageBox();
            // If richtextbox isn't empty
            if (!isTextBoxEmpty(rtxtbContent))
            {
                // If result == 0, save & exit
                if (confirmResult == 0)
                {
                    saveFile();
                    Close();
                }
                // Else if == 1, exit
                else if (confirmResult == 1)
                {
                    Close();
                }
            }
            // If it's empty, close
            else
            {
                Close();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Pretty self explanatory 
            closeApp();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Undo action
            rtxtbContent.Undo();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Redo action
            rtxtbContent.Redo();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Cuts selection
            rtxtbContent.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Copies selection
            rtxtbContent.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Paste at current position
            rtxtbContent.Paste();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Selects all the richtextbox content
            rtxtbContent.SelectAll();
        }

        private void dateTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Appends current time format (dd/mm/yy hh:mm:ss) at current position
            rtxtbContent.AppendText(DateTime.Now.ToString());
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Opens font dialog
            if (fdialFont.ShowDialog() == DialogResult.OK)
            {
                rtxtbContent.Font = fdialFont.Font;
            }
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Opens color dialog
            if (cdialColor.ShowDialog() == DialogResult.OK)
            {
                rtxtbContent.ForeColor = cdialColor.Color;
            }
        }

        private void rtxtbContent_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            // Hyperlink handler
            p = System.Diagnostics.Process.Start(e.LinkText);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            // Pretty self explanatory
            closeApp();
        }

        /*private void msMenuItem_Hover(object sender, EventArgs e)
        {
            ToolStripMenuItem item = (ToolStripMenuItem) sender;
        }*/

        private void rtxtbContent_TextChanged(object sender, EventArgs e)
        {
            // Displays the current column and line
            int char_index = rtxtbContent.GetCharIndexFromPosition(Cursor.Position);
            lablColumnLigns.Text = $"Col {(CursorPosition.Column(rtxtbContent, char_index))}, Ln {(CursorPosition.Line(rtxtbContent, char_index))}";

            // Displays the current word count
            int words = GetWordCount(rtxtbContent);
            lablWords.Text = $"Words {words}";

            // Indicator of wether or not the file is saved
            // * → not saved
            // nothing → saved
            fileModified = true;
            if (!(this.Text.Contains("*")))
            {
                this.Text = "*" + this.Text;
            }
        }

        private void rtxtbContent_ClientSizeChanged(object sender, EventArgs e)
        {
            updateZoomFactorLabel();
        }

        private void updateZoomFactorLabel()
        {
            // Displays the current zoom factor
            lablZoom.Text = $"Zoom {(rtxtbContent.ZoomFactor * 100)}%";
        }


        private void rtxtbContent_SelectionChanged(object sender, EventArgs e)
        {
        }

        /// 
        ///
        /// 

        // Returns the word count of the richTextBox
        private int GetWordCount(RichTextBox rtb)
        {
            MatchCollection wordColl = Regex.Matches(rtb.Text, @"[\W]+");
            return wordColl.Count;
        }

        // Get line and column of cursor position
        public class CursorPosition
        {
            [System.Runtime.InteropServices.DllImport("user32")]
            public static extern int GetCaretPos(ref Point lpPoint);

            private static int GetCorrection(RichTextBox e, int index)
            {
                Point pt1 = Point.Empty;
                GetCaretPos(ref pt1);
                Point pt2 = e.GetPositionFromCharIndex(index);

                if (pt1 != pt2)
                    return 1;
                else
                    return 0;
            }

            public static int Line(RichTextBox e, int index)
            {
                int correction = GetCorrection(e, index);
                return e.GetLineFromCharIndex(index) - correction + 1;
            }

            public static int Column(RichTextBox e, int index1)
            {
                int correction = GetCorrection(e, index1);
                Point p = e.GetPositionFromCharIndex(index1 - correction);

                if (p.X == 1)
                    return 1;

                p.X = 0;
                int index2 = e.GetCharIndexFromPosition(p);

                int col = index1 - index2 + 1;

                return col;
            }
        }

        private void fullscreenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toggleFullscreen(true);
        }

        private void windowedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toggleFullscreen(false);
        }

        private void toggleFullscreen(bool fullscreen)
        {
            if (fullscreen)
            {
                this.FormBorderStyle = FormBorderStyle.None;
                this.WindowState = FormWindowState.Maximized;
                this.TopMost = true;
                // Shows the close button on the tool bar
                btnClose.Visible = true;
            } else
            {
                this.FormBorderStyle = FormBorderStyle.Sizable;
                this.WindowState = FormWindowState.Normal;
                this.CenterToScreen();
                // Hides the close button on the tool bar
                btnClose.Visible = false;
            }
        }

        private void zoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // current zoom - 10 percent
            rtxtbContent.ZoomFactor -= (float)0.1;
            updateZoomFactorLabel();
        }

        private void zoomToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // current zoom + 10 percent 
            rtxtbContent.ZoomFactor += (float)0.1;
            updateZoomFactorLabel();
        }

        private void nupFontSize_ValueChanged(object sender, EventArgs e)
        {
            Font fontStyle = new Font(rtxtbContent.Font.FontFamily, (float)nupFontSize.Value, font);
            // Changes the font size of the whole rtxtbContent
            rtxtbContent.Font = fontStyle;
            // Word/OpenOffice/LibreOffice like font size (changes the font of the selected text/text typed after change)
            /*rtxtbContent.SelectionFont = fontStyle;*/
        }

        private void btnFontColor_Click(object sender, EventArgs e)
        {
            if (cdialColor.ShowDialog() == DialogResult.OK)
            {
                rtxtbContent.ForeColor = cdialColor.Color;
                btnFontColor.BackColor = cdialColor.Color;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void nupZoom_ValueChanged(object sender, EventArgs e)
        {
            rtxtbContent.ZoomFactor = (float)nupZoom.Value / 100;
            updateZoomFactorLabel();
        }

        private void cbFullscreen_CheckedChanged(object sender, EventArgs e)
        {
            if (cbFullscreen.Checked)
            {
                toggleFullscreen(true);
            } else
            {
                toggleFullscreen(false);
            }
        }

        private void toolbarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panlTools.Visible = !panlTools.Visible;
        }
    }
}

