﻿namespace Forms
{
    partial class RegistroVacaciones
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
            textBox10 = new TextBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            button3 = new Button();
            button1 = new Button();
            button2 = new Button();
            label3 = new Label();
            label2 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // textBox10
            // 
            textBox10.Location = new Point(327, 158);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(100, 23);
            textBox10.TabIndex = 19;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(28, 158);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(156, 23);
            textBox1.TabIndex = 20;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(623, 158);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 21;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(275, 9);
            label1.Name = "label1";
            label1.Size = new Size(227, 21);
            label1.TabIndex = 22;
            label1.Text = "REGISTRO DE VACACIONES ";
            // 
            // button3
            // 
            button3.FlatAppearance.MouseDownBackColor = Color.Red;
            button3.FlatAppearance.MouseOverBackColor = Color.Red;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = Color.White;
            button3.Location = new Point(28, 376);
            button3.Name = "button3";
            button3.Size = new Size(86, 33);
            button3.TabIndex = 26;
            button3.Text = "Cancelar ";
            button3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.FlatAppearance.MouseDownBackColor = Color.Lime;
            button1.FlatAppearance.MouseOverBackColor = Color.Lime;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(341, 376);
            button1.Name = "button1";
            button1.Size = new Size(86, 33);
            button1.TabIndex = 27;
            button1.Text = "Guardar ";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.FlatAppearance.MouseDownBackColor = Color.Red;
            button2.FlatAppearance.MouseOverBackColor = Color.Red;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(623, 376);
            button2.Name = "button2";
            button2.Size = new Size(86, 33);
            button2.TabIndex = 28;
            button2.Text = "Cerrar";
            button2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(327, 140);
            label3.Name = "label3";
            label3.Size = new Size(70, 15);
            label3.TabIndex = 29;
            label3.Text = "Fecha inicio";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(28, 140);
            label2.Name = "label2";
            label2.Size = new Size(74, 15);
            label2.TabIndex = 30;
            label2.Text = "Empleado ID";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(623, 140);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 31;
            label4.Text = "Fecha fin ";
            label4.Click += label4_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 69, 76);
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(button3);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(textBox10);
            Name = "RegistroVacaciones";
            Text = "RegistroVacaciones";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox10;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Button button3;
        private Button button1;
        private Button button2;
        private Label label3;
        private Label label2;
        private Label label4;
    }
}