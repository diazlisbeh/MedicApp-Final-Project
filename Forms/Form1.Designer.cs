namespace Forms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            panel3 = new Panel();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            btnMini = new Button();
            btnMaxi = new Button();
            btnCerrar = new Button();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            groupBox1 = new GroupBox();
            pictureBox10 = new PictureBox();
            button2 = new Button();
            pictureBox9 = new PictureBox();
            pictureBox8 = new PictureBox();
            button1 = new Button();
            pictureBox7 = new PictureBox();
            pictureBox6 = new PictureBox();
            btnCiudades = new Button();
            btnProfesionales = new Button();
            btnClientes = new Button();
            btnDashboard = new Button();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AllowDrop = true;
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1100, 788);
            panel1.TabIndex = 0;
            panel1.MouseDown += panel1_MouseDown;
            // 
            // panel4
            // 
            panel4.AllowDrop = true;
            panel4.BackColor = Color.FromArgb(55, 61, 69);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(201, 750);
            panel4.Margin = new Padding(3, 2, 3, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(899, 38);
            panel4.TabIndex = 5;
            panel4.MouseDown += panel4_MouseDown;
            // 
            // panel5
            // 
            panel5.AllowDrop = true;
            panel5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel5.BackColor = Color.FromArgb(64, 69, 76);
            panel5.Location = new Point(203, 65);
            panel5.Margin = new Padding(3, 2, 3, 2);
            panel5.Name = "panel5";
            panel5.Size = new Size(894, 681);
            panel5.TabIndex = 4;
            panel5.Paint += panel5_Paint;
            panel5.MouseDown += panel5_MouseDown;
            // 
            // panel3
            // 
            panel3.AllowDrop = true;
            panel3.BackColor = Color.FromArgb(214, 61, 92);
            panel3.Controls.Add(pictureBox5);
            panel3.Controls.Add(pictureBox4);
            panel3.Controls.Add(pictureBox3);
            panel3.Controls.Add(pictureBox2);
            panel3.Controls.Add(btnMini);
            panel3.Controls.Add(btnMaxi);
            panel3.Controls.Add(btnCerrar);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(201, 0);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(899, 61);
            panel3.TabIndex = 3;
            panel3.Paint += panel3_Paint;
            panel3.MouseDown += panel3_MouseDown;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(715, 15);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(21, 18);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 6;
            pictureBox5.TabStop = false;
            pictureBox5.Click += pictureBox5_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(674, 15);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(21, 18);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 5;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(633, 15);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(21, 18);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(6, 9);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(35, 30);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // btnMini
            // 
            btnMini.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            btnMini.BackColor = Color.Transparent;
            btnMini.BackgroundImageLayout = ImageLayout.Stretch;
            btnMini.Cursor = Cursors.Hand;
            btnMini.FlatAppearance.BorderSize = 0;
            btnMini.FlatStyle = FlatStyle.Flat;
            btnMini.Location = new Point(1236, 18);
            btnMini.Margin = new Padding(3, 2, 3, 2);
            btnMini.Name = "btnMini";
            btnMini.Size = new Size(21, 1);
            btnMini.TabIndex = 2;
            btnMini.UseVisualStyleBackColor = false;
            // 
            // btnMaxi
            // 
            btnMaxi.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            btnMaxi.BackColor = Color.Transparent;
            btnMaxi.BackgroundImageLayout = ImageLayout.Stretch;
            btnMaxi.Cursor = Cursors.Hand;
            btnMaxi.FlatAppearance.BorderSize = 0;
            btnMaxi.FlatStyle = FlatStyle.Flat;
            btnMaxi.Location = new Point(1263, 18);
            btnMaxi.Margin = new Padding(3, 2, 3, 2);
            btnMaxi.Name = "btnMaxi";
            btnMaxi.Size = new Size(21, 1);
            btnMaxi.TabIndex = 1;
            btnMaxi.UseVisualStyleBackColor = false;
            // 
            // btnCerrar
            // 
            btnCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            btnCerrar.BackColor = Color.Transparent;
            btnCerrar.BackgroundImageLayout = ImageLayout.Stretch;
            btnCerrar.Cursor = Cursors.Hand;
            btnCerrar.FlatAppearance.BorderSize = 0;
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.Location = new Point(1291, 18);
            btnCerrar.Margin = new Padding(3, 2, 3, 2);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(21, 1);
            btnCerrar.TabIndex = 0;
            btnCerrar.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.AllowDrop = true;
            panel2.BackColor = Color.FromArgb(29, 34, 39);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(groupBox1);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(201, 788);
            panel2.TabIndex = 2;
            panel2.MouseDown += panel2_MouseDown;
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(10, 9);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(185, 111);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.AutoSize = true;
            groupBox1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            groupBox1.Controls.Add(pictureBox10);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(pictureBox9);
            groupBox1.Controls.Add(pictureBox8);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(pictureBox7);
            groupBox1.Controls.Add(pictureBox6);
            groupBox1.Controls.Add(btnCiudades);
            groupBox1.Controls.Add(btnProfesionales);
            groupBox1.Controls.Add(btnClientes);
            groupBox1.Controls.Add(btnDashboard);
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.Location = new Point(0, 124);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(200, 223);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            // 
            // pictureBox10
            // 
            pictureBox10.Image = (Image)resources.GetObject("pictureBox10.Image");
            pictureBox10.Location = new Point(9, 172);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(35, 30);
            pictureBox10.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox10.TabIndex = 14;
            pictureBox10.TabStop = false;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderColor = Color.Gray;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 69, 76);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(5, 166);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(191, 36);
            button2.TabIndex = 6;
            button2.Text = "VACACIONES";
            button2.TextAlign = ContentAlignment.MiddleRight;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // pictureBox9
            // 
            pictureBox9.Image = (Image)resources.GetObject("pictureBox9.Image");
            pictureBox9.Location = new Point(8, 21);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(35, 30);
            pictureBox9.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox9.TabIndex = 13;
            pictureBox9.TabStop = false;
            // 
            // pictureBox8
            // 
            pictureBox8.Image = (Image)resources.GetObject("pictureBox8.Image");
            pictureBox8.Location = new Point(9, 138);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(35, 30);
            pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox8.TabIndex = 12;
            pictureBox8.TabStop = false;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderColor = Color.Gray;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 69, 76);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(5, 137);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(191, 36);
            button1.TabIndex = 11;
            button1.Text = "EMPLEADOS";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(9, 60);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(35, 30);
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.TabIndex = 10;
            pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(9, 102);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(35, 30);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 9;
            pictureBox6.TabStop = false;
            // 
            // btnCiudades
            // 
            btnCiudades.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCiudades.Cursor = Cursors.Hand;
            btnCiudades.FlatAppearance.BorderColor = Color.Gray;
            btnCiudades.FlatAppearance.BorderSize = 0;
            btnCiudades.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 69, 76);
            btnCiudades.FlatStyle = FlatStyle.Flat;
            btnCiudades.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCiudades.ForeColor = Color.White;
            btnCiudades.ImageAlign = ContentAlignment.MiddleLeft;
            btnCiudades.Location = new Point(200, 145);
            btnCiudades.Margin = new Padding(3, 2, 3, 2);
            btnCiudades.Name = "btnCiudades";
            btnCiudades.Size = new Size(191, 36);
            btnCiudades.TabIndex = 8;
            btnCiudades.Text = "CIUDADES";
            btnCiudades.TextAlign = ContentAlignment.MiddleRight;
            btnCiudades.UseVisualStyleBackColor = true;
            // 
            // btnProfesionales
            // 
            btnProfesionales.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnProfesionales.Cursor = Cursors.Hand;
            btnProfesionales.FlatAppearance.BorderColor = Color.Gray;
            btnProfesionales.FlatAppearance.BorderSize = 0;
            btnProfesionales.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 69, 76);
            btnProfesionales.FlatStyle = FlatStyle.Flat;
            btnProfesionales.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnProfesionales.ForeColor = Color.White;
            btnProfesionales.ImageAlign = ContentAlignment.MiddleLeft;
            btnProfesionales.Location = new Point(8, 103);
            btnProfesionales.Margin = new Padding(3, 2, 3, 2);
            btnProfesionales.Name = "btnProfesionales";
            btnProfesionales.Size = new Size(191, 36);
            btnProfesionales.TabIndex = 7;
            btnProfesionales.Text = "DOCTORES";
            btnProfesionales.TextAlign = ContentAlignment.MiddleRight;
            btnProfesionales.UseVisualStyleBackColor = true;
            btnProfesionales.Click += btnProfesionales_Click;
            // 
            // btnClientes
            // 
            btnClientes.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClientes.Cursor = Cursors.Hand;
            btnClientes.FlatAppearance.BorderColor = Color.Gray;
            btnClientes.FlatAppearance.BorderSize = 0;
            btnClientes.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 69, 76);
            btnClientes.FlatStyle = FlatStyle.Flat;
            btnClientes.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnClientes.ForeColor = Color.White;
            btnClientes.ImageAlign = ContentAlignment.MiddleLeft;
            btnClientes.Location = new Point(6, 61);
            btnClientes.Margin = new Padding(3, 2, 3, 2);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(191, 36);
            btnClientes.TabIndex = 6;
            btnClientes.Text = "PACIENTES";
            btnClientes.TextAlign = ContentAlignment.MiddleRight;
            btnClientes.UseVisualStyleBackColor = true;
            btnClientes.Click += btnClientes_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDashboard.Cursor = Cursors.Hand;
            btnDashboard.FlatAppearance.BorderColor = Color.Gray;
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 69, 76);
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnDashboard.ForeColor = Color.White;
            btnDashboard.ImageAlign = ContentAlignment.MiddleLeft;
            btnDashboard.Location = new Point(8, 19);
            btnDashboard.Margin = new Padding(3, 2, 3, 2);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(191, 36);
            btnDashboard.TabIndex = 5;
            btnDashboard.Text = "CONSULTAS";
            btnDashboard.TextAlign = ContentAlignment.MiddleRight;
            btnDashboard.UseVisualStyleBackColor = true;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 788);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            MouseDown += Form1_MouseDown;
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private Button btnMini;
        private Button btnMaxi;
        private Button btnCerrar;
        private Panel panel2;
        private PictureBox pictureBox1;
        private GroupBox groupBox1;
        private Button btnCiudades;
        private Button btnProfesionales;
        private Button btnClientes;
        private Button btnDashboard;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private Panel panel4;
        private Panel panel5;
        private PictureBox pictureBox7;
        private PictureBox pictureBox6;
        private PictureBox pictureBox8;
        private Button button1;
        private PictureBox pictureBox9;
        private Button button2;
        private PictureBox pictureBox10;
    }
}