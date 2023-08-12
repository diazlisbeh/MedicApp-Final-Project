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
    public partial class vacaciones : Form
    {
        private VacacionesService _service;
        const int BottomY = 158;
        public vacaciones()
        {
            InitializeComponent();
            _service = new VacacionesService();
        }

        private async void fillDataGrid()
        {
            var vacaciones = await _service.GetVaciones();
            this.dataGridView1.DataSource = vacaciones;
        }
        private async void vacaciones_Load(object sender, EventArgs e)
        {
            fillDataGrid();

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

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFormulary<RegistroVacaciones>();
            panel2.Visible = false;
            panel3.Visible = false;
            panelBottom.Height = 1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private async void btnOKCambios_Click(object sender, EventArgs e)
        {
            var vaca = new periodo_vacaciones();

            vaca.ID = int.Parse(labelID.Text);
            vaca.Fecha_inicio = DateOnly.FromDateTime(dateTimePicker1.Value);
            vaca.Fecha_fin = DateOnly.FromDateTime(dateTimePicker2.Value);


            bool validation = Utils.Validate(vaca);

            if (validation)
            {
                int res = await _service.Update(vaca.ID, vaca);

                if (res == 1)
                {
                    MessageBox.Show("Se ha agregado correctamente");
                    this.Close();
                }
                else { MessageBox.Show("Ha ocurrido un error al guardar los datos"); }

            }
            panel2.Visible = false;
            panelBottom.Height = 1;
            fillDataGrid();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panelBottom.Height = BottomY;
            panel3.Visible = false;
            panel2.Visible = true;

            labelID.Text = dataGridView1.CurrentRow.Cells["ID"].Value.ToString();
            dateTimePicker1.Value = DateTime.Parse(dataGridView1.CurrentRow.Cells["Fecha_inicio"].Value.ToString());
            dateTimePicker2.Value = DateTime.Parse(dataGridView1.CurrentRow.Cells["Fecha_fin"].Value.ToString());
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            panelBottom.Height = BottomY;
            panel2.Visible = false;
            panel3.Visible = true;
            labelDelID.Text = dataGridView1.CurrentRow.Cells["ID"].Value.ToString();
        }

        private void btnNOCambios_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panelBottom.Height = 1;
        }

        private async void btnOKDelete_Click(object sender, EventArgs e)
        {
            // La funcione de Delete va aqui!!
            DialogResult result = MessageBox.Show("¿Seguro desea eliminar al Doctor?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                int res = await _service.DeleteVaciones(int.Parse(labelDelID.Text));
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
