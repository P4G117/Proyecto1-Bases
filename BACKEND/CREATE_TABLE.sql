-- Se utiliza esto debido a que el atributo Nombre es un atributo compuesto
--CREATE SCHEMA PROYECTO1;

--CREATE TYPE PROYECTO1.NOMBRE AS(
--    Primer_Nombre VARCHAR(15),
--    Apellido1 VARCHAR(15),
--    Apellido2 VARCHAR(15)
--);
--Creación de las Tablas para StraviaTec

-- Tabla PATROCINADOR la cual es producto de un atributo multivaluado
-- de la entidad carrera
CREATE TABLE IF NOT EXISTS PROYECTO1.PATROCINADOR(
    ID_Patrocinador SERIAL NOT NULL,
    Nombre VARCHAR(15) NOT NULL,
    Representante VARCHAR(30) NOT NULL,
    NumRepresentante NUMERIC(20,0) NOT NULL,
    Logo VARCHAR NULL,
    PRIMARY KEY(ID_Patrocinador)
);

-- Tabla ORGANIZADOR una de las entidades fuertes de la solución
-- El atributo Usuario es un valor único
CREATE TABLE IF NOT EXISTS PROYECTO1.ORGANIZADOR(
    Usuario_Org VARCHAR(10) NOT NULL,
    -- Nombre PROYECTO1.NOMBRE NOT NULL ,
    Primer_Nombre VARCHAR(20) NOT NULL,
    Apellido1 VARCHAR(15) NOT NULL,
    Apellido2 VARCHAR(15),
    FecNac DATE NOT NULL,
    Nacionalidad VARCHAR(15) NULL,
    Foto VARCHAR NULL,
    Clave VARCHAR(15) NOT NULL,
    PRIMARY KEY(Usuario_Org)
);

-- Tabla DEPORTISTA una de las entidades fuertes de la solución
-- El atributo Usuario es un valor único
CREATE TABLE IF NOT EXISTS PROYECTO1.DEPORTISTA(
    Usuario_Dep VARCHAR(10) NOT NULL,
    -- Nombre PROYECTO1.NOMBRE NOT NULL,
    Primer_Nombre VARCHAR(15),
    Apellido1 VARCHAR(15),
    Apellido2 VARCHAR(15),
    FecNac DATE NOT NULL,
    Nacionalidad VARCHAR(15) NULL,
    Foto VARCHAR NULL,
    Clave VARCHAR(12) NOT NULL,
    PRIMARY KEY (Usuario_Dep)
);

-- Tabla ACTIVIDAD posee una relacion débil con DEPORTISTA
-- Los valores de el atributo Tipo_Actividad son valores
-- definidos por el problema
CREATE TABLE IF NOT EXISTS PROYECTO1.ACTIVIDAD(
    ID_Actividad SERIAL NOT NULL,
    NombreActividad VARCHAR NOT NULL,
    Fecha DATE NOT NULL,
    Hora TIME NOT NULL,
    Mapa VARCHAR NULL,
    Kilometros INT NULL,
    Duracion TIME NULL,
    Completitud VARCHAR(8) NULL,
    Tipo_Actividad VARCHAR DEFAULT ('Correr',
                                    'Nadar',
                                    'Ciclismo',
                                    'Senderistmo',
                                    'Kayak',
                                    'Caminata') NOT NULL,
    ID_Deportista VARCHAR NOT NULL,
    PRIMARY KEY(ID_Actividad)
);

-- Tabla CARRERA gestionada por la tabla ORGANIZADOR
-- Existe una combinacion única entre ID_Carrera y ID_Organizador
-- El atributo Tipo_Actividad tiene valores definidos por el problema
CREATE TABLE IF NOT EXISTS PROYECTO1.CARRERA (
    ID_Carrera SERIAL NOT NULL,
    ID_Organizador VARCHAR NOT NULL, --fk
    Nombre VARCHAR NOT NULL,
    Fecha DATE NOT NULL,
    Recorrido VARCHAR NOT NULL,
    Cuenta NUMERIC(20,0) NOT NULL,
    Costo NUMERIC(6,0) NOT NULL CHECK ( Costo >= 0 ),
    Privacidad BOOLEAN NOT NULL,
    Tipo_Actividad VARCHAR DEFAULT ('Correr',
                                    'Nadar',
                                    'Ciclismo',
                                    'Senderistmo',
                                    'Kayak',
                                    'Caminata') NOT NULL,
    PRIMARY KEY (ID_Carrera),
    UNIQUE (ID_Carrera,ID_Organizador)
);

