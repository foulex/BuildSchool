using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextFileSamples003
{
    static class Program
    {
        /// <summary>
        /// 應用程式的主要進入點。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
    class Restaurant
    {
        public int Seq { get; set; }
        public string DishName { get; set; }
        public string Shop { get; set; }
        public string Address { get; set; }
        public string Tel { get; set; }

    }
}
