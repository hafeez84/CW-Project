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

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void PutCities(ComboBox box)
        {
            citis.Add("London", "london");
            citis.Add("Istanbul", "istanbul");
            citis.Add("Ankara", "ankara");
            citis.Add("Brussels", "brussels");
            citis.Add("Paris", "paris");
            citis.Add("Samsun", "samsun");
            citis.Add("Trabzon", "trabzon");

            box.DataSource = new BindingSource(citis, null);
            box.DisplayMember = "Key";
            box.ValueMember = "Value";
        }
    }
}
