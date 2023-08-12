namespace Forms
{
    partial class vacaciones
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
            panelSuperBottom = new Panel();
            button1 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            label4 = new Label();
            label6 = new Label();
            panel1.SuspendLayout();
            panelBottom.SuspendLayout();
            panel2.SuspendLayout();
            panel2_2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 69, 76);
            panel1.Controls.Add(panelBottom);
            panel1.Controls.Add(panelSuperBottom);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(dataGridView1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(879, 500);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // panelBottom
            // 
            panelBottom.Controls.Add(panel2);
            panelBottom.Controls.Add(panel3);
            panelBottom.Dock = DockStyle.Bottom;
            panelBottom.Location = new Point(0, 265);
            panelBottom.Name = "panelBottom";
            panelBottom.Size = new Size(879, 201);
            panelBottom.TabIndex = 31;
            // 
            // panel2
            // 
            panel2.Controls.Add(dateTimePicker2);
            panel2.Controls.Add(dateTimePicker1);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label14);
            panel2.Controls.Add(labelID);
            panel2.Controls.Add(panel2_2);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(879, 158);
            panel2.TabIndex = 29;
            panel2.Visible = false;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label14.ForeColor = Color.White;
            label14.Location = new Point(616, 83);
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
            labelID.Location = new Point(650, 83);
            labelID.Name = "labelID";
            labelID.Size = new Size(58, 21);
            labelID.TabIndex = 76;
            labelID.Text = "labelID";
            // 
            // panel2_2
            // 
            panel2_2.Controls.Add(btnNOCambios);
            panel2_2.Controls.Add(btnOKCambios);
            panel2_2.Dock = DockStyle.Right;
            panel2_2.Location = new Point(808, 0);
            panel2_2.Name = "panel2_2";
            panel2_2.Size = new Size(71, 158);
            panel2_2.TabIndex = 1;
            // 
            // btnNOCambios
            // 
            btnNOCambios.Dock = DockStyle.Bottom;
            btnNOCambios.FlatAppearance.MouseDownBackColor = Color.DarkRed;
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
            // 
            // btnOKCambios
            // 
            btnOKCambios.Dock = DockStyle.Top;
            btnOKCambios.FlatAppearance.MouseDownBackColor = Color.Green;
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
            label2.Size = new Size(42, 15);
            label2.TabIndex = 0;
            label2.Text = "panel2";
            label2.Visible = false;
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
            panel3.Size = new Size(879, 43);
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
            btnOKDelete.Location = new Point(719, 0);
            btnOKDelete.Name = "btnOKDelete";
            btnOKDelete.Size = new Size(79, 43);
            btnOKDelete.TabIndex = 81;
            btnOKDelete.Text = "Eliminar";
            btnOKDelete.UseVisualStyleBackColor = true;
            // 
            // btnNODelete
            // 
            btnNODelete.Dock = DockStyle.Right;
            btnNODelete.FlatAppearance.MouseDownBackColor = Color.Green;
            btnNODelete.FlatAppearance.MouseOverBackColor = Color.Lime;
            btnNODelete.FlatStyle = FlatStyle.Flat;
            btnNODelete.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnNODelete.ForeColor = Color.White;
            btnNODelete.Location = new Point(798, 0);
            btnNODelete.Name = "btnNODelete";
            btnNODelete.Size = new Size(81, 43);
            btnNODelete.TabIndex = 80;
            btnNODelete.Text = "Cancelar";
            btnNODelete.UseVisualStyleBackColor = true;
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
            label3.Size = new Size(42, 15);
            label3.TabIndex = 0;
            label3.Text = "panel3";
            label3.Visible = false;
            // 
            // panelSuperBottom
            // 
            panelSuperBottom.Dock = DockStyle.Bottom;
            panelSuperBottom.Location = new Point(0, 466);
            panelSuperBottom.Name = "panelSuperBottom";
            panelSuperBottom.Size = new Size(879, 34);
            panelSuperBottom.TabIndex = 30;
            // 
            // button1
            // 
            button1.FlatAppearance.MouseDownBackColor = Color.DarkRed;
            button1.FlatAppearance.MouseOverBackColor = Color.Red;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(482, 217);
            button1.Name = "button1";
            button1.Size = new Size(86, 33);
            button1.TabIndex = 27;
            button1.Text = "Eliminar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // button4
            // 
            button4.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 64, 0);
            button4.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 0);
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ForeColor = Color.White;
            button4.Location = new Point(339, 217);
            button4.Name = "button4";
            button4.Size = new Size(86, 33);
            button4.TabIndex = 26;
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
            button3.Location = new Point(593, 217);
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
            button2.Location = new Point(202, 217);
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
            label1.Location = new Point(375, 9);
            label1.Name = "label1";
            label1.Size = new Size(110, 21);
            label1.TabIndex = 1;
            label1.Text = "VACACIONES";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(116, 33);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(628, 178);
            dataGridView1.TabIndex = 0;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Location = new Point(394, 50);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(111, 23);
            dateTimePicker2.TabIndex = 82;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(116, 50);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(111, 23);
            dateTimePicker1.TabIndex = 81;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(394, 26);
            label4.Name = "label4";
            label4.Size = new Size(76, 21);
            label4.TabIndex = 80;
            label4.Text = "Fecha fin ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(116, 26);
            label6.Name = "label6";
            label6.Size = new Size(91, 21);
            label6.TabIndex = 78;
            label6.Text = "Fecha inicio";
            // 
            // vacaciones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 69, 76);
            ClientSize = new Size(883, 500);
            Controls.Add(panel1);
            Name = "vacaciones";
            Text = "Form4";
            Load += vacaciones_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelBottom.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel2_2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button3;
        private Button button2;
        private Label label1;
        private DataGridView dataGridView1;
        private Button button4;
        private Button button1;
        private Panel panelBottom;
        private Panel panel2;
        private Label label14;
        private Label labelID;
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
        private Panel panelSuperBottom;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
        private Label label4;
        private Label label6;
    }
}