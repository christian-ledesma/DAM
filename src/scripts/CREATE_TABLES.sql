
CREATE TABLE OfertaEstados(
	Id int primary key identity(1,1),
	Descripcion nvarchar(50)
);

CREATE TABLE OfertaTipos(
	Id int primary key identity(1,1),
	Descripcion nvarchar(50)
);

CREATE TABLE Posiciones(
	Id int primary key identity(1,1),
	Nombre nvarchar(50)
);

CREATE TABLE Usuarios(
	Id int primary key identity(1,1),
	Email nvarchar(100),
	Password nvarchar(max),
	Nombre nvarchar(50),
	Apellidos nvarchar(50),
	Admin bit
);

CREATE TABLE Jugadores(
	Id int primary key identity(1,1),
	Nombre nvarchar(50),
	Apellidos nvarchar(50),
	Nacionalidad nvarchar(50),
	Valor decimal(10,2),
	PosicionId int,
	EquipoId int,
	Edad int,
	Dorsal int
);

CREATE TABLE Ofertas(
	Id int primary key identity(1,1),
	OfertaEstadoId int,
	Valor decimal(10,2),
	JugadorId int
);

CREATE TABLE EquipoOfertas(
	Id int primary key identity(1,1),
	EquipoOfertanteId int,
	EquipoOfertadoId int,
	OfertaId int
);

CREATE TABLE Equipos(
	Id int primary key identity(1,1),
	EntrenadorId int,
	Puntos int,
	Presupuesto decimal(10,2),
	PartidosJugados int,
	PartidosGanados int,
	PartidosEmpatados int,
	PartidosPerdidos int,
	ImagenUrl nvarchar(max),
	Ubicacion nvarchar(200),
	Estadio nvarchar(200)
);

CREATE TABLE Partidos(
	Id int primary key identity(1,1),
	TemporadaId int,
	EquipoGanadorId int,
	Goles int
);
