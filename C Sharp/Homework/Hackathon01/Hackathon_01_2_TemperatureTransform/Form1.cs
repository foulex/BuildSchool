using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Hackathon_01_2_TemperatureTransform
{

    //溫度換算☆☆☆
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void InsertNumber(string s)
        {
            if (textBox.Text == "0")
            {
                textBox.Text = "";
            }
            textBox.Text += s;
        }
        private void B_0_Click(object sender, EventArgs e)
        { InsertNumber("0"); }

        private void B_Dot_Click(object sender, EventArgs e)
        { InsertNumber("."); }

        private void B_1_Click(object sender, EventArgs e)
        { InsertNumber("1"); }

        private void B_2_Click(object sender, EventArgs e)
        { InsertNumber("2"); }

        private void B_3_Click(object sender, EventArgs e)
        { InsertNumber("3"); }

        private void B_4_Click(object sender, EventArgs e)
        { InsertNumber("4"); }

        private void B_5_Click(object sender, EventArgs e)
        { InsertNumber("5"); }

        private void B_6_Click(object sender, EventArgs e)
        { InsertNumber("6"); }

        private void B_7_Click(object sender, EventArgs e)
        { InsertNumber("7"); }

        private void B_8_Click(object sender, EventArgs e)
        { InsertNumber("8"); }

        private void B_9_Click(object sender, EventArgs e)
        { InsertNumber("9"); }

        private void B_Clear_Click(object sender, EventArgs e)
        { textBox.Text = "0"; }

        string Result;

        private void B_Convert_Click(object sender, EventArgs e)
        {
            Result = Regex.Replace(textBox.Text,"[^.0-9]","").Trim('0');
            textBox.Text = Result;
            if (R_CtoF.Checked)
            {
                Result = (9 / 5 * (double.Parse(Result)) + 32).ToString() + "˚C";
            }
            else
            {
                Result = ((double.Parse(Result) - 32) * 5 / 9).ToString() + "˚F";
            }
            Label_Result.Text = Result;
        }
    }
}
