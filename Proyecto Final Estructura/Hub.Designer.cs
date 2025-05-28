namespace Proyecto_Final_Estructura
{
    partial class Hub
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
            btnVG = new Button();
            btnGenre = new Button();
            label1 = new Label();
            btnRate2 = new Button();
            SuspendLayout();
            // 
            // btnVG
            // 
            btnVG.Location = new Point(12, 35);
            btnVG.Name = "btnVG";
            btnVG.Size = new Size(84, 23);
            btnVG.TabIndex = 0;
            btnVG.Text = "Videojuegos";
            btnVG.UseVisualStyleBackColor = true;
            btnVG.Click += btnVG_Click;
            // 
            // btnGenre
            // 
            btnGenre.Location = new Point(102, 35);
            btnGenre.Name = "btnGenre";
            btnGenre.Size = new Size(75, 23);
            btnGenre.TabIndex = 1;
            btnGenre.Text = "Generos";
            btnGenre.UseVisualStyleBackColor = true;
            btnGenre.Click += btnGenre_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(69, 9);
            label1.Name = "label1";
            label1.Size = new Size(151, 15);
            label1.TabIndex = 3;
            label1.Text = "Seleccione lo que desee ver";
            // 
            // btnRate2
            // 
            btnRate2.Location = new Point(183, 35);
            btnRate2.Name = "btnRate2";
            btnRate2.Size = new Size(99, 23);
            btnRate2.TabIndex = 4;
            btnRate2.Text = "Calificaciones";
            btnRate2.UseVisualStyleBackColor = true;
            btnRate2.Click += btnRate2_Click;
            // 
            // Hub
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(294, 78);
            Controls.Add(btnRate2);
            Controls.Add(label1);
            Controls.Add(btnGenre);
            Controls.Add(btnVG);
            Name = "Hub";
            Text = "Hub";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnVG;
        private Button btnGenre;
        private Label label1;
        private Button btnRate2;
    }
}