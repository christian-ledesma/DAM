﻿using Liga.FormUI.CustomControls;
using Liga.FormUI.DTOs;
using Liga.FormUI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Liga.FormUI.Forms
{
    public partial class Jugadores : Form
    {
        private IEnumerable<JugadorDto> _jugadores;
        private readonly JugadorService _jugadorService;

        public Jugadores()
        {
            _jugadorService = new JugadorService();
            InitializeComponent();
        }

        private async void Jugadores_Load(object sender, EventArgs e)
        {
            _jugadores = await _jugadorService.GetJugadoresList();

            FillGrid();
        }

        private void FillGrid()
        {
            var jugadorItems = new JugadorOferta[_jugadores.Count()];
            for (int i = 0; i < _jugadores.Count(); i++)
            {
                var nombreCompleto = $"{_jugadores.ToArray()[i].Nombre} {_jugadores.ToArray()[i].Apellidos}";
                jugadorItems[i] = new JugadorOferta
                {
                    JugadorId = _jugadores.ToArray()[i].Id,
                    NombreCompleto = nombreCompleto,
                    Pais = _jugadores.ToArray()[i].Nacionalidad,
                    Posicion = _jugadores.ToArray()[i].Posicion
                };
            }

            flowLayoutPanel1.Controls.AddRange(jugadorItems);
        }
    }
}
