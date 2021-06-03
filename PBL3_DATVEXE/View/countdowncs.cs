using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3_DATVEXE.View
{
    public partial class countdowncs : UserControl
    {
        int second = -1;
        int minute = 0;
        int ms = 0;
        public bool Check=false;
        public countdowncs()
        {
            InitializeComponent();
            setCountdown();
            
        }
        public void setCountdown()
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ms++;
            if (ms == 10)
            {
                second++;
                label1.Text = minute.ToString() + " : " + second.ToString();
                if (second == 59)
                {
                    second = -1;
                    minute++;
                }
                if (minute == 2)
                {
                    Check = true;
                    timer1.Enabled = false;
                }
                ms = 0;
            }
        }

       
    }
}
