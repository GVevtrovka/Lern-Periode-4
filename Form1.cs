namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public string Buttomclick1;
        public bool Run = true;
        public int Shooting_Intervall = 100;
        public int xpos;
        public int ypos;
        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyDown += Form1_KeyDown;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            Buttomclick1 = e.KeyCode.ToString();
            //MessageBox.Show(Buttomclick1);
            Rotation();
        }
        public async void Rotation()
        {
            while (Run = true)
            {
                xpos = 253;
                ypos = 331;
                pictureBox2.Location = new Point(xpos, ypos);
                await Task.Delay(Shooting_Intervall);
                while(ypos > 90)
                {
                    ypos -= 10;
                    pictureBox2.Location = new Point(xpos, ypos);
                    await Task.Delay(10);
                }
                explosion.Show();
                await Task.Delay(300);
                explosion.Hide();
            }

        }
        //253; 331 are the standard Positions for the Round
        //90 is Explosion height...
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
