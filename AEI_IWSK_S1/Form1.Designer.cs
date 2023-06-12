namespace AEI_IWSK_S1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button5 = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.połączenieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ustawieniaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wyjścieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oProgramieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.twórcyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.connectionInfoLabel = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.manualControlGroupBox = new System.Windows.Forms.GroupBox();
            this.rtsEnableCheckBox = new System.Windows.Forms.CheckBox();
            this.dtrEnableCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ctsState = new System.Windows.Forms.Label();
            this.dsrState = new System.Windows.Forms.Label();
            this.ctsLabel = new System.Windows.Forms.Label();
            this.dsrLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.manualControlGroupBox.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            statusStrip1.Location = new Point(0, 428);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 22);
            statusStrip1.TabIndex = 0;
            statusStrip1.Text = "statusStrip1";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox1);
            groupBox1.Location = new Point(12, 27);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(359, 255);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Nadawanie";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(0, 22);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(359, 233);
            textBox1.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBox2);
            groupBox2.Location = new Point(393, 27);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(395, 255);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Odbiór";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(0, 22);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(395, 233);
            textBox2.TabIndex = 1;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { połączenieToolStripMenuItem, oProgramieToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // połączenieToolStripMenuItem
            // 
            połączenieToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ustawieniaToolStripMenuItem, wyjścieToolStripMenuItem });
            połączenieToolStripMenuItem.Name = "połączenieToolStripMenuItem";
            połączenieToolStripMenuItem.Size = new Size(75, 20);
            połączenieToolStripMenuItem.Text = "Połączenie";
            // 
            // ustawieniaToolStripMenuItem
            // 
            ustawieniaToolStripMenuItem.Name = "ustawieniaToolStripMenuItem";
            ustawieniaToolStripMenuItem.Size = new Size(140, 22);
            ustawieniaToolStripMenuItem.Text = "Ustawienia...";
            ustawieniaToolStripMenuItem.Click += ustawieniaToolStripMenuItem_Click;
            // 
            // wyjścieToolStripMenuItem
            // 
            wyjścieToolStripMenuItem.Name = "wyjścieToolStripMenuItem";
            wyjścieToolStripMenuItem.Size = new Size(140, 22);
            wyjścieToolStripMenuItem.Text = "Wyjście";
            wyjścieToolStripMenuItem.Click += wyjścieToolStripMenuItem_Click;
            // 
            // oProgramieToolStripMenuItem
            // 
            oProgramieToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { twórcyToolStripMenuItem });
            oProgramieToolStripMenuItem.Name = "oProgramieToolStripMenuItem";
            oProgramieToolStripMenuItem.Size = new Size(86, 20);
            oProgramieToolStripMenuItem.Text = "O programie";
            // 
            // twórcyToolStripMenuItem
            // 
            twórcyToolStripMenuItem.Name = "twórcyToolStripMenuItem";
            twórcyToolStripMenuItem.Size = new Size(111, 22);
            twórcyToolStripMenuItem.Text = "Twórcy";
            twórcyToolStripMenuItem.Click += twórcyToolStripMenuItem_Click;
            // 
            // button1
            // 
            button1.Location = new Point(663, 402);
            button1.Name = "button1";
            button1.Size = new Size(125, 23);
            button1.TabIndex = 4;
            button1.Text = "Ustal połączenie";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(296, 288);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 5;
            button2.Text = "Wyślij";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // connectionInfoLabel
            // 
            connectionInfoLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            connectionInfoLabel.AutoSize = true;
            connectionInfoLabel.ForeColor = Color.Red;
            connectionInfoLabel.Location = new Point(532, 384);
            connectionInfoLabel.Name = "connectionInfoLabel";
            connectionInfoLabel.Size = new Size(134, 15);
            connectionInfoLabel.TabIndex = 6;
            connectionInfoLabel.Text = "Brak definicji połączenia";
            connectionInfoLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button3
            // 
            button3.Location = new Point(532, 402);
            button3.Name = "button3";
            button3.Size = new Size(125, 23);
            button3.TabIndex = 7;
            button3.Text = "Otwórz połączenie";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(401, 402);
            button4.Name = "button4";
            button4.Size = new Size(125, 23);
            button4.TabIndex = 8;
            button4.Text = "Zamknij połączenie";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(549, 369);
            label1.Name = "label1";
            label1.Size = new Size(92, 15);
            label1.TabIndex = 9;
            label1.Text = "Stan połączenia:";
            // 
            // manualControlGroupBox
            // 
            manualControlGroupBox.Controls.Add(rtsEnableCheckBox);
            manualControlGroupBox.Controls.Add(dtrEnableCheckBox);
            manualControlGroupBox.Enabled = false;
            manualControlGroupBox.Location = new Point(12, 316);
            manualControlGroupBox.Name = "manualControlGroupBox";
            manualControlGroupBox.Size = new Size(152, 100);
            manualControlGroupBox.TabIndex = 10;
            manualControlGroupBox.TabStop = false;
            manualControlGroupBox.Text = "Kontrola ręczna";
            // 
            // rtsEnableCheckBox
            // 
            rtsEnableCheckBox.AutoSize = true;
            rtsEnableCheckBox.Location = new Point(12, 47);
            rtsEnableCheckBox.Name = "rtsEnableCheckBox";
            rtsEnableCheckBox.Size = new Size(82, 19);
            rtsEnableCheckBox.TabIndex = 1;
            rtsEnableCheckBox.Text = "RTS Enable";
            rtsEnableCheckBox.UseVisualStyleBackColor = true;
            // 
            // dtrEnableCheckBox
            // 
            dtrEnableCheckBox.AutoSize = true;
            dtrEnableCheckBox.Location = new Point(12, 22);
            dtrEnableCheckBox.Name = "dtrEnableCheckBox";
            dtrEnableCheckBox.Size = new Size(84, 19);
            dtrEnableCheckBox.TabIndex = 0;
            dtrEnableCheckBox.Text = "DTR Enable";
            dtrEnableCheckBox.UseVisualStyleBackColor = true;
            dtrEnableCheckBox.CheckedChanged += dtrEnableCheckBox_CheckedChanged;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ctsState);
            this.groupBox3.Controls.Add(this.dsrState);
            this.groupBox3.Controls.Add(this.ctsLabel);
            this.groupBox3.Controls.Add(this.dsrLabel);
            this.groupBox3.Location = new System.Drawing.Point(179, 317);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(152, 100);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Monitoring wejść";
            // 
            // ctsState
            // 
            this.ctsState.AutoSize = true;
            this.ctsState.Location = new System.Drawing.Point(86, 46);
            this.ctsState.Name = "ctsState";
            this.ctsState.Size = new System.Drawing.Size(39, 15);
            this.ctsState.TabIndex = 3;
            this.ctsState.Text = "Niskie";
            
            //
            // button5
            //
            button5.Location = new Point(215, 288);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 12;
            button5.Text = "Ping";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;

            // 
            // dsrState
            // 
            this.dsrState.AutoSize = true;
            this.dsrState.Location = new System.Drawing.Point(86, 22);
            this.dsrState.Name = "dsrState";
            this.dsrState.Size = new System.Drawing.Size(39, 15);
            this.dsrState.TabIndex = 2;
            this.dsrState.Text = "Niskie";
            // 
            // ctsLabel
            // 
            this.ctsLabel.AutoSize = true;
            this.ctsLabel.Location = new System.Drawing.Point(6, 46);
            this.ctsLabel.Name = "ctsLabel";
            this.ctsLabel.Size = new System.Drawing.Size(73, 15);
            this.ctsLabel.TabIndex = 1;
            this.ctsLabel.Text = "Wejście CTS:";
            // 
            // dsrLabel
            // 
            this.dsrLabel.AutoSize = true;
            this.dsrLabel.Location = new System.Drawing.Point(6, 22);
            this.dsrLabel.Name = "dsrLabel";
            this.dsrLabel.Size = new System.Drawing.Size(74, 15);
            this.dsrLabel.TabIndex = 0;
            this.dsrLabel.Text = "Wejście DSR:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(button5);
            Controls.Add(groupBox3);
            Controls.Add(manualControlGroupBox);
            Controls.Add(label1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(connectionInfoLabel);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Kontrola komunikacyjna na porcie znakowym";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            manualControlGroupBox.ResumeLayout(false);
            manualControlGroupBox.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private StatusStrip statusStrip1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem połączenieToolStripMenuItem;
        private ToolStripMenuItem ustawieniaToolStripMenuItem;
        private ToolStripMenuItem oProgramieToolStripMenuItem;
        private ToolStripMenuItem twórcyToolStripMenuItem;
        private ToolStripMenuItem wyjścieToolStripMenuItem;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private Button button2;
        private Label connectionInfoLabel;
        private Button button3;
        private Button button4;
        private Label label1;
        private GroupBox manualControlGroupBox;
        private CheckBox rtsEnableCheckBox;
        private CheckBox dtrEnableCheckBox;
        private GroupBox groupBox3;
        private Button button5;
        private Label ctsState;
        private Label dsrState;
        private Label ctsLabel;
        private Label dsrLabel;
    }
}