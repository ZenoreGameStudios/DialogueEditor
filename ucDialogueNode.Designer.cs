namespace DialogueEditor
{
    partial class ucDialogueNode
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose (bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose ();
            }
            base.Dispose (disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent () {
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelGoesToNodeId = new System.Windows.Forms.Label();
            this.labelIdentification = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelDecisionNode = new System.Windows.Forms.Label();
            this.labelPlayerLines = new System.Windows.Forms.Label();
            this.labelNPCLines = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBoxSelected = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dialogue Node";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelGoesToNodeId);
            this.groupBox1.Controls.Add(this.labelIdentification);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.labelDecisionNode);
            this.groupBox1.Controls.Add(this.labelPlayerLines);
            this.groupBox1.Controls.Add(this.labelNPCLines);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(87, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(310, 69);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Stats";
            // 
            // labelGoesToNodeId
            // 
            this.labelGoesToNodeId.AutoSize = true;
            this.labelGoesToNodeId.Location = new System.Drawing.Point(211, 30);
            this.labelGoesToNodeId.Name = "labelGoesToNodeId";
            this.labelGoesToNodeId.Size = new System.Drawing.Size(13, 13);
            this.labelGoesToNodeId.TabIndex = 9;
            this.labelGoesToNodeId.Text = "0";
            // 
            // labelIdentification
            // 
            this.labelIdentification.AutoSize = true;
            this.labelIdentification.Location = new System.Drawing.Point(211, 16);
            this.labelIdentification.Name = "labelIdentification";
            this.labelIdentification.Size = new System.Drawing.Size(13, 13);
            this.labelIdentification.TabIndex = 8;
            this.labelIdentification.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(125, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Goes to Node:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(125, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Identification:";
            // 
            // labelDecisionNode
            // 
            this.labelDecisionNode.AutoSize = true;
            this.labelDecisionNode.Location = new System.Drawing.Point(92, 44);
            this.labelDecisionNode.Name = "labelDecisionNode";
            this.labelDecisionNode.Size = new System.Drawing.Size(13, 13);
            this.labelDecisionNode.TabIndex = 5;
            this.labelDecisionNode.Text = "0";
            // 
            // labelPlayerLines
            // 
            this.labelPlayerLines.AutoSize = true;
            this.labelPlayerLines.Location = new System.Drawing.Point(92, 30);
            this.labelPlayerLines.Name = "labelPlayerLines";
            this.labelPlayerLines.Size = new System.Drawing.Size(13, 13);
            this.labelPlayerLines.TabIndex = 4;
            this.labelPlayerLines.Text = "0";
            // 
            // labelNPCLines
            // 
            this.labelNPCLines.AutoSize = true;
            this.labelNPCLines.Location = new System.Drawing.Point(92, 16);
            this.labelNPCLines.Name = "labelNPCLines";
            this.labelNPCLines.Size = new System.Drawing.Size(13, 13);
            this.labelNPCLines.TabIndex = 3;
            this.labelNPCLines.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Decision Node:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Player Lines:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "NPC Lines:";
            // 
            // checkBoxSelected
            // 
            this.checkBoxSelected.AutoCheck = false;
            this.checkBoxSelected.AutoSize = true;
            this.checkBoxSelected.Location = new System.Drawing.Point(34, 46);
            this.checkBoxSelected.Name = "checkBoxSelected";
            this.checkBoxSelected.Size = new System.Drawing.Size(15, 14);
            this.checkBoxSelected.TabIndex = 2;
            this.checkBoxSelected.UseVisualStyleBackColor = true;
            // 
            // ucDialogueNode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.checkBoxSelected);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "ucDialogueNode";
            this.Size = new System.Drawing.Size(400, 75);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelDecisionNode;
        private System.Windows.Forms.Label labelPlayerLines;
        private System.Windows.Forms.Label labelNPCLines;
        private System.Windows.Forms.Label labelGoesToNodeId;
        private System.Windows.Forms.Label labelIdentification;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBoxSelected;
    }
}
