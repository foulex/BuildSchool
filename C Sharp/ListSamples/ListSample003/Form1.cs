using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListSample003
{
    public partial class Form1 : Form
    {
        private List<MyRect> ComboList;
        private void CreateList() {
            ComboList = new List<MyRect>()
            {
                new MyRect{Name="D1",   Width=5,    Height=5},
                new MyRect{Name="D2",   Width=10,   Height=10},
                new MyRect{Name="D3",   Width=20,   Height=20},
                new MyRect{Name="D4",   Width=100,  Height=100},
            };
        }
        private void SetCombobox()
        {
            comboBox1.DataSource    = ComboList;
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember   = "Area";
        }
        public Form1()
        {
            InitializeComponent();
            CreateList();
            SetCombobox();
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox theComboBox = (ComboBox)sender;
            int index = theComboBox.SelectedIndex;
            MyRect item = ComboList[index];
            MessageBox.Show($"取得索引{index}的面積為：{item.Area}。");
        }
    }
}
