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
    public partial class MainScreen : Form
    {
        private XmlDocument xmlDocument;

        private Panel theMainPanel;
        private FlowLayoutPanel pnlDialogueNodes;
        private WaterMarkTextBox txtDialogueName;
        private GroupBox grpbDialogueNodeBox;
        private GroupBox grpbEditing;
        private Label lblNumberOfNodes;
        private bool isDialogueOpen;
        private int numberOfNodes;

        public MainScreen () {
            InitializeComponent ();

            InitializeEverything ();
        }

        private void InitializeEverything () {
            isDialogueOpen = false;
            theMainPanel = mainPanel;
            pnlDialogueNodes = panelDialogueNodes;
            txtDialogueName = dialogueName;
            grpbDialogueNodeBox = dialogueNodeBox;
            grpbEditing = groupBoxEditing;
            lblNumberOfNodes = labelNumberofNodes;

            grpbEditing.Visible = false;

            CreateNew ();
        }

        private void CreateNew () {
            isDialogueOpen = true;
            numberOfNodes = 0;

            // Wipe everything

            UpdateAllText ();
        }

        private void UpdateAllText () {
            lblNumberOfNodes.Text = numberOfNodes.ToString ();
        }

        //#region Button functions
        private void newToolStripMenuItem1_Click (object sender, EventArgs e) {
            if (isDialogueOpen) {
                var confirmResult = MessageBox.Show ("A dialogue is still open, are you sure you want to open a new one?",
                    "Confirm delete current",
                    MessageBoxButtons.OKCancel);
                if (confirmResult == DialogResult.OK) {
                    CreateNew ();
                }
            } else {
                CreateNew ();
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
        private void MainScreen_FormClosing (object sender, FormClosingEventArgs e) {
            Application.Exit ();
        }
        private void button1_Click (object sender, EventArgs e) {
            DialogueNode newDN = new DialogueNode ();
            pnlDialogueNodes.Controls.Add (newDN);
            numberOfNodes++;

            UpdateAllText ();
        }
    }
}
