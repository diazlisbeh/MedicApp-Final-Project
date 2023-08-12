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
    public partial class Form4 : Form
    {
        private PacienteServices _service;
        public Form4()
        {
            InitializeComponent();
            numericUpDown1.Maximum = int.MaxValue - 1;
            numericUpDown2.Maximum = int.MaxValue - 1;
            _service = new PacienteServices();
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
                formulary.Refresh();
            }
        }

        const int BottomY = 158;

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFormulary<Form2>();
            panel2.Visible = false;
            panel3.Visible = false;
            panelBottom.Height = 1;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private async void fillDataGrid()
        {
            var pacientes = await _service.GetPacientes();
            this.dataGridView1.DataSource = pacientes;

        }

        private async void Form4_Load(object sender, EventArgs e)
        {
            fillDataGrid();
            panelBottom.Height = 1;
            // Modificacion de Pacientes
            var docservice = new MedicosService();
            var item = await docservice.GetMedicos();

            foreach (var i in item)
            {
                comboBox1.Items.Add(i);
            }
            comboBox1.DisplayMember = "Nombre";
            numericUpDown1.Maximum = int.MaxValue - 1;
            numericUpDown2.Maximum = int.MaxValue - 1;
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
            textBox5.Text = dataGridView1.CurrentRow.Cells["Numero_de_seguridad_social"].Value.ToString();
            numericUpDown1.Value = (int)dataGridView1.CurrentRow.Cells["Codigo_Postal"].Value;
            numericUpDown2.Value = (int)dataGridView1.CurrentRow.Cells["NIF"].Value;
            int medID = (int)dataGridView1.CurrentRow.Cells["Medico_ID"].Value;
            Medico item;
            int index = 0;
            for (int i = 0; i < comboBox1.Items.Count; i++)
            {
                item = (Medico)comboBox1.Items[i];
                if (item.ID == medID) { index = i; break; }
            }
            comboBox1.SelectedIndex = index;
        }

        private async void btnOKCambios_ClickAsync(object sender, EventArgs e)
        {
            var paci = new pacientes();
            var selectedMed = (Medico)comboBox1.SelectedItem;

            paci.ID = int.Parse(labelID.Text);
            paci.Nombre = textBox1.Text;
            paci.Direccion = textBox2.Text;
            paci.Telefono = textBox3.Text;
            paci.Numero_de_seguridad_social = textBox5.Text;
            paci.Codigo_Postal = (int)numericUpDown1.Value;
            paci.NIF = (int)numericUpDown2.Value;
            paci.Medico_ID = selectedMed.ID;

            // Guardar cambios
            int res = await _service.Update(paci.ID, paci);
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
            // Funcion de Delete
            DialogResult result = MessageBox.Show("¿Seguro desea eliminar al Paciente?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                int res = await _service.DeletePaciente(int.Parse(labelDelID.Text));
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
