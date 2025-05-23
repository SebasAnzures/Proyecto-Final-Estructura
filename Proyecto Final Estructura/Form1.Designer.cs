namespace Proyecto_Final_Estructura
{
    partial class Form1
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
            btnLogIn = new Button();
            button2 = new Button();
            tbpw = new TextBox();
            tbuser = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // btnLogIn
            // 
            btnLogIn.Location = new Point(24, 100);
            btnLogIn.Name = "btnLogIn";
            btnLogIn.Size = new Size(75, 23);
            btnLogIn.TabIndex = 0;
            btnLogIn.Text = "Log In";
            btnLogIn.UseVisualStyleBackColor = true;
            btnLogIn.Click += btnLogIn_Click;
            // 
            // button2
            // 
            button2.Location = new Point(152, 45);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 1;
            button2.Text = "Sign Up";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // tbpw
            // 
            tbpw.Location = new Point(12, 71);
            tbpw.Name = "tbpw";
            tbpw.PasswordChar = '*';
            tbpw.Size = new Size(100, 23);
            tbpw.TabIndex = 2;
            // 
            // tbuser
            // 
            tbuser.Location = new Point(12, 27);
            tbuser.Name = "tbuser";
            tbuser.Size = new Size(100, 23);
            tbuser.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 9);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 4;
            label1.Text = "Usuario:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 53);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 5;
            label2.Text = "Contraseña:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(138, 9);
            label3.Name = "label3";
            label3.Size = new Size(109, 15);
            label3.TabIndex = 6;
            label3.Text = "¿No tienes usuario?";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(254, 141);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbuser);
            Controls.Add(tbpw);
            Controls.Add(button2);
            Controls.Add(btnLogIn);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogIn;
        private Button button2;
        private TextBox tbpw;
        private TextBox tbuser;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