-- Tabla CATEGORIA, deriva de un atributo multivaluado de CARRERA
CREATE TABLE IF NOT EXISTS PROYECTO1.CATEGORIA(
    ID_Categoria SERIAL NOT NULL,
    Nombre_Categoria VARCHAR(8) NOT NULL,
    Descripcion VARCHAR(30) NOT NULL,
    PRIMARY KEY (ID_Categoria)
);

-- Tabla CATEGORIA_CARRERA, relaciona la cantidad de categorias que
-- posee una carrera.
CREATE TABLE IF NOT EXISTS PROYECTO1.CATEGORIA_CARRERA(
    ID_Categoria INT NOT NULL,
    ID_Carrera INT NOT NULL,
    PRIMARY KEY (ID_Carrera,ID_Categoria)
);

-- Tabla INSCRIPCION, esta relaciona las tablas DEPORTISTA Y CARRERA
CREATE TABLE IF NOT EXISTS PROYECTO1.INSCRIPCION (
    ID_Inscripcion SERIAL NOT NULL,
    ID_Carrera INT NOT NULL,
    Usuario_Dep VARCHAR NOT NULL,
    Comprobante VARCHAR NULL,
    Categoria VARCHAR(10) NOT NULL,
    PRIMARY KEY(ID_Inscripcion, ID_Carrera, Usuario_Dep)
);

-- Tabla GRUPO
CREATE TABLE IF NOT EXISTS PROYECTO1.GRUPO(
    ID_Grupo SERIAL NOT NULL,
    Nombre VARCHAR NOT NULL,
    Administrador VARCHAR NOT NULL,
    PRIMARY KEY(ID_Grupo)
);

-- Tabla DEPORTISTA_GRUPO, relaciona los deportistas que pertenecen a un grupo
CREATE TABLE IF NOT EXISTS PROYECTO1.DEPORTISTA_GRUPO(
    Usuario_Dep VARCHAR NOT NULL,
    ID_Grupo INT NOT NULL,
    PRIMARY KEY (Usuario_Dep,ID_Grupo)
);

-- Tabla RETO, gestionada por ORGANIZADOR
-- Posee una combinación única entre ID_Reto y ID_Organizador
-- El atributo Tipo_Actividad tiene valores definidos por el problema
CREATE TABLE IF NOT EXISTS PROYECTO1.RETO(
    ID_Reto SERIAL NOT NULL,
    Nombre VARCHAR NOT NULL,
    Periodo DATE NOT NULL,
    Privacidad BOOLEAN NOT NULL,
    Tipo_Reto VARCHAR DEFAULT ('Altitud','Fondo'), --Altitud o Fondo
    Tipo_Actividad VARCHAR DEFAULT ('Correr',
                                    'Nadar',
                                    'Ciclismo',
                                    'Senderistmo',
                                    'Kayak',
                                    'Caminata') NOT NULL,
    ID_Organizador VARCHAR NOT NULL,
    PRIMARY KEY (ID_Reto),
    UNIQUE (ID_Reto,ID_Organizador)
);

CREATE TABLE IF NOT EXISTS PROYECTO1.DEPORTISTA_RETO(
    Usuario_Dep VARCHAR NOT NULL,
    ID_Reto INT NOT NULL,
    PRIMARY KEY (Usuario_Dep,ID_Reto)
);

CREATE TABLE IF NOT EXISTS PROYECTO1.GRUPO_CARRERA(
    ID_Grupo INT NOT NULL,
    ID_Carrera INT NOT NULL,
    PRIMARY KEY (ID_Grupo,ID_Carrera)
);

CREATE TABLE IF NOT EXISTS PROYECTO1.GRUPO_RETO(
    ID_Grupo INT NOT NULL,
    ID_Reto INT NOT NULL,
    PRIMARY KEY (ID_Grupo,ID_Reto)
);
CREATE TABLE IF NOT EXISTS PROYECTO1.PATROCINADOR_CARRERA(
    ID_Patrocinador INT NOT NULL,
    ID_Carrera INT NOT NULL,
    PRIMARY KEY (ID_Carrera,ID_Patrocinador)
);

CREATE TABLE IF NOT EXISTS PROYECTO1.PATROCINADOR_RETO(
    ID_Patrocinador INT NOT NULL,
    ID_Reto INT NOT NULL,
    PRIMARY KEY (ID_Patrocinador,ID_Reto)
);

CREATE TABLE IF NOT EXISTS PROYECTO1.AMIGO(
    Deportista VARCHAR,
    Amigo VARCHAR,
    PRIMARY KEY (Deportista,Amigo)
);

