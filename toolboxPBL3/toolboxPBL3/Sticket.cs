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
    public partial class Sticket : UserControl
    {
        public Sticket()
        {
            InitializeComponent();
        }
        public void SetSticket(ViewSticket s)
        {
            lbtimestart.Text = s.Start;
            lbtimend.Text = s.End;
            lbxuatphat.Text = s.XuatPhat;
            lbdiemden.Text = s.DiemDen;
            lbdanhgia.Text = s.DanhGia.ToString();
            lbsoghetrong.Text = s.NumberOfEmptySeats.ToString();
            lbprice.Text = s.Price.ToString();
        }
    }
}
