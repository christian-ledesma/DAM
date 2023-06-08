namespace Liga.FormUI.CustomControls
{
    partial class JugadorOferta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JugadorOferta));
            labelPosicion = new System.Windows.Forms.Label();
            labelPais = new System.Windows.Forms.Label();
            labelNombre = new System.Windows.Forms.Label();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            customButton1 = new CustomButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // labelPosicion
            // 
            labelPosicion.AutoSize = true;
            labelPosicion.Location = new System.Drawing.Point(147, 65);
            labelPosicion.Name = "labelPosicion";
            labelPosicion.Size = new System.Drawing.Size(52, 15);
            labelPosicion.TabIndex = 7;
            labelPosicion.Text = "Posición";
            // 
            // labelPais
            // 
            labelPais.AutoSize = true;
            labelPais.Location = new System.Drawing.Point(147, 42);
            labelPais.Name = "labelPais";
            labelPais.Size = new System.Drawing.Size(28, 15);
            labelPais.TabIndex = 6;
            labelPais.Text = "País";
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.Location = new System.Drawing.Point(147, 20);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new System.Drawing.Size(112, 15);
            labelNombre.TabIndex = 5;
            labelNombre.Text = "Nombre y Apellidos";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(34, 20);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(60, 60);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // customButton1
            // 
            customButton1.BackColor = System.Drawing.Color.FromArgb(149, 217, 144);
            customButton1.BackgroundColor = System.Drawing.Color.FromArgb(149, 217, 144);
            customButton1.BorderColor = System.Drawing.Color.Green;
            customButton1.BorderRadius = 12;
            customButton1.BorderSize = 0;
            customButton1.FlatAppearance.BorderSize = 0;
            customButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            customButton1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            customButton1.ForeColor = System.Drawing.Color.Black;
            customButton1.Location = new System.Drawing.Point(480, 34);
            customButton1.Name = "customButton1";
            customButton1.Size = new System.Drawing.Size(102, 29);
            customButton1.TabIndex = 8;
            customButton1.Text = "Oferta";
            customButton1.TextColor = System.Drawing.Color.Black;
            customButton1.UseVisualStyleBackColor = false;
            customButton1.Click += customButton1_Click;
            // 
            // JugadorOferta
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(181, 226, 251);
            Controls.Add(customButton1);
            Controls.Add(labelPosicion);
            Controls.Add(labelPais);
            Controls.Add(labelNombre);
            Controls.Add(pictureBox1);
            Name = "JugadorOferta";
            Size = new System.Drawing.Size(617, 100);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label labelPosicion;
        private System.Windows.Forms.Label labelPais;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.PictureBox pictureBox1;
        private CustomButton customButton1;
    }
}
