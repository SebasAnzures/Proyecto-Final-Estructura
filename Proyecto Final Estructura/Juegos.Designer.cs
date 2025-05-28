namespace Proyecto_Final_Estructura
{
    partial class Juegos
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
            dgJuegos = new DataGridView();
            btnagregar = new Button();
            tbidjuego = new TextBox();
            tbnombre = new TextBox();
            tbplatform = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnupdate = new Button();
            btndelete = new Button();
            btnBack = new Button();
            tbusuario = new TextBox();
            label5 = new Label();
            btnRead = new Button();
            ((System.ComponentModel.ISupportInitialize)dgJuegos).BeginInit();
            SuspendLayout();
            // 
            // dgJuegos
            // 
            dgJuegos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgJuegos.Location = new Point(12, 12);
            dgJuegos.Name = "dgJuegos";
            dgJuegos.Size = new Size(776, 238);
            dgJuegos.TabIndex = 0;
            // 
            // btnagregar
            // 
            btnagregar.Location = new Point(12, 405);
            btnagregar.Name = "btnagregar";
            btnagregar.Size = new Size(75, 23);
            btnagregar.TabIndex = 1;
            btnagregar.Text = "Agregar";
            btnagregar.UseCompatibleTextRendering = true;
            btnagregar.UseVisualStyleBackColor = true;
            btnagregar.Click += btnagregar_Click;
            // 
            // tbidjuego
            // 
            tbidjuego.Location = new Point(12, 289);
            tbidjuego.Name = "tbidjuego";
            tbidjuego.Size = new Size(100, 23);
            tbidjuego.TabIndex = 2;
            // 
            // tbnombre
            // 
            tbnombre.Location = new Point(118, 289);
            tbnombre.Name = "tbnombre";
            tbnombre.Size = new Size(100, 23);
            tbnombre.TabIndex = 3;
            // 
            // tbplatform
            // 
            tbplatform.Location = new Point(224, 289);
            tbplatform.Name = "tbplatform";
            tbplatform.Size = new Size(100, 23);
            tbplatform.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 270);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 6;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(118, 270);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 7;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(224, 270);
            label3.Name = "label3";
            label3.Size = new Size(65, 15);
            label3.TabIndex = 8;
            label3.Text = "Plataforma";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(330, 270);
            label4.Name = "label4";
            label4.Size = new Size(0, 15);
            label4.TabIndex = 9;
            // 
            // btnupdate
            // 
            btnupdate.Location = new Point(94, 405);
            btnupdate.Name = "btnupdate";
            btnupdate.Size = new Size(75, 23);
            btnupdate.TabIndex = 10;
            btnupdate.Text = "Actualizar";
            btnupdate.UseVisualStyleBackColor = true;
            btnupdate.Click += btnupdate_Click;
            // 
            // btndelete
            // 
            btndelete.Location = new Point(175, 405);
            btndelete.Name = "btndelete";
            btndelete.Size = new Size(75, 23);
            btndelete.TabIndex = 11;
            btndelete.Text = "Delete";
            btndelete.UseVisualStyleBackColor = true;
            btndelete.Click += btndelete_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(713, 405);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(75, 23);
            btnBack.TabIndex = 12;
            btnBack.Text = "Regresar";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // tbusuario
            // 
            tbusuario.Location = new Point(336, 289);
            tbusuario.Name = "tbusuario";
            tbusuario.Size = new Size(100, 23);
            tbusuario.TabIndex = 13;
            tbusuario.Text = "1";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(336, 270);
            label5.Name = "label5";
            label5.Size = new Size(89, 15);
            label5.TabIndex = 14;
            label5.Text = "Agreagado por:";
            // 
            // btnRead
            // 
            btnRead.Location = new Point(336, 318);
            btnRead.Name = "btnRead";
            btnRead.Size = new Size(75, 23);
            btnRead.TabIndex = 15;
            btnRead.Text = "Buscar";
            btnRead.UseVisualStyleBackColor = true;
            btnRead.Click += btnRead_Click;
            // 
            // Juegos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRead);
            Controls.Add(label5);
            Controls.Add(tbusuario);
            Controls.Add(btnBack);
            Controls.Add(btndelete);
            Controls.Add(btnupdate);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbplatform);
            Controls.Add(tbnombre);
            Controls.Add(tbidjuego);
            Controls.Add(btnagregar);
            Controls.Add(dgJuegos);
            Name = "Juegos";
            Text = "Juegos";
            ((System.ComponentModel.ISupportInitialize)dgJuegos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgJuegos;
        private Button btnagregar;
        private TextBox tbidjuego;
        private TextBox tbnombre;
        private TextBox tbplatform;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnupdate;
        private Button btndelete;
        private Button btnBack;
        private TextBox tbusuario;
        private Label label5;
        private Button btnRead;
    }
}