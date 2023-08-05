﻿using System;
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
    public partial class Viewdoc : Form
    {
        public Viewdoc()
        {
            InitializeComponent();
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

        }
    }
}