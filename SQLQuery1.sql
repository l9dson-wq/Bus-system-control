create database sistemaAutobus
go 
use sistemaAutobus

CREATE TABLE usuarios(
	idUsuarios INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	nombreUsuario VARCHAR(100) NOT NULL,
	claveUsuario VARCHAR(100) NOT NULL,
	tipoUsuario VARCHAR(50) NOT NULL
)

DROP TABLE usuarios;
INSERT INTO usuarios VALUES ('andelson','ledson20','admin');
INSERT INTO usuarios VALUES ('nicolas', 'ysabel', 'comun');
SELECT * FROM usuarios;

CREATE TABLE choferes (
	idChoferes INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
	nombreChoferes VARCHAR(100) NOT NULL,
	apellidoChoferes VARCHAR(100) NOT NULL,
	fechaNacimientoChoferes smalldatetime NOT NULL, 
	cedulaChoferes VARCHAR(100) NOT NULL
)

INSERT INTO choferes VALUES ('Juan','Peralta','10/08/1995','40233144675');
UPDATE choferes SET nombreChoferes = 'cabron', apellidoChoferes = '', fechaNacimientoChoferes = '', cedulaChoferes = '';
select * from choferes;

CREATE TABLE autobuses (
	idAutobuses INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
	marcaAutobus VARCHAR(100),
	modeloAutobus VARCHAR(100),
	placaAutobus VARCHAR(100),
	colorAutobus VARCHAR(100),
	añoAutobus SMALLDATETIME 
)
DROP TABLE autobuses
INSERT INTO autobuses VALUES ('BMW','BPPW-21','SD46543','AZUL','11/15/1989')
SELECT * FROM autobuses

CREATE TABLE ruta (
	idRuta INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
	nombreRura VARCHAR(100) NOT NULL
)
DROP TABLE RUTA
INSERT INTO ruta VALUES ('Charles Villa Mella')
SELECT * FROM ruta

CREATE TABLE reservaciones (
	idReservaciones INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
	nombreChoferReservado VARCHAR(100) NOT NULL,
	marcaAutobusReservado VARCHAR(100) NOT Null,
	nombreRutaReservada VARCHAR(100) NOT NULL
)

