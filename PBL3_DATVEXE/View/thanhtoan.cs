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
using PBL3_DATVEXE.DTO;

namespace PBL3_DATVEXE.View
{
    public partial class thanhtoan : Form
    {
        public thanhtoan()
        {
            InitializeComponent();
            load();
        }
        public void load()
        {
            bunifuDataGridView1.DataSource = BLL_TKVX.Instance.getallorder();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            bunifuDataGridView1.DataSource = BLL_TKVX.Instance.getallorder1(bunifuTextBox1.Text);
        }

        private void bunifuButton3_Click(object sender, EventArgs e)
        {
            if (bunifuDataGridView1.SelectedRows.Count == 1)
            {
                string id_order = bunifuDataGridView1.SelectedRows[0].Cells["id_order"].Value.ToString();
                string id_person = BLL_TKVX.Instance.getid(id_order);
                try
                {
                    BLL_Person.Instance.update(id_person);
                    MessageBox.Show("thanh cong");
                }catch(Exception l)
                {
                    MessageBox.Show("that bai");
                }
            }
            }
    }

}
