namespace Inicio.FormularioPlan
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
            groupBox1 = new GroupBox();
            txtEspecialidad = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            txtDescripcion = new TextBox();
            txtID = new TextBox();
            label9 = new Label();
            button2 = new Button();
            button1 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtEspecialidad);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtDescripcion);
            groupBox1.Location = new Point(24, 120);
            groupBox1.Margin = new Padding(4, 5, 4, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 5, 4, 5);
            groupBox1.Size = new Size(420, 185);
            groupBox1.TabIndex = 62;
            groupBox1.TabStop = false;
            groupBox1.Text = "Detalles";
            // 
            // txtEspecialidad
            // 
            txtEspecialidad.DropDownStyle = ComboBoxStyle.DropDownList;
            txtEspecialidad.FormattingEnabled = true;
            txtEspecialidad.Location = new Point(187, 120);
            txtEspecialidad.Margin = new Padding(4, 5, 4, 5);
            txtEspecialidad.Name = "txtEspecialidad";
            txtEspecialidad.Size = new Size(205, 33);
            txtEspecialidad.TabIndex = 48;
            txtEspecialidad.SelectedIndexChanged += txtEspecialidad_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 125);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(132, 25);
            label2.TabIndex = 47;
            label2.Text = "ID Especialidad";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 63);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(104, 25);
            label1.TabIndex = 38;
            label1.Text = "Descripcion";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(187, 58);
            txtDescripcion.Margin = new Padding(4, 5, 4, 5);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(205, 31);
            txtDescripcion.TabIndex = 46;
            // 
            // txtID
            // 
            txtID.Enabled = false;
            txtID.Location = new Point(161, 32);
            txtID.Margin = new Padding(4, 5, 4, 5);
            txtID.Name = "txtID";
            txtID.Size = new Size(141, 31);
            txtID.TabIndex = 61;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(31, 37);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(68, 25);
            label9.TabIndex = 60;
            label9.Text = "ID Plan";
            // 
            // button2
            // 
            button2.Location = new Point(290, 343);
            button2.Margin = new Padding(4, 5, 4, 5);
            button2.Name = "button2";
            button2.Size = new Size(154, 58);
            button2.TabIndex = 59;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(99, 343);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(159, 58);
            button1.TabIndex = 58;
            button1.Text = "Aceptar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // AgregarForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(486, 448);
            Controls.Add(groupBox1);
            Controls.Add(txtID);
            Controls.Add(label9);
            Controls.Add(button2);
            Controls.Add(button1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "AgregarForm";
            Text = "AgregarForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private ComboBox txtEspecialidad;
        private Label label2;
        private Label label1;
        private TextBox txtDescripcion;
        private TextBox txtID;
        private Label label9;
        private Button button2;
        private Button button1;
    }
}