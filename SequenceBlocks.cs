using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.Json.Serialization.Metadata;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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

        }


        public void GetSequence()
        {
            List<(int, int)> coords = new();

            foreach (PictureBox c in BeatGrid.Controls)
            {
                if (c.BackColor == Color.Lime)
                {
                    coords.Add(new(BeatGrid.GetColumn(c), BeatGrid.GetRow(c)));
                }

            }
            MessageBox.Show(string.Join(" ", coords));
        }
        public void SetSequenceDimensions(int range, int beats)
        {


            BeatGrid.Visible = false;
            Range = range;
            Beats = beats;

            Selected.Clear();
            BeatGrid.Controls.Clear();
            BeatGrid.ColumnStyles.Clear();
            BeatGrid.RowStyles.Clear();

            BeatGrid.RowCount = range;
            BeatGrid.ColumnCount = beats;

            for (int r = 0; r < range; r++)
            {
                BeatGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 100 / Range));


                for (int b = 0; b < beats; b++)
                {

                    BeatGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100 / Beats));


                    PictureBox beatCell = new()
                    {
                        Dock = DockStyle.Fill,
                        BackColor = Color.Black,

                    };
                    beatCell.Click += new EventHandler(BeatCell_Click);

                    BeatGrid.Controls.Add(beatCell, b, r);

                }
            }
            BeatGrid.Visible = true;
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

           // MessageBox.Show(BeatGrid.GetCellPosition(beatCell).ToString());

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

        void Weird()
        {
            int counter = 1;
            while (counter < 344)
            {
                Thread.Sleep(120);
                OnBeat(this, EventArgs.Empty);
                CycleAroundPoint(counter/24);
                //TestButton_Click(this, EventArgs.Empty);
                counter++;
            }

        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            new Thread(new ThreadStart(Weird)).Start();

        }

        void CycleAroundPoint(int center)
        {
            List<Tuple<int, int>> n = new();

            int rows = BeatGrid.RowCount;
            int columns = BeatGrid.ColumnCount;

            int[] tr = { rows - 1, columns - 1 };
            int[] br = { rows - 1, 1 };
            int[] bl = { 1, 1 };
            int[] tl = { 1, columns - 1 };

            foreach (var s in Selected)
            {
                int c = s.Item2;
                int r = s.Item1;

                int[] add = c <= center && r < center ? tl :
                r >= center && c < center ? bl :
                c >= center && r > center ? br : tr;

                n.Add(new((add[0] + r) % rows, (add[1] + c) % columns));


            }

            ClearButton_Click(this, EventArgs.Empty);
            Selected = n;
            foreach (var s in Selected)
            {
                PictureBox cell = (PictureBox)BeatGrid.GetControlFromPosition(s.Item2, s.Item1);
                cell.BackColor = Color.Lime;
            }
        }
        private void ReMapUpdateButton_Click(object sender, EventArgs e)
        {

        }
        int[][] jumps = new int[][] { new int[] { 0, 1 }, new int[] { 1, 0 }, new int[] { 0, 19 }, new int[] { 19, 0 } };
        int i = 0;
        private void TestButton_Click(object sender, EventArgs e)
        {
            List<Tuple<int, int>> n = new();

            int rows = BeatGrid.RowCount;
            int columns = BeatGrid.ColumnCount;

            int[] tr = {rows-1, columns-1};
            int[] br = {rows-1,  1};
            int[] bl = { 1,  1};
            int[] tl = { 1, columns-1};

            foreach (var s in Selected)
            {
                int c = s.Item2;
                int r = s.Item1;

                int[] add = c <= 7 && r < 7 ? tl :
                r >= 7 && c < 7 ? bl :
                c >= 7 && r > 7 ? br : tr;

                n.Add(new((add[0] + r)%rows, (add[1] + c)%columns));

                
            }

            ClearButton_Click(this, EventArgs.Empty);
            Selected = n;
            foreach(var s in Selected)
            {
                PictureBox cell = (PictureBox)BeatGrid.GetControlFromPosition(s.Item2, s.Item1);
                cell.BackColor = Color.Lime;
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            foreach (Tuple<int, int> t in Selected)
            {
                PictureBox cell = (PictureBox)BeatGrid.GetControlFromPosition(t.Item2, t.Item1);
                cell.BackColor = Color.Black;
            }
            Selected.Clear();
            //event here
        }

        private void ResetDimensionsMenuItem_Click(object sender, EventArgs e)
        {
            SetSequenceDimensions(Range, Beats);
        }

        private void RangeComboBox_TextChanged(object sender, EventArgs e)
        {
            Range = rangeComboBox.SelectedIndex + 1;
        }

        private void BeatsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Beats = beatsComboBox.SelectedIndex + 1;
        }

        private void SequenceBlocks_Load(object sender, EventArgs e)
        {
            SetSequenceDimensions(22, 16);
        }

        
    }
}
