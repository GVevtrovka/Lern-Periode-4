using System.Security.Cryptography;

namespace Vevtrovka_Project
{
    public partial class Form1 : Form
    {
        public int maxxposExplosion1 = 388 + 100;
        public int minxposExplosion1 = 388 - 100;
        //388; 64
        public bool flyin = true;
        public bool exploded = false;
        public int xposPlane1;
        public int yposPlane1;
        public bool running = true;
        public bool Start = true;
        public int shootingIntervall = 1;
        public bool flakFiring = false;
        public int explosionNumber;
        public int flakNumber;
        public int xposRound;
        public int DolaDolaTip = 0;
        public int yposRound;
        public bool flakFiring1 = true;
        public bool fired = true;
        public PictureBox[] flakArray1 = new PictureBox[5];
        public PictureBox[] roundArray1 = new PictureBox[5];
        public int I = 0;
        public bool destroyed = false;
        public int Destroys = 0;
        //flakArray1[0] = explosion1_1;
        //flakArray1[1] = explosion2_1;
        //flakArray1[2] = explosion3_1;
        //flakArray1[3] = explosion4_1;
        //flakArray1[4] = explosion5_1;
        //roundArray1[0] = round1_1;
        //roundArray1[1] = round2_1;
        //roundArray1[2] = round3_1;
        //roundArray1[3] = round4_1;
        //roundArray1[4] = round5_1;

        public Form1()
        {
            InitializeComponent();
        }

        private void explosion2_1_Click(object sender, EventArgs e)
        {

        }
        public void Flakfire()
        {
            //flakFiring = true;
            //flakNumber = 1;
            //explosionNumber = 1;
            //PictureBox[] flakArray1 = new PictureBox[20];
            //PictureBox[] roundArray1 = new PictureBox[20];
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
        }
        public async Task Fire()
        {
            flakFiring = true;
            //for (int I = 0; I < 5; I++)
            //{
            xposRound = 386;
            yposRound = 305;
            for (int J = 0; J < 16; J++)
            {
                roundArray1[I].Location = new Point(xposRound, yposRound);
                roundArray1[I].Show();
                yposRound = yposRound - 16;
                await Task.Delay(20);
            }
            roundArray1[I].Hide();
            fired = true;
            destruction();
            flakArray1[I].Show();
            exploded = true;
            _ = destruction();
            await Task.Delay(1000);
            flakArray1[I].Hide();
            await Task.Delay(shootingIntervall);
            I++;
            flakFiring = false;
            if (I == 4)
            {
                I = 0;
            }
        }
        public async Task destruction()

        {
            for (int K = 0; K < 3; K++)
            {
                if (xposPlane1 <= minxposExplosion1 && xposPlane1 >= maxxposExplosion1 && exploded == true)
                {
                    exploded = false;
                    await Task.Delay(1);
                    await TaskForce();
                    //    Plane1.Hide();
                    //Plane1.Location = new Point(-122, 40);
                    //    destroyed = true;
                    //    await Task.Delay(10);
                    //    destroyed = false;
                    //    Plane1.Show();
                    await Task.Delay(10);
                }
            }

        }
        public async Task TaskForce()
        {
            Plane1.Hide();
            Plane1.Location = new Point(-122, 40);
            //destroyed = true;
            await Task.Delay(1000);
            //destroyed = false;
            Plane1.Show();
        }
        public async Task fly()
        {
            while (running)
            {
                if (!destroyed)
                {
                    yposPlane1 = -122;
                    xposPlane1 = 64;
                    for (int S = 0; S < 56; S++)
                    {
                        Plane1.Location = new Point(yposPlane1, xposPlane1);
                        await Task.Delay(40);
                        yposPlane1 += 15;
                    }
                }
            }

        }
        //15x56
        //744; 40
        //-112; 40
        //22; 52
        //22; 305

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (e.KeyChar == 'F')
            //{
            //    _ = Fire();
            //}
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (Start == true)
            {
                Flakfire();
                _ = fly();
                //_ = destruction();
                Start = false;
            }
            else
            {
                if (flakFiring == false)
                {
                    _ = Fire();
                }
            }
            return;
            //if (flakFiring == false)
            //{
            //    Fire();
            //    flakFiring = true;
            //}

            //if (flakFiring == false)
            //{
            //    Fire();
            //    flakFiring = true;
            //}

        }
    }
}
