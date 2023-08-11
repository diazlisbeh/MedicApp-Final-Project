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
    public partial class RegisCitas : Form
    {
        public RegisCitas()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void RegisCitas_Load(object sender, EventArgs e)
        {
            var service = new MedicosService();
            var items = await service.GetMedicos();
            foreach (var i in items)
            {
                comboBox1.Items.Add(i);
            }
            comboBox1.DisplayMember = "Nombre";


            var servicePaciente = new PacienteServices();
            var itemsPacientes = await servicePaciente.GetPacientes();
            foreach (var i in itemsPacientes)
            {
                comboBox3.Items.Add(i);
            }
            comboBox3.DisplayMember = "Nombre";

        }

        private async void button2_Click(object sender, EventArgs e)
        {
            var service = new ConsultasService();
            var consulta = new consultas();
            var medicoId = (Medico)comboBox1.SelectedItem;
            var pacienteId = (pacientes)comboBox3.SelectedItem;

            consulta.Paciente_ID = pacienteId.ID;
            consulta.Medico_ID = medicoId.ID;
            consulta.Dia_de_Semana = comboBox2.SelectedItem.ToString();
            consulta.Fecha = dateTimePicker1.Value;
            consulta.Hora_inicio = TimeOnly.Parse (dateTimePicker4.Value.ToShortTimeString());
            consulta.Hora_fin = TimeOnly.Parse(dateTimePicker3.Value.ToShortTimeString());

            int res = await service.AddConsulta(consulta);
            if (res == 1)
            {
                MessageBox.Show("Se ha agregado la consulta correctamente");
                this.Close();
            }
            if(res == 0)MessageBox.Show("Ha ocurrido un error al agregar su consulta");

           
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
