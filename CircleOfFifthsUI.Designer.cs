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
            ChordTypeBox = new ListBox();
            ChordLabel = new Label();
            VoiceLeadCheckBox = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.circlefive;
            pictureBox1.Location = new Point(539, 89);
            pictureBox1.Margin = new Padding(5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(720, 672);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.MouseUp += PictureBox1_MouseUp;
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
            // ChordLabel
            // 
            ChordLabel.AutoSize = true;
            ChordLabel.Font = new Font("Imprint MT Shadow", 28F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            ChordLabel.ForeColor = SystemColors.ButtonFace;
            ChordLabel.Location = new Point(859, 9);
            ChordLabel.Name = "ChordLabel";
            ChordLabel.Size = new Size(70, 66);
            ChordLabel.TabIndex = 2;
            ChordLabel.Text = "C";
            ChordLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // VoiceLeadCheckBox
            // 
            VoiceLeadCheckBox.AutoSize = true;
            VoiceLeadCheckBox.ForeColor = SystemColors.ButtonHighlight;
            VoiceLeadCheckBox.Location = new Point(26, 89);
            VoiceLeadCheckBox.Name = "VoiceLeadCheckBox";
            VoiceLeadCheckBox.Size = new Size(281, 42);
            VoiceLeadCheckBox.TabIndex = 3;
            VoiceLeadCheckBox.Text = "Auto Voice Leading";
            VoiceLeadCheckBox.UseVisualStyleBackColor = true;
            // 
            // CircleOfFifthsUI
            // 
            AutoScaleDimensions = new SizeF(15F, 38F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.Black;
            ClientSize = new Size(1797, 936);
            Controls.Add(VoiceLeadCheckBox);
            Controls.Add(ChordLabel);
            Controls.Add(ChordTypeBox);
            Controls.Add(pictureBox1);
            Font = new Font("Segoe UI", 14F);
            Margin = new Padding(5);
            Name = "CircleOfFifthsUI";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private ListBox ChordTypeBox;
        private Label ChordLabel;
        private CheckBox VoiceLeadCheckBox;
    }
}
