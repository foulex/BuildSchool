using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListSample002
{
    public partial class Form1 : Form
    {
        private List<MyRect> _List;
        private void CreateList()
        {
            _List = new List<MyRect>()
            {
             new MyRect { name = "D1", Width = 5,   Height = 5 },
             new MyRect { name = "D2", Width = 10,  Height = 10 },
             new MyRect { name = "D3", Width = 20,  Height = 20 },
             new MyRect { name = "D4", Width = 100, Height = 100 }
            };
        }
        private void SetComboBox()
        {
            comboBox1.DataSource = _List;
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "Area";
        }
        public Form1()
        {
            InitializeComponent();
            CreateList();
            SetComboBox();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int area = (int)comboBox1.SelectedValue;
            MessageBox.Show(area.ToString());
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
