namespace FormularioPersona.Views
{
    partial class BusquedaForm
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
            label1 = new Label();
            btnCancelar = new Button();
            tbId = new TextBox();
            btnAceptar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(26, 23);
            label1.Name = "label1";
            label1.Size = new Size(197, 25);
            label1.TabIndex = 0;
            label1.Text = "Ingresa el ID a buscar:";
            label1.Click += label1_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(221, 125);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(98, 24);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // tbId
            // 
            tbId.Location = new Point(26, 63);
            tbId.Name = "tbId";
            tbId.Size = new Size(242, 23);
            tbId.TabIndex = 3;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(105, 125);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(98, 24);
            btnAceptar.TabIndex = 4;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // BusquedaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(331, 167);
            Controls.Add(btnAceptar);
            Controls.Add(tbId);
            Controls.Add(btnCancelar);
            Controls.Add(label1);
            Name = "BusquedaForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "BusquedaForm";
            Load += BusquedaForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnCancelar;
        private TextBox tbId;
        private Button btnAceptar;
    }
}