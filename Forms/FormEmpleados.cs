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
    public partial class FormEmpleados : Form
    {
        public FormEmpleados()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private async void button3_Click(object sender, EventArgs e)
        {
            var empleado = new empleados();
            var service = new EmpleadosService();
            var selected = (tipo_empleado)comboBox1.SelectedItem;
            empleado.Nombre = textBox1.Text;
            empleado.Direccion = textBox2.Text;
            empleado.Telefono = textBox3.Text;
            empleado.Poblacion = textBox4.Text;
            empleado.Provincia = textBox5.Text;
            empleado.Codigo_Postal = (int)numericUpDown1.Value;
            empleado.NIF = (int)numericUpDown2.Value;
            empleado.Numero_de_seguridad_social = textBox8.Text;
            empleado.Tipo_empleado = selected.ID;

            int result = await service.AddEmpleado(empleado);


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*     var service = new TipoEmpleadoService();
                 var lis = service.GetTipoEmpleado();
                 comboBox1.Items.AddRange(lis.id);*/
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void FormEmpleados_LoadAsync(object sender, EventArgs e)
        {
            var service = new TipoEmpleadoService();
            var tipo = await service.GetTipoEmpleado();
            foreach (var i in tipo)
            {
                comboBox1.Items.Add(i);
            }
            comboBox1.DisplayMember = "Tipo";
            numericUpDown1.Maximum = int.MaxValue - 1;
            numericUpDown2.Maximum = int.MaxValue - 1;
        }
    }
}
