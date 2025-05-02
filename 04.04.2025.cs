using System.Diagnostics.Eventing.Reader;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

namespace Vevtrovka_Project
{
    public partial class Form1 : Form
    {
        public int Upgrades = 0;
        public int maxxposExplosion1 = 388 + 25;//413
        public int minxposExplosion1 = 388 - 25;//363
        //388; 64
        public PictureBox[] Plane = new PictureBox[10];
        public int point = 0;
        public bool flyin = true;
        public bool exploded = false;
        public int xposPlane1;
        public int yposPlane1;
        public bool running = true;
        public bool Start = true;
        public int shootingIntervall = 500;
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
        public int[] SpeedArray = new int[10];
        public int[] PointArray = new int[10];
        public int I = 0;
        public bool destroyed = false;
        public int Destroys = 0;
        public int AttackNumber;
        public int BulletSpeed = 15;

        public Form1()
        {
            InitializeComponent();
        }

        private void explosion2_1_Click(object sender, EventArgs e)
        {

        }
        public void Flakfire()
        {
            flak1.Show();
            pictureBox1.Show();
            textBox1.ReadOnly = false;
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
            Plane[0] = Plane1;
            Plane[1] = Plane2;
            Plane[2] = Plane3;
            Plane[3] = Plane4;
            Plane[4] = Plane5;
            Plane[5] = Plane6;
            Plane[6] = Plane7;
            Plane[7] = Plane8;
            Plane[8] = Plane9;
            Plane[9] = Plane10;
            PointArray[0] = 1;
            PointArray[1] = 2;
            PointArray[2] = 3;
            PointArray[3] = 4;
            PointArray[4] = 5;
            PointArray[5] = 6;
            PointArray[6] = 7;
            PointArray[7] = 8;
            PointArray[8] = 9;
            PointArray[9] = 10;

            SpeedArray[0] = 20;
            SpeedArray[1] = 18;
            SpeedArray[2] = 16;
            SpeedArray[3] = 14;
            SpeedArray[4] = 12;
            SpeedArray[5] = 10;
            SpeedArray[6] = 9;
            SpeedArray[7] = 8;
            SpeedArray[8] = 7;
            SpeedArray[9] = 6;
            Plane[0].Hide();
            Plane[1].Hide();
            Plane[2].Hide();
            Plane[3].Hide();
            Plane[4].Hide();
            Plane[5].Hide();
            Plane[6].Hide();
            Plane[7].Hide();
            Plane[8].Hide();
            Plane[9].Hide();
            _ = fly();
        }
        public async Task Fire()
        {
            flakFiring = true;
            xposRound = 386;
            yposRound = 305;
            for (int J = 0; J < 16; J++)
            {
                roundArray1[I].Location = new Point(xposRound, yposRound);
                roundArray1[I].Show();
                yposRound = yposRound - 16;
                await Task.Delay(BulletSpeed);
            }
            roundArray1[I].Hide();
            fired = true;
            flakArray1[I].Show();
            exploded = true;
            await Task.Delay(250);
            exploded = false;
            flakArray1[I].Hide();
            await Task.Delay(shootingIntervall);
            flakFiring = false;
        }
        public async Task fly()
        {
            while (running)
            {
                yposPlane1 = -103;
                xposPlane1 = 64;
                Random random = new Random();
                AttackNumber = random.Next(1, 100);
                if (AttackNumber >= 1 && AttackNumber <= 30)
                {
                    AttackNumber = 0;
                }
                if (AttackNumber >= 31 && AttackNumber <= 50)
                {
                    AttackNumber = 1;
                }
                if (AttackNumber >= 51 && AttackNumber <= 65)
                {
                    AttackNumber = 2;
                }
                if (AttackNumber >= 66 && AttackNumber <= 75)
                {
                    AttackNumber = 3;
                }
                if (AttackNumber >= 76 && AttackNumber <= 83)
                {
                    AttackNumber = 4;
                }
                if (AttackNumber >= 84 && AttackNumber <= 89)
                {
                    AttackNumber = 5;
                }
                if (AttackNumber >= 90 && AttackNumber <= 93)
                {
                    AttackNumber = 6;
                }
                if (AttackNumber >= 94 && AttackNumber <= 96)
                {
                    AttackNumber = 7;
                }
                if (AttackNumber >= 97 && AttackNumber <= 98)
                {
                    AttackNumber = 8;
                }
                if (AttackNumber >= 99 && AttackNumber <= 100)
                {
                    AttackNumber = 9;
                }
                Plane[AttackNumber].Show();
                for (int S = 0; S < 56; S++)
                {
                    Plane[AttackNumber].Location = new Point(yposPlane1, xposPlane1);
                    pictureBox1.Location = new Point(yposPlane1, xposPlane1);

                    await Task.Delay(SpeedArray[AttackNumber]);
                    yposPlane1 += 15;
                    if (S == 29 || S == 30 || S == 31 || S == 32)
                    {
                        if (exploded == true)
                        {
                            point += PointArray[AttackNumber];
                            exploded = false;
                            Plane[AttackNumber].Hide();
                        }
                    }
                    textBox1.Text = Convert.ToString(point);
                 
                }
                Plane[AttackNumber].Hide();
            }
        }
        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (Start == true)
            {
                Flakfire();
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
        }

        private void Plane1_Click(object sender, EventArgs e)
        {

        }

        private void Upgrade_Click(object sender, EventArgs e)
        {
           if(Upgrades <= 6 && point >= 50)
            {
                shootingIntervall -= 80;
                BulletSpeed -= 2;
                Upgrades += 1;
                point -= 50;
            }
        }
    }
}
