using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.Json.Serialization.Metadata;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sequencer
{
    public partial class SequenceBlocks : Form
    {
        public List<Tuple<int, int>> Selected = new();

        public int Range { get; set; }
        public int Beats { get; set; }

        private int beatCount = -1;
        public SequenceBlocks()
        {
            InitializeComponent();

            SetSequenceDimensions(12, 16);
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
            Range = range;
            Beats = beats;

            Selected.Clear();

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

            Tuple<int, int> coords = new(BeatGrid.GetRow(beatCell), BeatGrid.GetColumn(beatCell));

            if (Selected.Contains(coords))
            {
                beatCell.BackColor = Color.Black;
                Selected.Remove(coords);
            }
            else
            {
                beatCell.BackColor = Color.Lime;
                Selected.Add(coords);
            }

            //raise event with coords to send as event args to phrasemap class
        }


        private void OnBeat(object sender, EventArgs e)
        {
            for (int i = 0; i < Range; i++)
            {
                Tuple<int, int> coords = new(i, beatCount);

                if (Selected.Contains(coords))
                {
                    PictureBox cell = (PictureBox)BeatGrid.GetControlFromPosition(coords.Item2, coords.Item1);
                    cell.BackColor = Color.Lime;
                }
            }
            beatCount = (beatCount + 1) % Beats;
            

            for (int i = 0; i < Range; i++)
            {
                Tuple<int, int> coords = new(i, beatCount);

                if (Selected.Contains(coords))
                {
                    PictureBox cell = (PictureBox)BeatGrid.GetControlFromPosition(coords.Item2, coords.Item1);
                    cell.BackColor = Color.Blue;
                }
            }
        }




        private void ClearButton_Click(object sender, EventArgs e)
        {
            foreach (Tuple<int, int> t in Selected)
            {
                PictureBox cell = (PictureBox)BeatGrid.GetControlFromPosition(t.Item2, t.Item1);
                cell.BackColor = Color.Black;
            }
            Selected.Clear();
        }
       
        void Weird()
        {
            int counter = 1;
            while (counter < 144)
            {
                Thread.Sleep(80);
                OnBeat(this, EventArgs.Empty);
                
                counter++;
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {

            OnBeat(this, EventArgs.Empty);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Thread(new ThreadStart(Weird)).Start();

        }
    }
}
