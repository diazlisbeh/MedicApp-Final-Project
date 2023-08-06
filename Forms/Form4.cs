using BusinessLogic;
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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        //Method to open formularies within the panel
        private void OpenFormulary<Myform>() where Myform : Form, new()
        {
            Form formulary;
            formulary = panel1.Controls.OfType<Myform>().FirstOrDefault();//Look in the formulary collection
            //if the formulary/instance does not exist
            if (formulary == null)
            {
                formulary = new Myform();
                formulary.TopLevel = false;
                formulary.FormBorderStyle = FormBorderStyle.None;
                formulary.Dock = DockStyle.Fill;
                panel1.Controls.Add(formulary);
                panel1.Tag = formulary;
                formulary.Show();
                formulary.BringToFront();
            }
            //if the formulary/instance exist 
            else
            {
                formulary.BringToFront();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFormulary<Form2>();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private async void Form4_Load(object sender, EventArgs e)
        {
            var service = new PacienteServices();
            var pacientes = await service.GetPacientes();
            this.dataGridView1.DataSource = pacientes;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
