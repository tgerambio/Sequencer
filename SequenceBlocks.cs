using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sequencer
{
    public partial class SequenceBlocks : Form
    {
        public HashSet<(int, int)> Selected = new();
        public SequenceBlocks()
        {
            InitializeComponent();

            SetSequenceDimensions(12, 8);
        }

        public void GetSequence()
        {
            List<(int, int)> coords = new();

            foreach (PictureBox c in BeatGrid.Controls)
            {
                if (c.BackColor == Color.Lime)
                {
                    coords.Add((BeatGrid.GetRow(c), BeatGrid.GetColumn(c)));
                }

            }
            MessageBox.Show(string.Join(" ", coords));
        }
        public void SetSequenceDimensions(int range, int beats)
        {
            BeatGrid.ColumnStyles.Clear();
            BeatGrid.RowStyles.Clear();

            BeatGrid.RowCount = range;
            BeatGrid.ColumnCount = beats;



            for (int r = 0; r < range; r++)
            {
                BeatGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100 / beats));

                BeatGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 100 / range));
                for (int b = 0; b < beats; b++)
                {
                    BeatGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100 / beats));


                    PictureBox beatCell = new()
                    {
                        Dock = DockStyle.Fill,
                        BackColor = Color.Black,

                    };
                    beatCell.Click += new EventHandler(BeatCell_Click);

                    BeatGrid.Controls.Add(beatCell, b, r);

                }
            }
        }
        protected override void OnResizeBegin(EventArgs e)
        {
            SuspendLayout();
            base.OnResizeBegin(e);
        }
        protected override void OnResizeEnd(EventArgs e)
        {
            ResumeLayout();
            base.OnResizeEnd(e);
        }
        private void BeatCell_Click(object sender, EventArgs e)
        {
            PictureBox beatCell = (PictureBox)sender;

            beatCell.BackColor = beatCell.BackColor == Color.Black ? Color.Lime : Color.Black;

            //raise event with coords to send as event args to phrasemap class
        }

        private void ToolStripComboBox1_Click(object sender, EventArgs e)
        {
            ToolStripComboBox tSCB = (ToolStripComboBox)sender;

            string? s = tSCB.SelectedItem as string;

            if (s == "Clear")
            {
                foreach (PictureBox beatCell in BeatGrid.Controls)
                {
                    if (beatCell.BackColor == Color.Lime)
                    {
                        BeatCell_Click(beatCell, EventArgs.Empty);
                    }

                }
            }

        }

    }
}
