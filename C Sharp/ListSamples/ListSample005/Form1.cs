using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListSample005
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            AnimalList();
        }

        private List<string> Animals;
        private void AnimalList()
        {
            Animals = new List<string>()
            {
                "Dog","Cat","Monkey","Fly","Donkey","Dog2"
            };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string result = Animals.Find((x) => x == textBox1.Text);
            MessageBox.Show($"Find: {result}");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int Index = Animals.FindIndex((x) => x == textBox1.Text);
            MessageBox.Show($"Find Index: {Index}");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //字串不只一個，所以需要使用List
            List<string> Ans = Animals.FindAll((x) => x.Contains(textBox1.Text));
            string result = string.Empty;
            foreach(string item in Ans)
            {
                result = result + item + ",";
            }
            MessageBox.Show($"Find All:{result}");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string result = Animals.FindLast((x) => x.Contains(textBox1.Text));
            MessageBox.Show($"Find Last:{result}");
        }
    }
}
