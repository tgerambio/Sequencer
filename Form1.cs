using System.Runtime.CompilerServices;

namespace Sequencer
{
    public partial class CircleOfFifthsUI : Form
    {

        private readonly Dictionary<Rectangle, string> CoordMap = new()
        {
            {new(324, 10, 70, 70), "C" }, {new(470, 50, 70, 70), "G" }, {new(578, 153, 70, 70), "D"}, {new(615, 300, 70, 70), "A"},
            {new(578, 441, 70, 70), "E"}, {new(471, 547, 70, 70), "B"}, {new(325, 584, 70, 70), "F♯"}, {new(183, 543,70, 70), "C♯"},
            {new(79, 442, 70, 70), "A♭"}, {new(42, 298, 70, 70), "E"}, {new(81, 153, 70, 70), "B♭"}, {new(183, 54, 70, 70), "F"},

            {new(333, 100, 60, 60), "A" }, {new(434, 128, 60,60), "E" }, {new(510, 198, 60,60), "B"},{new(540, 303, 60, 60), "F♯"},
            {new(510, 409, 60, 60), "C♯"}, {new(434, 480, 60,60), "G♯"}, {new(333, 509, 60,60), "E♭"},{new(230, 480, 60, 60), "B♭"},
            {new(156, 409, 60, 60), "F" }, {new(131, 303, 60,60), "C" }, {new(159, 205, 60,60), "G"},{new(230, 128, 60, 60), "D"},

            {new(342, 178,40, 40),"B"  }, {new(408, 198, 40, 40),"F♯"},{new(456,245, 40, 40),"C♯" },{new(472, 314,40, 40),"G♯" },
            {new(456, 378,40, 40),"E♭" }, {new(408,424,40, 40),"B♭"  },{new(342, 443, 40, 40),"F" },{new(276, 424,40, 40),"C" },
            {new(226, 378, 40, 40),"G" }, {new(209, 314,40, 40),"D"  },{new(226,245,40, 40),"A" },{new(276,198,40, 40),"E" },

        };


        
        private string? rootNote;

        private readonly List<string> majorChordTypes = ["M", "Δ", "7"];

        private readonly List<string> minorChordTypes = ["m", "m7", "7", "+"];

        private readonly List<string> diminishedChordTypes = ["°", "°7", "ø"];
        public CircleOfFifthsUI()
        {
            InitializeComponent();
            ChordTypeBox.Parent = pictureBox1; 
        }

        public delegate void TypeClickedEventHandler(object sender, EventArgs e);

        public event TypeClickedEventHandler? TypeClicked;
        protected virtual void OnTypeClicked(EventArgs e)
        {
            TypeClicked?.Invoke(this, e);
        }

        private void PictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            //textBox1.Text = string.Format("X: {0} Y: {1}", e.X, e.Y); 

            foreach (var rect in CoordMap.Keys) // this is dumb
            {
                if (rect.Contains(e.X, e.Y))
                {
                    rootNote = CoordMap[rect]; 
                    ChordTypeBox.Location = new Point(e.X, e.Y);
                    int x = rect.Width;
                    ChordTypeBox.DataSource = x == 70 ? majorChordTypes : x == 60 ? minorChordTypes : diminishedChordTypes;
                    ChordTypeBox.Visible = true;
                }
            }

        }
        
        private void ListBox1_Click(object sender, EventArgs e)
        {
            ListBox lB = (ListBox)sender;

            string? cType = lB.SelectedItem?.ToString();

            textBox1.Text =  rootNote + cType;

            ChordTypeBox.Visible = false;

            OnTypeClicked(EventArgs.Empty);// empty EventArgs for now..
        }
    }
}
