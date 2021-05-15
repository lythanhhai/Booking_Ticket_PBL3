using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL3_DATVEXE.BLL;

namespace PBL3_DATVEXE.View
{
    public partial class QLVX : Form
    {
        public QLVX()
        {
            InitializeComponent();
            load();
        }
        public void load()
        {
            dataGridView1.DataSource = BLL_QLVX.Instance.getallQLVX();
        }
    }
}
