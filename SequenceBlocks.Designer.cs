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
            BeatGrid = new TableLayoutPanel();
            groupBox1 = new GroupBox();
            comboBox1 = new ComboBox();
            button2 = new Button();
            beatsSetter = new NumericUpDown();
            reMapGroupBox = new GroupBox();
            label3 = new Label();
            positionLabel = new Label();
            numericUpDown2 = new NumericUpDown();
            positionSetter = new NumericUpDown();
            reMapUpdateButton = new Button();
            label1 = new Label();
            testButton = new Button();
            toolStrip1 = new ToolStrip();
            setDimensionButton = new ToolStripDropDownButton();
            rangeMenuItem = new ToolStripMenuItem();
            rangeComboBox = new ToolStripComboBox();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripSeparator2 = new ToolStripSeparator();
            beatsMenuItem = new ToolStripMenuItem();
            beatsComboBox = new ToolStripComboBox();
            toolStripSeparator3 = new ToolStripSeparator();
            resetDimensionsMenuItem = new ToolStripMenuItem();
            clearButton = new ToolStripButton();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)beatsSetter).BeginInit();
            reMapGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)positionSetter).BeginInit();
            toolStrip1.SuspendLayout();
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
            BeatGrid.Location = new Point(0, 24);
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
            BeatGrid.Size = new Size(1000, 652);
            BeatGrid.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(BeatGrid);
            groupBox1.FlatStyle = FlatStyle.Popup;
            groupBox1.Location = new Point(3, 27);
            groupBox1.Margin = new Padding(0);
            groupBox1.MaximumSize = new Size(1000, 676);
            groupBox1.MinimumSize = new Size(1000, 676);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(0);
            groupBox1.Size = new Size(1000, 676);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(1128, 60);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(182, 33);
            comboBox1.TabIndex = 0;
            // 
            // button2
            // 
            button2.ForeColor = SystemColors.ActiveCaptionText;
            button2.Location = new Point(1010, 59);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 7;
            button2.Text = "loop";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // beatsSetter
            // 
            beatsSetter.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            beatsSetter.ForeColor = SystemColors.ControlText;
            beatsSetter.Location = new Point(237, 21);
            beatsSetter.Maximum = new decimal(new int[] { 32, 0, 0, 0 });
            beatsSetter.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            beatsSetter.Name = "beatsSetter";
            beatsSetter.Size = new Size(57, 37);
            beatsSetter.TabIndex = 2;
            beatsSetter.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // reMapGroupBox
            // 
            reMapGroupBox.Controls.Add(label3);
            reMapGroupBox.Controls.Add(positionLabel);
            reMapGroupBox.Controls.Add(numericUpDown2);
            reMapGroupBox.Controls.Add(positionSetter);
            reMapGroupBox.Controls.Add(reMapUpdateButton);
            reMapGroupBox.Controls.Add(label1);
            reMapGroupBox.Controls.Add(beatsSetter);
            reMapGroupBox.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            reMapGroupBox.ForeColor = SystemColors.ButtonHighlight;
            reMapGroupBox.Location = new Point(1010, 282);
            reMapGroupBox.Name = "reMapGroupBox";
            reMapGroupBox.Size = new Size(300, 220);
            reMapGroupBox.TabIndex = 9;
            reMapGroupBox.TabStop = false;
            reMapGroupBox.Text = "Re-Map";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(161, 122);
            label3.Name = "label3";
            label3.Size = new Size(70, 28);
            label3.TabIndex = 8;
            label3.Text = "label3";
            // 
            // positionLabel
            // 
            positionLabel.AutoSize = true;
            positionLabel.Location = new Point(143, 73);
            positionLabel.Name = "positionLabel";
            positionLabel.Size = new Size(88, 28);
            positionLabel.TabIndex = 7;
            positionLabel.Text = "Position";
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(237, 122);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(61, 34);
            numericUpDown2.TabIndex = 6;
            // 
            // positionSetter
            // 
            positionSetter.Location = new Point(237, 73);
            positionSetter.Maximum = new decimal(new int[] { 24, 0, 0, 0 });
            positionSetter.Minimum = new decimal(new int[] { 24, 0, 0, int.MinValue });
            positionSetter.Name = "positionSetter";
            positionSetter.Size = new Size(57, 34);
            positionSetter.TabIndex = 5;
            positionSetter.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // reMapUpdateButton
            // 
            reMapUpdateButton.BackColor = Color.DodgerBlue;
            reMapUpdateButton.Location = new Point(6, 33);
            reMapUpdateButton.Name = "reMapUpdateButton";
            reMapUpdateButton.Size = new Size(112, 34);
            reMapUpdateButton.TabIndex = 4;
            reMapUpdateButton.Text = "Update";
            reMapUpdateButton.UseVisualStyleBackColor = false;
            reMapUpdateButton.Click += ReMapUpdateButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(161, 21);
            label1.Name = "label1";
            label1.Size = new Size(64, 28);
            label1.TabIndex = 3;
            label1.Text = "Beats";
            // 
            // testButton
            // 
            testButton.ForeColor = SystemColors.ActiveCaptionText;
            testButton.Location = new Point(1016, 151);
            testButton.Name = "testButton";
            testButton.Size = new Size(112, 34);
            testButton.TabIndex = 9;
            testButton.Text = "testButton";
            testButton.UseVisualStyleBackColor = true;
            testButton.Click += TestButton_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(24, 24);
            toolStrip1.Items.AddRange(new ToolStripItem[] { setDimensionButton, clearButton });
            toolStrip1.Location = new Point(3, 3);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1316, 34);
            toolStrip1.TabIndex = 10;
            toolStrip1.Text = "toolStrip1";
            // 
            // setDimensionButton
            // 
            setDimensionButton.AccessibleName = "";
            setDimensionButton.BackColor = SystemColors.ControlDarkDark;
            setDimensionButton.DropDownItems.AddRange(new ToolStripItem[] { rangeMenuItem, toolStripSeparator1, toolStripSeparator2, beatsMenuItem, toolStripSeparator3, resetDimensionsMenuItem });
            setDimensionButton.ForeColor = SystemColors.ActiveCaptionText;
            setDimensionButton.Image = Properties.Resources.arrows;
            setDimensionButton.ImageTransparentColor = Color.DimGray;
            setDimensionButton.Margin = new Padding(0, 2, 10, 3);
            setDimensionButton.Name = "setDimensionButton";
            setDimensionButton.Size = new Size(177, 29);
            setDimensionButton.Text = "Set Dimensions";
            setDimensionButton.TextImageRelation = TextImageRelation.TextBeforeImage;
            setDimensionButton.ToolTipText = "Sets or resets the dimensions of the sequencer.\r\nRange-Beats\r\n\r\n";
            // 
            // rangeMenuItem
            // 
            rangeMenuItem.BackColor = SystemColors.ActiveCaptionText;
            rangeMenuItem.DropDownItems.AddRange(new ToolStripItem[] { rangeComboBox });
            rangeMenuItem.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            rangeMenuItem.ForeColor = SystemColors.ButtonHighlight;
            rangeMenuItem.Name = "rangeMenuItem";
            rangeMenuItem.Size = new Size(260, 36);
            rangeMenuItem.Text = "Range ↕";
            // 
            // rangeComboBox
            // 
            rangeComboBox.DropDownWidth = 40;
            rangeComboBox.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24" });
            rangeComboBox.MaxDropDownItems = 24;
            rangeComboBox.MaxLength = 2;
            rangeComboBox.Name = "rangeComboBox";
            rangeComboBox.Size = new Size(75, 33);
            rangeComboBox.TextChanged += RangeComboBox_TextChanged;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(257, 6);
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(257, 6);
            // 
            // beatsMenuItem
            // 
            beatsMenuItem.BackColor = SystemColors.ActiveCaptionText;
            beatsMenuItem.DropDownItems.AddRange(new ToolStripItem[] { beatsComboBox });
            beatsMenuItem.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            beatsMenuItem.ForeColor = SystemColors.ButtonHighlight;
            beatsMenuItem.Name = "beatsMenuItem";
            beatsMenuItem.Size = new Size(260, 36);
            beatsMenuItem.Text = "Beats ↔";
            // 
            // beatsComboBox
            // 
            beatsComboBox.DropDownWidth = 40;
            beatsComboBox.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32" });
            beatsComboBox.MaxDropDownItems = 32;
            beatsComboBox.MaxLength = 2;
            beatsComboBox.Name = "beatsComboBox";
            beatsComboBox.Size = new Size(75, 33);
            beatsComboBox.SelectedIndexChanged += BeatsComboBox_SelectedIndexChanged;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(257, 6);
            // 
            // resetDimensionsMenuItem
            // 
            resetDimensionsMenuItem.BackColor = Color.RoyalBlue;
            resetDimensionsMenuItem.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            resetDimensionsMenuItem.Name = "resetDimensionsMenuItem";
            resetDimensionsMenuItem.Size = new Size(260, 36);
            resetDimensionsMenuItem.Text = "Set Dimensions";
            resetDimensionsMenuItem.Click += ResetDimensionsMenuItem_Click;
            // 
            // clearButton
            // 
            clearButton.BackColor = Color.Red;
            clearButton.ImageTransparentColor = Color.Magenta;
            clearButton.Margin = new Padding(0, 2, 10, 3);
            clearButton.MergeIndex = 1;
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(55, 29);
            clearButton.Text = "Clear";
            clearButton.TextImageRelation = TextImageRelation.TextBeforeImage;
            clearButton.ToolTipText = "Clears all selected indexes in the sequence\r\n";
            clearButton.Click += ClearButton_Click;
            // 
            // SequenceBlocks
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1322, 733);
            Controls.Add(toolStrip1);
            Controls.Add(testButton);
            Controls.Add(reMapGroupBox);
            Controls.Add(button2);
            Controls.Add(comboBox1);
            Controls.Add(groupBox1);
            DoubleBuffered = true;
            ForeColor = SystemColors.Control;
            Name = "SequenceBlocks";
            Padding = new Padding(3);
            Text = "SequenceBlocks";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)beatsSetter).EndInit();
            reMapGroupBox.ResumeLayout(false);
            reMapGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)positionSetter).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TableLayoutPanel BeatGrid;
        private GroupBox groupBox1;
        private ComboBox comboBox1;
        private Label label1;
        private Button button1;
        private Button button2;
        private NumericUpDown beatsSetter;
        private GroupBox reMapGroupBox;
        private Button reMapUpdateButton;
        private NumericUpDown positionSetter;
        private Label label3;
        private Label positionLabel;
        private NumericUpDown numericUpDown2;
        private Button testButton;
        private ToolStrip toolStrip1;
        private ToolStripDropDownButton setDimensionButton;
        private ToolStripButton clearButton;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem beatsMenuItem;
        private ToolStripMenuItem rangeMenuItem;
        private ToolStripComboBox rangeComboBox;
        private ToolStripComboBox beatsComboBox;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem resetDimensionsMenuItem;
    }
}