namespace Sequencer
{
    partial class SequenceBlocks
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
            ListViewItem listViewItem1 = new ListViewItem("");
            BeatGrid = new TableLayoutPanel();
            groupBox1 = new GroupBox();
            menuStrip1 = new MenuStrip();
            toolStripComboBox1 = new ToolStripComboBox();
            clearButton = new ToolStripMenuItem();
            comboBox1 = new ComboBox();
            listView1 = new ListView();
            button1 = new Button();
            button2 = new Button();
            groupBox1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // BeatGrid
            // 
            BeatGrid.AutoSize = true;
            BeatGrid.BackColor = SystemColors.ActiveCaptionText;
            BeatGrid.BackgroundImageLayout = ImageLayout.None;
            BeatGrid.CellBorderStyle = TableLayoutPanelCellBorderStyle.Inset;
            BeatGrid.ColumnCount = 1;
            BeatGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            BeatGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            BeatGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            BeatGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            BeatGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            BeatGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            BeatGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            BeatGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            BeatGrid.Dock = DockStyle.Fill;
            BeatGrid.Location = new Point(3, 64);
            BeatGrid.Name = "BeatGrid";
            BeatGrid.RowCount = 1;
            BeatGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            BeatGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            BeatGrid.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            BeatGrid.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            BeatGrid.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            BeatGrid.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            BeatGrid.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            BeatGrid.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            BeatGrid.Size = new Size(994, 533);
            BeatGrid.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ActiveCaptionText;
            groupBox1.Controls.Add(BeatGrid);
            groupBox1.Controls.Add(menuStrip1);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.FlatStyle = FlatStyle.Popup;
            groupBox1.Location = new Point(0, 0);
            groupBox1.MaximumSize = new Size(1000, 600);
            groupBox1.MinimumSize = new Size(1000, 600);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1000, 600);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.ControlDarkDark;
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripComboBox1, clearButton });
            menuStrip1.Location = new Point(3, 27);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(994, 37);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripComboBox1
            // 
            toolStripComboBox1.AccessibleRole = AccessibleRole.ButtonDropDownGrid;
            toolStripComboBox1.BackColor = SystemColors.ControlDarkDark;
            toolStripComboBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            toolStripComboBox1.Items.AddRange(new object[] { "Sequence", "Velocity", "Sustain" });
            toolStripComboBox1.Name = "toolStripComboBox1";
            toolStripComboBox1.Size = new Size(95, 33);
            toolStripComboBox1.Text = "Options";
            // 
            // clearButton
            // 
            clearButton.BackColor = Color.Red;
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(67, 33);
            clearButton.Text = "Clear";
            clearButton.Click += ClearButton_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(1128, 12);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(182, 33);
            comboBox1.TabIndex = 0;
            // 
            // listView1
            // 
            listView1.Items.AddRange(new ListViewItem[] { listViewItem1 });
            listView1.Location = new Point(1128, 64);
            listView1.Name = "listView1";
            listView1.Size = new Size(182, 146);
            listView1.TabIndex = 3;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // button1
            // 
            button1.Location = new Point(1010, 64);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 6;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(1010, 104);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 7;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // SequenceBlocks
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1322, 707);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(listView1);
            Controls.Add(comboBox1);
            Controls.Add(groupBox1);
            DoubleBuffered = true;
            ForeColor = SystemColors.Control;
            MainMenuStrip = menuStrip1;
            Name = "SequenceBlocks";
            Text = "SequenceBlocks";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel BeatGrid;
        private GroupBox groupBox1;
        private ComboBox comboBox1;
        private MenuStrip menuStrip1;
        private ListView listView1;
        private ToolStripComboBox toolStripComboBox1;
        private ToolStripMenuItem clearButton;
        private Label label1;
        private Button button1;
        private Button button2;
    }
}