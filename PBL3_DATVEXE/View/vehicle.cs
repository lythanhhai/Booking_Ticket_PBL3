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
    public partial class vehicle : Form
    {
        public vehicle()
        {
            InitializeComponent();
            load();
        }

        public void load()
        {
            dataGridView1.DataSource = BLL_vehicle.Instance.getallvehicle();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            textBox1.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            DTO_vehicle r = new DTO_vehicle();
            r.id_vehicle = textBox1.Text;
            r.type = textBox2.Text;
            r.name = textBox3.Text;
            r.number_seat = Convert.ToInt32(textBox4.Text);
            BLL_vehicle.Instance.add_vehicle(r);
            load();
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            DTO_vehicle r = new DTO_vehicle();
            r.id_vehicle = textBox1.Text;
            r.type = textBox2.Text;
            r.name = textBox3.Text;
            r.number_seat = Convert.ToInt32(textBox4.Text);
            BLL_vehicle.Instance.edit(r);
            load();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            DTO_vehicle r = new DTO_vehicle();
            r.id_vehicle = textBox1.Text;
            r.type = textBox2.Text;
            r.name = textBox3.Text;
            r.number_seat = Convert.ToInt32(textBox4.Text);
            BLL_vehicle.Instance.deletevehicle(r.id_vehicle);
            load();
        }

        private void reset_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }
    }
}
