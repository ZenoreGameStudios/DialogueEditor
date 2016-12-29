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
        #region WindowsForms variables
        private Panel theMainPanel;
        private FlowLayoutPanel pnlDialogueNodes;
        private WaterMarkTextBox txtDialogueName;
        private GroupBox grpbDialogueNodeBox;
        private Label lblNumberOfNodes;
        private NumericUpDown numSelectedNode;
        #endregion
        #region Functionality variables
        private bool isDialogueOpen;
        private int numberOfNodes;
        private string nameOfDialogue;
        private List<ucDialogueNode> ucDialogueNodes;
        #endregion

        public MainScreen () {
            InitializeComponent ();
            InitializeTheRest ();
        }

        private void InitializeTheRest () {
            isDialogueOpen = false;
            theMainPanel = mainPanel;
            pnlDialogueNodes = panelDialogueNodes;
            txtDialogueName = textBoxDialogueName;
            grpbDialogueNodeBox = dialogueNodeBox;
            lblNumberOfNodes = labelNumberofNodes;
            numSelectedNode = numericSelectedNode;
            
            CreateNew ();
        }
        private void CreateNew () {
            isDialogueOpen = true;
            
            WipeEverything ();
            UpdateGUIText ();
        }
        private void WipeEverything () {
            nameOfDialogue = "";
            pnlDialogueNodes.Controls.Clear ();
            numberOfNodes = 0;
            ucDialogueNodes = new List<ucDialogueNode> ();
        }
        private void UpdateGUIText () {
            lblNumberOfNodes.Text = numberOfNodes.ToString ();
            txtDialogueName.Text = nameOfDialogue;
            this.Text = "Dialogue Editor";
        }
        private void ChangeNodeSelection (int i) {

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
        private void buttonCreateDialogueNode_Click (object sender, EventArgs e) {
            ucDialogueNode newDN = new ucDialogueNode (numberOfNodes + 1);
            pnlDialogueNodes.Controls.Add (newDN);
            ucDialogueNodes.Add (newDN);
            numSelectedNode.Maximum = numberOfNodes;
            numberOfNodes++;
            
            UpdateGUIText ();
        }
        private void buttonSaveName_Click (object sender, EventArgs e) {
            nameOfDialogue = txtDialogueName.Text;
            this.Text = "Dialogue Editor   :   " + nameOfDialogue;
        }
        private void textBoxDialogueName_KeyUp (object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                nameOfDialogue = txtDialogueName.Text;
                this.Text = "Dialogue Editor   :   " + nameOfDialogue;
            }
        }
        private void buttonEditNode_Click (object sender, EventArgs e) {
            
            ChangeNodeSelection ((int)numSelectedNode.Value);
            // Open editing window
            MessageBox.Show ("" + (int) numSelectedNode.Value);
        }
    }
}
