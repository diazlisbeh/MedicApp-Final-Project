using BusinessLogic;
using DataAccess;
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
    public partial class Form2 : Form
    {
        static pacientes paciente = new pacientes();
        static PacienteServices service = new PacienteServices();
        public Form2()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private async void button2_Click_1(object sender, EventArgs e)
        {


            paciente.Nombre = textBox1.Text;
            paciente.Direccion = textBox2.Text;
            paciente.Telefono = textBox3.Text;
            paciente.Codigo_Postal = Convert.ToInt32(numericUpDown1.Value);
            paciente.NIF = Convert.ToInt32(numericUpDown2.Value);
            paciente.Numero_de_seguridad_social = textBox6.Text;
            paciente.Medico_ID = int.Parse(comboBox1.Text);

            int result = await service.AddPaciente(paciente);

            if (result == 1) { MessageBox.Show("Se ha agregado el paciente correctamente"); }
            else { MessageBox.Show("Ha ocurrido un error"); }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void Form2_Load(object sender, EventArgs e)
        {
            //comboBox1.DataSource = await service.GetPacientes();
        }
    }
}
