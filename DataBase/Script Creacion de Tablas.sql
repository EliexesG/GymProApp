use GymPro
go
-- Crear Tablas
CREATE TABLE TipoUsuario (
	Codigo int Identity(1, 1) PRIMARY KEY,
	Descripcion nvarchar(30)
)

go 

CREATE TABLE Usuario (
	Identificacion nvarchar(18) NOT NULL,
	Nombre nvarchar(30),
	Apellido1 nvarchar(30),
	Apellido2 nvarchar(30),
	Fotografia VARBINARY(MAX),
	CodigoTipoUsuario int NOT NULL,
	Contrasenna varbinary(MAX),
	FechaNacimiento Date,
	Correo nvarchar(50),
	Telefono nvarchar(15),
	Genero int,
	Activo bit,
	PRIMARY KEY(Identificacion),
	FOREIGN KEY(CodigoTipoUsuario) REFERENCES TipoUsuario(Codigo)
)

go

CREATE TABLE ExpedienteUsuario (
	Fecha Date NOT NULL,
	IdentificacionUsuario nvarchar(18) NOT NULL,
	Peso float,
	Altura int,
	IMC float,
	MetabolismoBasal float,
	Activo bit
	PRIMARY KEY (Fecha, IdentificacionUsuario),
	FOREIGN KEY (IdentificacionUsuario) REFERENCES Usuario(Identificacion)
)

go

CREATE TABLE TipoEjercicio (
	Codigo int IDENTITY (1,1) PRIMARY KEY NOT NULL,
	Nombre nvarchar(30),
	Descripcion nvarchar(MAX),
	Activo bit
)

go

CREATE TABLE Ejercicio (
	Codigo int IDENTITY (1,1) PRIMARY KEY NOT NULL,
	Nombre nvarchar(30),
	Descripcion nvarchar(MAX),
	CodigoTipo int,
	Multimedia VARBINARY(MAX),
	Activo bit,
	FOREIGN KEY (CodigoTipo) REFERENCES TipoEjercicio(Codigo)
)

go

CREATE TABLE Entrenamiento (
	Codigo int IDENTITY (1,1) PRIMARY KEY NOT NULL,
	IdentificacionCliente nvarchar(18) NOT NULL,
	IdentificacionEntrenador nvarchar(18) NOT NULL,
	Nombre nvarchar(30),
	Activo bit,
	FOREIGN KEY (IdentificacionCliente) REFERENCES Usuario(Identificacion),
	FOREIGN KEY (IdentificacionEntrenador) REFERENCES Usuario(Identificacion)
)

go

CREATE TABLE DiaEntrenamiento(
	CodigoEntrenamiento int NOT NULL,
	Dia int,
	Activo bit,
	PRIMARY KEY(CodigoEntrenamiento, Dia),
	FOREIGN KEY (CodigoEntrenamiento) REFERENCES Entrenamiento (Codigo)
)

go

CREATE TABLE EjercicioEnEntrenamiento (
	CodigoEntrenamiento int NOT NULL,
	CodigoEjercicio int NOT NULL,
	Repeticiones int,
	Peso float,
	Series nvarchar(30),
	Tiempo int,
	Activo bit,
	PRIMARY KEY (CodigoEntrenamiento, CodigoEjercicio),
	FOREIGN KEY (CodigoEntrenamiento) REFERENCES Entrenamiento(Codigo),
	FOREIGN KEY (CodigoEjercicio) REFERENCES Ejercicio (Codigo)
)

drop Table EjercicioEnEntrenamiento

go

CREATE TABLE Servicio(
	Codigo int IDENTITY(1, 1) PRIMARY KEY NOT NULL,
	Descripcion nvarchar(30),
	Monto float
)

go

CREATE TABLE FacturaEncabezado (
	Codigo int IDENTITY(1, 1) PRIMARY KEY NOT NULL,
	IdentificacionUsuario nvarchar(18) NOT NULL,
	CodigoQR VARBINARY(MAX),
	FechaPago date,
	FechaProximoPago date,
	MontoTotal float,
	MontoMulta float,
	Activo bit,
	FOREIGN KEY (IdentificacionUsuario) REFERENCES Usuario(Identificacion)
)

go

CREATE TABLE FacturaDetalle (
	CodigoFactura int NOT NULL,
	CodigoServicio int NOT NULL,
	Activo bit,
	Primary KEY(CodigoFactura, CodigoServicio),
	FOREIGN KEY (CodigoFactura) REFERENCES FacturaEncabezado(Codigo),
	FOREIGN KEY (CodigoServicio) REFERENCES Servicio(Codigo)
)

go

CREATE TABLE ControlIngresoEgreso(
	IdentificacionUsuario nvarchar(18) NOT NULL,
	Fecha Date NOT NULL,
	HoraEntrada Time,
	HoraSalida Time,
	PRIMARY KEY (IdentificacionUsuario, Fecha),
	Foreign KEY (IdentificacionUsuario) REFERENCES Usuario(Identificacion)
)