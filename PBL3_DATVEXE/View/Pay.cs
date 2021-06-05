using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3_DATVEXE.View
{
    public partial class Pay : UserControl
    {
        int second = -1;
        int minute = 0;
        int ms = 0;
        public Pay()
        {
            InitializeComponent();
            setCountdown();
        }
        public void setCountdown()
        {
            timer1.Enabled = true;
        }

       

        
    }
}
