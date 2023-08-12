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
    public partial class Citasmed : Form
    {
        private ConsultasService _service;
        const int BottomY = 158;
        public Citasmed()
        {
            InitializeComponent();
            _service = new ConsultasService();
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
            OpenFormulary<RegisCitas>();
            panel2.Visible = false;
            panel3.Visible = false;
            panelBottom.Height = 1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void fillDataGrid()
        {
            //var service = new ConsultasService();
            var consultas = await _service.GetConsultas();
            dataGridView1.DataSource = consultas;
        }

        private async void Citasmed_Load(object sender, EventArgs e)
        {
            fillDataGrid();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panelBottom.Height = BottomY;
            panel3.Visible = false;
            panel2.Visible = true;

            labelID.Text = dataGridView1.CurrentRow.Cells["Consulta_ID"].Value.ToString();
            dateTimePicker1.Value = DateTime.Parse(dataGridView1.CurrentRow.Cells["Fecha"].Value.ToString());
            dateTimePicker2.Value = DateTime.Parse(dataGridView1.CurrentRow.Cells["Hora_inicio"].Value.ToString());
            dateTimePicker3.Value = DateTime.Parse(dataGridView1.CurrentRow.Cells["Hora_fin"].Value.ToString());
        }

        private async void btnOKCambios_Click(object sender, EventArgs e)
        {
            consultas citas = new consultas();

            citas.Consulta_ID = int.Parse(labelID.Text);
            citas.Fecha = DateOnly.FromDateTime(dateTimePicker1.Value);
            citas.Hora_inicio = TimeOnly.FromDateTime(dateTimePicker2.Value);
            citas.Hora_fin = TimeOnly.FromDateTime(dateTimePicker3.Value);
            citas.Dia_de_Semana = dateTimePicker1.Value.DayOfWeek.ToString();

            bool validation = Utils.Validate(citas);

            if (validation)
            {
                int res = await _service.Update(citas.Consulta_ID, citas);

                if (res == 1)
                {
                    MessageBox.Show("Se ha agregado correctamente");
                    this.Close();
                }
                else { MessageBox.Show("Ha ocurrido un error al guardar los datos"); }

            }
            // La funcion de guardar va aqui!!

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
                int res = await _service.DeleteConsulta(int.Parse(labelDelID.Text));
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
