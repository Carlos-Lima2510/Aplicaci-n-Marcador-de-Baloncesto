namespace Aplicación_Marcador_de_Baloncesto.Interfaces
{
    partial class FormBaloncesto
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBaloncesto));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Reinicio = new System.Windows.Forms.Button();
            this.btn_Pausa = new System.Windows.Forms.Button();
            this.btn_InicioTiempo = new System.Windows.Forms.Button();
            this.label_Tiempo = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label_Cuarto = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label_Visitante = new System.Windows.Forms.Label();
            this.label_Local = new System.Windows.Forms.Label();
            this.labelLocal = new System.Windows.Forms.Label();
            this.labelVisitante = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gold;
            this.panel1.Controls.Add(this.btn_Reinicio);
            this.panel1.Controls.Add(this.btn_Pausa);
            this.panel1.Controls.Add(this.btn_InicioTiempo);
            this.panel1.Controls.Add(this.label_Tiempo);
            this.panel1.Location = new System.Drawing.Point(50, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(668, 156);
            this.panel1.TabIndex = 0;
            // 
            // btn_Reinicio
            // 
            this.btn_Reinicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Reinicio.Font = new System.Drawing.Font("Bauhaus 93", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reinicio.Location = new System.Drawing.Point(523, 94);
            this.btn_Reinicio.Name = "btn_Reinicio";
            this.btn_Reinicio.Size = new System.Drawing.Size(111, 31);
            this.btn_Reinicio.TabIndex = 3;
            this.btn_Reinicio.Text = "Reinicio";
            this.btn_Reinicio.UseVisualStyleBackColor = true;
            this.btn_Reinicio.Click += new System.EventHandler(this.btn_Reinicio_Click);
            // 
            // btn_Pausa
            // 
            this.btn_Pausa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Pausa.Font = new System.Drawing.Font("Bauhaus 93", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Pausa.Location = new System.Drawing.Point(523, 57);
            this.btn_Pausa.Name = "btn_Pausa";
            this.btn_Pausa.Size = new System.Drawing.Size(111, 31);
            this.btn_Pausa.TabIndex = 2;
            this.btn_Pausa.Text = "Pausa";
            this.btn_Pausa.UseVisualStyleBackColor = true;
            this.btn_Pausa.Click += new System.EventHandler(this.button4_Click);
            // 
            // btn_InicioTiempo
            // 
            this.btn_InicioTiempo.BackColor = System.Drawing.Color.Transparent;
            this.btn_InicioTiempo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_InicioTiempo.Font = new System.Drawing.Font("Bauhaus 93", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_InicioTiempo.Location = new System.Drawing.Point(523, 20);
            this.btn_InicioTiempo.Name = "btn_InicioTiempo";
            this.btn_InicioTiempo.Size = new System.Drawing.Size(111, 31);
            this.btn_InicioTiempo.TabIndex = 1;
            this.btn_InicioTiempo.Text = "Inicio";
            this.btn_InicioTiempo.UseVisualStyleBackColor = false;
            this.btn_InicioTiempo.Click += new System.EventHandler(this.btn_InicioTiempo_Click);
            // 
            // label_Tiempo
            // 
            this.label_Tiempo.AutoSize = true;
            this.label_Tiempo.Font = new System.Drawing.Font("Bauhaus 93", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Tiempo.Location = new System.Drawing.Point(205, 31);
            this.label_Tiempo.Name = "label_Tiempo";
            this.label_Tiempo.Size = new System.Drawing.Size(249, 91);
            this.label_Tiempo.TabIndex = 0;
            this.label_Tiempo.Text = "12:00";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gold;
            this.panel2.Controls.Add(this.label_Cuarto);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(270, 174);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(234, 138);
            this.panel2.TabIndex = 1;
            // 
            // label_Cuarto
            // 
            this.label_Cuarto.AutoSize = true;
            this.label_Cuarto.Font = new System.Drawing.Font("Bauhaus 93", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Cuarto.Location = new System.Drawing.Point(169, 51);
            this.label_Cuarto.Name = "label_Cuarto";
            this.label_Cuarto.Size = new System.Drawing.Size(36, 39);
            this.label_Cuarto.TabIndex = 1;
            this.label_Cuarto.Text = "1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bauhaus 93", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cuarto:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gold;
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.label_Visitante);
            this.panel3.Controls.Add(this.label_Local);
            this.panel3.Location = new System.Drawing.Point(50, 318);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(668, 142);
            this.panel3.TabIndex = 2;
            // 
            // label_Visitante
            // 
            this.label_Visitante.AutoSize = true;
            this.label_Visitante.Font = new System.Drawing.Font("Bauhaus 93", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Visitante.Location = new System.Drawing.Point(571, 40);
            this.label_Visitante.Name = "label_Visitante";
            this.label_Visitante.Size = new System.Drawing.Size(63, 68);
            this.label_Visitante.TabIndex = 8;
            this.label_Visitante.Text = "0";
            // 
            // label_Local
            // 
            this.label_Local.AutoSize = true;
            this.label_Local.Font = new System.Drawing.Font("Bauhaus 93", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Local.Location = new System.Drawing.Point(40, 40);
            this.label_Local.Name = "label_Local";
            this.label_Local.Size = new System.Drawing.Size(63, 68);
            this.label_Local.TabIndex = 0;
            this.label_Local.Text = "0";
            // 
            // labelLocal
            // 
            this.labelLocal.AutoSize = true;
            this.labelLocal.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLocal.Location = new System.Drawing.Point(85, 474);
            this.labelLocal.Name = "labelLocal";
            this.labelLocal.Size = new System.Drawing.Size(57, 23);
            this.labelLocal.TabIndex = 4;
            this.labelLocal.Text = "Local";
            // 
            // labelVisitante
            // 
            this.labelVisitante.AutoSize = true;
            this.labelVisitante.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVisitante.Location = new System.Drawing.Point(606, 474);
            this.labelVisitante.Name = "labelVisitante";
            this.labelVisitante.Size = new System.Drawing.Size(87, 23);
            this.labelVisitante.TabIndex = 5;
            this.labelVisitante.Text = "Visitante";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gold;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Bauhaus 93", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(270, 474);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 60);
            this.button1.TabIndex = 6;
            this.button1.Text = "Puntuar Equipo Local";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Gold;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Bauhaus 93", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(397, 474);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 60);
            this.button2.TabIndex = 7;
            this.button2.Text = "Puntuar Equipo Visitante";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(238, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(206, 136);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // FormBaloncesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 555);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelVisitante);
            this.Controls.Add(this.labelLocal);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormBaloncesto";
            this.Text = "FormBaloncesto";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label labelLocal;
        private System.Windows.Forms.Label labelVisitante;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label_Local;
        private System.Windows.Forms.Label label_Visitante;
        private System.Windows.Forms.Label label_Tiempo;
        private System.Windows.Forms.Button btn_Reinicio;
        private System.Windows.Forms.Button btn_Pausa;
        private System.Windows.Forms.Button btn_InicioTiempo;
        private System.Windows.Forms.Label label_Cuarto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}