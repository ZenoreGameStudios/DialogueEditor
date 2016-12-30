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
    public partial class EditingNode : UserControl
    {
        public List<TextBox> txtNPCLines = new List<TextBox> ();
        public List<TextBox> txtPlayerLines = new List<TextBox> ();
        private List<Label> lblNPCLines = new List<Label> ();
        private List<Label> lblPlayerLines = new List<Label> ();

        public int npc, player, decision, goesToId;

        public EditingNode (ucDialogueNode theNode) {
            InitializeComponent ();
            GetAllValues (theNode);
            AssignVariables ();
            ShowAppropiateItems ();
        }

        private void GetAllValues (ucDialogueNode theNode) {
            npc = theNode.dialogueNode.numberNPCLines;
            player = theNode.dialogueNode.numberPlayerAnswers;
            decision = theNode.dialogueNode.isNodeDecision;
            goesToId = theNode.dialogueNode.goesToNodeId;

            numericNPCLines.Value = npc;
            numericNPCLines.Value = player;
            numericDecision.Value = decision;
            numericGoesTo.Value = goesToId;
        }
        private void AssignVariables () {
            txtNPCLines = new List<TextBox> ();
            txtNPCLines.Add (textBox1);
            txtNPCLines.Add (textBox2);
            txtNPCLines.Add (textBox3);
            txtNPCLines.Add (textBox4);
            txtNPCLines.Add (textBox5);

            txtPlayerLines = new List<TextBox> ();
            txtPlayerLines.Add (textBox6);
            txtPlayerLines.Add (textBox7);
            txtPlayerLines.Add (textBox8);
            txtPlayerLines.Add (textBox9);
            txtPlayerLines.Add (textBox10);

            lblNPCLines = new List<Label> ();
            lblNPCLines.Add (label5);
            lblNPCLines.Add (label6);
            lblNPCLines.Add (label7);
            lblNPCLines.Add (label8);
            lblNPCLines.Add (label9);

            lblPlayerLines = new List<Label> ();
            lblPlayerLines.Add (label10);
            lblPlayerLines.Add (label11);
            lblPlayerLines.Add (label12);
            lblPlayerLines.Add (label13);
            lblPlayerLines.Add (label14);
        }
        private void ShowAppropiateItems () {
            int temp = 0;
            foreach (TextBox txtBox in txtNPCLines) {
                if (temp < npc) {
                    txtBox.Visible = true;
                    temp++;
                } else {
                    txtBox.Visible = false;
                    temp++;
                }
            }
            temp = 0;
            foreach (Label label in lblNPCLines) {
                if (temp < npc) {
                    label.Visible = true;
                    temp++;
                } else {
                    label.Visible = false;
                    temp++;
                }
            }
            temp = 0;
            foreach (TextBox txtBox in txtPlayerLines) {
                if (temp < player) {
                    txtBox.Visible = true;
                    temp++;
                } else {
                    txtBox.Visible = false;
                    temp++;
                }
            }
            temp = 0;
            foreach (Label label in lblPlayerLines) {
                if (temp < player) {
                    label.Visible = true;
                    temp++;
                } else {
                    label.Visible = false;
                    temp++;
                }
            }
        }
        

        private void numericNPCLines_ValueChanged (object sender, EventArgs e) {
            npc = (int) numericNPCLines.Value;
            ShowAppropiateItems ();
        }
        private void numericPlayerLines_ValueChanged (object sender, EventArgs e) {
            player = (int) numericPlayerLines.Value;
            ShowAppropiateItems ();
        }
        private void numericDecision_ValueChanged (object sender, EventArgs e) {
            decision = (int) numericDecision.Value;
            ShowAppropiateItems ();
        }
        private void numericGoesTo_ValueChanged (object sender, EventArgs e) {
            goesToId = (int) numericGoesTo.Value;
            ShowAppropiateItems ();
        }
    }
}