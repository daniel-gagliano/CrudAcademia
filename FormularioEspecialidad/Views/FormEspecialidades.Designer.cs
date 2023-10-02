namespace FormularioPersona
{
    partial class FormEspecialidades
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
            dgvEspecialidades = new DataGridView();
            btConsultar = new Button();
            btAgregar = new Button();
            btEditar = new Button();
            btEliminar = new Button();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvEspecialidades).BeginInit();
            SuspendLayout();
            // 
            // dgvEspecialidades
            // 
            dgvEspecialidades.AllowUserToAddRows = false;
            dgvEspecialidades.AllowUserToDeleteRows = false;
            dgvEspecialidades.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvEspecialidades.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEspecialidades.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEspecialidades.Location = new Point(27, 114);
            dgvEspecialidades.MultiSelect = false;
            dgvEspecialidades.Name = "dgvEspecialidades";
            dgvEspecialidades.ReadOnly = true;
            dgvEspecialidades.RowTemplate.Height = 25;
            dgvEspecialidades.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEspecialidades.Size = new Size(530, 308);
            dgvEspecialidades.TabIndex = 0;
            // 
            // btConsultar
            // 
            btConsultar.BackColor = Color.DodgerBlue;
            btConsultar.Font = new Font("Berlin Sans FB Demi", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btConsultar.ForeColor = SystemColors.ButtonFace;
            btConsultar.Location = new Point(592, 114);
            btConsultar.Name = "btConsultar";
            btConsultar.Size = new Size(134, 60);
            btConsultar.TabIndex = 1;
            btConsultar.Text = "Consultar";
            btConsultar.UseVisualStyleBackColor = false;
            btConsultar.Click += btConsultar_Click;
            // 
            // btAgregar
            // 
            btAgregar.BackColor = Color.YellowGreen;
            btAgregar.Font = new Font("Berlin Sans FB Demi", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btAgregar.ForeColor = SystemColors.ButtonFace;
            btAgregar.Location = new Point(592, 196);
            btAgregar.Name = "btAgregar";
            btAgregar.Size = new Size(134, 60);
            btAgregar.TabIndex = 2;
            btAgregar.Text = "Agregar";
            btAgregar.UseVisualStyleBackColor = false;
            btAgregar.Click += btAgregar_Click;
            // 
            // btEditar
            // 
            btEditar.BackColor = Color.Orange;
            btEditar.Font = new Font("Berlin Sans FB Demi", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btEditar.ForeColor = SystemColors.ButtonFace;
            btEditar.Location = new Point(592, 278);
            btEditar.Name = "btEditar";
            btEditar.Size = new Size(134, 60);
            btEditar.TabIndex = 3;
            btEditar.Text = "Editar";
            btEditar.UseVisualStyleBackColor = false;
            btEditar.Click += btEditar_Click;
            // 
            // btEliminar
            // 
            btEliminar.BackColor = Color.IndianRed;
            btEliminar.Font = new Font("Berlin Sans FB Demi", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btEliminar.ForeColor = SystemColors.ButtonFace;
            btEliminar.Location = new Point(592, 362);
            btEliminar.Name = "btEliminar";
            btEliminar.Size = new Size(134, 60);
            btEliminar.TabIndex = 4;
            btEliminar.Text = "Eliminar";
            btEliminar.UseVisualStyleBackColor = false;
            btEliminar.Click += btEliminar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Berlin Sans FB", 39.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(27, 29);
            label1.Name = "label1";
            label1.Size = new Size(338, 58);
            label1.TabIndex = 5;
            label1.Text = "Especialidades";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Arial Narrow", 36F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(371, 27);
            button1.Name = "button1";
            button1.Size = new Size(60, 67);
            button1.TabIndex = 6;
            button1.Text = "⭮";
            button1.TextAlign = ContentAlignment.TopLeft;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(472, 48);
            button2.Name = "button2";
            button2.Size = new Size(85, 39);
            button2.TabIndex = 7;
            button2.Text = "Inicio";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // FormEspecialidades
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(btEliminar);
            Controls.Add(btEditar);
            Controls.Add(btAgregar);
            Controls.Add(btConsultar);
            Controls.Add(dgvEspecialidades);
            Name = "FormEspecialidades";
            StartPosition = FormStartPosition.CenterParent;
            Text = "CRUD Personas";
            Load += FormPersonas_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEspecialidades).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvEspecialidades;
        private Button btConsultar;
        private Button btAgregar;
        private Button btEditar;
        private Button btEliminar;
        private Label label1;
        private Button button1;
        private Button button2;
    }
}