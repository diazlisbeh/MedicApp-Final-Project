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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Forms
{
    public partial class RegistroVacaciones : Form
    {
        public RegistroVacaciones()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var vaciones = new periodo_vacaciones();
            var service = new VacacionesService();
            var selected = (empleados)comboBox1.SelectedItem;
            vaciones.Empleado_ID = selected.ID;
            vaciones.Fecha_inicio = DateOnly.FromDateTime(dateTimePicker1.Value);
            vaciones.Fecha_fin = DateOnly.FromDateTime(dateTimePicker2.Value);

            int result = await service.AddVaciones(vaciones);

            if (result == 1) { MessageBox.Show("Se ha agregado el periodo de vaciones correctamente"); }
            else { MessageBox.Show("Ha ocurrido un error"); }
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void RegistroVacaciones_Load(object sender, EventArgs e)
        {
            var service = new EmpleadosService();
            var items = await service.GetEmpleados();

            foreach (var i in items)
            {
                comboBox1.Items.Add(i);
            }
            comboBox1.DisplayMember = "Nombre";
        }
    }
}
