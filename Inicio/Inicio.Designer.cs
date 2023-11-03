namespace Inicio
{
    partial class Inicio
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
            lblTitle = new Label();
            btnPersonas = new Button();
            button1 = new Button();
            button2 = new Button();
            groupBox1 = new GroupBox();
            button6 = new Button();
            button7 = new Button();
            groupBox2 = new GroupBox();
            button4 = new Button();
            groupBox3 = new GroupBox();
            button5 = new Button();
            button3 = new Button();
            button8 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Bahnschrift", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.Location = new Point(12, 12);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(703, 57);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Menú principal";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnPersonas
            // 
            btnPersonas.Location = new Point(6, 36);
            btnPersonas.Name = "btnPersonas";
            btnPersonas.Size = new Size(189, 44);
            btnPersonas.TabIndex = 1;
            btnPersonas.Text = "USUARIOS";
            btnPersonas.UseVisualStyleBackColor = true;
            btnPersonas.Click += btnPersonas_Click;
            // 
            // button1
            // 
            button1.Location = new Point(6, 86);
            button1.Name = "button1";
            button1.Size = new Size(189, 48);
            button1.TabIndex = 2;
            button1.Text = "PLANES";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(6, 140);
            button2.Name = "button2";
            button2.Size = new Size(189, 47);
            button2.TabIndex = 3;
            button2.Text = "ESPECIALIDADES";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button6);
            groupBox1.Controls.Add(btnPersonas);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Location = new Point(34, 100);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(201, 284);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "ADMINISTRADOR";
            // 
            // button6
            // 
            button6.Location = new Point(6, 193);
            button6.Name = "button6";
            button6.Size = new Size(189, 42);
            button6.TabIndex = 4;
            button6.Text = "MATERIAS";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(5, 126);
            button7.Name = "button7";
            button7.Size = new Size(189, 61);
            button7.TabIndex = 5;
            button7.Text = "REPORTE DE CURSOS";
            button7.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button4);
            groupBox2.Location = new Point(263, 100);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(200, 284);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "ALUMNO";
            // 
            // button4
            // 
            button4.Location = new Point(6, 103);
            button4.Name = "button4";
            button4.Size = new Size(188, 61);
            button4.TabIndex = 0;
            button4.Text = "INSCRIBIRSE A MATERIAS";
            button4.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(button7);
            groupBox3.Controls.Add(button5);
            groupBox3.Location = new Point(499, 100);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(200, 284);
            groupBox3.TabIndex = 6;
            groupBox3.TabStop = false;
            groupBox3.Text = "PROFESOR";
            // 
            // button5
            // 
            button5.Location = new Point(6, 59);
            button5.Name = "button5";
            button5.Size = new Size(188, 61);
            button5.TabIndex = 0;
            button5.Text = "CARGAR NOTAS";
            button5.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(263, 407);
            button3.Name = "button3";
            button3.Size = new Size(96, 23);
            button3.TabIndex = 7;
            button3.Text = "Cerrar Sesión";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button8
            // 
            button8.DialogResult = DialogResult.Abort;
            button8.Location = new Point(367, 407);
            button8.Name = "button8";
            button8.Size = new Size(96, 23);
            button8.TabIndex = 8;
            button8.Text = "Salir";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // Inicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = button8;
            ClientSize = new Size(727, 457);
            Controls.Add(button8);
            Controls.Add(button3);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Inicio";
            StartPosition = FormStartPosition.CenterParent;
            Text = "ACADEMIA";
            FormClosed += Inicio_FormClosed;
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label lblTitle;
        private Button btnPersonas;
        private Button button1;
        private Button button2;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button button4;
        private GroupBox groupBox3;
        private Button button5;
        private Button button3;
        private Button button6;
        private Button button7;
        private Button button8;
    }
}