﻿namespace Inicio
{
    partial class Login
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
            lblTitle = new Label();
            txtUsuario = new TextBox();
            pictureBox1 = new PictureBox();
            txtPassword = new TextBox();
            pictureBox2 = new PictureBox();
            btnOK = new Button();
            chkShowPw = new CheckBox();
            pictureBox3 = new PictureBox();
            lblError = new Label();
            cmbLoginAs = new ComboBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Bahnschrift", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.Location = new Point(12, 128);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(591, 56);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Sistema de Gestión Académica";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtUsuario
            // 
            txtUsuario.Cursor = Cursors.IBeam;
            txtUsuario.Location = new Point(233, 254);
            txtUsuario.MaxLength = 20;
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PlaceholderText = "Usuario";
            txtUsuario.Size = new Size(167, 23);
            txtUsuario.TabIndex = 1;
            txtUsuario.KeyPress += txt_KeyPress;
            txtUsuario.KeyUp += txt_KeyUp;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.round_account_button_with_user_inside_icon_icons_com_72596;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(204, 254);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(23, 23);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // txtPassword
            // 
            txtPassword.Cursor = Cursors.IBeam;
            txtPassword.Location = new Point(233, 298);
            txtPassword.MaxLength = 20;
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Contraseña";
            txtPassword.Size = new Size(167, 23);
            txtPassword.TabIndex = 3;
            txtPassword.UseSystemPasswordChar = true;
            txtPassword.KeyPress += txt_KeyPress;
            txtPassword.KeyUp += txt_KeyUp;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources.password_3715;
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Location = new Point(204, 298);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(23, 23);
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // btnOK
            // 
            btnOK.Location = new Point(204, 362);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(196, 23);
            btnOK.TabIndex = 5;
            btnOK.Text = "Ingresar";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // chkShowPw
            // 
            chkShowPw.AutoSize = true;
            chkShowPw.Location = new Point(406, 300);
            chkShowPw.Name = "chkShowPw";
            chkShowPw.Size = new Size(67, 19);
            chkShowPw.TabIndex = 6;
            chkShowPw.Text = "Mostrar";
            chkShowPw.UseVisualStyleBackColor = true;
            chkShowPw.CheckedChanged += chkShowPw_CheckedChanged;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = Properties.Resources.pngwing_com;
            pictureBox3.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox3.Location = new Point(12, 40);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(591, 85);
            pictureBox3.TabIndex = 7;
            pictureBox3.TabStop = false;
            // 
            // lblError
            // 
            lblError.ForeColor = Color.IndianRed;
            lblError.Location = new Point(12, 333);
            lblError.Name = "lblError";
            lblError.Size = new Size(591, 23);
            lblError.TabIndex = 8;
            lblError.Text = "Usuario y/o contraseña incorrectos. Intente nuevamente.";
            lblError.TextAlign = ContentAlignment.MiddleCenter;
            lblError.Visible = false;
            // 
            // cmbLoginAs
            // 
            cmbLoginAs.FormattingEnabled = true;
            cmbLoginAs.Items.AddRange(new object[] { "Alumno", "Docente", "Administrador" });
            cmbLoginAs.Location = new Point(269, 197);
            cmbLoginAs.Name = "cmbLoginAs";
            cmbLoginAs.Size = new Size(167, 23);
            cmbLoginAs.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift SemiLight", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(170, 200);
            label1.Name = "label1";
            label1.Size = new Size(95, 16);
            label1.TabIndex = 10;
            label1.Text = "Ingresar como:";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(615, 426);
            Controls.Add(label1);
            Controls.Add(cmbLoginAs);
            Controls.Add(lblError);
            Controls.Add(pictureBox3);
            Controls.Add(chkShowPw);
            Controls.Add(btnOK);
            Controls.Add(pictureBox2);
            Controls.Add(txtPassword);
            Controls.Add(pictureBox1);
            Controls.Add(txtUsuario);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Login";
            FormClosed += Login_FormClosed;
            Load += Login_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private TextBox txtUsuario;
        private PictureBox pictureBox1;
        private TextBox txtPassword;
        private PictureBox pictureBox2;
        private Button btnOK;
        private CheckBox chkShowPw;
        private PictureBox pictureBox3;
        private Label lblError;
        private ComboBox cmbLoginAs;
        private Label label1;
    }
}