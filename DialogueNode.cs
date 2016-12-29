using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DialogueEditor
{
    public class DialogueNode
    {
        public int numberNPCLines;
        public int numberPlayerAnswers;
        public int isNodeDecision;
        public int identification;
        public int goesToNodeId;

        public List<string> NPCLines = new List<string> ();
        public List<string> PlayerLines = new List<string> ();

        // Tags 'NPCLines', 'PlayerLines' and 'text'

        public DialogueNode(int npc, int player, int decision, int id, int goesTo) {
            numberNPCLines = npc;
            numberPlayerAnswers = player;
            isNodeDecision = decision;
            identification = id;
            goesToNodeId = goesTo;
        }
    }
}