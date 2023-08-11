using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms
{
    public partial class RegisCitas : Form
    {
        public RegisCitas()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void RegisCitas_Load(object sender, EventArgs e)
        {
            // Con esto, el campo de dia de la semana se puede llenar sin necesidad de un textbox/combobox
            string dia = dateTimePicker1.Value.DayOfWeek.ToString();
            dateTimePicker1.Value = DateTime.Today;
        }
    }
}
