namespace Sequencer
{
    partial class CircleOfFifthsUI
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
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            ChordTypeBox = new ListBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.edited2;
            pictureBox1.Location = new Point(539, 89);
            pictureBox1.Margin = new Padding(5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(720, 672);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.MouseUp += PictureBox1_MouseUp;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 28F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(21, 26);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(154, 82);
            textBox1.TabIndex = 0;
            // 
            // ChordTypeBox
            // 
            ChordTypeBox.BackColor = SystemColors.ScrollBar;
            ChordTypeBox.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ChordTypeBox.FormattingEnabled = true;
            ChordTypeBox.ItemHeight = 21;
            ChordTypeBox.Location = new Point(907, 125);
            ChordTypeBox.Name = "ChordTypeBox";
            ChordTypeBox.Size = new Size(87, 109);
            ChordTypeBox.TabIndex = 1;
            ChordTypeBox.Click += ListBox1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(15F, 38F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.Black;
            ClientSize = new Size(1797, 936);
            Controls.Add(ChordTypeBox);
            Controls.Add(textBox1);
            Controls.Add(pictureBox1);
            Font = new Font("Segoe UI", 14F);
            Margin = new Padding(5);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox textBox1;
        private ListBox ChordTypeBox;
    }
}
