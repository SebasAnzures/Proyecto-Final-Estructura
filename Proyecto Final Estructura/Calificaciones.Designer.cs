namespace Proyecto_Final_Estructura
{
    partial class Calificaciones
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
            dgCalificaciones = new DataGridView();
            tbIdRate = new TextBox();
            tbIdGame = new TextBox();
            tbScore = new TextBox();
            tbCC = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnAgregar = new Button();
            btnUpdate = new Button();
            btnBack = new Button();
            btnDelete2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgCalificaciones).BeginInit();
            SuspendLayout();
            // 
            // dgCalificaciones
            // 
            dgCalificaciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgCalificaciones.Location = new Point(12, 12);
            dgCalificaciones.Name = "dgCalificaciones";
            dgCalificaciones.Size = new Size(776, 243);
            dgCalificaciones.TabIndex = 0;
            // 
            // tbIdRate
            // 
            tbIdRate.Location = new Point(12, 281);
            tbIdRate.Name = "tbIdRate";
            tbIdRate.Size = new Size(100, 23);
            tbIdRate.TabIndex = 1;
            // 
            // tbIdGame
            // 
            tbIdGame.Location = new Point(118, 281);
            tbIdGame.Name = "tbIdGame";
            tbIdGame.Size = new Size(100, 23);
            tbIdGame.TabIndex = 2;
            // 
            // tbScore
            // 
            tbScore.Location = new Point(224, 281);
            tbScore.Name = "tbScore";
            tbScore.Size = new Size(100, 23);
            tbScore.TabIndex = 3;
            // 
            // tbCC
            // 
            tbCC.Location = new Point(330, 281);
            tbCC.Multiline = true;
            tbCC.Name = "tbCC";
            tbCC.Size = new Size(458, 123);
            tbCC.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 262);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 5;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(330, 262);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 6;
            label2.Text = "Comentario";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(118, 262);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 7;
            label3.Text = "Juego (ID)";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(224, 262);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 8;
            label4.Text = "Puntuaje";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(12, 410);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 9;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(93, 410);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 10;
            btnUpdate.Text = "Actualizar";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(713, 410);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(75, 23);
            btnBack.TabIndex = 12;
            btnBack.Text = "Regresar";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnDelete2
            // 
            btnDelete2.Location = new Point(174, 410);
            btnDelete2.Name = "btnDelete2";
            btnDelete2.Size = new Size(75, 23);
            btnDelete2.TabIndex = 13;
            btnDelete2.Text = "Eliminar";
            btnDelete2.UseVisualStyleBackColor = true;
            btnDelete2.Click += btnDelete2_Click;
            // 
            // Calificaciones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDelete2);
            Controls.Add(btnBack);
            Controls.Add(btnUpdate);
            Controls.Add(btnAgregar);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbCC);
            Controls.Add(tbScore);
            Controls.Add(tbIdGame);
            Controls.Add(tbIdRate);
            Controls.Add(dgCalificaciones);
            Name = "Calificaciones";
            Text = "Calificaciones";
            ((System.ComponentModel.ISupportInitialize)dgCalificaciones).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgCalificaciones;
        private TextBox tbIdRate;
        private TextBox tbIdGame;
        private TextBox tbScore;
        private TextBox tbCC;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnAgregar;
        private Button btnUpdate;
        private Button btnBack;
        private Button btnDelete2;
    }
}