using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DictionarySample001
{
    public partial class Form1 : Form
    {
        private Dictionary<string, MyRectangle> _dictionary;
        private void CreateDictionary()
        {
            _dictionary = new Dictionary<string, MyRectangle>();
            _dictionary.Add("D1", new MyRectangle { Width = 5, Height = 5 });
            _dictionary.Add("D2", new MyRectangle { Width = 10, Height = 10 });
            _dictionary.Add("D3", new MyRectangle { Width = 20, Height = 20 });
            _dictionary.Add("D4", new MyRectangle { Width = 100, Height = 100 });
        }

        public Form1()
        {
            InitializeComponent();
            CreateDictionary();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string key = textBox1.Text;
            if (_dictionary.ContainsKey(key))
            {
                int area = _dictionary[key].GetArea();
                MessageBox.Show($"{key} 的面積為： {area}");
            }
            else
            {
                MessageBox.Show("查無資料");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
