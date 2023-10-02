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
            txtDescripcion = new TextBox();
            label1 = new Label();
            button1 = new Button();
            label9 = new Label();
            txtID = new TextBox();
            groupBox1 = new GroupBox();
            txtEspecialidad = new ComboBox();
            label2 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Location = new Point(223, 199);
            button2.Name = "button2";
            button2.Size = new Size(108, 35);
            button2.TabIndex = 54;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(131, 35);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(145, 23);
            txtDescripcion.TabIndex = 46;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 38);
            label1.Name = "label1";
            label1.Size = new Size(69, 15);
            label1.TabIndex = 38;
            label1.Text = "Descripcion";
            // 
            // button1
            // 
            button1.Location = new Point(89, 199);
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
            label9.Size = new Size(44, 15);
            label9.TabIndex = 55;
            label9.Text = "ID Plan";
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
            groupBox1.Controls.Add(txtEspecialidad);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtDescripcion);
            groupBox1.Location = new Point(37, 65);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(294, 111);
            groupBox1.TabIndex = 57;
            groupBox1.TabStop = false;
            groupBox1.Text = "Detalles";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // txtEspecialidad
            // 
            txtEspecialidad.DropDownStyle = ComboBoxStyle.DropDownList;
            txtEspecialidad.FormattingEnabled = true;
            txtEspecialidad.Location = new Point(131, 72);
            txtEspecialidad.Name = "txtEspecialidad";
            txtEspecialidad.Size = new Size(145, 23);
            txtEspecialidad.TabIndex = 48;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 75);
            label2.Name = "label2";
            label2.Size = new Size(86, 15);
            label2.TabIndex = 47;
            label2.Text = "ID Especialidad";
            // 
            // AgregarForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(378, 271);
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
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private TextBox txtDescripcion;
        private Label label1;
        private Button button1;
        private Label label9;
        private TextBox txtID;
        private GroupBox groupBox1;
        private DateTimePicker dateTimePicker1;
        private ComboBox txtEspecialidad;
        private Label label2;
    }
}