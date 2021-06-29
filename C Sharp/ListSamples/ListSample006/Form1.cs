using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListSample006
{
    public partial class Form1 : Form
    {
        private List<string> _LeftList  = new List<string> { "A","B","C","D"};
        private List<string> _RightList = new List<string>();
        //省略CreateList()
        private void SetListBoxDataSource()
        {
            listBox1.SelectionMode = SelectionMode.One;
            listBox2.SelectionMode = SelectionMode.One;
        }
        private void ChangeData()
        {
            listBox1.DataSource = null;
            listBox2.DataSource = null;
            listBox1.DataSource = _LeftList;
            listBox2.DataSource = _RightList;
        }
        public Form1()
        {
            InitializeComponent();
            SetListBoxDataSource();
            ChangeData();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 從左移到右
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            if(listBox1.SelectedItem != null)
            {
                string SI = (string)listBox1.SelectedItem;
                _LeftList.Remove(SI);
                _RightList.Add(SI);
                ChangeData();
            }
        }
        /// <summary>
        /// 從右移到左
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedItem != null)
            {
                string SI = (string)listBox2.SelectedItem;
                _LeftList.Add(SI);
                _RightList.Remove(SI);
                ChangeData();
            }
        }
    }

}
