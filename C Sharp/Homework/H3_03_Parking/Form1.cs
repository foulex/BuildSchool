using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace H3_03_Parking
{
    public partial class Form1 : Form
    {
        float Total;
        int x;
        int[] Price = { 30, 40, 60 };
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Total = (dateTimePicker_Leave.Value - dateTimePicker_Enter.Value).Hours;
            MessageBox.Show($"{Total}");
            if (Total <= 2)
            {
                x = 0;
            }
            else if (Total <= 4)
            {
                x = 1;
            }
            else x = 2;
            label_Price.Text=$"應繳{Total*2*Price[x]}";
            
        }
    }
}
