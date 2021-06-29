using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FarmerMove2
{
    public partial class Form1 : Form
    {
        //初始設定
        List<string> LList = new List<string>() { "農夫", "野狼", "綿羊", "蔬菜" }, 
                     RList = new List<string>();

        bool    FarmerAtLeft = true;

        private void button_Click(object sender, EventArgs e)
        {           
            if      (LeftSide.SelectedItem  != null) 
            {
                LList.Remove((string)LeftSide.SelectedItem); RList.Add((string)LeftSide.SelectedItem);
            }
            else if (RightSide.SelectedItem != null) 
            {
                RList.Remove((string)RightSide.SelectedItem);LList.Add((string)RightSide.SelectedItem);
            }

            MoveFarmer();
            RefreshWindow();
            var WhereSheep = LList.Count(x=>x=="綿羊");
            var WhereWolf = LList.Count(x=>x=="野狼");
            var WhereVeg = LList.Count(x=>x=="蔬菜");

            if      (FarmerAtLeft==true && WhereSheep !=0)  {/*農夫跟綿羊在一起，一切安全不會出事。*/}
            else if (WhereWolf != WhereSheep)               { MessageBox.Show("野狼吃了綿羊。");}
            else if (WhereVeg != WhereSheep)                { MessageBox.Show("綿羊吃了蔬菜。");}

        }

        private void SetListBoxDataSource()
        { 
            LeftSide.SelectionMode  = SelectionMode.One; 
            RightSide.SelectionMode = SelectionMode.One; 
        }

        private void RefreshWindow()
        {
            LeftSide.DataSource     = null;
            RightSide.DataSource    = null;
            LeftSide.DataSource     = LList;
            RightSide.DataSource    = RList;
        }

        public void MoveFarmer()
        {
            if  (FarmerAtLeft)
                {LList.Remove("農夫"); RList.Add("農夫");}
            else{RList.Remove("農夫"); LList.Add("農夫");}
            FarmerAtLeft = !(FarmerAtLeft);
        }
        public Form1()
        {
            InitializeComponent();
            SetListBoxDataSource();
            RefreshWindow();
        }
    }
}
