using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace WeatherApp
{
    public partial class Form1 : Form
    {
        private Dictionary<String, String> citis = new Dictionary<string, string>();
        public Form1()
        {
            InitializeComponent();
            this.TopMost = true;
            this.WindowState = FormWindowState.Maximized;
            PutCities(comboBoxCities);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string city = ((KeyValuePair<string, string>)comboBoxCities.SelectedItem).Value;
            GetData.city_code(city, dataGridViewDays);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridViewDays.Width = dataGridViewDays.Columns.Cast<DataGridViewColumn>().Sum(x => x.Width)
                                    +(dataGridViewDays.RowHeadersVisible ? dataGridViewDays.RowHeadersWidth : 0) + dataGridViewDays.Margin.Horizontal;
            dataGridViewDays.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewDays.Columns[dataGridViewDays.ColumnCount - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
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
