﻿namespace Forms
{
    partial class Viewdoc
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            panelBottom = new Panel();
            panel2 = new Panel();
            label14 = new Label();
            labelID = new Label();
            label12 = new Label();
            label11 = new Label();
            textBox9 = new TextBox();
            label10 = new Label();
            textBox11 = new TextBox();
            textBox10 = new TextBox();
            numericUpDown2 = new NumericUpDown();
            label9 = new Label();
            textBox5 = new TextBox();
            label6 = new Label();
            label5 = new Label();
            textBox4 = new TextBox();
            numericUpDown1 = new NumericUpDown();
            label8 = new Label();
            label4 = new Label();
            textBox3 = new TextBox();
            label7 = new Label();
            textBox2 = new TextBox();
            label13 = new Label();
            textBox1 = new TextBox();
            panel2_2 = new Panel();
            btnNOCambios = new Button();
            btnOKCambios = new Button();
            label2 = new Label();
            panel3 = new Panel();
            btnOKDelete = new Button();
            btnNODelete = new Button();
            label15 = new Label();
            labelDelID = new Label();
            label3 = new Label();
            panel4 = new Panel();
            button1 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            panelBottom.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            panel2_2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 69, 76);
            panel1.Controls.Add(panelBottom);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(dataGridView1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(883, 500);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // panelBottom
            // 
            panelBottom.Controls.Add(panel2);
            panelBottom.Controls.Add(panel3);
            panelBottom.Dock = DockStyle.Bottom;
            panelBottom.Location = new Point(0, 265);
            panelBottom.Name = "panelBottom";
            panelBottom.Size = new Size(883, 201);
            panelBottom.TabIndex = 29;
            // 
            // panel2
            // 
            panel2.Controls.Add(label14);
            panel2.Controls.Add(labelID);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(textBox9);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(textBox11);
            panel2.Controls.Add(textBox10);
            panel2.Controls.Add(numericUpDown2);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(textBox5);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(textBox4);
            panel2.Controls.Add(numericUpDown1);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(textBox3);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(label13);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(panel2_2);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(883, 158);
            panel2.TabIndex = 29;
            panel2.Visible = false;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label14.ForeColor = Color.White;
            label14.Location = new Point(584, 66);
            label14.Name = "label14";
            label14.Size = new Size(28, 21);
            label14.TabIndex = 77;
            label14.Text = "ID:";
            // 
            // labelID
            // 
            labelID.AutoSize = true;
            labelID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelID.ForeColor = Color.White;
            labelID.Location = new Point(618, 66);
            labelID.Name = "labelID";
            labelID.Size = new Size(58, 21);
            labelID.TabIndex = 76;
            labelID.Text = "labelID";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label12.ForeColor = Color.White;
            label12.Location = new Point(559, 3);
            label12.Name = "label12";
            label12.Size = new Size(30, 15);
            label12.TabIndex = 68;
            label12.Text = "Tipo";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label11.ForeColor = Color.White;
            label11.Location = new Point(381, 100);
            label11.Name = "label11";
            label11.Size = new Size(124, 15);
            label11.TabIndex = 75;
            label11.Text = "Numero de Colegiado";
            // 
            // textBox9
            // 
            textBox9.Location = new Point(559, 21);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(139, 23);
            textBox9.TabIndex = 63;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = Color.White;
            label10.Location = new Point(381, 50);
            label10.Name = "label10";
            label10.Size = new Size(157, 15);
            label10.TabIndex = 74;
            label10.Text = "Numero de Seguridad Social";
            // 
            // textBox11
            // 
            textBox11.Location = new Point(381, 68);
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(160, 23);
            textBox11.TabIndex = 73;
            // 
            // textBox10
            // 
            textBox10.Location = new Point(381, 118);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(160, 23);
            textBox10.TabIndex = 72;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(381, 21);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(139, 23);
            numericUpDown2.TabIndex = 71;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.White;
            label9.Location = new Point(381, 3);
            label9.Name = "label9";
            label9.Size = new Size(25, 15);
            label9.TabIndex = 70;
            label9.Text = "NIF";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(214, 68);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(139, 23);
            textBox5.TabIndex = 69;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(214, 50);
            label6.Name = "label6";
            label6.Size = new Size(56, 15);
            label6.TabIndex = 68;
            label6.Text = "Provincia";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(214, 3);
            label5.Name = "label5";
            label5.Size = new Size(60, 15);
            label5.TabIndex = 67;
            label5.Text = "Poblacion";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(214, 21);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(139, 23);
            textBox4.TabIndex = 66;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(214, 119);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 62;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(214, 100);
            label8.Name = "label8";
            label8.Size = new Size(81, 15);
            label8.TabIndex = 65;
            label8.Text = "Codigo postal";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(3, 100);
            label4.Name = "label4";
            label4.Size = new Size(52, 15);
            label4.TabIndex = 64;
            label4.Text = "Telefono";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(3, 118);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(176, 23);
            textBox3.TabIndex = 63;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(3, 50);
            label7.Name = "label7";
            label7.Size = new Size(57, 15);
            label7.TabIndex = 58;
            label7.Text = "Direccion";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(3, 68);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(176, 23);
            textBox2.TabIndex = 57;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label13.ForeColor = Color.White;
            label13.Location = new Point(3, 3);
            label13.Name = "label13";
            label13.Size = new Size(51, 15);
            label13.TabIndex = 56;
            label13.Text = "Nombre";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(3, 21);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(176, 23);
            textBox1.TabIndex = 55;
            // 
            // panel2_2
            // 
            panel2_2.Controls.Add(btnNOCambios);
            panel2_2.Controls.Add(btnOKCambios);
            panel2_2.Dock = DockStyle.Right;
            panel2_2.Location = new Point(812, 0);
            panel2_2.Name = "panel2_2";
            panel2_2.Size = new Size(71, 158);
            panel2_2.TabIndex = 1;
            // 
            // btnNOCambios
            // 
            btnNOCambios.Dock = DockStyle.Bottom;
            btnNOCambios.FlatAppearance.MouseDownBackColor = Color.Red;
            btnNOCambios.FlatAppearance.MouseOverBackColor = Color.Red;
            btnNOCambios.FlatStyle = FlatStyle.Flat;
            btnNOCambios.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnNOCambios.ForeColor = Color.White;
            btnNOCambios.Location = new Point(0, 78);
            btnNOCambios.Name = "btnNOCambios";
            btnNOCambios.Size = new Size(71, 80);
            btnNOCambios.TabIndex = 27;
            btnNOCambios.Text = "Cancelar";
            btnNOCambios.UseVisualStyleBackColor = true;
            btnNOCambios.Click += btnNOCambios_Click;
            // 
            // btnOKCambios
            // 
            btnOKCambios.Dock = DockStyle.Top;
            btnOKCambios.FlatAppearance.MouseDownBackColor = Color.Lime;
            btnOKCambios.FlatAppearance.MouseOverBackColor = Color.Lime;
            btnOKCambios.FlatStyle = FlatStyle.Flat;
            btnOKCambios.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnOKCambios.ForeColor = Color.White;
            btnOKCambios.Location = new Point(0, 0);
            btnOKCambios.Name = "btnOKCambios";
            btnOKCambios.Size = new Size(71, 76);
            btnOKCambios.TabIndex = 26;
            btnOKCambios.Text = "Confirmar";
            btnOKCambios.UseVisualStyleBackColor = true;
            btnOKCambios.Click += btnOKCambios_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 143);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 0;
            label2.Text = "label2";
            // 
            // panel3
            // 
            panel3.Controls.Add(btnOKDelete);
            panel3.Controls.Add(btnNODelete);
            panel3.Controls.Add(label15);
            panel3.Controls.Add(labelDelID);
            panel3.Controls.Add(label3);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 158);
            panel3.Name = "panel3";
            panel3.Size = new Size(883, 43);
            panel3.TabIndex = 28;
            panel3.Visible = false;
            // 
            // btnOKDelete
            // 
            btnOKDelete.Dock = DockStyle.Right;
            btnOKDelete.FlatAppearance.MouseDownBackColor = Color.Red;
            btnOKDelete.FlatAppearance.MouseOverBackColor = Color.Red;
            btnOKDelete.FlatStyle = FlatStyle.Flat;
            btnOKDelete.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnOKDelete.ForeColor = Color.White;
            btnOKDelete.Location = new Point(723, 0);
            btnOKDelete.Name = "btnOKDelete";
            btnOKDelete.Size = new Size(79, 43);
            btnOKDelete.TabIndex = 81;
            btnOKDelete.Text = "Eliminar";
            btnOKDelete.UseVisualStyleBackColor = true;
            btnOKDelete.Click += btnOKDelete_Click;
            // 
            // btnNODelete
            // 
            btnNODelete.Dock = DockStyle.Right;
            btnNODelete.FlatAppearance.MouseDownBackColor = Color.Red;
            btnNODelete.FlatAppearance.MouseOverBackColor = Color.Red;
            btnNODelete.FlatStyle = FlatStyle.Flat;
            btnNODelete.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnNODelete.ForeColor = Color.White;
            btnNODelete.Location = new Point(802, 0);
            btnNODelete.Name = "btnNODelete";
            btnNODelete.Size = new Size(81, 43);
            btnNODelete.TabIndex = 80;
            btnNODelete.Text = "Cancelar";
            btnNODelete.UseVisualStyleBackColor = true;
            btnNODelete.Click += btnNODelete_Click;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label15.ForeColor = Color.White;
            label15.Location = new Point(390, 11);
            label15.Name = "label15";
            label15.Size = new Size(28, 21);
            label15.TabIndex = 79;
            label15.Text = "ID:";
            // 
            // labelDelID
            // 
            labelDelID.AutoSize = true;
            labelDelID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelDelID.ForeColor = Color.White;
            labelDelID.Location = new Point(424, 11);
            labelDelID.Name = "labelDelID";
            labelDelID.Size = new Size(81, 21);
            labelDelID.TabIndex = 78;
            labelDelID.Text = "labelDelID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 28);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 0;
            label3.Text = "label3";
            // 
            // panel4
            // 
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(0, 466);
            panel4.Name = "panel4";
            panel4.Size = new Size(883, 34);
            panel4.TabIndex = 28;
            // 
            // button1
            // 
            button1.FlatAppearance.MouseDownBackColor = Color.Red;
            button1.FlatAppearance.MouseOverBackColor = Color.Red;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(452, 217);
            button1.Name = "button1";
            button1.Size = new Size(86, 33);
            button1.TabIndex = 26;
            button1.Text = "Eliminar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button4
            // 
            button4.FlatAppearance.MouseDownBackColor = Color.Lime;
            button4.FlatAppearance.MouseOverBackColor = Color.Lime;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ForeColor = Color.White;
            button4.Location = new Point(335, 217);
            button4.Name = "button4";
            button4.Size = new Size(86, 33);
            button4.TabIndex = 25;
            button4.Text = "Modificar";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.FlatAppearance.MouseDownBackColor = Color.Red;
            button3.FlatAppearance.MouseOverBackColor = Color.Red;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = Color.White;
            button3.Location = new Point(559, 217);
            button3.Name = "button3";
            button3.Size = new Size(86, 33);
            button3.TabIndex = 24;
            button3.Text = "Cerrar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.FlatAppearance.MouseDownBackColor = Color.Lime;
            button2.FlatAppearance.MouseOverBackColor = Color.Lime;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(229, 217);
            button2.Name = "button2";
            button2.Size = new Size(86, 33);
            button2.TabIndex = 23;
            button2.Text = "Registrar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(335, 9);
            label1.Name = "label1";
            label1.Size = new Size(203, 21);
            label1.TabIndex = 1;
            label1.Text = "DOCTORES REGISTRADOS";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(116, 33);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(628, 178);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Viewdoc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(883, 500);
            Controls.Add(panel1);
            Name = "Viewdoc";
            Text = "Viewdoc";
            Load += Viewdoc_Load;
            Shown += Viewdoc_Shown;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelBottom.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            panel2_2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dataGridView1;
        private Label label1;
        private Button button2;
        private Button button3;
        private Button button1;
        private Button button4;
        private Panel panel4;
        private Panel panelBottom;
        private Panel panel2;
        private Label label14;
        private Label labelID;
        private Label label12;
        private Label label11;
        private TextBox textBox9;
        private Label label10;
        private TextBox textBox11;
        private TextBox textBox10;
        private NumericUpDown numericUpDown2;
        private Label label9;
        private TextBox textBox5;
        private Label label6;
        private Label label5;
        private TextBox textBox4;
        private NumericUpDown numericUpDown1;
        private Label label8;
        private Label label4;
        private TextBox textBox3;
        private Label label7;
        private TextBox textBox2;
        private Label label13;
        private TextBox textBox1;
        private Panel panel2_2;
        private Button btnNOCambios;
        private Button btnOKCambios;
        private Label label2;
        private Panel panel3;
        private Button btnOKDelete;
        private Button btnNODelete;
        private Label label15;
        private Label labelDelID;
        private Label label3;
    }
}