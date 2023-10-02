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
            SuspendLayout();
            // 
            // button2
            // 
            button2.Location = new Point(170, 124);
            button2.Name = "button2";
            button2.Size = new Size(108, 35);
            button2.TabIndex = 54;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(147, 71);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(100, 23);
            txtDescripcion.TabIndex = 46;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 74);
            label1.Name = "label1";
            label1.Size = new Size(69, 15);
            label1.TabIndex = 38;
            label1.Text = "Descripcion";
            // 
            // button1
            // 
            button1.Location = new Point(33, 124);
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
            label9.Location = new Point(42, 25);
            label9.Name = "label9";
            label9.Size = new Size(86, 15);
            label9.TabIndex = 55;
            label9.Text = "ID Especialidad";
            // 
            // txtID
            // 
            txtID.Enabled = false;
            txtID.Location = new Point(147, 22);
            txtID.Name = "txtID";
            txtID.Size = new Size(100, 23);
            txtID.TabIndex = 56;
            // 
            // AgregarForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(355, 181);
            Controls.Add(label1);
            Controls.Add(txtID);
            Controls.Add(txtDescripcion);
            Controls.Add(label9);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "AgregarForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "AgregarForm";
            Load += AgregarForm_Load_1;
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
        private DateTimePicker dateTimePicker1;
    }
}