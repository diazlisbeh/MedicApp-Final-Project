﻿namespace Forms
{
    partial class FormEmpleados
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
            numericUpDown1 = new NumericUpDown();
            numericUpDown2 = new NumericUpDown();
            button3 = new Button();
            button2 = new Button();
            comboBox1 = new ComboBox();
            label8 = new Label();
            label9 = new Label();
            textBox8 = new TextBox();
            label10 = new Label();
            label7 = new Label();
            label6 = new Label();
            textBox5 = new TextBox();
            label5 = new Label();
            textBox4 = new TextBox();
            label4 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(numericUpDown1);
            panel1.Controls.Add(numericUpDown2);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(textBox8);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(textBox5);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(textBox4);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(883, 500);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(364, 265);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 1;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(671, 107);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(157, 23);
            numericUpDown2.TabIndex = 2;
            // 
            // button3
            // 
            button3.FlatAppearance.MouseDownBackColor = Color.Lime;
            button3.FlatAppearance.MouseOverBackColor = Color.Lime;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = Color.White;
            button3.Location = new Point(248, 375);
            button3.Name = "button3";
            button3.Size = new Size(86, 33);
            button3.TabIndex = 24;
            button3.Text = "Guardar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.FlatAppearance.MouseDownBackColor = Color.Red;
            button2.FlatAppearance.MouseOverBackColor = Color.Red;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(540, 375);
            button2.Name = "button2";
            button2.Size = new Size(86, 33);
            button2.TabIndex = 23;
            button2.Text = "Cerrar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(671, 264);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(157, 23);
            comboBox1.TabIndex = 22;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(671, 240);
            label8.Name = "label8";
            label8.Size = new Size(134, 21);
            label8.TabIndex = 21;
            label8.Text = "Tipo de Empleado";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.White;
            label9.Location = new Point(671, 157);
            label9.Name = "label9";
            label9.Size = new Size(209, 21);
            label9.TabIndex = 19;
            label9.Text = "Numero de Seguridad Social";
            // 
            // textBox8
            // 
            textBox8.Location = new Point(671, 181);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(157, 23);
            textBox8.TabIndex = 18;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = Color.White;
            label10.Location = new Point(671, 82);
            label10.Name = "label10";
            label10.Size = new Size(34, 21);
            label10.TabIndex = 17;
            label10.Text = "NIF";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(364, 240);
            label7.Name = "label7";
            label7.Size = new Size(105, 21);
            label7.TabIndex = 15;
            label7.Text = "Codigo Postal";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(364, 157);
            label6.Name = "label6";
            label6.Size = new Size(74, 21);
            label6.TabIndex = 13;
            label6.Text = "Provincia";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(364, 181);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(157, 23);
            textBox5.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(364, 82);
            label5.Name = "label5";
            label5.Size = new Size(77, 21);
            label5.TabIndex = 11;
            label5.Text = "Poblacion";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(364, 106);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(157, 23);
            textBox4.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(12, 240);
            label4.Name = "label4";
            label4.Size = new Size(68, 21);
            label4.TabIndex = 9;
            label4.Text = "Telefono";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(12, 264);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(157, 23);
            textBox3.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(12, 157);
            label3.Name = "label3";
            label3.Size = new Size(75, 21);
            label3.TabIndex = 7;
            label3.Text = "Direccion";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 181);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(202, 23);
            textBox2.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(12, 82);
            label2.Name = "label2";
            label2.Size = new Size(68, 21);
            label2.TabIndex = 5;
            label2.Text = "Nombre";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 106);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(202, 23);
            textBox1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(328, 9);
            label1.Name = "label1";
            label1.Size = new Size(209, 21);
            label1.TabIndex = 1;
            label1.Text = "REGISTRO DE EMPLEADOS";
            // 
            // FormEmpleados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 69, 76);
            ClientSize = new Size(883, 500);
            Controls.Add(panel1);
            Name = "FormEmpleados";
            Text = "FormEmpleados";
            Load += FormEmpleados_LoadAsync;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Label label4;
        private TextBox textBox3;
        private Label label3;
        private TextBox textBox2;
        private Label label5;
        private TextBox textBox4;
        private Label label8;
        private Label label9;
        private TextBox textBox8;
        private Label label10;
        private Label label7;
        private Label label6;
        private TextBox textBox5;
        private ComboBox comboBox1;
        private Button button3;
        private Button button2;
        private NumericUpDown numericUpDown1;
        private NumericUpDown numericUpDown2;
    }
}