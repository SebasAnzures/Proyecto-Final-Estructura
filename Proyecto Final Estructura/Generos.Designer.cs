namespace Proyecto_Final_Estructura
{
    partial class Generos
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
            dgGeneros = new DataGridView();
            tbGenre = new TextBox();
            label1 = new Label();
            btnAgregar = new Button();
            btnBack = new Button();
            ((System.ComponentModel.ISupportInitialize)dgGeneros).BeginInit();
            SuspendLayout();
            // 
            // dgGeneros
            // 
            dgGeneros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgGeneros.Location = new Point(12, 12);
            dgGeneros.Name = "dgGeneros";
            dgGeneros.Size = new Size(776, 245);
            dgGeneros.TabIndex = 0;
            // 
            // tbGenre
            // 
            tbGenre.Location = new Point(12, 287);
            tbGenre.Name = "tbGenre";
            tbGenre.Size = new Size(100, 23);
            tbGenre.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 269);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 2;
            label1.Text = "Genero";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(12, 404);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 3;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click_1;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(713, 404);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(75, 23);
            btnBack.TabIndex = 4;
            btnBack.Text = "Regresar";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // Generos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBack);
            Controls.Add(btnAgregar);
            Controls.Add(label1);
            Controls.Add(tbGenre);
            Controls.Add(dgGeneros);
            Name = "Generos";
            Text = "Generos";
            ((System.ComponentModel.ISupportInitialize)dgGeneros).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgGeneros;
        private TextBox tbGenre;
        private Label label1;
        private Button btnAgregar;
        private Button btnBack;
    }
}