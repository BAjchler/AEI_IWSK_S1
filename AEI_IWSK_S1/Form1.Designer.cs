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
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(359, 255);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nadawanie";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(0, 22);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(359, 233);
            this.textBox1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Location = new System.Drawing.Point(393, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(395, 255);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Odbiór";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(0, 22);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(395, 233);
            this.textBox2.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.połączenieToolStripMenuItem,
            this.oProgramieToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // połączenieToolStripMenuItem
            // 
            this.połączenieToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ustawieniaToolStripMenuItem,
            this.wyjścieToolStripMenuItem});
            this.połączenieToolStripMenuItem.Name = "połączenieToolStripMenuItem";
            this.połączenieToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.połączenieToolStripMenuItem.Text = "Połączenie";
            // 
            // ustawieniaToolStripMenuItem
            // 
            this.ustawieniaToolStripMenuItem.Name = "ustawieniaToolStripMenuItem";
            this.ustawieniaToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.ustawieniaToolStripMenuItem.Text = "Ustawienia...";
            this.ustawieniaToolStripMenuItem.Click += new System.EventHandler(this.ustawieniaToolStripMenuItem_Click);
            // 
            // wyjścieToolStripMenuItem
            // 
            this.wyjścieToolStripMenuItem.Name = "wyjścieToolStripMenuItem";
            this.wyjścieToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.wyjścieToolStripMenuItem.Text = "Wyjście";
            this.wyjścieToolStripMenuItem.Click += new System.EventHandler(this.wyjścieToolStripMenuItem_Click);
            // 
            // oProgramieToolStripMenuItem
            // 
            this.oProgramieToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.twórcyToolStripMenuItem});
            this.oProgramieToolStripMenuItem.Name = "oProgramieToolStripMenuItem";
            this.oProgramieToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.oProgramieToolStripMenuItem.Text = "O programie";
            // 
            // twórcyToolStripMenuItem
            // 
            this.twórcyToolStripMenuItem.Name = "twórcyToolStripMenuItem";
            this.twórcyToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.twórcyToolStripMenuItem.Text = "Twórcy";
            this.twórcyToolStripMenuItem.Click += new System.EventHandler(this.twórcyToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(663, 402);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Ustal połączenie";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(296, 288);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Wyślij";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // connectionInfoLabel
            // 
            this.connectionInfoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.connectionInfoLabel.AutoSize = true;
            this.connectionInfoLabel.ForeColor = System.Drawing.Color.Red;
            this.connectionInfoLabel.Location = new System.Drawing.Point(532, 384);
            this.connectionInfoLabel.Name = "connectionInfoLabel";
            this.connectionInfoLabel.Size = new System.Drawing.Size(134, 15);
            this.connectionInfoLabel.TabIndex = 6;
            this.connectionInfoLabel.Text = "Brak definicji połączenia";
            this.connectionInfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(532, 402);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(125, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "Otwórz połączenie";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(401, 402);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(125, 23);
            this.button4.TabIndex = 8;
            this.button4.Text = "Zamknij połączenie";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(549, 369);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Stan połączenia:";
            // 
            // manualControlGroupBox
            // 
            this.manualControlGroupBox.Controls.Add(this.rtsEnableCheckBox);
            this.manualControlGroupBox.Controls.Add(this.dtrEnableCheckBox);
            this.manualControlGroupBox.Enabled = false;
            this.manualControlGroupBox.Location = new System.Drawing.Point(12, 316);
            this.manualControlGroupBox.Name = "manualControlGroupBox";
            this.manualControlGroupBox.Size = new System.Drawing.Size(152, 100);
            this.manualControlGroupBox.TabIndex = 10;
            this.manualControlGroupBox.TabStop = false;
            this.manualControlGroupBox.Text = "Kontrola ręczna";
            // 
            // rtsEnableCheckBox
            // 
            this.rtsEnableCheckBox.AutoSize = true;
            this.rtsEnableCheckBox.Location = new System.Drawing.Point(12, 47);
            this.rtsEnableCheckBox.Name = "rtsEnableCheckBox";
            this.rtsEnableCheckBox.Size = new System.Drawing.Size(82, 19);
            this.rtsEnableCheckBox.TabIndex = 1;
            this.rtsEnableCheckBox.Text = "RTS Enable";
            this.rtsEnableCheckBox.UseVisualStyleBackColor = true;
            // 
            // dtrEnableCheckBox
            // 
            this.dtrEnableCheckBox.AutoSize = true;
            this.dtrEnableCheckBox.Location = new System.Drawing.Point(12, 22);
            this.dtrEnableCheckBox.Name = "dtrEnableCheckBox";
            this.dtrEnableCheckBox.Size = new System.Drawing.Size(84, 19);
            this.dtrEnableCheckBox.TabIndex = 0;
            this.dtrEnableCheckBox.Text = "DTR Enable";
            this.dtrEnableCheckBox.UseVisualStyleBackColor = true;
            this.dtrEnableCheckBox.CheckedChanged += new System.EventHandler(this.dtrEnableCheckBox_CheckedChanged);
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.manualControlGroupBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.connectionInfoLabel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Kontrola komunikacyjna na porcie znakowym";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.manualControlGroupBox.ResumeLayout(false);
            this.manualControlGroupBox.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private Label ctsState;
        private Label dsrState;
        private Label ctsLabel;
        private Label dsrLabel;
    }
}