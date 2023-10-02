namespace FormularioPersona.Views
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
            button2 = new Button();
            txtTelefono = new TextBox();
            txtLegajo = new TextBox();
            txtEmail = new TextBox();
            txtDireccion = new TextBox();
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            label9 = new Label();
            txtID = new TextBox();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            txtIdPlan = new ComboBox();
            txtTipoPersona = new ComboBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Location = new Point(481, 262);
            button2.Name = "button2";
            button2.Size = new Size(108, 35);
            button2.TabIndex = 54;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(96, 121);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(100, 23);
            txtTelefono.TabIndex = 52;
            // 
            // txtLegajo
            // 
            txtLegajo.Location = new Point(124, 38);
            txtLegajo.Name = "txtLegajo";
            txtLegajo.Size = new Size(121, 23);
            txtLegajo.TabIndex = 51;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(96, 150);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(100, 23);
            txtEmail.TabIndex = 49;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(96, 92);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(100, 23);
            txtDireccion.TabIndex = 48;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(96, 63);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(100, 23);
            txtApellido.TabIndex = 47;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(96, 35);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 46;
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
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(11, 124);
            label7.Name = "label7";
            label7.Size = new Size(52, 15);
            label7.TabIndex = 44;
            label7.Text = "Telefono";
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
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 153);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 41;
            label4.Text = "Email";
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 66);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 39;
            label2.Text = "Apellido";
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
            // button1
            // 
            button1.Location = new Point(344, 262);
            button1.Name = "button1";
            button1.Size = new Size(111, 35);
            button1.TabIndex = 37;
            button1.Text = "Aceptar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(42, 15);
            label9.Name = "label9";
            label9.Size = new Size(63, 15);
            label9.TabIndex = 55;
            label9.Text = "ID Persona";
            // 
            // txtID
            // 
            txtID.Enabled = false;
            txtID.Location = new Point(133, 12);
            txtID.Name = "txtID";
            txtID.Size = new Size(100, 23);
            txtID.TabIndex = 56;
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
            groupBox1.Location = new Point(37, 65);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(247, 202);
            groupBox1.TabIndex = 57;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos Personales";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtIdPlan);
            groupBox2.Controls.Add(txtTipoPersona);
            groupBox2.Controls.Add(txtLegajo);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label8);
            groupBox2.Location = new Point(344, 65);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(284, 162);
            groupBox2.TabIndex = 58;
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
            // AgregarForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(660, 321);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(txtID);
            Controls.Add(label9);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "AgregarForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "AgregarForm";
            Load += AgregarForm_Load_1;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private TextBox txtTelefono;
        private TextBox txtLegajo;
        private TextBox txtEmail;
        private TextBox txtDireccion;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button1;
        private Label label9;
        private TextBox txtID;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private ComboBox txtTipoPersona;
        private ComboBox txtIdPlan;
        private DateTimePicker dateTimePicker1;
    }
}