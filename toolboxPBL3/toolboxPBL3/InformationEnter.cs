using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace toolboxPBL3
{
    public partial class InformationEnter : UserControl
    {
        public InformationEnter()
        {
            InitializeComponent();
        }

       public string GetlbName()
        {
            return lbNme.Text;
        }
        public void SetlbName(string s)
        {
            lbNme.Text = s;
        }
        public string GetlbPhone()
        {
            return lbphone.Text;
        }
        public void SetlbPhone(string s)
        {
            lbphone.Text = s;
        }
        public string GetlbEmail()
        {
            return lbemail.Text;
        }
        public void SetlbEmail(string s)
        {
            lbemail.Text = s;
        }
        public string GetlbNote()
        {
            return lbnote.Text;
        }
        public void SetlbNote(string s)
        {
            lbnote.Text = s;
        }
    }
}
