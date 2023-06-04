namespace Liga.FormUI.CustomControls
{
    partial class JugadorItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JugadorItem));
            pictureBox1 = new System.Windows.Forms.PictureBox();
            labelNombre = new System.Windows.Forms.Label();
            labelPais = new System.Windows.Forms.Label();
            labelPosicion = new System.Windows.Forms.Label();
            customButton1 = new CustomButton();
            customButton2 = new CustomButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(15, 20);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(60, 60);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.Location = new System.Drawing.Point(112, 20);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new System.Drawing.Size(112, 15);
            labelNombre.TabIndex = 1;
            labelNombre.Text = "Nombre y Apellidos";
            // 
            // labelPais
            // 
            labelPais.AutoSize = true;
            labelPais.Location = new System.Drawing.Point(112, 42);
            labelPais.Name = "labelPais";
            labelPais.Size = new System.Drawing.Size(28, 15);
            labelPais.TabIndex = 2;
            labelPais.Text = "País";
            // 
            // labelPosicion
            // 
            labelPosicion.AutoSize = true;
            labelPosicion.Location = new System.Drawing.Point(112, 65);
            labelPosicion.Name = "labelPosicion";
            labelPosicion.Size = new System.Drawing.Size(52, 15);
            labelPosicion.TabIndex = 3;
            labelPosicion.Text = "Posición";
            // 
            // customButton1
            // 
            customButton1.BackColor = System.Drawing.Color.FromArgb(231, 220, 123);
            customButton1.BackgroundColor = System.Drawing.Color.FromArgb(231, 220, 123);
            customButton1.BorderColor = System.Drawing.Color.Green;
            customButton1.BorderRadius = 12;
            customButton1.BorderSize = 0;
            customButton1.FlatAppearance.BorderSize = 0;
            customButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            customButton1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            customButton1.ForeColor = System.Drawing.Color.Black;
            customButton1.Location = new System.Drawing.Point(374, 20);
            customButton1.Name = "customButton1";
            customButton1.Size = new System.Drawing.Size(102, 29);
            customButton1.TabIndex = 4;
            customButton1.Text = "Actualizar";
            customButton1.TextColor = System.Drawing.Color.Black;
            customButton1.UseVisualStyleBackColor = false;
            customButton1.Click += customButton1_Click;
            // 
            // customButton2
            // 
            customButton2.BackColor = System.Drawing.Color.FromArgb(231, 123, 123);
            customButton2.BackgroundColor = System.Drawing.Color.FromArgb(231, 123, 123);
            customButton2.BorderColor = System.Drawing.Color.Green;
            customButton2.BorderRadius = 12;
            customButton2.BorderSize = 0;
            customButton2.FlatAppearance.BorderSize = 0;
            customButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            customButton2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            customButton2.ForeColor = System.Drawing.Color.Black;
            customButton2.Location = new System.Drawing.Point(374, 55);
            customButton2.Name = "customButton2";
            customButton2.Size = new System.Drawing.Size(102, 29);
            customButton2.TabIndex = 5;
            customButton2.Text = "Eliminar";
            customButton2.TextColor = System.Drawing.Color.Black;
            customButton2.UseVisualStyleBackColor = false;
            // 
            // JugadorItem
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(181, 226, 251);
            Controls.Add(customButton2);
            Controls.Add(customButton1);
            Controls.Add(labelPosicion);
            Controls.Add(labelPais);
            Controls.Add(labelNombre);
            Controls.Add(pictureBox1);
            Name = "JugadorItem";
            Size = new System.Drawing.Size(505, 100);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelPais;
        private System.Windows.Forms.Label labelPosicion;
        private CustomButton customButton1;
        private CustomButton customButton2;
    }
}
