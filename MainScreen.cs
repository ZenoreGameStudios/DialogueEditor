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
        private EditingNode newEditingNode;
        #endregion
        #region Functionality variables
        private bool isDialogueOpen;
        private bool editing;
        private int numberOfNodes;
        private string nameOfDialogue;
        private List<ucDialogueNode> ucDialogueNodes;

        private XmlDocument docXml;

        private const string TAG_NAME = "DialogueName";
        private const string TAG_NPCNUMBER = "numberNPCLines";
        private const string TAG_PLAYERNUMBER = "numberPlayerAnswers";
        private const string TAG_DECISION = "isNodeDecision";
        private const string TAG_ID = "identification";
        private const string TAG_GOES = "nodeGoesTo";
        private const string TAG_NPCLINES = "NPCLines";
        private const string TAG_PLAYERLINES = "PlayerLines";
        private const string TAG_TEXT = "text";
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
            numSelectedNode.Minimum = 0;
            numSelectedNode.Maximum = 0;

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
            foreach (ucDialogueNode node in ucDialogueNodes) {
                if (node.dialogueNode.identification != i) {
                    node.ChangeSelection (false);
                } else {
                    node.ChangeSelection (true);
                }
            }
        }
        private void SaveDialogueNode (int npc, int player, int decision, int goesTo, List<string> npcStrings, List<string> playerStrings) {
            ucDialogueNodes[(int) numSelectedNode.Value - 1].UpdateNodeInformation (npc, player, decision, goesTo);
            ucDialogueNodes[(int) numSelectedNode.Value - 1].UpdateStats ();
            ucDialogueNodes[(int) numSelectedNode.Value - 1].dialogueNode.NPCLines = npcStrings;
            ucDialogueNodes[(int) numSelectedNode.Value - 1].dialogueNode.PlayerLines = playerStrings;
        }

        private void PopulateXmlDocument () {
            docXml = new XmlDocument ();
            //string tempString = "<?xml version=\"1.0\" encoding=\"utf - 8\"?>";
            docXml.LoadXml ("<?xml version=\"1.0\" encoding=\"utf-8\"?><Dialogue></Dialogue>");

            XmlElement elemName = docXml.CreateElement (TAG_NAME);
            elemName.InnerText = nameOfDialogue;
            docXml.DocumentElement.AppendChild (elemName);
            for (int i = 0; i < numberOfNodes; i++) {
                XmlElement elemNode = PopulateNode (i);
                XmlElement elemLinesNPC = PopulateLinesNPC (i);
                XmlElement elemLinesPlayer = PopulateLinesPlayer (i);
                elemNode.AppendChild (elemLinesNPC);
                elemNode.AppendChild (elemLinesPlayer);
                docXml.DocumentElement.AppendChild (elemNode);
            }

            docXml.PreserveWhitespace = false;
        }

        private XmlElement PopulateNode (int i) {
            XmlElement Container = docXml.CreateElement ("DialogueNode");
            XmlElement elemItem = docXml.CreateElement (TAG_NPCNUMBER);
            elemItem.InnerText = ucDialogueNodes[i].dialogueNode.numberNPCLines.ToString ();
            Container.AppendChild (elemItem);
            elemItem = docXml.CreateElement (TAG_PLAYERNUMBER);
            elemItem.InnerText = ucDialogueNodes[i].dialogueNode.numberPlayerAnswers.ToString ();
            Container.AppendChild (elemItem);
            elemItem = docXml.CreateElement (TAG_DECISION);
            elemItem.InnerText = ucDialogueNodes[i].dialogueNode.isNodeDecision.ToString ();
            Container.AppendChild (elemItem);
            elemItem = docXml.CreateElement (TAG_ID);
            elemItem.InnerText = ucDialogueNodes[i].dialogueNode.identification.ToString ();
            Container.AppendChild (elemItem);
            elemItem = docXml.CreateElement (TAG_GOES);
            elemItem.InnerText = ucDialogueNodes[i].dialogueNode.goesToNodeId.ToString ();
            Container.AppendChild (elemItem);

            return Container;
        }
        private XmlElement PopulateLinesNPC (int i) {
            XmlElement Container = docXml.CreateElement (TAG_NPCLINES);
            XmlElement elemText = docXml.CreateElement (TAG_TEXT);
            foreach (string line in ucDialogueNodes[i].dialogueNode.NPCLines) {
                if (line != "") {
                    elemText = docXml.CreateElement (TAG_TEXT);
                    elemText.InnerText = line;
                    Container.AppendChild (elemText);
                }
            }

            return Container;
        }
        private XmlElement PopulateLinesPlayer (int i) {
            XmlElement Container = docXml.CreateElement (TAG_PLAYERLINES);
            XmlElement elemText = docXml.CreateElement (TAG_TEXT);
            foreach (string line in ucDialogueNodes[i].dialogueNode.PlayerLines) {
                if (line != "") {
                    elemText = docXml.CreateElement (TAG_TEXT);
                    elemText.InnerText = line;
                    Container.AppendChild (elemText);
                }
            }

            return Container;
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
            numberOfNodes++;
            numSelectedNode.Minimum = 1;
            numSelectedNode.Maximum = numberOfNodes;

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
            if (!editing) {
                if (ucDialogueNodes.Count < 1) {
                    MessageBox.Show ("No Nodes created");
                    return;
                } else {
                    dialogueNodeBox.Text = "EditingNode";
                    foreach (ucDialogueNode node in ucDialogueNodes) {
                        node.Visible = false;
                    }
                    newEditingNode = new EditingNode (ucDialogueNodes[(int) numSelectedNode.Value - 1]);
                    panelDialogueNodes.Controls.Add (newEditingNode);
                    buttonEditNode.Text = "Save Node";
                    numSelectedNode.Enabled = false;
                    editing = true;
                }
            } else {
                // Save the node
                List<string> theNPCList = new List<string> ();
                List<string> thePlayerList = new List<string> ();
                foreach (TextBox txtBox in newEditingNode.txtNPCLines) {
                    theNPCList.Add (txtBox.Text);
                }
                foreach (TextBox txtBox in newEditingNode.txtPlayerLines) {
                    thePlayerList.Add (txtBox.Text);
                }
                SaveDialogueNode (newEditingNode.npc, newEditingNode.player, newEditingNode.decision, newEditingNode.goesToId, theNPCList, thePlayerList);
                dialogueNodeBox.Text = "Dialogue Nodes";
                foreach (ucDialogueNode node in ucDialogueNodes) {
                    node.Visible = true;
                }
                panelDialogueNodes.Controls.Remove (newEditingNode);
                buttonEditNode.Text = "Edit Dialogue Node";
                numSelectedNode.Enabled = true;
                editing = false;
            }
        }
        private void numericSelectedNode_ValueChanged (object sender, EventArgs e) {
            ChangeNodeSelection ((int) numSelectedNode.Value);
        }

        private void buttonSaveDialogue_Click (object sender, EventArgs e) {
            PopulateXmlDocument ();
            SaveFileDialog saveFileDialog = new SaveFileDialog ();
            saveFileDialog.Filter = "XML-File | *.xml";
            if (saveFileDialog.ShowDialog() == DialogResult.OK) {
                docXml.Save (saveFileDialog.FileName);
            }
        }
    }
}