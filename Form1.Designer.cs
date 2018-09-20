namespace CLICKER2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.listView1 = new System.Windows.Forms.ListView();
            this.counterCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.actionCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.xCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.yCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.delayCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.repeatCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.noteCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colorCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.xBox = new System.Windows.Forms.TextBox();
            this.yBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.delayBox = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.noteBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.repeatBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.addActionHotkey = new System.Windows.Forms.TextBox();
            this.assignActionHotkey = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.startStopBox = new System.Windows.Forms.TextBox();
            this.assignStartStop = new System.Windows.Forms.Button();
            this.startStopButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.removeActionButton = new System.Windows.Forms.Button();
            this.moveActionUp = new System.Windows.Forms.Button();
            this.moveActionDown = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openScriptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.counterCol,
            this.actionCol,
            this.xCol,
            this.yCol,
            this.delayCol,
            this.repeatCol,
            this.noteCol,
            this.colorCol});
            this.listView1.FullRowSelect = true;
            this.listView1.Location = new System.Drawing.Point(465, 43);
            this.listView1.Margin = new System.Windows.Forms.Padding(2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(584, 421);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            // 
            // counterCol
            // 
            this.counterCol.Text = "#";
            this.counterCol.Width = 20;
            // 
            // actionCol
            // 
            this.actionCol.Text = "Action";
            this.actionCol.Width = 125;
            // 
            // xCol
            // 
            this.xCol.Text = "X";
            this.xCol.Width = 45;
            // 
            // yCol
            // 
            this.yCol.Text = "Y";
            this.yCol.Width = 45;
            // 
            // delayCol
            // 
            this.delayCol.Text = "Delay (ms)";
            this.delayCol.Width = 80;
            // 
            // repeatCol
            // 
            this.repeatCol.Text = "Repeat";
            this.repeatCol.Width = 40;
            // 
            // noteCol
            // 
            this.noteCol.Text = "Note";
            this.noteCol.Width = 230;
            // 
            // colorCol
            // 
            this.colorCol.Width = 0;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(16, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Action";
            this.label1.UseMnemonic = false;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // xBox
            // 
            this.xBox.AccessibleName = "xBox";
            this.xBox.Location = new System.Drawing.Point(89, 57);
            this.xBox.Margin = new System.Windows.Forms.Padding(2);
            this.xBox.Name = "xBox";
            this.xBox.Size = new System.Drawing.Size(41, 20);
            this.xBox.TabIndex = 3;
            this.xBox.TextChanged += new System.EventHandler(this.xBox_TextChanged);
            // 
            // yBox
            // 
            this.yBox.AccessibleName = "yBox";
            this.yBox.Location = new System.Drawing.Point(211, 57);
            this.yBox.Margin = new System.Windows.Forms.Padding(2);
            this.yBox.Name = "yBox";
            this.yBox.Size = new System.Drawing.Size(41, 20);
            this.yBox.TabIndex = 4;
            this.yBox.TextChanged += new System.EventHandler(this.yBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 59);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "X-Coordinate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(140, 59);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Y-Coordinate";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 87);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Delay (ms)";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // delayBox
            // 
            this.delayBox.AccessibleName = "yBox";
            this.delayBox.Location = new System.Drawing.Point(89, 85);
            this.delayBox.Margin = new System.Windows.Forms.Padding(2);
            this.delayBox.Name = "delayBox";
            this.delayBox.Size = new System.Drawing.Size(163, 20);
            this.delayBox.TabIndex = 9;
            this.delayBox.TextChanged += new System.EventHandler(this.delayBox_TextChanged);
            this.delayBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.delayBox_KeyPress);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Left Click",
            "Right Click",
            "Double Click",
            "CTRL+F",
            "CTRL+S",
            "CTRL+C",
            "CTRL+V",
            "CTRL+A",
            "Press Esc",
            "Press Tab",
            "Press Enter",
            "Press Tab",
            "Press Backspace",
            "Left Arrow",
            "Right Arrow",
            "Up Arrow",
            "Down Arrow",
            "Wait For Pixel",
            "Type Note",
            "Read From File"});
            this.comboBox1.Location = new System.Drawing.Point(89, 26);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(163, 21);
            this.comboBox1.TabIndex = 10;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox1.TextChanged += new System.EventHandler(this.comboBox1_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 113);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Note";
            // 
            // noteBox
            // 
            this.noteBox.Location = new System.Drawing.Point(89, 111);
            this.noteBox.Margin = new System.Windows.Forms.Padding(2);
            this.noteBox.Name = "noteBox";
            this.noteBox.Size = new System.Drawing.Size(286, 20);
            this.noteBox.TabIndex = 12;
            this.noteBox.TextChanged += new System.EventHandler(this.noteBox_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.repeatBox);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.delayBox);
            this.groupBox1.Controls.Add(this.noteBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.xBox);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.yBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(16, 43);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(386, 159);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add/Edit Item";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter_1);
            // 
            // repeatBox
            // 
            this.repeatBox.Location = new System.Drawing.Point(311, 85);
            this.repeatBox.Margin = new System.Windows.Forms.Padding(2);
            this.repeatBox.Name = "repeatBox";
            this.repeatBox.Size = new System.Drawing.Size(63, 20);
            this.repeatBox.TabIndex = 26;
            this.repeatBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.delayBox_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(266, 87);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Repeat";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 30);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Add Action Shortcut";
            // 
            // addActionHotkey
            // 
            this.addActionHotkey.Location = new System.Drawing.Point(126, 30);
            this.addActionHotkey.Margin = new System.Windows.Forms.Padding(2);
            this.addActionHotkey.Name = "addActionHotkey";
            this.addActionHotkey.Size = new System.Drawing.Size(65, 20);
            this.addActionHotkey.TabIndex = 15;
            this.addActionHotkey.TextChanged += new System.EventHandler(this.addActionHotkey_TextChanged);
            this.addActionHotkey.KeyDown += new System.Windows.Forms.KeyEventHandler(this.addActionHotkey_KeyDown);
            // 
            // assignActionHotkey
            // 
            this.assignActionHotkey.Location = new System.Drawing.Point(200, 23);
            this.assignActionHotkey.Margin = new System.Windows.Forms.Padding(2);
            this.assignActionHotkey.Name = "assignActionHotkey";
            this.assignActionHotkey.Size = new System.Drawing.Size(50, 27);
            this.assignActionHotkey.TabIndex = 16;
            this.assignActionHotkey.Text = "Assign";
            this.assignActionHotkey.UseVisualStyleBackColor = true;
            this.assignActionHotkey.Click += new System.EventHandler(this.assignActionHotkey_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 67);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Start/Stop Script";
            // 
            // startStopBox
            // 
            this.startStopBox.Location = new System.Drawing.Point(126, 67);
            this.startStopBox.Margin = new System.Windows.Forms.Padding(2);
            this.startStopBox.Name = "startStopBox";
            this.startStopBox.Size = new System.Drawing.Size(65, 20);
            this.startStopBox.TabIndex = 18;
            this.startStopBox.TextChanged += new System.EventHandler(this.startStopBox_TextChanged_1);
            this.startStopBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.startStopBox_KeyDown);
            // 
            // assignStartStop
            // 
            this.assignStartStop.Location = new System.Drawing.Point(200, 62);
            this.assignStartStop.Margin = new System.Windows.Forms.Padding(2);
            this.assignStartStop.Name = "assignStartStop";
            this.assignStartStop.Size = new System.Drawing.Size(50, 27);
            this.assignStartStop.TabIndex = 19;
            this.assignStartStop.Text = "Assign";
            this.assignStartStop.UseVisualStyleBackColor = true;
            this.assignStartStop.Click += new System.EventHandler(this.assignStartStop_Click_1);
            // 
            // startStopButton
            // 
            this.startStopButton.Location = new System.Drawing.Point(16, 384);
            this.startStopButton.Margin = new System.Windows.Forms.Padding(2);
            this.startStopButton.Name = "startStopButton";
            this.startStopButton.Size = new System.Drawing.Size(190, 79);
            this.startStopButton.TabIndex = 20;
            this.startStopButton.Text = "Start / Stop Script";
            this.startStopButton.UseVisualStyleBackColor = true;
            this.startStopButton.Click += new System.EventHandler(this.startStopButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.assignActionHotkey);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.assignStartStop);
            this.groupBox2.Controls.Add(this.addActionHotkey);
            this.groupBox2.Controls.Add(this.startStopBox);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(16, 220);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(386, 119);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Shortcuts";
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            // 
            // removeActionButton
            // 
            this.removeActionButton.Location = new System.Drawing.Point(333, 375);
            this.removeActionButton.Margin = new System.Windows.Forms.Padding(2);
            this.removeActionButton.Name = "removeActionButton";
            this.removeActionButton.Size = new System.Drawing.Size(83, 88);
            this.removeActionButton.TabIndex = 22;
            this.removeActionButton.Text = "Remove Action";
            this.removeActionButton.UseVisualStyleBackColor = true;
            this.removeActionButton.Click += new System.EventHandler(this.removeActionButton_Click);
            // 
            // moveActionUp
            // 
            this.moveActionUp.Location = new System.Drawing.Point(435, 375);
            this.moveActionUp.Margin = new System.Windows.Forms.Padding(2);
            this.moveActionUp.Name = "moveActionUp";
            this.moveActionUp.Size = new System.Drawing.Size(27, 38);
            this.moveActionUp.TabIndex = 23;
            this.moveActionUp.Text = "▲";
            this.moveActionUp.UseVisualStyleBackColor = true;
            this.moveActionUp.Click += new System.EventHandler(this.moveActionUp_Click);
            // 
            // moveActionDown
            // 
            this.moveActionDown.Location = new System.Drawing.Point(435, 426);
            this.moveActionDown.Margin = new System.Windows.Forms.Padding(2);
            this.moveActionDown.Name = "moveActionDown";
            this.moveActionDown.Size = new System.Drawing.Size(27, 37);
            this.moveActionDown.TabIndex = 24;
            this.moveActionDown.Text = "▼";
            this.moveActionDown.UseVisualStyleBackColor = true;
            this.moveActionDown.Click += new System.EventHandler(this.moveActionDown_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(1104, 24);
            this.menuStrip1.TabIndex = 25;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.openScriptToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 22);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // openScriptToolStripMenuItem
            // 
            this.openScriptToolStripMenuItem.Name = "openScriptToolStripMenuItem";
            this.openScriptToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.openScriptToolStripMenuItem.Text = "Open Script";
            this.openScriptToolStripMenuItem.Click += new System.EventHandler(this.openScriptToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 22);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 22);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 22);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1104, 519);
            this.Controls.Add(this.moveActionDown);
            this.Controls.Add(this.moveActionUp);
            this.Controls.Add(this.removeActionButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.startStopButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.menuStrip1);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "SmartMacro v1.0 (beta)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColumnHeader xCol;
        private System.Windows.Forms.ColumnHeader yCol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox xBox;
        private System.Windows.Forms.TextBox yBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox delayBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ColumnHeader delayCol;
        private System.Windows.Forms.ColumnHeader counterCol;
        private System.Windows.Forms.ColumnHeader actionCol;
        private System.Windows.Forms.ColumnHeader noteCol;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox noteBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox addActionHotkey;
        private System.Windows.Forms.Button assignActionHotkey;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox startStopBox;
        private System.Windows.Forms.Button assignStartStop;
        private System.Windows.Forms.Button startStopButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button removeActionButton;
        private System.Windows.Forms.Button moveActionUp;
        private System.Windows.Forms.Button moveActionDown;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openScriptToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TextBox repeatBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ColumnHeader repeatCol;
        public System.Windows.Forms.ListView listView1;
        public System.Windows.Forms.ColumnHeader colorCol;
    }
}

