using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace Pomodoro_Windows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.BackColor = Color.Green;
            this.TransparencyKey = Color.Green;
            this.Icon = Properties.Resources.Red_Tomato_Icon;
            this.TopMost = true;
            int x = Screen.PrimaryScreen.WorkingArea.Right - this.Width;
            int y = Screen.PrimaryScreen.WorkingArea.Bottom - this.Height;
            this.Location = new Point (x, y);
        }
        System.Timers.Timer time;
        int min, sec, wmin, rmin, lrmin, restcount = 0;
        bool work = true, change = true, reset = true;
        bool dragging = false;
        Point start_point = new Point(0, 0);

        public void MakeTomatoRed()
        {
            panel2.BackgroundImage = Properties.Resources.Red_Tomato;
            Backbtn.BackColor = Color.Orange;
            Pause.BackColor = Color.Orange;
            Quitbtn2.BackColor = Color.Orange;
        }
        public void MakeTomatoGreen()
        {
            panel2.BackgroundImage = Properties.Resources.Green_Tomato;
            Backbtn.BackColor = Color.YellowGreen;
            Pause.BackColor = Color.YellowGreen;
            Quitbtn2.BackColor = Color.YellowGreen;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //setup timer
            time = new System.Timers.Timer();
            time.Interval = 1000; //1 second interval
            time.Elapsed += OnTimeEvent;
            //hides panel 2
            panel2.Hide();
            //place panel2 behind panel1
            panel2.Location = panel1.Location;
            // set the transparency
            label1.BackColor = System.Drawing.Color.Transparent;
            label2.BackColor = System.Drawing.Color.Transparent;
            Timer.BackColor = System.Drawing.Color.Transparent;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            //clicking the panel will let program know you are dragging it
            dragging = true;
            start_point = new Point(e.X, e.Y);
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            //releasing mouse button means you are not dragging anymore
            dragging = false;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            //let you drag the program anywhere in the screen
            if (dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.start_point.X, p.Y - this.start_point.Y);
            }
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            start_point = new Point(e.X, e.Y);
        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.start_point.X, p.Y - this.start_point.Y);
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            reset = true;
            Startbtn.Text = "Start";
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            reset = true;
            Startbtn.Text = "Start";
        }

        private void OnTimeEvent(object sender, ElapsedEventArgs e)
        {
            if (work == true && change == true)
            {
                min = wmin;
                change = false;
                MakeTomatoRed();

            }
            else if (work == false && change == true && restcount < 4 )
            {
                min = rmin;
                change = false;
                MakeTomatoGreen();
            }
            else if (work == false && change == true && restcount >= 4)
            {
                min = lrmin;
                change = false;
                MakeTomatoGreen();
            }
            sec -= 1; //decreasing seconds
            Invoke(new Action(() =>
            {
                //if sec reaches zero
                if (sec < 0)
                {
                    sec = 59;
                    min -= 1;
                }
                
                // display time
                Timer.Text = string.Format("{0}:{1}", min.ToString().PadLeft(2, '0'), sec.ToString().PadLeft(2, '0'));
                if (min == 0 && sec == 0)
                {
                    if (work == false && restcount <= 2)
                    {
                        restcount++;
                    }
                    else if (work == false && restcount >= 3)
                        restcount = 0;
                    work = !work;
                    change = true;
                }
                

            }));
        }

        private void Startbtn_Click(object sender, EventArgs e)
        {
            
            if (reset)
            {
                wmin = Convert.ToInt32(Math.Round(numericUpDown1.Value, 0));
                rmin = Convert.ToInt32(Math.Round(numericUpDown2.Value, 0));
                sec = 0;
                min = wmin;
                Timer.Text = string.Format("{0}:{1}", min.ToString().PadLeft(2, '0'), sec.ToString().PadLeft(2, '0'));
                work = true;
                change = true;
                MakeTomatoRed();
                // set long rest time
                if (wmin > 40)
                    lrmin = 30;
                else if (wmin < 40)
                    lrmin = 20;
            }
            //get the location of panel 1 and set the location to panel 2
            //shows panel 2 and hides panel 1
            panel2.Location = panel1.Location;
            panel1.Hide();
            panel2.Show();

        }

        private void Backbtn_Click(object sender, EventArgs e)
        {
            //shows panel 1 and hides panel 2
            panel1.Location = panel2.Location;
            panel2.Hide();
            panel1.Show();
            time.Stop();
            Pause.Text = "Start";
            Startbtn.Text = "Resume";
            reset = false;
        }

        private void Pause_Click(object sender, EventArgs e)
        {
            // if button starts or pauses depending on the text on the button
            Button btn = sender as Button;
            string p = btn.Text;
            if (p == "Start")
            {
                time.Start();
                Pause.Text = "Pause";
            }

            if (p == "Pause")
            {
                time.Stop();
                Pause.Text = "Start";
            }
        }

        private void Quitbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Quitbtn2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
//////////////////////////////////////////////////////////////
///////////////Made by: John Benedict D. Malabanan////////////
///////////////email me @: jb11malabanan@gmail.com////////////
//////////////////////////////////////////////////////////////
////////Just made this for programming practice///////////////
//////////Feel free to message me if you want to use it///////
//////////////////////////////////////////////////////////////
