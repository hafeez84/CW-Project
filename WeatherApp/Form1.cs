using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherApp
{
    public partial class Form1 : Form
    {
        private Dictionary<String, String> citis = new Dictionary<string, string>();
        public Form1()
        {
            InitializeComponent();
            PutCities(comboBoxCities);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string si = ((KeyValuePair<string, string>)comboBoxCities.SelectedItem).Value;
            //string si = comboBoxCities.Items[comboBoxCities.SelectedIndex].ToString();
            Console.WriteLine(si);
            GetData.city_name(si, dataGridViewDays);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void PutCities(ComboBox box)
        {   // values are woeid taken from metaweather.com
            citis.Add("London", "44418");
            citis.Add("Istanbul", "2344116");
            citis.Add("Ankara", "2343732");
            citis.Add("Brussels", "968019");
            citis.Add("Paris", "615702");
            citis.Add("Copenhagen", "554890");
            citis.Add("Barcelona", "753692");

            box.DataSource = new BindingSource(citis, null);
            box.DisplayMember = "Key";
            box.ValueMember = "Value";
        }
    }
}
