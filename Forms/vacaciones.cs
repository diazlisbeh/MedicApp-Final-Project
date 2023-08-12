using BusinessLogic;
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
        public vacaciones()
        {
            InitializeComponent();
            _service = new VacacionesService();
        }

        private async void vacaciones_Load(object sender, EventArgs e)
        {
            
            var vacaciones = await _service.GetVaciones();
            this.dataGridView1.DataSource = vacaciones;
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

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOKCambios_Click(object sender, EventArgs e)
        {
/*
            bool validation = Utils.Validate(vaciones);

            if (validation)
            {
                int res = await _service.Update(vaciones);

                if (res == 1)
                {
                    MessageBox.Show("Se ha agregado correctamente");
                    this.Close();
                }
                else { MessageBox.Show("Ha ocurrido un error al guardar los datos"); }

            }*/
        }
    }
}
