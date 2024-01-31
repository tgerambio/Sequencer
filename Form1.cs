namespace Sequencer
{
    public partial class Form1 : Form
    {
        
        Dictionary<Rectangle, string> map = new();
               
        public Form1()
        {
            InitializeComponent();

            map.Add(new(239, 6, 50, 50), "C");
            map.Add(new(353, 38, 50, 50), "G");
            map.Add(new(441, 122, 50, 50), "D");
            map.Add(new(473, 243, 50, 50), "A");
            map.Add(new(430, 356, 50, 50), "E");
            map.Add(new(349, 445, 50, 50), "B");
            map.Add(new(234, 473, 50, 50), "F#");
            map.Add(new(121, 437, 50, 50), "C#");
            map.Add(new(37, 355, 50, 50), "Ab");
            map.Add(new(6, 238, 50, 50), "Eb");
            map.Add(new(35, 124, 50, 50), "Bb");
            map.Add(new(121, 38, 50, 50), "F");
            map.Add(new(244, 78, 45, 45), "A minor");

        }


        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            textBox1.Text = string.Format("X: {0} Y: {1}", e.X, e.Y);

            foreach(var rect in map)
            {
                if (rect.Key.Contains(e.X, e.Y))
                {
                    textBox1.Text = map[rect.Key];
                }
            }
            
        }
    }
}
