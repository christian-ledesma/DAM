using Liga.FormUI.DTOs;
using Liga.FormUI.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Liga.FormUI.Forms
{
    public partial class Clasificacion : Form
    {
        private readonly EquipoService _equiposService;
        public Clasificacion()
        {
            _equiposService = new EquipoService();
            RellenarEquipos();
            InitializeComponent();
        }

        private void Clasificacion_Load(object sender, EventArgs e)
        {
            //AjustarAltura();
        }

        private async void RellenarEquipos()
        {
            var equipos = await _equiposService.GetAll();
            foreach (var equipo in equipos)
            {
                int index = clasificacionGrid.Rows.Add();
                DataGridViewRow row = clasificacionGrid.Rows[index];

                row.Cells[0].Value = index + 1;
                row.Cells[1].Value = equipo.Nombre;
                row.Cells[2].Value = equipo.Puntos;
                row.Cells[3].Value = equipo.PartidosJugados;
                row.Cells[4].Value = equipo.PartidosGanados;
                row.Cells[5].Value = equipo.PartidosEmpatados;
                row.Cells[6].Value = equipo.PartidosPerdidos;
            }
        }

        //private void AjustarAltura()
        //{
        //    var height = clasificacionGrid.ColumnHeadersHeight;
        //    foreach (DataGridViewRow dr in clasificacionGrid.Rows)
        //    {
        //        height += dr.Height;
        //    }

        //    clasificacionGrid.Height = height;
        //}
    }
}
