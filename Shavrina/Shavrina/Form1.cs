using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shavrina
{
   
    public partial class Form1 : Form
    {
        public Timer tm = new Timer();
        public float XMouse;
        public float YMouse;
        public bool hodPlayer = false;
        public float intervalX = 0;
        public float intervalY = 0;
        PointF[] points = new PointF[1000];
        int XodovInGame = 0;
        double time = 0;
        PointObject[] pointObjects = new PointObject[1000];
        Color pointColorOne = Color.Red;
        Color pointColorTwo = Color.Blue;
        

        public Form1()
        {   
            
            InitializeComponent();
            DoubleBuffered = true;
            tm.Interval = 100;
            tm.Tick += Update;
            tm.Start();
        }
        public float LogoTime = 0;
        public void Update(object sender, EventArgs e)
        {


            if (LogoTime == 10)
            {

                logo.Visible = false;
                time += 0.1;
            }
            else
            {
                LogoTime++;
            }
           
            TimerGame.Text = Math.Round(time).ToString() + ":" +"00";
       //   Player1Label.Text = XMouse.ToString() + " : "+ YMouse.ToString();
        }
        private void GeneratePole(float xCoord, float yCoord,float interval)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void logo1_Load(object sender, EventArgs e)
        {

        }

        private void mainMenu1_Load(object sender, EventArgs e)
        {

        }

        private void NewGame_Click(object sender, EventArgs e)
        {
           
        }

        private void Settings_click(object sender, EventArgs e)
        {
         
        }

        private void ExiteClick(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void OK(object sender, EventArgs e)
        {
            
        }

        private void CAncel(object sender, EventArgs e)
        {
         
        }

        private void label1_Click(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void logo_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ColorDialog cl = new ColorDialog();
            cl.ShowDialog();
            pointColorOne = cl.Color;
            Color1.BackColor = pointColorOne;

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Player2Label_Click(object sender, EventArgs e)
        {

        }

        private void Player1Name_TextChanged(object sender, EventArgs e)
        {

        }

        private void color2_Click(object sender, EventArgs e)
        {
            ColorDialog cl = new ColorDialog();
            cl.ShowDialog();
            pointColorTwo = cl.Color;
            color2.BackColor = pointColorTwo;
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void pole1_Load(object sender, EventArgs e)
        {

        }

        private void DrawPoints(object sender, PaintEventArgs e)
        {

            PointF sizepoint = new PointF(10, 10);
            for (int i = 1; i <= XodovInGame; i++)
            {
                PointF[] tempPoints = new PointF[5];
                if (hodPlayer == true)
                {

                    SolidBrush br = new SolidBrush(pointColorOne);

                    e.Graphics.FillEllipse(br, points[i].X, points[i].Y, sizepoint.X, sizepoint.Y);
                    hodPlayer = false;
                    pointObjects[i] = new PointObject(pointColorOne, points[i], false, false, false);
                }
                else
                {
                    SolidBrush br = new SolidBrush(pointColorTwo);
                    e.Graphics.FillEllipse(br, points[i].X, points[i].Y, sizepoint.X, sizepoint.Y);
                    hodPlayer = true;

                    pointObjects[i] = new PointObject(pointColorTwo, points[i], false, false, false);
                }

               // label1.Text = pointObjects[i].colorPoint.ToString() + " " + pointObjects[i].pointCoordinates.X.ToString() + " : " + pointObjects[i].pointCoordinates.Y.ToString();
            }
            ConnectPoints(e.Graphics);

            hodPlayer = false;
        }
        public void ConnectPoints(Graphics g)
        {
            PointObject[] temp = new PointObject[4];
            if (XodovInGame >= 8)
            {
                int chet = 0;
                for (int i = 1; i < XodovInGame; i++)
                {
                    for (int l = 1; l < XodovInGame; l++)
                    {
                        if (pointObjects[i].pointCoordinates.X - intervalX == pointObjects[l].pointCoordinates.X
                              && pointObjects[i].pointCoordinates.Y == pointObjects[l].pointCoordinates.Y
                              && pointObjects[i].colorPoint != pointObjects[l].colorPoint && pointObjects[i].connect == false)
                        {
                            temp[0] = pointObjects[l];
                            chet++;
                        }
                        if (pointObjects[i].pointCoordinates.X + intervalX == pointObjects[l].pointCoordinates.X
                             && pointObjects[i].pointCoordinates.Y == pointObjects[l].pointCoordinates.Y
                             && pointObjects[i].colorPoint != pointObjects[l].colorPoint && pointObjects[i].connect == false)
                        {
                            temp[2] = pointObjects[l];
                            chet++;
                        }
                        if (pointObjects[i].pointCoordinates.X == pointObjects[l].pointCoordinates.X
                         && pointObjects[i].pointCoordinates.Y - intervalY == pointObjects[l].pointCoordinates.Y
                         && pointObjects[i].colorPoint != pointObjects[l].colorPoint && pointObjects[i].connect == false)
                        {
                            temp[1] = pointObjects[l];
                            chet++;
                        }
                        if (pointObjects[i].pointCoordinates.X == pointObjects[l].pointCoordinates.X
                         && pointObjects[i].pointCoordinates.Y + intervalY == pointObjects[l].pointCoordinates.Y
                         && pointObjects[i].colorPoint != pointObjects[l].colorPoint && pointObjects[i].connect == false)
                        {
                            temp[3] = pointObjects[l];
                            chet++;
                        }


                    }
                    if (chet == 4)
                    {
                        if (temp[3] != null && temp[2] != null && temp[1] != null && temp[0] != null)
                        {
                            PointF[] pointsF = new PointF[4];
                            pointsF[0] = temp[0].pointCoordinates;
                            pointsF[1] = temp[1].pointCoordinates;
                            pointsF[2] = temp[2].pointCoordinates;
                            pointsF[3] = temp[3].pointCoordinates;
                            pointsF[0].X += 5;
                            pointsF[0].Y += 5;
                            pointsF[1].X += 5;
                            pointsF[1].Y += 5;
                            pointsF[2].X += 5;
                            pointsF[2].Y += 5;
                            pointsF[3].X += 5;
                            pointsF[3].Y += 5;

                            SolidBrush br = new SolidBrush(temp[0].colorPoint);

                            g.FillPolygon(br, pointsF);
                            chet = 0;
                            pointObjects[i].connect = true;

                        }
                    }
                    else
                    {
                        chet = 0;
                    }


                }






            }


        }

        bool HavePoint = false;
        private void ClickMouse(object sender, MouseEventArgs e)
        {

            XMouse = e.X;
            YMouse = e.Y;



            //label2.Text = HavePoint.ToString();
            if (intervalX == 0)
            {
                intervalX = (pole1.Size.Width - 1) / 20;
                intervalY = (pole1.Size.Height - 1) / 20;
            }
            XMouse = RoundCoord(XMouse, intervalX);
            YMouse = RoundCoord(YMouse, intervalY);
            CheckPoints();
            if (HavePoint == false)
            {
                //  label1.Text = XMouse.ToString() + ":" + YMouse.ToString();
                XodovInGame++;
                if (points.Length <= XodovInGame)
                    points[XodovInGame] = new PointF(XMouse, YMouse);
                else
                {
                    PointF[] tempp = new PointF[XodovInGame + 1];
                    tempp = points;
                    Array.Resize(ref points, XodovInGame + 50);
                    points = tempp;
                    points[XodovInGame] = new PointF(XMouse, YMouse);

                }
                pole1.Refresh();


            }
            else
            {

            }




        }
        public void CheckPoints()
        {
            for (int i = 1; i <= XodovInGame; i++)
            {
                if (XMouse != points[i].X || YMouse != points[i].Y)
                {
                    HavePoint = false;


                }
                else
                {

                    HavePoint = true;
                    break;
                }

            }
        }
        private void CoordMous(object sender, MouseEventArgs e)
        {

        }
        public float RoundCoord(float coord, float interval)
        {
            float tempCOord = coord;
            while (coord > 99)
            {
                coord -= 100;
            }
            while (coord >= interval)
            {
                coord -= interval;
            }


            if (coord >= 0 && coord < 15)
            {
                tempCOord -= coord;
            }
            else if (coord >= 15 && coord < 16)
            {
                tempCOord += 10;
            }
            else if (coord >= 16 && coord < 17)
            {
                tempCOord += 9;
            }
            else if (coord >= 17 && coord < 18)
            {
                tempCOord += 8;
            }
            else if (coord >= 18 && coord < 19)
            {
                tempCOord += 7;
            }
            else if (coord >= 19 && coord < 20)
            {
                tempCOord += 6;
            }
            else if (coord >= 20 && coord < 21)
            {
                tempCOord += 5;
            }
            else if (coord >= 21 && coord < 22)
            {
                tempCOord += 4;
            }
            else if (coord >= 22 && coord < 23)
            {
                tempCOord += 3;
            }
            else if (coord >= 23 && coord < 24)
            {
                tempCOord += 2;
            }
            else if (coord >= 24 && coord < 25)
            {
                tempCOord += 1;
            }
            else
            {
                tempCOord = tempCOord;
            }

            return tempCOord - 5;


        }

        private void SettingClick(object sender, EventArgs e)
        {
            if (label5.Visible == false)
            {
                label5.Visible = true;
                SoundCheck.Visible = true;
                Descript.Visible = true;
            }
            else
            {
                label5.Visible = false;
                SoundCheck.Visible = false;
                Descript.Visible = false;
            }

        }

        private void Description(object sender, EventArgs e)
        {
            if (descript1.Visible == false)
            {
                descript1.Visible = true;
            }
            else
            {
                descript1.Visible = false;
            }
        }

        private void ClickMouse(object sender, EventArgs e)
        {

        }

        private void descript1_Load(object sender, EventArgs e)
        {

        }
        bool soundVkl = false;
        private void SoundCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (soundVkl== false)
            {
                soundVkl = true;
            }
            else
            {
                soundVkl = false;
            }

            SoundPlayer simpleSound = new SoundPlayer(Environment.CurrentDirectory + @"/2.wav");

            if (soundVkl)
            {




                simpleSound.Play();
            }
            else
            {


                simpleSound.Stop();
            }
        }

        private void logo_Load_1(object sender, EventArgs e)
        {

        }
    }
}
