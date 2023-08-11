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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            numericUpDown1.Maximum = int.MaxValue - 1;
            numericUpDown2.Maximum = int.MaxValue - 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var doctor = new Medico();
            var service = new MedicosService();

            doctor.Nombre = textBox1.Text;
            doctor.Direccion = textBox2.Text;
            doctor.Telefono = textBox3.Text;
            doctor.Poblacion = textBox4.Text;
            doctor.Provincia = textBox5.Text;
            doctor.Codigo_Postal = (int)numericUpDown1.Value;
            doctor.Tipo = textBox9.Text;
            doctor.NIF = (int)numericUpDown2.Value;
            doctor.Numero_de_colegiado = textBox10.Text;
            doctor.Numero_de_seguridad_social = textBox11.Text;

            int result = await service.AddMedicos(doctor);

            if (result == 0) { MessageBox.Show("Ha ocurrido un Error."); }
            else { MessageBox.Show("Se ha agregado el Medico exitosamente"); }
        }
    }
}
