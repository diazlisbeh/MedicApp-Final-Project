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

            vaciones.Empleado_ID = int.Parse(textBox1.Text);
            vaciones.Fecha_inicio = DateOnly.FromDateTime(dateTimePicker1.Value);
            vaciones.Fecha_fin = DateOnly.FromDateTime(dateTimePicker2.Value);

            int result = await service.AddVaciones(vaciones);

            if(result == 1) { MessageBox.Show("Se ha agregado el periodo de vaciones correctamente"); }
             else { MessageBox.Show("Ha ocurrido un error"); }
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
