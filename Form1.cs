namespace Sequencer
{
    public partial class Form1 : Form
    {

        Dictionary<Rectangle, string> CoordMap = new()
        {
            {new(324, 10, 70, 70), "C" },{new(470, 50, 70, 70), "G" }, {new(578, 153, 70, 70), "D"}, {new(615, 300, 70, 70), "A"},
            {new(578, 441, 70, 70), "E" }, {new(471, 547, 70, 70), "B"}, {new(325, 584, 70, 70), "F#"}, {new(183, 543,70, 70), "C#"},
            {new(79, 442, 70, 70), "Ab" }, {new(42, 298, 70, 70), "Eb"}, {new(81, 153, 70, 70), "Bb"}, {new(183, 54, 70, 70), "F"},
            
            {new(333, 100, 60, 60), "Am" }, {new(434, 128, 60,60), "Em" }, {new(510, 198, 60,60), "Bm"},{new(540, 303, 60, 60), "F#m"},
            {new(510, 409, 60, 60), "C#m" }, {new(434, 480, 60,60), "G#m" }, {new(333, 509, 60,60), "Ebm"},{new(230, 480, 60, 60), "Bbm"},
            {new(156, 409, 60, 60), "Fm" }, {new(131, 303, 60,60), "Cm" }, {new(159, 205, 60,60), "Gm"},{new(230, 128, 60, 60), "Dm"},

            {new(342, 178,40, 40),"Bdim" }, {new(408, 198, 40, 40),"F#dim" },{new(456,245, 40, 40),"C#dim" },{new(472, 314,40, 40),"G#dim" },
            {new(456, 378,40, 40),"Ebdim" },{new(408,424,40, 40),"Bbdim" },{new(342, 443, 40, 40),"Fdim" },{new(276, 424,40, 40),"Cdim" },
            {new(226, 378, 40, 40),"Gdim" },{new(209, 314,40, 40),"Ddim" },{new(226,245,40, 40),"Adim" },{new(276,198,40, 40),"Edim" },

        };

           
               
        public Form1()
        {
            InitializeComponent();
            
        }
        
        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            textBox1.Text = string.Format("X: {0} Y: {1}", e.X, e.Y); // to help find coords 

            foreach(var rect in CoordMap)
            {
                if (rect.Key.Contains(e.X, e.Y))
                {
                    textBox1.Text = CoordMap[rect.Key];
                }
            }
            
        }
    }
}
