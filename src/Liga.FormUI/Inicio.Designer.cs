﻿namespace Liga.FormUI
{
    partial class Inicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.SidebarPanel = new System.Windows.Forms.Panel();
            this.buttonCerrarSesion = new System.Windows.Forms.Button();
            this.buttonNoticias = new System.Windows.Forms.Button();
            this.buttonPerfil = new System.Windows.Forms.Button();
            this.buttonClasificacion = new System.Windows.Forms.Button();
            this.buttonJugadores = new System.Windows.Forms.Button();
            this.buttonEquipos = new System.Windows.Forms.Button();
            this.buttonMiEquipo = new System.Windows.Forms.Button();
            this.ButtonInicio = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelContent = new System.Windows.Forms.Panel();
            this.SidebarPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // SidebarPanel
            // 
            this.SidebarPanel.AutoScroll = true;
            this.SidebarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(226)))), ((int)(((byte)(251)))));
            this.SidebarPanel.Controls.Add(this.buttonCerrarSesion);
            this.SidebarPanel.Controls.Add(this.buttonNoticias);
            this.SidebarPanel.Controls.Add(this.buttonPerfil);
            this.SidebarPanel.Controls.Add(this.buttonClasificacion);
            this.SidebarPanel.Controls.Add(this.buttonJugadores);
            this.SidebarPanel.Controls.Add(this.buttonEquipos);
            this.SidebarPanel.Controls.Add(this.buttonMiEquipo);
            this.SidebarPanel.Controls.Add(this.ButtonInicio);
            this.SidebarPanel.Controls.Add(this.panel1);
            this.SidebarPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SidebarPanel.Location = new System.Drawing.Point(0, 0);
            this.SidebarPanel.Name = "SidebarPanel";
            this.SidebarPanel.Size = new System.Drawing.Size(320, 681);
            this.SidebarPanel.TabIndex = 0;
            // 
            // buttonCerrarSesion
            // 
            this.buttonCerrarSesion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonCerrarSesion.FlatAppearance.BorderSize = 0;
            this.buttonCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCerrarSesion.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonCerrarSesion.ForeColor = System.Drawing.Color.Black;
            this.buttonCerrarSesion.Location = new System.Drawing.Point(0, 636);
            this.buttonCerrarSesion.Name = "buttonCerrarSesion";
            this.buttonCerrarSesion.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.buttonCerrarSesion.Size = new System.Drawing.Size(320, 45);
            this.buttonCerrarSesion.TabIndex = 8;
            this.buttonCerrarSesion.Text = "Cerrar Sesión";
            this.buttonCerrarSesion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCerrarSesion.UseVisualStyleBackColor = true;
            this.buttonCerrarSesion.Click += new System.EventHandler(this.buttonCerrarSesion_Click);
            // 
            // buttonNoticias
            // 
            this.buttonNoticias.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonNoticias.FlatAppearance.BorderSize = 0;
            this.buttonNoticias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNoticias.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonNoticias.ForeColor = System.Drawing.Color.Black;
            this.buttonNoticias.Location = new System.Drawing.Point(0, 370);
            this.buttonNoticias.Name = "buttonNoticias";
            this.buttonNoticias.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.buttonNoticias.Size = new System.Drawing.Size(320, 45);
            this.buttonNoticias.TabIndex = 7;
            this.buttonNoticias.Text = "Noticias";
            this.buttonNoticias.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonNoticias.UseVisualStyleBackColor = true;
            this.buttonNoticias.Click += new System.EventHandler(this.buttonNoticias_Click);
            // 
            // buttonPerfil
            // 
            this.buttonPerfil.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonPerfil.FlatAppearance.BorderSize = 0;
            this.buttonPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPerfil.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonPerfil.ForeColor = System.Drawing.Color.Black;
            this.buttonPerfil.Location = new System.Drawing.Point(0, 325);
            this.buttonPerfil.Name = "buttonPerfil";
            this.buttonPerfil.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.buttonPerfil.Size = new System.Drawing.Size(320, 45);
            this.buttonPerfil.TabIndex = 6;
            this.buttonPerfil.Text = "Mi Perfil";
            this.buttonPerfil.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPerfil.UseVisualStyleBackColor = true;
            this.buttonPerfil.Click += new System.EventHandler(this.buttonPerfil_Click);
            // 
            // buttonClasificacion
            // 
            this.buttonClasificacion.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonClasificacion.FlatAppearance.BorderSize = 0;
            this.buttonClasificacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClasificacion.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonClasificacion.ForeColor = System.Drawing.Color.Black;
            this.buttonClasificacion.Location = new System.Drawing.Point(0, 280);
            this.buttonClasificacion.Name = "buttonClasificacion";
            this.buttonClasificacion.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.buttonClasificacion.Size = new System.Drawing.Size(320, 45);
            this.buttonClasificacion.TabIndex = 5;
            this.buttonClasificacion.Text = "Clasificación";
            this.buttonClasificacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonClasificacion.UseVisualStyleBackColor = true;
            this.buttonClasificacion.Click += new System.EventHandler(this.buttonEstadísticas_Click);
            // 
            // buttonJugadores
            // 
            this.buttonJugadores.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonJugadores.FlatAppearance.BorderSize = 0;
            this.buttonJugadores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonJugadores.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonJugadores.ForeColor = System.Drawing.Color.Black;
            this.buttonJugadores.Location = new System.Drawing.Point(0, 235);
            this.buttonJugadores.Name = "buttonJugadores";
            this.buttonJugadores.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.buttonJugadores.Size = new System.Drawing.Size(320, 45);
            this.buttonJugadores.TabIndex = 4;
            this.buttonJugadores.Text = "Jugadores";
            this.buttonJugadores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonJugadores.UseVisualStyleBackColor = true;
            this.buttonJugadores.Click += new System.EventHandler(this.buttonJugadores_Click);
            // 
            // buttonEquipos
            // 
            this.buttonEquipos.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonEquipos.FlatAppearance.BorderSize = 0;
            this.buttonEquipos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEquipos.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonEquipos.ForeColor = System.Drawing.Color.Black;
            this.buttonEquipos.Location = new System.Drawing.Point(0, 190);
            this.buttonEquipos.Name = "buttonEquipos";
            this.buttonEquipos.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.buttonEquipos.Size = new System.Drawing.Size(320, 45);
            this.buttonEquipos.TabIndex = 3;
            this.buttonEquipos.Text = "Equipos";
            this.buttonEquipos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEquipos.UseVisualStyleBackColor = true;
            this.buttonEquipos.Click += new System.EventHandler(this.buttonEquipos_Click);
            // 
            // buttonMiEquipo
            // 
            this.buttonMiEquipo.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonMiEquipo.FlatAppearance.BorderSize = 0;
            this.buttonMiEquipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMiEquipo.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonMiEquipo.ForeColor = System.Drawing.Color.Black;
            this.buttonMiEquipo.Location = new System.Drawing.Point(0, 145);
            this.buttonMiEquipo.Name = "buttonMiEquipo";
            this.buttonMiEquipo.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.buttonMiEquipo.Size = new System.Drawing.Size(320, 45);
            this.buttonMiEquipo.TabIndex = 2;
            this.buttonMiEquipo.Text = "Mi Equipo";
            this.buttonMiEquipo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonMiEquipo.UseVisualStyleBackColor = true;
            this.buttonMiEquipo.Click += new System.EventHandler(this.buttonMiEquipo_Click);
            // 
            // ButtonInicio
            // 
            this.ButtonInicio.Dock = System.Windows.Forms.DockStyle.Top;
            this.ButtonInicio.FlatAppearance.BorderSize = 0;
            this.ButtonInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonInicio.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonInicio.ForeColor = System.Drawing.Color.Black;
            this.ButtonInicio.Location = new System.Drawing.Point(0, 100);
            this.ButtonInicio.Name = "ButtonInicio";
            this.ButtonInicio.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.ButtonInicio.Size = new System.Drawing.Size(320, 45);
            this.ButtonInicio.TabIndex = 1;
            this.ButtonInicio.Text = "Inicio";
            this.ButtonInicio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonInicio.UseVisualStyleBackColor = true;
            this.ButtonInicio.Click += new System.EventHandler(this.ButtonInicio_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(320, 100);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(36, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(240, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelContent
            // 
            this.panelContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelContent.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(235)))), ((int)(((byte)(252)))));
            this.panelContent.Location = new System.Drawing.Point(320, 0);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(944, 681);
            this.panelContent.TabIndex = 1;
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.SidebarPanel);
            this.Name = "Inicio";
            this.Text = "Super Copa Europea";
            this.SidebarPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SidebarPanel;
        private System.Windows.Forms.Button ButtonInicio;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonNoticias;
        private System.Windows.Forms.Button buttonPerfil;
        private System.Windows.Forms.Button buttonClasificacion;
        private System.Windows.Forms.Button buttonJugadores;
        private System.Windows.Forms.Button buttonEquipos;
        private System.Windows.Forms.Button buttonMiEquipo;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonCerrarSesion;
    }
}
