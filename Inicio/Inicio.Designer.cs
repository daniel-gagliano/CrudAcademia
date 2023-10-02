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
            label1 = new Label();
            btnPersonas = new Button();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Berlin Sans FB Demi", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(90, 32);
            label1.Name = "label1";
            label1.Size = new Size(136, 27);
            label1.TabIndex = 0;
            label1.Text = "Bienvenido";
            // 
            // btnPersonas
            // 
            btnPersonas.Location = new Point(79, 107);
            btnPersonas.Name = "btnPersonas";
            btnPersonas.Size = new Size(147, 76);
            btnPersonas.TabIndex = 1;
            btnPersonas.Text = "CRUD PERSONAS";
            btnPersonas.UseVisualStyleBackColor = true;
            btnPersonas.Click += btnPersonas_Click;
            // 
            // button1
            // 
            button1.Location = new Point(79, 208);
            button1.Name = "button1";
            button1.Size = new Size(147, 80);
            button1.TabIndex = 2;
            button1.Text = "CRUD PLANES";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(79, 319);
            button2.Name = "button2";
            button2.Size = new Size(147, 81);
            button2.TabIndex = 3;
            button2.Text = "CRUD ESPECIALIDADES";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Inicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(316, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btnPersonas);
            Controls.Add(label1);
            Name = "Inicio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ACADEMIA";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnPersonas;
        private Button button1;
        private Button button2;
    }
}