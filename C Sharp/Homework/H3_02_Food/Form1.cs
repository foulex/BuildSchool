using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace H4_02_滷味
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();       
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Total = 0;
            int[] BuyNums = new int[4], Price = { 30, 17, 15, 40 };
            string RS3="";
            string[] TFoods = {TFood1.Text,TFood2.Text,TFood3.Text,TFood4.Text};
            List<int> MC = new List<int>();

            for(int i=0 ; i<=3 ; i++)
            {
                if(TFoods[i]=="")
                { TFoods[i] = "0"; }
                else
                { BuyNums[i] =int.Parse(TFoods[i]); }
                Total += BuyNums[i] * Price[i];
            }
            LMPrice.Text = $"總價:{Total}元";

            string TotalString = "00"+Total.ToString();
            char[] RS2=TotalString.ToCharArray();
            Array.Reverse(RS2);
            RS3=new string(RS2);
            foreach(var c in RS3)
            { MC.Add(c); }

            if (MC[0] >= 5)
            {
                MC[0] -= 5;
                LM5.Text = "5元:1枚";
            }else { LM5.Text = "5元:0枚"; }

            LM1.Text = "1元:" + MC[0].ToString() + "枚";

            if (MC[1] >= 5)
            {
                MC[1] -= 5;
                LM50.Text = "50元:1枚";
            }
            else { LM50.Text = "5元:0枚"; }
            LM10.Text = "10元:" + MC[1].ToString() + "枚";

            if (MC[2] >= 5)
            {
                MC[2] -= 5;
                LM500.Text = "500鈔:1張";
            }
            else { LM500.Text = "500鈔:0張"; }
            LM100.Text = "100鈔:" + MC[2].ToString() + "張";
            LM1000.Text = "1000鈔:" + (Total-Total%1000)/1000 + "張";
        }
    }
}