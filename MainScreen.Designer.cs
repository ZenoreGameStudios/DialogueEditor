namespace DialogueEditor
{
    partial class MainScreen
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent () {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zenoreGameStudiosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.programToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.dialogueNodeBox = new System.Windows.Forms.GroupBox();
            this.panelDialogueNodes = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.numericSelectedNode = new System.Windows.Forms.NumericUpDown();
            this.buttonEditNode = new System.Windows.Forms.Button();
            this.buttonSaveDialogue = new System.Windows.Forms.Button();
            this.buttonCreateDialogueNode = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonSaveName = new System.Windows.Forms.Button();
            this.labelNumberofNodes = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxDialogueName = new DialogueEditor.WaterMarkTextBox();
            this.menuStrip1.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.dialogueNodeBox.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericSelectedNode)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(652, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem1,
            this.quitToolStripMenuItem});
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.newToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem1
            // 
            this.newToolStripMenuItem1.Name = "newToolStripMenuItem1";
            this.newToolStripMenuItem1.Size = new System.Drawing.Size(98, 22);
            this.newToolStripMenuItem1.Text = "New";
            this.newToolStripMenuItem1.Click += new System.EventHandler(this.newToolStripMenuItem1_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zenoreGameStudiosToolStripMenuItem,
            this.programToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // zenoreGameStudiosToolStripMenuItem
            // 
            this.zenoreGameStudiosToolStripMenuItem.Name = "zenoreGameStudiosToolStripMenuItem";
            this.zenoreGameStudiosToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.zenoreGameStudiosToolStripMenuItem.Text = "ZenoreGameStudios";
            this.zenoreGameStudiosToolStripMenuItem.Click += new System.EventHandler(this.zenoreGameStudiosToolStripMenuItem_Click);
            // 
            // programToolStripMenuItem
            // 
            this.programToolStripMenuItem.Name = "programToolStripMenuItem";
            this.programToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.programToolStripMenuItem.Text = "Program";
            this.programToolStripMenuItem.Click += new System.EventHandler(this.programToolStripMenuItem_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainPanel.Controls.Add(this.dialogueNodeBox);
            this.mainPanel.Controls.Add(this.groupBox2);
            this.mainPanel.Controls.Add(this.groupBox1);
            this.mainPanel.Location = new System.Drawing.Point(0, 30);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(652, 386);
            this.mainPanel.TabIndex = 1;
            // 
            // dialogueNodeBox
            // 
            this.dialogueNodeBox.Controls.Add(this.panelDialogueNodes);
            this.dialogueNodeBox.Location = new System.Drawing.Point(218, 3);
            this.dialogueNodeBox.Name = "dialogueNodeBox";
            this.dialogueNodeBox.Size = new System.Drawing.Size(426, 377);
            this.dialogueNodeBox.TabIndex = 2;
            this.dialogueNodeBox.TabStop = false;
            this.dialogueNodeBox.Text = "Dialogue Nodes";
            // 
            // panelDialogueNodes
            // 
            this.panelDialogueNodes.AutoScroll = true;
            this.panelDialogueNodes.BackColor = System.Drawing.SystemColors.Control;
            this.panelDialogueNodes.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.panelDialogueNodes.Location = new System.Drawing.Point(6, 19);
            this.panelDialogueNodes.Name = "panelDialogueNodes";
            this.panelDialogueNodes.Size = new System.Drawing.Size(411, 352);
            this.panelDialogueNodes.TabIndex = 0;
            this.panelDialogueNodes.WrapContents = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.numericSelectedNode);
            this.groupBox2.Controls.Add(this.buttonEditNode);
            this.groupBox2.Controls.Add(this.buttonSaveDialogue);
            this.groupBox2.Controls.Add(this.buttonCreateDialogueNode);
            this.groupBox2.Location = new System.Drawing.Point(12, 147);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 233);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Controls";
            // 
            // numericSelectedNode
            // 
            this.numericSelectedNode.Location = new System.Drawing.Point(142, 90);
            this.numericSelectedNode.Name = "numericSelectedNode";
            this.numericSelectedNode.Size = new System.Drawing.Size(39, 20);
            this.numericSelectedNode.TabIndex = 3;
            this.numericSelectedNode.ValueChanged += new System.EventHandler(this.numericSelectedNode_ValueChanged);
            // 
            // buttonEditNode
            // 
            this.buttonEditNode.Location = new System.Drawing.Point(11, 80);
            this.buttonEditNode.Name = "buttonEditNode";
            this.buttonEditNode.Size = new System.Drawing.Size(125, 36);
            this.buttonEditNode.TabIndex = 2;
            this.buttonEditNode.Text = "Edit Dialogue Node";
            this.buttonEditNode.UseVisualStyleBackColor = true;
            this.buttonEditNode.Click += new System.EventHandler(this.buttonEditNode_Click);
            // 
            // buttonSaveDialogue
            // 
            this.buttonSaveDialogue.Location = new System.Drawing.Point(11, 122);
            this.buttonSaveDialogue.Name = "buttonSaveDialogue";
            this.buttonSaveDialogue.Size = new System.Drawing.Size(170, 36);
            this.buttonSaveDialogue.TabIndex = 1;
            this.buttonSaveDialogue.Text = "Save Dialogue";
            this.buttonSaveDialogue.UseVisualStyleBackColor = true;
            this.buttonSaveDialogue.Click += new System.EventHandler(this.buttonSaveDialogue_Click);
            // 
            // buttonCreateDialogueNode
            // 
            this.buttonCreateDialogueNode.Location = new System.Drawing.Point(11, 38);
            this.buttonCreateDialogueNode.Name = "buttonCreateDialogueNode";
            this.buttonCreateDialogueNode.Size = new System.Drawing.Size(170, 36);
            this.buttonCreateDialogueNode.TabIndex = 0;
            this.buttonCreateDialogueNode.Text = "Create Dialogue Node";
            this.buttonCreateDialogueNode.UseVisualStyleBackColor = true;
            this.buttonCreateDialogueNode.Click += new System.EventHandler(this.buttonCreateDialogueNode_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonSaveName);
            this.groupBox1.Controls.Add(this.labelNumberofNodes);
            this.groupBox1.Controls.Add(this.textBoxDialogueName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 138);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Main Information";
            // 
            // buttonSaveName
            // 
            this.buttonSaveName.Location = new System.Drawing.Point(11, 57);
            this.buttonSaveName.Name = "buttonSaveName";
            this.buttonSaveName.Size = new System.Drawing.Size(170, 23);
            this.buttonSaveName.TabIndex = 4;
            this.buttonSaveName.Text = "Save Name";
            this.buttonSaveName.UseVisualStyleBackColor = true;
            this.buttonSaveName.Click += new System.EventHandler(this.buttonSaveName_Click);
            // 
            // labelNumberofNodes
            // 
            this.labelNumberofNodes.AutoSize = true;
            this.labelNumberofNodes.Location = new System.Drawing.Point(55, 97);
            this.labelNumberofNodes.Name = "labelNumberofNodes";
            this.labelNumberofNodes.Size = new System.Drawing.Size(97, 13);
            this.labelNumberofNodes.TabIndex = 3;
            this.labelNumberofNodes.Text = "labelNumberNodes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nodes:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // textBoxDialogueName
            // 
            this.textBoxDialogueName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.textBoxDialogueName.Location = new System.Drawing.Point(52, 21);
            this.textBoxDialogueName.Name = "textBoxDialogueName";
            this.textBoxDialogueName.Size = new System.Drawing.Size(129, 20);
            this.textBoxDialogueName.TabIndex = 1;
            this.textBoxDialogueName.WaterMarkColor = System.Drawing.Color.Gray;
            this.textBoxDialogueName.WaterMarkText = "Introduce a name";
            this.textBoxDialogueName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxDialogueName_KeyUp);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 418);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "MainScreen";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dialogue Editor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainScreen_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.mainPanel.ResumeLayout(false);
            this.dialogueNodeBox.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericSelectedNode)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zenoreGameStudiosToolStripMenuItem;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem programToolStripMenuItem;
        private WaterMarkTextBox textBoxDialogueName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox dialogueNodeBox;
        private System.Windows.Forms.Button buttonCreateDialogueNode;
        private System.Windows.Forms.FlowLayoutPanel panelDialogueNodes;
        private System.Windows.Forms.Label labelNumberofNodes;
        private System.Windows.Forms.Button buttonSaveDialogue;
        private System.Windows.Forms.Button buttonSaveName;
        private System.Windows.Forms.Button buttonEditNode;
        private System.Windows.Forms.NumericUpDown numericSelectedNode;
    }
}

