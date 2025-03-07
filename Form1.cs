namespace Vevtrovka_Project
{
    public partial class Form1 : Form
    {
        public int shootingIntervall = 1;
        public bool flakFiring = true;
        public int explosionNumber;
        public int flakNumber;
        public int xposRound;
        public int DolaDolaTip = 0;
        public int yposRound;
        public bool flakFiring1 = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void explosion2_1_Click(object sender, EventArgs e)
        {

        }
        public async Task Flakfire()
        {
            flakNumber = 1;
            explosionNumber = 1;
            PictureBox[] flakArray1 = new PictureBox[20];
            PictureBox[] roundArray1 = new PictureBox[20];
            explosion1_1.Hide();
            explosion2_1.Hide();
            explosion3_1.Hide();
            explosion4_1.Hide();
            explosion5_1.Hide();
            round1_1.Hide();
            round2_1.Hide();
            round3_1.Hide();
            round4_1.Hide();
            round5_1.Hide();
            flakArray1[0] = explosion1_1;
            flakArray1[1] = explosion2_1;
            flakArray1[2] = explosion3_1;
            flakArray1[3] = explosion4_1;
            flakArray1[4] = explosion5_1;
            roundArray1[0] = round1_1;
            roundArray1[1] = round2_1;
            roundArray1[2] = round3_1;
            roundArray1[3] = round4_1;
            roundArray1[4] = round5_1;
            while (flakFiring = true)
            {
                for (int I = 0; I < 5; I++)
                {
                    xposRound = 22;
                    yposRound = 305;
                    for (int J = 0; J < 16; J++)
                    {
                        roundArray1[I].Location = new Point(xposRound, yposRound);
                        roundArray1[I].Show();
                        yposRound = yposRound - 16;
                        await Task.Delay(10);
                    }
                    roundArray1[I].Hide();
                    flakArray1[I].Show();
                    await Task.Delay(1000);
                    flakArray1[I].Hide();
                    await Task.Delay(shootingIntervall);
                }
            }
        }
        //22; 52
        //22; 305

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            if (flakFiring1 == true)
        {
                Flakfire();
                flakFiring1 = false;
        }

        }
    }
}
