namespace Liga.FormUI.CustomControls
{
    partial class Equipo
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Equipo));
            this.labelClasificacion = new System.Windows.Forms.Label();
            this.labelDirector = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelDerrotas = new System.Windows.Forms.Label();
            this.labelVictorias = new System.Windows.Forms.Label();
            this.labelUbicacion = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelClasificacion
            // 
            this.labelClasificacion.AutoSize = true;
            this.labelClasificacion.Location = new System.Drawing.Point(147, 65);
            this.labelClasificacion.Name = "labelClasificacion";
            this.labelClasificacion.Size = new System.Drawing.Size(74, 15);
            this.labelClasificacion.TabIndex = 11;
            this.labelClasificacion.Text = "Clasificación";
            // 
            // labelDirector
            // 
            this.labelDirector.AutoSize = true;
            this.labelDirector.Location = new System.Drawing.Point(147, 42);
            this.labelDirector.Name = "labelDirector";
            this.labelDirector.Size = new System.Drawing.Size(49, 15);
            this.labelDirector.TabIndex = 10;
            this.labelDirector.Text = "Director";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(147, 20);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(51, 15);
            this.labelNombre.TabIndex = 9;
            this.labelNombre.Text = "Nombre";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(34, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // labelDerrotas
            // 
            this.labelDerrotas.AutoSize = true;
            this.labelDerrotas.Location = new System.Drawing.Point(326, 65);
            this.labelDerrotas.Name = "labelDerrotas";
            this.labelDerrotas.Size = new System.Drawing.Size(51, 15);
            this.labelDerrotas.TabIndex = 14;
            this.labelDerrotas.Text = "Derrotas";
            // 
            // labelVictorias
            // 
            this.labelVictorias.AutoSize = true;
            this.labelVictorias.Location = new System.Drawing.Point(326, 42);
            this.labelVictorias.Name = "labelVictorias";
            this.labelVictorias.Size = new System.Drawing.Size(52, 15);
            this.labelVictorias.TabIndex = 13;
            this.labelVictorias.Text = "Victorias";
            // 
            // labelUbicacion
            // 
            this.labelUbicacion.AutoSize = true;
            this.labelUbicacion.Location = new System.Drawing.Point(326, 20);
            this.labelUbicacion.Name = "labelUbicacion";
            this.labelUbicacion.Size = new System.Drawing.Size(60, 15);
            this.labelUbicacion.TabIndex = 12;
            this.labelUbicacion.Text = "Ubicación";
            // 
            // Equipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(226)))), ((int)(((byte)(251)))));
            this.Controls.Add(this.labelDerrotas);
            this.Controls.Add(this.labelVictorias);
            this.Controls.Add(this.labelUbicacion);
            this.Controls.Add(this.labelClasificacion);
            this.Controls.Add(this.labelDirector);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Equipo";
            this.Size = new System.Drawing.Size(617, 100);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelClasificacion;
        private System.Windows.Forms.Label labelDirector;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelDerrotas;
        private System.Windows.Forms.Label labelVictorias;
        private System.Windows.Forms.Label labelUbicacion;
    }
}
