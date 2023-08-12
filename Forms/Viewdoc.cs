using BusinessLogic;
using DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms
{
    public partial class Viewdoc : Form
    {
        private MedicosService _service;
        const int BottomY = 158;

        public Viewdoc()
        {
            InitializeComponent();
            numericUpDown1.Maximum = int.MaxValue - 1;
            numericUpDown2.Maximum = int.MaxValue - 1;
            _service = new MedicosService();
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
            OpenFormulary<Form3>();
            panel2.Visible = false;
            panel3.Visible = false;
            panelBottom.Height = 1;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private async void fillDataGrid()
        {
            dataGridView1.DataSource = null;
            List<MedicosDto> listamedicos = await _service.GetMedicosWithSustituto();
            dataGridView1.DataSource = listamedicos;
        }

        private void Viewdoc_Load(object sender, EventArgs e)
        {
            fillDataGrid();
            panelBottom.Height = 1;
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
            textBox10.Text = dataGridView1.CurrentRow.Cells["Numero_de_colegiado"].Value.ToString();
            textBox9.Text = dataGridView1.CurrentRow.Cells["Tipo"].Value.ToString();
        }

        private async void btnOKCambios_Click(object sender, EventArgs e)
        {
            var doc = new Medico();


            doc.ID = int.Parse(labelID.Text);
            doc.Nombre = textBox1.Text;
            doc.Direccion = textBox2.Text;
            doc.Telefono = textBox3.Text;
            doc.Poblacion = textBox4.Text;
            doc.Provincia = textBox5.Text;
            doc.Codigo_Postal = (int)numericUpDown1.Value;
            doc.NIF = (int)numericUpDown2.Value;
            doc.Numero_de_seguridad_social = textBox11.Text;
            doc.Numero_de_colegiado = textBox10.Text;
            doc.Tipo = textBox9.Text;

            // La funcion de guardar va aqui!!
            int res = await _service.Update(doc.ID, doc);
            if (res == 1) MessageBox.Show("Se ha actualizado correctamente");
            //else { MessageBox.Show("Ha ocurrido un error al intentar guardar"); }
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
            // La funcione de Delete va aqui!!
            DialogResult result = MessageBox.Show("¿Seguro desea eliminar al Doctor?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                int res = await _service.DeleteMedico(int.Parse(labelDelID.Text));
                if (res == 1) MessageBox.Show("Se ha eliminado correctamente");
            }
            //  int res = await _service.DeleteMedico(int.Parse(labelDelID.Text));

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
