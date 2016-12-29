using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DialogueEditor
{
    public partial class ucDialogueNode : UserControl
    {
        public DialogueNode dialogueNode;

        public Label lblNPCLines;
        public Label lblPlayerLines;
        public Label lblIsDecisionNode;
        public Label lblIdentification;
        public Label lblGoesToNodeID;

        public CheckBox checkBIsThisSelected;

        private Color originalColour;

        public ucDialogueNode (int id) {
            InitializeComponent ();

            lblNPCLines = labelNPCLines;
            lblPlayerLines = labelPlayerLines;
            lblIsDecisionNode = labelDecisionNode;
            lblIdentification = labelIdentification;
            lblGoesToNodeID = labelGoesToNodeId;

            originalColour = this.BackColor;
            checkBIsThisSelected = checkBoxSelected;

            dialogueNode = new DialogueNode (0, 0, 0, id, -1);
            UpdateStats ();
        }

        public void UpdateStats () {
            lblNPCLines.Text = dialogueNode.numberNPCLines.ToString ();
            lblPlayerLines.Text = dialogueNode.numberPlayerAnswers.ToString ();
            lblIsDecisionNode.Text = dialogueNode.isNodeDecision == 1 ? "True" : "False";
            lblIdentification.Text = dialogueNode.identification.ToString ();
            lblGoesToNodeID.Text = dialogueNode.goesToNodeId.ToString ();
        }
        public void UpdateNodeInformation (int npc, int player, int decision, int goesTo) {
            dialogueNode.numberNPCLines = npc;
            dialogueNode.numberPlayerAnswers = player;
            dialogueNode.isNodeDecision = decision;
            dialogueNode.goesToNodeId = goesTo;
        }
        public void ChangeSelection (bool selected) {
            if (selected) {
                checkBIsThisSelected.CheckState = CheckState.Checked;
                this.BackColor = Color.LightBlue;
            } else {
                checkBIsThisSelected.CheckState = CheckState.Unchecked;
                this.BackColor = originalColour;
            }
        }
    }
}