-- Seccion para las llaves foráneas necesarias

ALTER TABLE PROYECTO1.ACTIVIDAD
ADD FOREIGN KEY (ID_Deportista)
REFERENCES PROYECTO1.DEPORTISTA(Usuario_Dep);

ALTER TABLE PROYECTO1.CARRERA
ADD FOREIGN KEY (ID_Organizador)
REFERENCES PROYECTO1.ORGANIZADOR(Usuario_Org);

ALTER TABLE PROYECTO1.RETO
ADD FOREIGN KEY (ID_Organizador)
REFERENCES PROYECTO1.ORGANIZADOR(Usuario_Org);

ALTER TABLE PROYECTO1.GRUPO
ADD FOREIGN KEY (Administrador)
REFERENCES PROYECTO1.ORGANIZADOR(Usuario_Org);

ALTER TABLE PROYECTO1.DEPORTISTA_GRUPO
ADD FOREIGN KEY (Usuario_Dep)
REFERENCES PROYECTO1.DEPORTISTA(Usuario_Dep);

ALTER TABLE PROYECTO1.DEPORTISTA_GRUPO
ADD FOREIGN KEY (ID_Grupo)
REFERENCES PROYECTO1.GRUPO(ID_Grupo);

ALTER TABLE PROYECTO1.DEPORTISTA_RETO
ADD FOREIGN KEY (Usuario_Dep)
REFERENCES PROYECTO1.DEPORTISTA(Usuario_Dep);

ALTER TABLE PROYECTO1.DEPORTISTA_RETO
ADD FOREIGN KEY (ID_Reto)
REFERENCES PROYECTO1.RETO(ID_Reto);

ALTER TABLE PROYECTO1.GRUPO_CARRERA
ADD FOREIGN KEY (ID_Grupo)
REFERENCES PROYECTO1.GRUPO(ID_Grupo);

ALTER TABLE PROYECTO1.GRUPO_CARRERA
ADD FOREIGN KEY (ID_Carrera)
REFERENCES PROYECTO1.CARRERA(ID_Carrera);

ALTER TABLE PROYECTO1.GRUPO_RETO
ADD FOREIGN KEY (ID_Grupo)
REFERENCES PROYECTO1.GRUPO(ID_Grupo);

ALTER TABLE PROYECTO1.GRUPO_RETO
ADD FOREIGN KEY (ID_Reto)
REFERENCES PROYECTO1.RETO(ID_Reto);

ALTER TABLE PROYECTO1.PATROCINADOR_CARRERA
ADD FOREIGN KEY (ID_Patrocinador)
REFERENCES PROYECTO1.PATROCINADOR(ID_Patrocinador);

ALTER TABLE PROYECTO1.PATROCINADOR_CARRERA
ADD FOREIGN KEY (ID_Carrera)
REFERENCES PROYECTO1.CARRERA(ID_Carrera);

ALTER TABLE PROYECTO1.PATROCINADOR_RETO
ADD FOREIGN KEY (ID_Patrocinador)
REFERENCES PROYECTO1.PATROCINADOR(ID_Patrocinador);

ALTER TABLE PROYECTO1.PATROCINADOR_RETO
ADD FOREIGN KEY (ID_Reto)
REFERENCES PROYECTO1.RETO(ID_Reto);

ALTER TABLE PROYECTO1.INSCRIPCION
ADD FOREIGN KEY (ID_Carrera)
REFERENCES PROYECTO1.CARRERA(ID_Carrera);

ALTER TABLE PROYECTO1.INSCRIPCION
ADD FOREIGN KEY (Usuario_Dep)
REFERENCES PROYECTO1.DEPORTISTA(Usuario_Dep);

ALTER TABLE PROYECTO1.CATEGORIA_CARRERA
ADD FOREIGN KEY (ID_Categoria)
REFERENCES PROYECTO1.CATEGORIA(ID_Categoria);

ALTER TABLE PROYECTO1.CATEGORIA_CARRERA
ADD FOREIGN KEY (ID_Carrera)
REFERENCES PROYECTO1.CARRERA(ID_Carrera);

ALTER TABLE PROYECTO1.AMIGO
ADD FOREIGN KEY (Deportista)
REFERENCES PROYECTO1.DEPORTISTA(Usuario_Dep);

ALTER TABLE PROYECTO1.AMIGO
ADD FOREIGN KEY (Amigo)
REFERENCES PROYECTO1.DEPORTISTA(Usuario_Dep);
