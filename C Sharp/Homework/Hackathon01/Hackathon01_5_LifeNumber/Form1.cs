using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hackathon01_5_LifeNumber
{
    public partial class Form1 : Form
    {
        List<Zodiac> ZList;
        public Form1()
        {
            InitializeComponent();
        }

        int Year, Month, Day, TheNums = 0;

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            Year = dateTimePicker1.Value.Year;
            Month = dateTimePicker1.Value.Month;
            Day = dateTimePicker1.Value.Day;

            foreach (var i in Year.ToString()) TheNums += i - '0';
            foreach (var i in Month.ToString()) TheNums += i - '0';
            foreach (var i in Day.ToString()) TheNums += i - '0';
            if (TheNums > 10)
            {
                int j = 0;
                foreach (var i in TheNums.ToString()) j += i - '0';
                TheNums = j;
            }
        }
    }
}
