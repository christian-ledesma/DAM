namespace Liga.FormUI.Forms
{
    partial class Clasificacion
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
            dataGridView1 = new System.Windows.Forms.DataGridView();
            Posicion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Equipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Puntos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            PJ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            PP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            PG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            PE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { Posicion, Equipo, Puntos, PJ, PP, PG, PE });
            dataGridView1.Location = new System.Drawing.Point(61, 56);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new System.Drawing.Size(838, 576);
            dataGridView1.TabIndex = 0;
            // 
            // Posicion
            // 
            Posicion.HeaderText = "Posicion";
            Posicion.Name = "Posicion";
            Posicion.ReadOnly = true;
            // 
            // Equipo
            // 
            Equipo.HeaderText = "Equipo";
            Equipo.Name = "Equipo";
            Equipo.ReadOnly = true;
            // 
            // Puntos
            // 
            Puntos.HeaderText = "Puntos";
            Puntos.Name = "Puntos";
            Puntos.ReadOnly = true;
            // 
            // PJ
            // 
            PJ.HeaderText = "PJ";
            PJ.Name = "PJ";
            PJ.ReadOnly = true;
            // 
            // PP
            // 
            PP.HeaderText = "PP";
            PP.Name = "PP";
            PP.ReadOnly = true;
            // 
            // PG
            // 
            PG.HeaderText = "PG";
            PG.Name = "PG";
            PG.ReadOnly = true;
            // 
            // PE
            // 
            PE.HeaderText = "PE";
            PE.Name = "PE";
            PE.ReadOnly = true;
            // 
            // Clasificacion
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(206, 235, 252);
            ClientSize = new System.Drawing.Size(944, 681);
            Controls.Add(dataGridView1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "Clasificacion";
            Text = "Clasificacion";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Posicion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Equipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Puntos;
        private System.Windows.Forms.DataGridViewTextBoxColumn PJ;
        private System.Windows.Forms.DataGridViewTextBoxColumn PP;
        private System.Windows.Forms.DataGridViewTextBoxColumn PG;
        private System.Windows.Forms.DataGridViewTextBoxColumn PE;
    }
}