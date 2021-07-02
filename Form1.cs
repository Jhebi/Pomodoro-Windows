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
        }
        System.Timers.Timer time;
        int min, sec, wmin, rmin, lrmin;
        
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

        private void Backbtn_Click(object sender, EventArgs e)
        {
            //shows panel 1 and hides panel 2
            panel2.Hide();
            panel1.Show();
        }

        private void Quitbtn2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //setup timer
            time = new System.Timers.Timer();
            time.Interval = 1000; //1 second interval
            time.Elapsed += OnTimeEvent;
            //hides panel 2
            panel2.Hide();
        }

        private void OnTimeEvent(object sender, ElapsedEventArgs e)
        {
            sec += 1; //counting seconds
            Invoke(new Action(() =>
                {
                    if (sec == 60)
                    {
                        sec = 0;
                        min += 1;
                    }
                    Timer.Text = string.Format("{0}:{1}", min.ToString().PadLeft(2, '0'), sec.ToString().PadLeft(2, '0'));
                }));
            
        }

        private void Startbtn_Click(object sender, EventArgs e)
        {
            //shows panel 2 and hides panel 1
            panel1.Hide();
            panel2.Show();

        }

        private void Quitbtn_Click(object sender, EventArgs e)
        {
            //stops the timer
            time.Stop();
        }

       
    }
}
