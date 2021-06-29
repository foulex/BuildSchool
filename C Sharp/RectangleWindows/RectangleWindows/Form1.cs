using System;
using RectangleLibrary;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RectangleWindows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label3.Text = RectangleOperationHelper.ComArea
                          (new RectangleLibrary.Rectangle 
                          { Width = Decimal.ToInt32(numericUpDown1.Value), 
                           Height = Decimal.ToInt32(numericUpDown2.Value) }).ToString();
        }
    }
}
