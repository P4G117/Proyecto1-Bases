-- Se utiliza esto debido a que el atributo Nombre es un atributo compuesto

CREATE TYPE NOMBRE AS(
    Primer_Nombre VARCHAR,
    Apellido1 VARCHAR,
    Apellido2 VARCHAR
);
--Creación de las Tablas para StraviaTec
CREATE TABLE IF NOT EXISTS PATROCINADOR(
    ID_Patrocinador SERIAL NOT NULL,
    Nombre VARCHAR NOT NULL,
    Representante VARCHAR NOT NULL,
    NumRepresentante INT NOT NULL,
    Logo VARCHAR NULL,
    PRIMARY KEY(ID_Patrocinador)
);

CREATE TABLE IF NOT EXISTS ORGANIZADOR(
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

CREATE TABLE IF NOT EXISTS DEPORTISTA(
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

CREATE TABLE IF NOT EXISTS TIPO_ACTIVIDAD(
    ID_TipoActividad SERIAL NOT NULL,
    Tipo_Actividad VARCHAR NOT NULL,
    PRIMARY KEY(ID_TipoActividad)
);

CREATE TABLE IF NOT EXISTS ACTIVIDAD(
    ID_Actividad SERIAL NOT NULL,
    Fecha DATE NOT NULL,
    HORA TIME NOT NULL,
    Mapa VARCHAR NULL,
    Kilometros INT NULL,
    Duracion TIME NULL,
    Completitud VARCHAR NULL,
    ID_TipoActividad INT NOT NULL,
    PRIMARY KEY(ID_Actividad),
    FOREIGN KEY (ID_TipoActividad) REFERENCES TIPO_ACTIVIDAD(ID_TipoActividad)
);

CREATE TABLE IF NOT EXISTS CARRERA (
    ID_Carrera SERIAL NOT NULL,
    ID_Organizador INT NOT NULL,
    Nombre VARCHAR NOT NULL,
    Fecha DATE NOT NULL,
    Recorrido VARCHAR NOT NULL,
    Cuenta VARCHAR NOT NULL,
    Costo INT NOT NULL,
    Privacidad BOOLEAN NOT NULL,
    Tipo_Actividad INT NOT NULL,
    ID_Deportista INT NOT NULL,
    PRIMARY KEY (ID_Carrera),
    UNIQUE (ID_Carrera,ID_Organizador),
    FOREIGN KEY (ID_Organizador) REFERENCES ORGANIZADOR(ID_Organizador),
    FOREIGN KEY (Tipo_Actividad) REFERENCES TIPO_ACTIVIDAD(ID_TipoActividad),
    FOREIGN KEY (ID_Deportista) REFERENCES DEPORTISTA(ID_Deportista)

);

CREATE TABLE IF NOT EXISTS PATROCINADOR_CARRERA(
    ID_Patrocinador INT NOT NULL,
    ID_Carrera INT NOT NULL,
    FOREIGN KEY (ID_Patrocinador) REFERENCES PATROCINADOR(ID_Patrocinador),
    FOREIGN KEY (ID_Carrera) REFERENCES CARRERA(ID_Carrera)
);

CREATE TABLE IF NOT EXISTS CATEGORIA(
    ID_Categoria SERIAL NOT NULL,
    Nombre_Categoria VARCHAR NOT NULL,
    Descripcion VARCHAR NOT NULL,
    PRIMARY KEY (ID_Categoria)
);

CREATE TABLE IF NOT EXISTS CATEGORIA_CARRERA(
    ID_Categoria INT NOT NULL,
    ID_Carrera INT NOT NULL,
    FOREIGN KEY (ID_Categoria) REFERENCES CATEGORIA(ID_Categoria),
    FOREIGN KEY (ID_Carrera) REFERENCES CARRERA(ID_Carrera)
);

CREATE TABLE IF NOT EXISTS INSCRIPCION (
    ID_Inscripcion SERIAL NOT NULL,
    Comprobante VARCHAR NULL,
    ID_Carrera INT NOT NULL,
    ID_Deportista INT NOT NULL,
    ID_Categoria INT NOT NULL,
    PRIMARY KEY(ID_Inscripcion),
    FOREIGN KEY (ID_Carrera) REFERENCES CARRERA(ID_Carrera),
    FOREIGN KEY (ID_Deportista) REFERENCES DEPORTISTA(ID_Deportista),
    FOREIGN KEY (ID_Categoria) REFERENCES CATEGORIA(ID_Categoria)
);

CREATE TABLE IF NOT EXISTS DEPORTISTA_ACTIVIDAD(
    ID_Deportista INT NOT NULL,
    ID_Actividad INT NOT NULL,
    FOREIGN KEY (ID_Deportista) REFERENCES DEPORTISTA(ID_Deportista),
    FOREIGN KEY (ID_Actividad) REFERENCES ACTIVIDAD(ID_Actividad)
);

CREATE TABLE GRUPO(
    ID_Grupo SERIAL NOT NULL,
    Nombre VARCHAR NOT NULL,
    Administrador INT NOT NULL,
    PRIMARY KEY(ID_Grupo),
    FOREIGN KEY (Administrador) REFERENCES Organizador(ID_Organizador)
);

CREATE TABLE DEPORTISTA_GRUPO(
    ID_Deportista INT NOT NULL,
    ID_Grupo INT NOT NULL,
    FOREIGN KEY (ID_Deportista) REFERENCES DEPORTISTA(ID_Deportista),
    FOREIGN KEY (ID_Grupo) REFERENCES GRUPO(ID_Grupo)
);

CREATE TABLE IF NOT EXISTS RETO(
    ID_Reto SERIAL NOT NULL,
    ID_Organizador INT NOT NULL,
    Nombre VARCHAR NOT NULL,
    Periodo DATE NOT NULL,
    Privacidad BOOLEAN NOT NULL,
    Tipo_Reto VARCHAR, --Altitud o Fondo
    Tipo_Actividad INT NOT NULL,
    Patrocinio INT NULL,
    PRIMARY KEY (ID_Reto),
    UNIQUE (ID_Reto,ID_Organizador),
    FOREIGN KEY (ID_Organizador) REFERENCES ORGANIZADOR(ID_Organizador),
    FOREIGN KEY (Tipo_Actividad) REFERENCES TIPO_ACTIVIDAD(ID_TipoActividad),
    FOREIGN KEY (Patrocinio) REFERENCES PATROCINADOR(ID_Patrocinador)
);

CREATE TABLE DEPORTISTA_RETO(
    ID_Deportista INT NOT NULL,
    ID_RETO INT NOT NULL,
    FOREIGN KEY (ID_Deportista) REFERENCES DEPORTISTA(ID_Deportista),
    FOREIGN KEY (ID_RETO) REFERENCES RETO(ID_Reto)
);

