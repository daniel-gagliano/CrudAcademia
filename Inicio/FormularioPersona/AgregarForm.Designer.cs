namespace Inicio.FormularioPersona
{
    partial class AgregarForm
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
            groupBox2 = new GroupBox();
            txtIdPlan = new ComboBox();
            txtTipoPersona = new ComboBox();
            txtLegajo = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label8 = new Label();
            groupBox1 = new GroupBox();
            label1 = new Label();
            label3 = new Label();
            txtNombre = new TextBox();
            txtDireccion = new TextBox();
            label2 = new Label();
            txtTelefono = new TextBox();
            label4 = new Label();
            txtApellido = new TextBox();
            txtEmail = new TextBox();
            label7 = new Label();
            txtID = new TextBox();
            label9 = new Label();
            button2 = new Button();
            button1 = new Button();
            groupBox3 = new GroupBox();
            txtContraseña = new TextBox();
            txtUsuario = new TextBox();
            label11 = new Label();
            label10 = new Label();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtIdPlan);
            groupBox2.Controls.Add(txtTipoPersona);
            groupBox2.Controls.Add(txtLegajo);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label8);
            groupBox2.Location = new Point(450, 95);
            groupBox2.Margin = new Padding(4, 5, 4, 5);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4, 5, 4, 5);
            groupBox2.Size = new Size(406, 240);
            groupBox2.TabIndex = 64;
            groupBox2.TabStop = false;
            groupBox2.Text = "Academia";
            // 
            // txtIdPlan
            // 
            txtIdPlan.DropDownStyle = ComboBoxStyle.DropDownList;
            txtIdPlan.FormattingEnabled = true;
            txtIdPlan.Items.AddRange(new object[] { "2008", "2016", "2023" });
            txtIdPlan.Location = new Point(177, 177);
            txtIdPlan.Margin = new Padding(4, 5, 4, 5);
            txtIdPlan.Name = "txtIdPlan";
            txtIdPlan.Size = new Size(171, 33);
            txtIdPlan.TabIndex = 55;
            // 
            // txtTipoPersona
            // 
            txtTipoPersona.DropDownStyle = ComboBoxStyle.DropDownList;
            txtTipoPersona.FormattingEnabled = true;
            txtTipoPersona.Items.AddRange(new object[] { "Estudiante", "Profesor" });
            txtTipoPersona.Location = new Point(177, 118);
            txtTipoPersona.Margin = new Padding(4, 5, 4, 5);
            txtTipoPersona.Name = "txtTipoPersona";
            txtTipoPersona.Size = new Size(171, 33);
            txtTipoPersona.TabIndex = 54;
            // 
            // txtLegajo
            // 
            txtLegajo.Location = new Point(177, 63);
            txtLegajo.Margin = new Padding(4, 5, 4, 5);
            txtLegajo.Name = "txtLegajo";
            txtLegajo.Size = new Size(171, 31);
            txtLegajo.TabIndex = 51;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(19, 68);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(64, 25);
            label6.TabIndex = 43;
            label6.Text = "Legajo";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(19, 190);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(68, 25);
            label5.TabIndex = 42;
            label5.Text = "ID Plan";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(19, 132);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(141, 25);
            label8.TabIndex = 45;
            label8.Text = "Tipo de persona";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Controls.Add(txtDireccion);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtTelefono);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtApellido);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(label7);
            groupBox1.Location = new Point(36, 295);
            groupBox1.Margin = new Padding(4, 5, 4, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 5, 4, 5);
            groupBox1.Size = new Size(353, 310);
            groupBox1.TabIndex = 63;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos Personales";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 63);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(78, 25);
            label1.TabIndex = 38;
            label1.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 158);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(85, 25);
            label3.TabIndex = 40;
            label3.Text = "Direccion";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(137, 58);
            txtNombre.Margin = new Padding(4, 5, 4, 5);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(141, 31);
            txtNombre.TabIndex = 46;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(137, 153);
            txtDireccion.Margin = new Padding(4, 5, 4, 5);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(141, 31);
            txtDireccion.TabIndex = 48;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 110);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(78, 25);
            label2.TabIndex = 39;
            label2.Text = "Apellido";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(137, 202);
            txtTelefono.Margin = new Padding(4, 5, 4, 5);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(141, 31);
            txtTelefono.TabIndex = 52;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 255);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(54, 25);
            label4.TabIndex = 41;
            label4.Text = "Email";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(137, 105);
            txtApellido.Margin = new Padding(4, 5, 4, 5);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(141, 31);
            txtApellido.TabIndex = 47;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(137, 250);
            txtEmail.Margin = new Padding(4, 5, 4, 5);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(141, 31);
            txtEmail.TabIndex = 49;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(16, 207);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(79, 25);
            label7.TabIndex = 44;
            label7.Text = "Telefono";
            // 
            // txtID
            // 
            txtID.Enabled = false;
            txtID.Location = new Point(166, 30);
            txtID.Margin = new Padding(4, 5, 4, 5);
            txtID.Name = "txtID";
            txtID.Size = new Size(141, 31);
            txtID.TabIndex = 62;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(36, 35);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(97, 25);
            label9.TabIndex = 61;
            label9.Text = "ID Persona";
            // 
            // button2
            // 
            button2.Location = new Point(701, 545);
            button2.Margin = new Padding(4, 5, 4, 5);
            button2.Name = "button2";
            button2.Size = new Size(154, 58);
            button2.TabIndex = 60;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(450, 547);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(159, 58);
            button1.TabIndex = 59;
            button1.Text = "Aceptar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtContraseña);
            groupBox3.Controls.Add(txtUsuario);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(label10);
            groupBox3.Location = new Point(36, 95);
            groupBox3.Margin = new Padding(4, 5, 4, 5);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(4, 5, 4, 5);
            groupBox3.Size = new Size(353, 172);
            groupBox3.TabIndex = 65;
            groupBox3.TabStop = false;
            groupBox3.Text = "Autenticación";
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(137, 110);
            txtContraseña.Margin = new Padding(4, 5, 4, 5);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(171, 31);
            txtContraseña.TabIndex = 3;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(137, 50);
            txtUsuario.Margin = new Padding(4, 5, 4, 5);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(171, 31);
            txtUsuario.TabIndex = 2;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(16, 115);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(101, 25);
            label11.TabIndex = 1;
            label11.Text = "Contraseña";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(19, 55);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(72, 25);
            label10.TabIndex = 0;
            label10.Text = "Usuario";
            // 
            // AgregarForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(887, 637);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(txtID);
            Controls.Add(label9);
            Controls.Add(button2);
            Controls.Add(button1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "AgregarForm";
            Text = "AgregarForm";
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox2;
        private ComboBox txtIdPlan;
        private ComboBox txtTipoPersona;
        private TextBox txtLegajo;
        private Label label6;
        private Label label5;
        private Label label8;
        private GroupBox groupBox1;
        private Label label1;
        private Label label3;
        private TextBox txtNombre;
        private TextBox txtDireccion;
        private Label label2;
        private TextBox txtTelefono;
        private Label label4;
        private TextBox txtApellido;
        private TextBox txtEmail;
        private Label label7;
        private TextBox txtID;
        private Label label9;
        private Button button2;
        private Button button1;
        private GroupBox groupBox3;
        private TextBox txtContraseña;
        private TextBox txtUsuario;
        private Label label11;
        private Label label10;
    }
}