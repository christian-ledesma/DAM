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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.clasificacionGrid = new System.Windows.Forms.DataGridView();
            this.Posicion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Equipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Puntos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PJ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.clasificacionGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // clasificacionGrid
            // 
            this.clasificacionGrid.AllowUserToAddRows = false;
            this.clasificacionGrid.AllowUserToDeleteRows = false;
            this.clasificacionGrid.AllowUserToResizeColumns = false;
            this.clasificacionGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(226)))), ((int)(((byte)(251)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(226)))), ((int)(((byte)(251)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.clasificacionGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.clasificacionGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clasificacionGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(235)))), ((int)(((byte)(252)))));
            this.clasificacionGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clasificacionGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.clasificacionGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(226)))), ((int)(((byte)(251)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(226)))), ((int)(((byte)(251)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.clasificacionGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.clasificacionGrid.ColumnHeadersHeight = 50;
            this.clasificacionGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.clasificacionGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Posicion,
            this.Equipo,
            this.Puntos,
            this.PJ,
            this.PG,
            this.PE,
            this.PP});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(235)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(235)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.clasificacionGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.clasificacionGrid.EnableHeadersVisualStyles = false;
            this.clasificacionGrid.Location = new System.Drawing.Point(44, 56);
            this.clasificacionGrid.MultiSelect = false;
            this.clasificacionGrid.Name = "clasificacionGrid";
            this.clasificacionGrid.ReadOnly = true;
            this.clasificacionGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.clasificacionGrid.RowHeadersVisible = false;
            this.clasificacionGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.clasificacionGrid.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.clasificacionGrid.RowTemplate.Height = 40;
            this.clasificacionGrid.RowTemplate.ReadOnly = true;
            this.clasificacionGrid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clasificacionGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.clasificacionGrid.ShowCellErrors = false;
            this.clasificacionGrid.ShowCellToolTips = false;
            this.clasificacionGrid.ShowEditingIcon = false;
            this.clasificacionGrid.ShowRowErrors = false;
            this.clasificacionGrid.Size = new System.Drawing.Size(866, 576);
            this.clasificacionGrid.TabIndex = 0;
            // 
            // Posicion
            // 
            this.Posicion.HeaderText = "Posición";
            this.Posicion.Name = "Posicion";
            this.Posicion.ReadOnly = true;
            this.Posicion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Posicion.Width = 110;
            // 
            // Equipo
            // 
            this.Equipo.HeaderText = "Equipo";
            this.Equipo.Name = "Equipo";
            this.Equipo.ReadOnly = true;
            this.Equipo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Equipo.Width = 140;
            // 
            // Puntos
            // 
            this.Puntos.HeaderText = "Puntos";
            this.Puntos.Name = "Puntos";
            this.Puntos.ReadOnly = true;
            this.Puntos.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Puntos.Width = 120;
            // 
            // PJ
            // 
            this.PJ.HeaderText = "PJ";
            this.PJ.Name = "PJ";
            this.PJ.ReadOnly = true;
            this.PJ.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.PJ.Width = 120;
            // 
            // PG
            // 
            this.PG.HeaderText = "PG";
            this.PG.Name = "PG";
            this.PG.ReadOnly = true;
            this.PG.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.PG.Width = 120;
            // 
            // PE
            // 
            this.PE.HeaderText = "PE";
            this.PE.Name = "PE";
            this.PE.ReadOnly = true;
            this.PE.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.PE.Width = 118;
            // 
            // PP
            // 
            this.PP.HeaderText = "PP";
            this.PP.Name = "PP";
            this.PP.ReadOnly = true;
            this.PP.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.PP.Width = 120;
            // 
            // Clasificacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(235)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(944, 681);
            this.Controls.Add(this.clasificacionGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Clasificacion";
            this.Text = "Clasificacion";
            this.Load += new System.EventHandler(this.Clasificacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clasificacionGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView clasificacionGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Posicion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Equipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Puntos;
        private System.Windows.Forms.DataGridViewTextBoxColumn PJ;
        private System.Windows.Forms.DataGridViewTextBoxColumn PG;
        private System.Windows.Forms.DataGridViewTextBoxColumn PE;
        private System.Windows.Forms.DataGridViewTextBoxColumn PP;
    }
}