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

        private async void button3_Click(object sender, EventArgs e)
        {
            var empleado = new empleados();
            var service = new EmpleadosService();

            empleado.Nombre = textBox1.Text;
            empleado.Direccion = textBox2.Text;
            empleado.Telefono = textBox3.Text;
            empleado.Poblacion = textBox4.Text;
            empleado.Provincia = textBox5.Text;
            empleado.Codigo_Postal = Convert.ToInt32(numericUpDown1.Value);
            empleado.NIF = Convert.ToInt32(numericUpDown2.Value);
            empleado.Numero_de_seguridad_social = textBox8.Text;
            empleado.Tipo_empleado = comboBox1.SelectedIndex + 1;

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

        private void FormEmpleados_Load(object sender, EventArgs e)
        {
            //comboBox1.DataContext = this;
        }
    }
}
