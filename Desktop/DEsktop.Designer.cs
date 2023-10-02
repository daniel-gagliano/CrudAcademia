namespace Desktop
{
    partial class Desktop
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Berlin Sans FB Demi", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(133, 20);
            label1.Name = "label1";
            label1.Size = new Size(136, 27);
            label1.TabIndex = 0;
            label1.Text = "Bienvenido";
            // 
            // button1
            // 
            button1.Location = new Point(123, 75);
            button1.Name = "button1";
            button1.Size = new Size(146, 78);
            button1.TabIndex = 1;
            button1.Text = "CRUD PERSONAS";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(123, 179);
            button2.Name = "button2";
            button2.Size = new Size(146, 78);
            button2.TabIndex = 2;
            button2.Text = "CRUD PLANES";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(123, 283);
            button3.Name = "button3";
            button3.Size = new Size(146, 78);
            button3.TabIndex = 3;
            button3.Text = "CRUD ESPECIALIDADES";
            button3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(382, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}