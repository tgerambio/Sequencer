namespace Sequencer
{
    public partial class Form1 : Form
    {

        private readonly Dictionary<Rectangle, string> CoordMap = new()
        {
            {new(324, 10, 70, 70), "C" },{new(470, 50, 70, 70), "G" }, {new(578, 153, 70, 70), "D"}, {new(615, 300, 70, 70), "A"},
            {new(578, 441, 70, 70), "E" }, {new(471, 547, 70, 70), "B"}, {new(325, 584, 70, 70), "F#"}, {new(183, 543,70, 70), "C#"},
            {new(79, 442, 70, 70), "Ab" }, {new(42, 298, 70, 70), "Eb"}, {new(81, 153, 70, 70), "Bb"}, {new(183, 54, 70, 70), "F"},

            {new(333, 100, 60, 60), "A" }, {new(434, 128, 60,60), "E" }, {new(510, 198, 60,60), "B"},{new(540, 303, 60, 60), "F#"},
            {new(510, 409, 60, 60), "C#" }, {new(434, 480, 60,60), "G#" }, {new(333, 509, 60,60), "Eb"},{new(230, 480, 60, 60), "Bb"},
            {new(156, 409, 60, 60), "F" }, {new(131, 303, 60,60), "C" }, {new(159, 205, 60,60), "G"},{new(230, 128, 60, 60), "D"},

            {new(342, 178,40, 40),"B" }, {new(408, 198, 40, 40),"F#" },{new(456,245, 40, 40),"C#" },{new(472, 314,40, 40),"G#" },
            {new(456, 378,40, 40),"Eb" },{new(408,424,40, 40),"Bb" },{new(342, 443, 40, 40),"F" },{new(276, 424,40, 40),"C" },
            {new(226, 378, 40, 40),"G" },{new(209, 314,40, 40),"D" },{new(226,245,40, 40),"A" },{new(276,198,40, 40),"E" },

        };

        private readonly List<string> MajorChordTypes = ["M", "Δ", "7"];

        private readonly List<string> MinorChordTypes = ["m", "m7", "7"];

        private readonly List<string> DiminishedChordTypes = ["°", "°7", "ø"];
        public Form1()
        {
            InitializeComponent();
            listBox1.Parent = pictureBox1;
        }

        private void PictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            //textBox1.Text = string.Format("X: {0} Y: {1}", e.X, e.Y); // to help find coords 

            foreach (var rect in CoordMap) // not efficient
            {
                if (rect.Key.Contains(e.X, e.Y))
                {
                    textBox1.Text = CoordMap[rect.Key];
                    listBox1.Location = new Point(e.X, e.Y);
                    int x = rect.Key.Width;
                    listBox1.DataSource = x == 70 ? MajorChordTypes : x == 60 ? MinorChordTypes : DiminishedChordTypes;
                    listBox1.Visible = true;
                }
            }

        }

        private void ListBox1_Click(object sender, EventArgs e)
        {
            ListBox lB = (ListBox)sender;

            textBox1.Text = lB.SelectedItem?.ToString();

            listBox1.Visible = false;
        }
    }
}
