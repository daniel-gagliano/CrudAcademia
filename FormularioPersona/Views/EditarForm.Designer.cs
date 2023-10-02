namespace FormularioPersona.Views
{
    partial class EditarForm
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
            button2 = new Button();
            button1 = new Button();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
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
            groupBox2.Location = new Point(329, 71);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(284, 162);
            groupBox2.TabIndex = 64;
            groupBox2.TabStop = false;
            groupBox2.Text = "Academia";
            // 
            // txtIdPlan
            // 
            txtIdPlan.DropDownStyle = ComboBoxStyle.DropDownList;
            txtIdPlan.FormattingEnabled = true;
            txtIdPlan.Items.AddRange(new object[] { "2008", "2016", "2023" });
            txtIdPlan.Location = new Point(124, 76);
            txtIdPlan.Name = "txtIdPlan";
            txtIdPlan.Size = new Size(121, 23);
            txtIdPlan.TabIndex = 55;
            // 
            // txtTipoPersona
            // 
            txtTipoPersona.DropDownStyle = ComboBoxStyle.DropDownList;
            txtTipoPersona.FormattingEnabled = true;
            txtTipoPersona.Items.AddRange(new object[] { "Estudiante", "Profesor" });
            txtTipoPersona.Location = new Point(124, 113);
            txtTipoPersona.Name = "txtTipoPersona";
            txtTipoPersona.Size = new Size(121, 23);
            txtTipoPersona.TabIndex = 54;
            // 
            // txtLegajo
            // 
            txtLegajo.Location = new Point(124, 38);
            txtLegajo.Name = "txtLegajo";
            txtLegajo.Size = new Size(121, 23);
            txtLegajo.TabIndex = 51;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(13, 41);
            label6.Name = "label6";
            label6.Size = new Size(42, 15);
            label6.TabIndex = 43;
            label6.Text = "Legajo";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(13, 79);
            label5.Name = "label5";
            label5.Size = new Size(44, 15);
            label5.TabIndex = 42;
            label5.Text = "ID Plan";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(11, 113);
            label8.Name = "label8";
            label8.Size = new Size(91, 15);
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
            groupBox1.Location = new Point(22, 71);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(247, 202);
            groupBox1.TabIndex = 63;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos Personales";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 38);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 38;
            label1.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 95);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 40;
            label3.Text = "Direccion";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(96, 35);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 46;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(96, 92);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(100, 23);
            txtDireccion.TabIndex = 48;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 66);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 39;
            label2.Text = "Apellido";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(96, 121);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(100, 23);
            txtTelefono.TabIndex = 52;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 153);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 41;
            label4.Text = "Email";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(96, 63);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(100, 23);
            txtApellido.TabIndex = 47;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(96, 150);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(100, 23);
            txtEmail.TabIndex = 49;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(11, 124);
            label7.Name = "label7";
            label7.Size = new Size(52, 15);
            label7.TabIndex = 44;
            label7.Text = "Telefono";
            // 
            // button2
            // 
            button2.Location = new Point(466, 268);
            button2.Name = "button2";
            button2.Size = new Size(108, 35);
            button2.TabIndex = 60;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(329, 268);
            button1.Name = "button1";
            button1.Size = new Size(111, 35);
            button1.TabIndex = 59;
            button1.Text = "Aceptar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // EditarForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(646, 350);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "EditarForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "EditarForm";
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
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
        private Button button2;
        private Button button1;
    }
}