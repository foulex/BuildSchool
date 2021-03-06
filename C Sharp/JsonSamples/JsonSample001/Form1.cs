using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JsonSample001
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
        }

        async private void button1_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            string URI = "https://lod2.apc.gov.tw/API/v1/dump/datastore/A53000000A-000003-001";
            string data = await client.GetStringAsync(URI);
            var result = JsonConvert.DeserializeObject<Class1[]>(data);
            dataGridView1.DataSource = result[0].result.records;

        }
    }
}
