using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace DialogueEditor
{
    public partial class Main : Form
    {
        private XmlDocument xmlDocument;

        private Panel theMainPanel;
        private WaterMarkTextBox txtDialogueName;
        private GroupBox grpbDialogueNodeBox;
        private bool isDialogueOpen;

        public Main () {
            InitializeComponent ();

            InitializeEverything ();
        }

        private void InitializeEverything () {
            isDialogueOpen = false;
            theMainPanel = mainPanel;
            theMainPanel.Enabled = false;
            theMainPanel.Visible = false;
            txtDialogueName = dialogueName;
            grpbDialogueNodeBox = dialogueNodeBox;
            grpbDialogueNodeBox.Visible = false;
            grpbDialogueNodeBox.Enabled = false;
        }

        private void CreateNew () {
            isDialogueOpen = true;
        }
        private void InitializeGUI () {
            theMainPanel.Enabled = true;
        }

        //#region Button functions
        private void newToolStripMenuItem1_Click (object sender, EventArgs e) {
            if (isDialogueOpen) {
                var confirmResult = MessageBox.Show ("A dialogue is still open, are you sure you want to open a new one?",
                    "Confirm delete current",
                    MessageBoxButtons.OKCancel);
                if (confirmResult == DialogResult.OK) {
                    CreateNew ();
                    InitializeGUI ();
                }
            } else {
                CreateNew ();
                InitializeGUI ();
            }
            
        }
        private void quitToolStripMenuItem_Click (object sender, EventArgs e) {
            Application.Exit ();
        }
        private void zenoreGameStudiosToolStripMenuItem_Click (object sender, EventArgs e) {
            Process.Start ("http://zenoregamestudios.azurewebsites.net/");
        }
        private void programToolStripMenuItem_Click (object sender, EventArgs e) {
            MessageBox.Show ("This program was created by the team at ZenoreGameStudios to be able " +
                "to easily create dialogues for our Unity Dialogue Module");
        }
    }
}
