using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hackathon_01_4_Guess
{
    public partial class Form1 : Form
    {
        Random              Random      = new Random();
        List<string>        GameList    = new List<string>(),
                            PlayerList  = new List<string>(),
                            NumList     = Enumerable.Range(0, 10).Select(x => x.ToString()).ToList();
        IEnumerable<string> ExcNums;

        public Form1()
        {
            InitializeComponent();
        }

        private void B_Start_Click(object sender, EventArgs e)
        {
            AnsList.Items.Clear();
            B_Start.Enabled     = false;
            B_Ans.Enabled       = true;
            B_Send.Enabled      = true;
            B_Giveup.Enabled    = true;

            for (int i = 0; i <= 3; i++)
            {
                ExcNums = NumList.Except(GameList);
                GameList.Add(ExcNums
                        .ElementAt(Random.Next(0, ExcNums.Count()))
                        .ToString());
            }
        }

        private void B_Ans_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"答案是{string.Join(" ",GameList)}");
        }

        private void B_Send_Click(object sender, EventArgs e)
        {
            textBox.Text = Regex.Replace(textBox.Text, "[^0-9]","");
            if (textBox.Text.Length == 4)
            {
                PlayerList = textBox.Text.Split().ToList();
                while (true)
                {

                }

                
                //MessageBox.Show($"答案是{string.Join(" ", PlayerList)}");
                AnsList.Items.Add(string.Join("",PlayerList));
            }else MessageBox.Show($"請輸入剛好四位數字。");



        }

        private void B_Giveup_Click(object sender, EventArgs e)
        {

        }
    }
}
