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
    public partial class QLVX : Form
    {
        public QLVX()
        {
            InitializeComponent();
            load();
            load_statistics();
        }
        public void load_statistics()
        {
            List<DTO_route> list = BLL_Route.Instance.getallRoute();
            comboBox1.Items.Add(new CBBitem
            {
                Text = "",
                Value = "0"
            });
            foreach (var i in list)
            {
                comboBox1.Items.Add(new CBBitem
                {
                    Value = i.id_route,
                    Text = i.departure + "-" + i.arrival
                });
            }
            comboBox1.SelectedIndex = 0;
            List<DTO_vehicle> list1 = BLL_vehicle.Instance.getallvehicle();
            comboBox2.Items.Add(new CBBitem
            {
                Text = "",
                Value = "0"
            });
            foreach (var i in list1)
            {
                comboBox2.Items.Add(new CBBitem
                {
                    Value = i.id_vehicle,
                    Text = i.name
                });
            }
            comboBox2.SelectedIndex = 0;
            List<DTO_DelRoute> list3 = BLL_delRoute.Instance.getallDetRoute();
            comboBox3.Items.Add(new CBBitem
            {
                Text = "",
                Value = "0"
            });
            foreach (var i in list3)
            {
                comboBox3.Items.Add(new CBBitem
                {
                    Value = i.id_delroute,
                    Text = i.date.ToShortDateString()+"--"+ i.time_start
                });
            }
            comboBox3.SelectedIndex = 0;

        }

        public void load()
        {
            dataGridView1.DataSource = BLL_QLVX.Instance.getallQLVX();
        }
        public void Show1(string route, string vehicle, string date_route)
        {
            // dataGridView1.DataSource = BLL_QLVX.Instance.getQLVXBY(((CBBitem)comboBox1.SelectedItem).Value, ((CBBitem)comboBox2.SelectedItem).Value, ((CBBitem)comboBox3.SelectedItem).Value);
            dataGridView1.DataSource = BLL_QLVX.Instance.getQLVXBY(route, vehicle, date_route);

        }
        public void Show2(string route, string vehicle, string date_route, string name_person,string number)
        {
           
            dataGridView1.DataSource = BLL_QLVX.Instance.getQLVXBY1(route, vehicle, date_route, name_person,number);

        }

        private void thongke_Click(object sender, EventArgs e)
        {
            Show1(((CBBitem)comboBox1.SelectedItem).Text, ((CBBitem)comboBox2.SelectedItem).Text, ((CBBitem)comboBox3.SelectedItem).Text);
            textBox1.Text = BLL_QLVX.Instance.tt(((CBBitem)comboBox1.SelectedItem).Text, ((CBBitem)comboBox2.SelectedItem).Text, ((CBBitem)comboBox3.SelectedItem).Text).ToString();
            textBox2.Text = BLL_QLVX.Instance.tp(((CBBitem)comboBox1.SelectedItem).Text, ((CBBitem)comboBox2.SelectedItem).Text, ((CBBitem)comboBox3.SelectedItem).Text).ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Show2(((CBBitem)comboBox1.SelectedItem).Text, ((CBBitem)comboBox2.SelectedItem).Text, ((CBBitem)comboBox3.SelectedItem).Text,textBox4.Text,textBox3.Text);
        }
    }
}
