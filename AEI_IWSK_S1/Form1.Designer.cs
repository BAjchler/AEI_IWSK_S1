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
            statusStrip1 = new StatusStrip();
            groupBox1 = new GroupBox();
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
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            button5 = new Button();
            label6 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            menuStrip1.SuspendLayout();
            manualControlGroupBox.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
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
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(label2);
            groupBox3.Enabled = false;
            groupBox3.Location = new Point(179, 317);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(152, 100);
            groupBox3.TabIndex = 11;
            groupBox3.TabStop = false;
            groupBox3.Text = "Monitoring wejść";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(86, 46);
            label5.Name = "label5";
            label5.Size = new Size(37, 15);
            label5.TabIndex = 3;
            label5.Text = "niskie";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(86, 22);
            label4.Name = "label4";
            label4.Size = new Size(37, 15);
            label4.TabIndex = 2;
            label4.Text = "niskie";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 46);
            label3.Name = "label3";
            label3.Size = new Size(73, 15);
            label3.TabIndex = 1;
            label3.Text = "Wejście CTS:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 22);
            label2.Name = "label2";
            label2.Size = new Size(74, 15);
            label2.TabIndex = 0;
            label2.Text = "Wejście DSR:";
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
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(93, 292);
            label6.Name = "label6";
            label6.Size = new Size(0, 15);
            label6.TabIndex = 13;
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
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button button5;
        private Label label6;
    }
}