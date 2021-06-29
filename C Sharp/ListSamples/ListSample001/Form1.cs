using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListSample001
{
    public partial class Form1 : Form
    {
        private List<MyRect> _List;
        private void CreateList()
        {
            _List = new List<MyRect>();
            _List.Add(new MyRect { name = "D1", Width = 5, Height = 5 });
            _List.Add(new MyRect { name = "D2", Width = 10, Height = 10 });
            _List.Add(new MyRect { name = "D3", Width = 20, Height = 20 });
            _List.Add(new MyRect { name = "D4", Width = 100, Height = 100 });
        }

        public Form1()
        {
            InitializeComponent();
            CreateList();
            SetComboBox();
        }
        private void SetComboBox()
        {
            comboBox1.DataSource = _List;
            comboBox1.DisplayMember = "Name";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MyRect item = (MyRect)comboBox1.SelectedItem;
            MessageBox.Show($"{item.name}的面積為：{item.GetArea()}");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
