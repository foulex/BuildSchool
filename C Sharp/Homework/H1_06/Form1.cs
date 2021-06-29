using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace D2_06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //D2_06
            int ThisYear =int.Parse(textBox1.Text);
            DateTime Cdate = new DateTime(ThisYear, 1, 1); //設定成輸入年份的一月一號
            int Sat=0, Sun=0;
            while(Cdate.Year == ThisYear)
            {
                if (Cdate.DayOfWeek == DayOfWeek.Saturday)  Sat++;
                if (Cdate.DayOfWeek == DayOfWeek.Sunday)    Sun++;
                Cdate = Cdate.AddDays(1);
            }

            L_Sat.Text = Sat.ToString();
            L_Sun.Text = Sun.ToString();
            

            //D2_07
            //由於365天/7=52禮拜...1天
            //必定有52天的禮拜六與日，所以判定第一天與最後周來增加額外天數
            //第一天為禮拜五：平年沒事，閏年六加1
            //第一天為禮拜六：平年六加1，閏年日加1
            //第一天為禮拜日：平年日加1，閏年沒事

            /*if(DateTime.IsLeapYear(ThisYear))
             * {
             *      if(Cdate.DayOfWeek==DayOfWeek.Friday) Sat++;
             *      if(Cdate.DayOfWeek==DayOfWeek.Saturday) Sun++;
             * }
             *else
             * {
             *      if(Cdate.DayOfWeek==DayOfWeek.Saturday) Sat++;
             *      if(Cdate.DayOfWeek==DayOfWeek.Sunday) Sun++;
             * }
             * MessageBox.Show($"禮拜六有{Sat+52}天，禮拜日有{Sun+52}天。");
             *      
             */

            //D2_08
            //輸入民國時+1911年
        }
    }
}
