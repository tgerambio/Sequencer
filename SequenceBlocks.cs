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
        
        public SequenceBlocks()
        {
            InitializeComponent();
            
            SetSequence(16, 8);
        }

        void SetSequence(int range, int beats)
        {
            BeatGrid.ColumnStyles.Clear();
            BeatGrid.RowStyles.Clear() ;

            BeatGrid.RowCount = range;
            BeatGrid.ColumnCount = beats;
            
            for (int r = 0;r < range; r++)
            {
                BeatGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100 / beats));

                for (int b = 0;b < beats;b++)
                {
                    BeatGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 100 / range));

                    var beatCell = new PictureBox()
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
            Color c = beatCell.BackColor;

            beatCell.BackColor = c == Color.Black ? Color.Lime : Color.Black;

        }
    }
}
