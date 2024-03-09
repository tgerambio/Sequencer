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
            components = new System.ComponentModel.Container();
            BeatGrid = new TableLayoutPanel();
            groupBox1 = new GroupBox();
            progressBar1 = new ProgressBar();
            imageList1 = new ImageList(components);
            groupBox1.SuspendLayout();
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
            BeatGrid.Location = new Point(3, 27);
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
            BeatGrid.Size = new Size(794, 4);
            BeatGrid.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.AutoSize = true;
            groupBox1.BackColor = SystemColors.ActiveCaptionText;
            groupBox1.Controls.Add(BeatGrid);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.FlatStyle = FlatStyle.Popup;
            groupBox1.Location = new Point(0, 0);
            groupBox1.MaximumSize = new Size(800, 500);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(800, 34);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // progressBar1
            // 
            progressBar1.Dock = DockStyle.Fill;
            progressBar1.Location = new Point(0, 34);
            progressBar1.MarqueeAnimationSpeed = 20;
            progressBar1.Maximum = 32;
            progressBar1.MaximumSize = new Size(800, 30);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(800, 30);
            progressBar1.Step = 1;
            progressBar1.Style = ProgressBarStyle.Marquee;
            progressBar1.TabIndex = 2;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.WhiteSmoke;
            // 
            // SequenceBlocks
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1322, 707);
            Controls.Add(progressBar1);
            Controls.Add(groupBox1);
            DoubleBuffered = true;
            ForeColor = SystemColors.Control;
            Name = "SequenceBlocks";
            Text = "SequenceBlocks";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TableLayoutPanel BeatGrid;
        private GroupBox groupBox1;
        private ProgressBar progressBar1;
        private ImageList imageList1;
    }
}