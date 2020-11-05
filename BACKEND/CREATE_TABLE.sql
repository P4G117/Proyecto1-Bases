-- Se utiliza esto debido a que el atributo Nombre es un atributo compuesto

CREATE TYPE NOMBRE AS(
    Primer_Nombre VARCHAR,
    Apellido1 VARCHAR,
    Apellido2 VARCHAR
);

CREATE SCHEMA PROYECTO1;

--Creación de las Tablas para StraviaTec
CREATE TABLE IF NOT EXISTS PROYECTO1.PATROCINADOR(
    ID_Patrocinador SERIAL NOT NULL,
    Nombre VARCHAR NOT NULL,
    Representante VARCHAR NOT NULL,
    NumRepresentante INT NOT NULL,
    Logo VARCHAR NULL,
    PRIMARY KEY(ID_Patrocinador)
);

CREATE TABLE IF NOT EXISTS PROYECTO1.ORGANIZADOR(
    ID_Organizador SERIAL NOT NULL,
    Usuario VARCHAR NOT NULL,
    Nombre NOMBRE NOT NULL ,
    FecNac DATE NOT NULL,
    Nacionaldad VARCHAR NULL,
    Foto VARCHAR NULL,
    Clave VARCHAR NOT NULL,
    PRIMARY KEY(ID_Organizador),
    UNIQUE (Usuario)
);

CREATE TABLE IF NOT EXISTS PROYECTO1.DEPORTISTA(
    ID_Deportista SERIAL NOT NULL,
    Usuario VARCHAR NOT NULL,
    Nombre NOMBRE NOT NULL,
    FecNac DATE NOT NULL,
    Nacionalidad VARCHAR NULL,
    Foto VARCHAR NULL,
    Clave VARCHAR NOT NULL,
    PRIMARY KEY (ID_Deportista),
    UNIQUE(Usuario)
);

CREATE TABLE IF NOT EXISTS PROYECTO1.ACTIVIDAD(
    ID_Actividad SERIAL NOT NULL,
    NombreActividad VARCHAR NOT NULL,
    Fecha DATE NOT NULL,
    Hora TIME NOT NULL,
    Mapa VARCHAR NULL,
    Kilometros INT NULL,
    Duracion TIME NULL,
    Completitud VARCHAR NULL,
    TipoActividad VARCHAR NOT NULL,
    ID_Deportista INT NOT NULL, --FK
    PRIMARY KEY(ID_Actividad)
);

CREATE TABLE IF NOT EXISTS PROYECTO1.CARRERA (
    ID_Carrera SERIAL NOT NULL,
    ID_Organizador INT NOT NULL, --fk
    Nombre VARCHAR NOT NULL,
    Fecha DATE NOT NULL,
    Recorrido VARCHAR NOT NULL,
    Cuenta VARCHAR NOT NULL,
    Costo INT NOT NULL,
    Privacidad BOOLEAN NOT NULL,
    Tipo_Actividad VARCHAR NOT NULL,
    PRIMARY KEY (ID_Carrera),
    UNIQUE (ID_Carrera,ID_Organizador)

);

CREATE TABLE IF NOT EXISTS PROYECTO1.CATEGORIA(
    ID_Categoria SERIAL NOT NULL,
    Nombre_Categoria VARCHAR NOT NULL,
    Descripcion VARCHAR NOT NULL,
    PRIMARY KEY (ID_Categoria)
);

CREATE TABLE IF NOT EXISTS PROYECTO1.CATEGORIA_CARRERA(
    ID_Categoria INT NOT NULL,
    ID_Carrera INT NOT NULL,
    PRIMARY KEY (ID_Carrera,ID_Categoria)
);

CREATE TABLE IF NOT EXISTS PROYECTO1.INSCRIPCION (
    ID_Inscripcion SERIAL NOT NULL,
    ID_Carrera INT NOT NULL,
    ID_Deportista INT NOT NULL,
    Comprobante VARCHAR NULL,
    Categoria VARCHAR NOT NULL,
    PRIMARY KEY(ID_Inscripcion, ID_Carrera, ID_Deportista)
);

CREATE TABLE PROYECTO1.GRUPO(
    ID_Grupo SERIAL NOT NULL,
    Nombre VARCHAR NOT NULL,
    Administrador INT NOT NULL,
    PRIMARY KEY(ID_Grupo)
);

CREATE TABLE PROYECTO1.DEPORTISTA_GRUPO(
    ID_Deportista INT NOT NULL,
    ID_Grupo INT NOT NULL,
    PRIMARY KEY (ID_Deportista,ID_Grupo)
);

CREATE TABLE IF NOT EXISTS PROYECTO1.RETO(
    ID_Reto SERIAL NOT NULL,
    Nombre VARCHAR NOT NULL,
    Periodo DATE NOT NULL,
    Privacidad BOOLEAN NOT NULL,
    Tipo_Reto VARCHAR, --Altitud o Fondo
    Tipo_Actividad VARCHAR NOT NULL,
    Patrocinio INT NULL,
    PRIMARY KEY (ID_Reto),
    ID_Organizador INT NOT NULL,
    UNIQUE (ID_Reto,ID_Organizador)
);

CREATE TABLE PROYECTO1.DEPORTISTA_RETO(
    ID_Deportista INT NOT NULL,
    ID_RETO INT NOT NULL,
    PRIMARY KEY (ID_Deportista,ID_RETO)
);

CREATE TABLE PROYECTO1.GRUPO_CARRERA(
    ID_Grupo INT NOT NULL,
    ID_Carrera INT NOT NULL,
    PRIMARY KEY (ID_Grupo,ID_Carrera)
);

CREATE TABLE PROYECTO1.GRUPO_RETO(
    ID_Grupo INT NOT NULL,
    ID_Deportista INT NOT NULL,
    PRIMARY KEY (ID_Grupo,ID_Deportista)
);
CREATE TABLE IF NOT EXISTS PROYECTO1.PATROCINADOR_CARRERA(
    ID_Patrocinador INT NOT NULL,
    ID_Carrera INT NOT NULL,
    PRIMARY KEY (ID_Carrera,ID_Patrocinador)
);

CREATE TABLE PROYECTO1.PATROCINADOR_RETO(
    ID_Patrocinador INT NOT NULL,
    ID_Reto INT NOT NULL,
    PRIMARY KEY (ID_Patrocinador,ID_Reto)
);