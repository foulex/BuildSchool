using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListSample003
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
    class MyRect
    {
        public string   Name    { get; set; }
        public int      Width   { get; set; }
        public int      Height  { get; set; }
        public int      Area
        {
            get { return Width * Height; }
        }  
    }
}
