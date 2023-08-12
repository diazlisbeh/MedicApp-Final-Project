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
    public partial class Viewemplo : Form
    {
        private EmpleadosService _service;
        const int BottomY = 158;

        public Viewemplo()
        {
            InitializeComponent();
            numericUpDown1.Maximum = int.MaxValue - 1;
            numericUpDown2.Maximum = int.MaxValue - 1;
            _service = new EmpleadosService();
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
            OpenFormulary<FormEmpleados>();
            panel2.Visible = false;
            panel3.Visible = false;
            panelBottom.Height = 1;
        }

        private async void fillDataGrid()
        {
            dataGridView1.DataSource = null;
            List<empleados> listempleados = await _service.GetEmpleados();
            dataGridView1.DataSource = listempleados;
        }

        private async void Viewemplo_Load(object sender, EventArgs e)
        {
            fillDataGrid();
            panelBottom.Height = 1;

            // Para modificacion de empleados
            var service = new TipoEmpleadoService();
            var tipo = await service.GetTipoEmpleado();
            foreach (var i in tipo)
            {
                comboBox1.Items.Add(i);
            }
            comboBox1.DisplayMember = "Tipo";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panelBottom.Height = BottomY;
            panel3.Visible = false;
            panel2.Visible = true;

            labelID.Text = dataGridView1.CurrentRow.Cells["ID"].Value.ToString();
            textBox1.Text = dataGridView1.CurrentRow.Cells["Nombre"].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells["Direccion"].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells["Telefono"].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells["Poblacion"].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells["Provincia"].Value.ToString();
            numericUpDown1.Value = (int)dataGridView1.CurrentRow.Cells["Codigo_Postal"].Value;
            numericUpDown2.Value = (int)dataGridView1.CurrentRow.Cells["NIF"].Value;
            textBox11.Text = dataGridView1.CurrentRow.Cells["Numero_de_seguridad_social"].Value.ToString();
            int tipo = (int)dataGridView1.CurrentRow.Cells["Tipo_empleado"].Value;
            tipo_empleado item;
            int index = 0;
            for (int i = 0; i < comboBox1.Items.Count; i++)
            {
                item = (tipo_empleado)comboBox1.Items[i];
                if (item.ID == tipo) { index = i; break; }
            }
            comboBox1.SelectedIndex = index;
        }

        private async void btnOKCambios_Click(object sender, EventArgs e)
        {
            var emple = new empleados();
            var tipo = (tipo_empleado)comboBox1.SelectedItem;

            emple.ID = int.Parse(labelID.Text);
            emple.Nombre = textBox1.Text;
            emple.Direccion = textBox2.Text;
            emple.Telefono = textBox3.Text;
            emple.Poblacion = textBox4.Text;
            emple.Provincia = textBox5.Text;
            emple.Codigo_Postal = (int)numericUpDown1.Value;
            emple.NIF = (int)numericUpDown2.Value;
            emple.Numero_de_seguridad_social = textBox11.Text;
            emple.Tipo_empleado = tipo.ID;

            // La funcion de guardar va aqui!!
            bool validation = Utils.Validate(emple);

            if (validation)
            {
                int res = await _service.Update(emple.ID, emple);

                if (res == 1)
                {
                    MessageBox.Show("Se ha agregado correctamente","Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    this.Close();
                }
                else { MessageBox.Show("Ha ocurrido un error al guardar los datos"); }

            }

            panel2.Visible = false;
            panelBottom.Height = 1;
            fillDataGrid();
        }

        private void btnNOCambios_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panelBottom.Height = 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelBottom.Height = BottomY;
            panel2.Visible = false;
            panel3.Visible = true;
            labelDelID.Text = dataGridView1.CurrentRow.Cells["ID"].Value.ToString();
        }

        private async void btnOKDelete_Click(object sender, EventArgs e)
        {
            // Funcion de Delete
            DialogResult result = MessageBox.Show("¿Seguro desea eliminar al Empleado?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                int res = await _service.DeleteEmpleado(int.Parse(labelDelID.Text));
                if (res == 1) MessageBox.Show("Se ha eliminado correctamente");
            }

            panel3.Visible = false;
            panelBottom.Height = 1;
            fillDataGrid();
        }

        private void btnNODelete_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
            panelBottom.Height = 1;
        }

        private void panel1_ControlAdded(object sender, ControlEventArgs e)
        {
            fillDataGrid();
        }
    }
}
