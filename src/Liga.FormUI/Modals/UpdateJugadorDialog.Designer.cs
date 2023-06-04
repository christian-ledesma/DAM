namespace Liga.FormUI.Modals
{
    partial class UpdateJugadorDialog
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
            textBoxNombre = new System.Windows.Forms.TextBox();
            textBoxNacionalidad = new System.Windows.Forms.TextBox();
            textBoxApellidos = new System.Windows.Forms.TextBox();
            labelNombre = new System.Windows.Forms.Label();
            labelApellidos = new System.Windows.Forms.Label();
            labelNacionalidad = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            customButtonGuardar = new CustomControls.CustomButton();
            textBoxDorsal = new System.Windows.Forms.TextBox();
            SuspendLayout();
            // 
            // textBoxNombre
            // 
            textBoxNombre.Location = new System.Drawing.Point(12, 46);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new System.Drawing.Size(175, 23);
            textBoxNombre.TabIndex = 0;
            // 
            // textBoxNacionalidad
            // 
            textBoxNacionalidad.Location = new System.Drawing.Point(12, 116);
            textBoxNacionalidad.Name = "textBoxNacionalidad";
            textBoxNacionalidad.Size = new System.Drawing.Size(175, 23);
            textBoxNacionalidad.TabIndex = 1;
            // 
            // textBoxApellidos
            // 
            textBoxApellidos.Location = new System.Drawing.Point(231, 46);
            textBoxApellidos.Name = "textBoxApellidos";
            textBoxApellidos.Size = new System.Drawing.Size(175, 23);
            textBoxApellidos.TabIndex = 2;
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.Location = new System.Drawing.Point(12, 28);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new System.Drawing.Size(51, 15);
            labelNombre.TabIndex = 4;
            labelNombre.Text = "Nombre";
            // 
            // labelApellidos
            // 
            labelApellidos.AutoSize = true;
            labelApellidos.Location = new System.Drawing.Point(231, 28);
            labelApellidos.Name = "labelApellidos";
            labelApellidos.Size = new System.Drawing.Size(56, 15);
            labelApellidos.TabIndex = 5;
            labelApellidos.Text = "Apellidos";
            // 
            // labelNacionalidad
            // 
            labelNacionalidad.AutoSize = true;
            labelNacionalidad.Location = new System.Drawing.Point(12, 98);
            labelNacionalidad.Name = "labelNacionalidad";
            labelNacionalidad.Size = new System.Drawing.Size(77, 15);
            labelNacionalidad.TabIndex = 6;
            labelNacionalidad.Text = "Nacionalidad";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(231, 98);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(40, 15);
            label4.TabIndex = 7;
            label4.Text = "Dorsal";
            // 
            // customButtonGuardar
            // 
            customButtonGuardar.BackColor = System.Drawing.Color.FromArgb(149, 217, 144);
            customButtonGuardar.BackgroundColor = System.Drawing.Color.FromArgb(149, 217, 144);
            customButtonGuardar.BorderColor = System.Drawing.Color.Green;
            customButtonGuardar.BorderRadius = 12;
            customButtonGuardar.BorderSize = 0;
            customButtonGuardar.FlatAppearance.BorderSize = 0;
            customButtonGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            customButtonGuardar.ForeColor = System.Drawing.Color.Black;
            customButtonGuardar.Location = new System.Drawing.Point(256, 159);
            customButtonGuardar.Name = "customButtonGuardar";
            customButtonGuardar.Size = new System.Drawing.Size(150, 40);
            customButtonGuardar.TabIndex = 9;
            customButtonGuardar.Text = "Guardar";
            customButtonGuardar.TextColor = System.Drawing.Color.Black;
            customButtonGuardar.UseVisualStyleBackColor = false;
            customButtonGuardar.Click += customButtonGuardar_Click;
            // 
            // textBoxDorsal
            // 
            textBoxDorsal.Location = new System.Drawing.Point(231, 116);
            textBoxDorsal.Name = "textBoxDorsal";
            textBoxDorsal.Size = new System.Drawing.Size(175, 23);
            textBoxDorsal.TabIndex = 10;
            textBoxDorsal.KeyPress += textBoxDorsal_KeyPress;
            // 
            // UpdateJugadorDialog
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(206, 235, 252);
            ClientSize = new System.Drawing.Size(434, 211);
            Controls.Add(textBoxDorsal);
            Controls.Add(customButtonGuardar);
            Controls.Add(label4);
            Controls.Add(labelNacionalidad);
            Controls.Add(labelApellidos);
            Controls.Add(labelNombre);
            Controls.Add(textBoxApellidos);
            Controls.Add(textBoxNacionalidad);
            Controls.Add(textBoxNombre);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "UpdateJugadorDialog";
            Text = "Actualizar Jugador";
            Load += UpdateJugadorDialog_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxNacionalidad;
        private System.Windows.Forms.TextBox textBoxApellidos;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelApellidos;
        private System.Windows.Forms.Label labelNacionalidad;
        private System.Windows.Forms.Label label4;
        private CustomControls.CustomButton customButtonGuardar;
        private System.Windows.Forms.TextBox textBoxDorsal;
    }
}