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
            button5 = new Button();
            statusStrip1 = new StatusStrip();
            groupBox1 = new GroupBox();
            textBox3 = new TextBox();
            textBox1 = new TextBox();
            groupBox2 = new GroupBox();
            textBox2 = new TextBox();
            menuStrip1 = new MenuStrip();
            połączenieToolStripMenuItem = new ToolStripMenuItem();
            ustawieniaToolStripMenuItem = new ToolStripMenuItem();
            wyjścieToolStripMenuItem = new ToolStripMenuItem();
            oProgramieToolStripMenuItem = new ToolStripMenuItem();
            twórcyToolStripMenuItem = new ToolStripMenuItem();
            button1 = new Button();
            button2 = new Button();
            connectionInfoLabel = new Label();
            button3 = new Button();
            button4 = new Button();
            label1 = new Label();
            manualControlGroupBox = new GroupBox();
            rtsEnableCheckBox = new CheckBox();
            dtrEnableCheckBox = new CheckBox();
            groupBox3 = new GroupBox();
            ctsState = new Label();
            dsrState = new Label();
            ctsLabel = new Label();
            dsrLabel = new Label();
            button6 = new Button();
            textBox4 = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            menuStrip1.SuspendLayout();
            manualControlGroupBox.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // button5
            // 
            button5.Location = new Point(305, 288);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 12;
            button5.Text = "Ping";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.Location = new Point(0, 428);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1230, 22);
            statusStrip1.TabIndex = 0;
            statusStrip1.Text = "statusStrip1";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Location = new Point(12, 27);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(572, 255);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Nadawanie";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(12, 16);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(327, 233);
            textBox3.TabIndex = 1;
            textBox3.TextChanged += textBox3_TextChanged;
            textBox3.KeyPress += textBox3_KeyPress;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(345, 16);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(218, 233);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBox4);
            groupBox2.Controls.Add(textBox2);
            groupBox2.Location = new Point(593, 25);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(625, 255);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Odbiór";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(370, 16);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(249, 233);
            textBox2.TabIndex = 1;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { połączenieToolStripMenuItem, oProgramieToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1230, 24);
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
            button1.Location = new Point(863, 400);
            button1.Name = "button1";
            button1.Size = new Size(125, 23);
            button1.TabIndex = 4;
            button1.Text = "Ustal połączenie";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(386, 288);
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
            connectionInfoLabel.Location = new Point(732, 382);
            connectionInfoLabel.Name = "connectionInfoLabel";
            connectionInfoLabel.Size = new Size(134, 15);
            connectionInfoLabel.TabIndex = 6;
            connectionInfoLabel.Text = "Brak definicji połączenia";
            connectionInfoLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button3
            // 
            button3.Location = new Point(732, 400);
            button3.Name = "button3";
            button3.Size = new Size(125, 23);
            button3.TabIndex = 7;
            button3.Text = "Otwórz połączenie";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(601, 400);
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
            label1.Location = new Point(749, 367);
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
            groupBox3.Controls.Add(ctsState);
            groupBox3.Controls.Add(dsrState);
            groupBox3.Controls.Add(ctsLabel);
            groupBox3.Controls.Add(dsrLabel);
            groupBox3.Location = new Point(179, 317);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(152, 100);
            groupBox3.TabIndex = 11;
            groupBox3.TabStop = false;
            groupBox3.Text = "Monitoring wejść";
            // 
            // ctsState
            // 
            ctsState.AutoSize = true;
            ctsState.Location = new Point(86, 46);
            ctsState.Name = "ctsState";
            ctsState.Size = new Size(39, 15);
            ctsState.TabIndex = 3;
            ctsState.Text = "Niskie";
            // 
            // dsrState
            // 
            dsrState.AutoSize = true;
            dsrState.Location = new Point(86, 22);
            dsrState.Name = "dsrState";
            dsrState.Size = new Size(39, 15);
            dsrState.TabIndex = 2;
            dsrState.Text = "Niskie";
            // 
            // ctsLabel
            // 
            ctsLabel.AutoSize = true;
            ctsLabel.Location = new Point(6, 46);
            ctsLabel.Name = "ctsLabel";
            ctsLabel.Size = new Size(73, 15);
            ctsLabel.TabIndex = 1;
            ctsLabel.Text = "Wejście CTS:";
            // 
            // dsrLabel
            // 
            dsrLabel.AutoSize = true;
            dsrLabel.Location = new Point(6, 22);
            dsrLabel.Name = "dsrLabel";
            dsrLabel.Size = new Size(74, 15);
            dsrLabel.TabIndex = 0;
            dsrLabel.Text = "Wejście DSR:";
            // 
            // button6
            // 
            button6.Location = new Point(82, 288);
            button6.Name = "button6";
            button6.Size = new Size(105, 23);
            button6.TabIndex = 13;
            button6.Text = "Load file";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(8, 18);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(356, 233);
            textBox4.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1230, 450);
            Controls.Add(button6);
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
        private TextBox textBox3;
        private Button button6;
        private TextBox textBox4;
    }
}