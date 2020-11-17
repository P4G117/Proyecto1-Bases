--##################################################################################################
--#######################                   PATROCINADOR               #############################
--##################################################################################################
--Inserción de Datos Tabla Patrocinador
INSERT INTO proyecto1.patrocinador(Nombre, Representante, Numrepresentante, Logo)
VALUES ('Google','Roberto River',50689856231,'URL: Logo Google');
INSERT INTO proyecto1.patrocinador(Nombre, Representante, Numrepresentante, Logo)
VALUES ('Amazon','Ana Mora',50675623102,'URL: Logo Amazon');
INSERT INTO proyecto1.patrocinador(Nombre, Representante, Numrepresentante, Logo)
VALUES ('Dos Pinos','Ricardo Cartin',50685963215,'URL: Logo Dos Pinos');
INSERT INTO proyecto1.patrocinador(Nombre, Representante, Numrepresentante, Logo)
VALUES ('HP','María Alvarado',50670150084,'URL: Logo HP');
INSERT INTO proyecto1.patrocinador(Nombre, Representante, Numrepresentante, Logo)
VALUES ('Toyota','Cristian Bolaños',50560235489,'URL: Logo Toyota');
INSERT INTO proyecto1.patrocinador(Nombre, Representante, Numrepresentante, Logo)
VALUES ('Walmart','David Guzmán',50660234578,'URL: Logo Walmart');
INSERT INTO proyecto1.patrocinador(Nombre, Representante, Numrepresentante, Logo)
VALUES ('Universal','Edgar Cordero',50688889999,'URL: Logo Universal');
INSERT INTO proyecto1.patrocinador(Nombre, Representante, Numrepresentante, Logo)
VALUES ('Arenas','Gloriana Solís',50678561230,'URL: Logo Arenas');
INSERT INTO proyecto1.patrocinador(Nombre, Representante, Numrepresentante, Logo)
VALUES ('POPS','Carlos Campos',50668952451,'URL: Logo POPS');
INSERT INTO proyecto1.patrocinador(Nombre, Representante, Numrepresentante, Logo)
VALUES ('Nivea','Luis Monge',50475421053,'URL: Logo Nivea');
INSERT INTO proyecto1.patrocinador(Nombre, Representante, Numrepresentante, Logo)
VALUES ('Pilsen','Josúe Aguilar',50689000011,'URL: Logo Pilsen');
INSERT INTO proyecto1.patrocinador(Nombre, Representante, Numrepresentante, Logo)
VALUES ('Pali','Katerine Logan',50560234578,'URL: Logo Pali');
INSERT INTO proyecto1.patrocinador(Nombre, Representante, Numrepresentante, Logo)
VALUES ('Nike','Baloy Cruz',50756120314,'URL: Logo Nike');
INSERT INTO proyecto1.patrocinador(Nombre, Representante, Numrepresentante, Logo)
VALUES ('McDonald','Adriana Navarro',50365658787,'URL: Logo McDonald');
INSERT INTO proyecto1.patrocinador(Nombre, Representante, Numrepresentante, Logo)
VALUES ('Adidas','Edgardo Camaño',50677889900,'URL: Logo Adidas');

--Mostrar Datos de la Tabla Patrocinador
SELECT * FROM proyecto1.patrocinador;

--##################################################################################################
--#######################                    ORGANIZADOR               #############################
--##################################################################################################

--Inserción de Datos Tabla Organizador
INSERT INTO proyecto1.organizador(Usuario_Org, Primer_Nombre,Apellido1, Apellido2, FecNac, Nacionalidad, Foto, Clave)
VALUES ('adri85','Adriana','Hernandez','Villa','1985/02/20','Costarricense','URL Foto 1','perrito21');
INSERT INTO proyecto1.organizador(Usuario_Org, Primer_Nombre,Apellido1, Apellido2, FecNac, Nacionalidad, Foto, Clave)
VALUES ('cgr2910','Camilo','Goméz','Rodríguez','1995/10/29','Costarricense','URL Foto 2','caricaturas');
INSERT INTO proyecto1.organizador(Usuario_Org, Primer_Nombre,Apellido1, Apellido2, FecNac, Nacionalidad, Foto, Clave)
VALUES ('felocruz','Felipe','Villa','Cruz','1980/05/16','Hondureño','URL Foto 3','ciclismo4ever');
INSERT INTO proyecto1.organizador(Usuario_Org, Primer_Nombre,Apellido1, Apellido2, FecNac, Nacionalidad, Foto, Clave)
VALUES ('alvadc','Daniel','Alva','Campos','1999/04/25','Costarricense','URL Foto 4','principito14');
INSERT INTO proyecto1.organizador(Usuario_Org, Primer_Nombre,Apellido1, Apellido2, FecNac, Nacionalidad, Foto, Clave)
VALUES ('castillo16','Cesar','Castillo','Rivera','1965/01/16','Costarricense','URL Foto 5','123456');
INSERT INTO proyecto1.organizador(Usuario_Org, Primer_Nombre,Apellido1, Apellido2, FecNac, Nacionalidad, Foto, Clave)
VALUES ('flor1211','Flor','Rojas','Villegas','1970/12/11','Nicaragüense','URL Foto 6','florville12');
INSERT INTO proyecto1.organizador(Usuario_Org, Primer_Nombre,Apellido1, Apellido2, FecNac, Nacionalidad, Foto, Clave)
VALUES ('Barrera72','Tulio','Barrera','Torres','1972/03/30','Panameño','URL Foto 7','tuliotorres');
INSERT INTO proyecto1.organizador(Usuario_Org, Primer_Nombre,Apellido1, Apellido2, FecNac, Nacionalidad, Foto, Clave)
VALUES ('solano23','Angelica','Solano','Peréz','1990/11/23','Nicaragüense','URL Foto 8','avengers2020');
INSERT INTO proyecto1.organizador(Usuario_Org, Primer_Nombre,Apellido1, Apellido2, FecNac, Nacionalidad, Foto, Clave)
VALUES ('chico04','Francisco','Romero','Quesada','1989/04/14','Costarricense','URL Foto 9','anime16');
INSERT INTO proyecto1.organizador(Usuario_Org, Primer_Nombre,Apellido1, Apellido2, FecNac, Nacionalidad, Foto, Clave)
VALUES ('laujp16','Laura','Jiménez','Prado','2001/09/16','Costarricense','URL Foto 10','cariñosito16');

--Mostrar Datos de la Tabla Organizador
SELECT * FROM proyecto1.organizador;

--##################################################################################################
--#######################                    DEPORTISTA                #############################
--##################################################################################################

--Inserción de Datos Tabla Deportista
INSERT INTO proyecto1.deportista(Usuario_Dep, Primer_Nombre,Apellido1, Apellido2, FecNac, Nacionalidad, Foto, Clave)
VALUES ('guivalcas','Guillermo','Valdivia','Casapia','1985/12/03','Panameño','URL Foto','olakease');
INSERT INTO proyecto1.deportista(Usuario_Dep, Primer_Nombre,Apellido1, Apellido2, FecNac, Nacionalidad, Foto, Clave)
VALUES ('adri45s','Adriana','Hernandez','Villa','1985/02/20','Costarricense','URL Foto 1','perrito21');
INSERT INTO proyecto1.deportista(Usuario_Dep, Primer_Nombre,Apellido1, Apellido2, FecNac, Nacionalidad, Foto, Clave)
VALUES ('cgr1995','Camilo','Goméz','Rodríguez','1995/10/29','Costarricense','URL Foto 2','caricaturas');
INSERT INTO proyecto1.deportista(Usuario_Dep, Primer_Nombre,Apellido1, Apellido2, FecNac, Nacionalidad, Foto, Clave)
VALUES ('cruz16','Felipe','Villa','Cruz','1980/05/16','Hondureño','URL Foto 3','ciclismoever');
INSERT INTO proyecto1.deportista(Usuario_Dep, Primer_Nombre,Apellido1, Apellido2, FecNac, Nacionalidad, Foto, Clave)
VALUES ('milHerr','Milagros','Herrera','Carbajal','2002/03/20','Guatemalteco','URL Foto 3','1234');
INSERT INTO proyecto1.deportista(Usuario_Dep, Primer_Nombre,Apellido1, Apellido2, FecNac, Nacionalidad, Foto, Clave)
VALUES ('ElbaVL','Elba','Venegas','Lujan','1999/08/14','Costarricense','URL Foto 3','1234');
INSERT INTO proyecto1.deportista(Usuario_Dep, Primer_Nombre,Apellido1, Apellido2, FecNac, Nacionalidad, Foto, Clave)
VALUES ('MMMartin','Martin','Martinez','Maruez','2003/02/28','Costarricense','URL Foto 3','1234');
INSERT INTO proyecto1.deportista(Usuario_Dep, Primer_Nombre,Apellido1, Apellido2, FecNac, Nacionalidad, Foto, Clave)
VALUES ('josueRL','Josue','Rios','Lima','1980/09/03','Nicaraguense','URL Foto 3','1234');
INSERT INTO proyecto1.deportista(Usuario_Dep, Primer_Nombre,Apellido1, Apellido2, FecNac, Nacionalidad, Foto, Clave)
VALUES ('carlos','Carlos','Madriz','Gonzalez','1970/04/26','Costarricense','URL Foto 3','1234');
INSERT INTO proyecto1.deportista(Usuario_Dep, Primer_Nombre,Apellido1, Apellido2, FecNac, Nacionalidad, Foto, Clave)
VALUES ('vanneH95','Vanessa','Herrera','Taras','2000/11/05','Costarricense','URL Foto 3','1234');
INSERT INTO proyecto1.deportista(Usuario_Dep, Primer_Nombre,Apellido1, Apellido2, FecNac, Nacionalidad, Foto, Clave)
VALUES ('MadrizR','Rocio','Selva','Madriz','2012/03/03','Costarricense','URL Foto 3','1234');
INSERT INTO proyecto1.deportista(Usuario_Dep, Primer_Nombre,Apellido1, Apellido2, FecNac, Nacionalidad, Foto, Clave)
VALUES ('sebas2008','Sebastian','Perez','Jiménez','2008/05/28','Costarricense','URL Foto 3','1234');
INSERT INTO proyecto1.deportista(Usuario_Dep, Primer_Nombre,Apellido1, Apellido2, FecNac, Nacionalidad, Foto, Clave)
VALUES ('cLima','Carmen','Rodríguez','Lima','1997/07/07','Costarricense','URL Foto 3','1234');
INSERT INTO proyecto1.deportista(Usuario_Dep, Primer_Nombre,Apellido1, Apellido2, FecNac, Nacionalidad, Foto, Clave)
VALUES ('carlitos','Carlos','Alvarado','Quesada','1994/09/12','Hondureño','URL Foto 3','1234');
INSERT INTO proyecto1.deportista(Usuario_Dep, Primer_Nombre,Apellido1, Apellido2, FecNac, Nacionalidad, Foto, Clave)
VALUES ('terecastro','Teresa','Noguera','Castro','1970/08/05','Panameño','URL Foto 3','1234');
INSERT INTO proyecto1.deportista(Usuario_Dep, Primer_Nombre,Apellido1, Apellido2, FecNac, Nacionalidad, Foto, Clave)
VALUES ('julimasis','Juliana','Muñoz','Masis','2005/04/29','Costarricense','URL Foto 3','1234');
INSERT INTO proyecto1.deportista(Usuario_Dep, Primer_Nombre,Apellido1, Apellido2, FecNac, Nacionalidad, Foto, Clave)
VALUES ('rodribon','Rodrigo','Bone','Valle','1963/12/12','Costarricense','URL Foto 3','1234');
INSERT INTO proyecto1.deportista(Usuario_Dep, Primer_Nombre,Apellido1, Apellido2, FecNac, Nacionalidad, Foto, Clave)
VALUES ('larisa','Larisa','Barrantes','Lima','1980/09/03','Nicaraguense','URL Foto 3','1234');
INSERT INTO proyecto1.deportista(Usuario_Dep, Primer_Nombre,Apellido1, Apellido2, FecNac, Nacionalidad, Foto, Clave)
VALUES ('ferrerC','Jorge','Ferrer','Cervantes','1985/06/30','Costarricense','URL Foto 3','1234');
INSERT INTO proyecto1.deportista(Usuario_Dep, Primer_Nombre,Apellido1, Apellido2, FecNac, Nacionalidad, Foto, Clave)
VALUES ('luRapa','Lucia','Ramirez','Palma','2003/09/03','Nicaraguense','URL Foto 3','1234');

SELECT * FROM proyecto1.deportista;

--##################################################################################################
--#######################                    ACTIVIDAD                 #############################
--##################################################################################################

--Inserción de Datos Tabla Actividad
INSERT INTO proyecto1.actividad(NombreActividad, Fecha, Hora, Mapa, Kilometros, Duracion, Completitud, Tipo_Actividad, ID_Deportista)
VALUES ('Aguas peligrosas','2021/05/31','06:00:00','Mapa6',17,'01:51:02','Reto','Nadar','adri45s');
INSERT INTO proyecto1.actividad(NombreActividad, Fecha, Hora, Mapa, Kilometros, Duracion, Completitud, Tipo_Actividad, ID_Deportista)
VALUES ('Reventazon','2020/12/18','08:00:00','Mapa7',16,'03:25:43','Personal','Kayak','carlitos');
INSERT INTO proyecto1.actividad(NombreActividad, Fecha, Hora, Mapa, Kilometros, Duracion, Completitud, Tipo_Actividad, ID_Deportista)
VALUES ('Senderos de mi pueblo','2021/06/07','05:15:00','',20,'04:28:51','Reto','Senderismo','terecastro');
INSERT INTO proyecto1.actividad(NombreActividad, Fecha, Hora, Mapa, Kilometros, Duracion, Completitud, Tipo_Actividad, ID_Deportista)
VALUES ('Clasica Palmarin','2021/01/27','08:00:00','Mapa 2',15,'01:24:35','Carrera','Ciclismo','vanneH95');
INSERT INTO proyecto1.actividad(NombreActividad, Fecha, Hora, Mapa, Kilometros, Duracion, Completitud, Tipo_Actividad, ID_Deportista)
VALUES ('Clasica Palmarin','2021/01/27','08:00:00','Mapa 2',15,'01:40:00','Carrera','Ciclismo','MMMartin');
INSERT INTO proyecto1.actividad(NombreActividad, Fecha, Hora, Mapa, Kilometros, Duracion, Completitud, Tipo_Actividad, ID_Deportista)
VALUES ('Clasica Palmarin','2021/01/27','08:00:00','Mapa 2',15,'01:10:15','Carrera','Ciclismo','luRapa');
INSERT INTO proyecto1.actividad(NombreActividad, Fecha, Hora, Mapa, Kilometros, Duracion, Completitud, Tipo_Actividad, ID_Deportista)
VALUES ('Clasica Palmarin','2021/01/27','08:00:00','Mapa 2',15,'01:50:15','Carrera','Ciclismo','MadrizR');
INSERT INTO proyecto1.actividad(NombreActividad, Fecha, Hora, Mapa, Kilometros, Duracion, Completitud, Tipo_Actividad, ID_Deportista)
VALUES ('Clasica Palmarin','2021/01/27','08:00:00','Mapa 2',15,'01:05:15','Carrera','Ciclismo','cgr1995');
INSERT INTO proyecto1.actividad(NombreActividad, Fecha, Hora, Mapa, Kilometros, Duracion, Completitud, Tipo_Actividad, ID_Deportista)
VALUES ('Clasica Palmarin','2021/01/27','08:00:00','Mapa 2',15,'02:10:35','Carrera','Ciclismo','carlos');
INSERT INTO proyecto1.actividad(NombreActividad, Fecha, Hora, Mapa, Kilometros, Duracion, Completitud, Tipo_Actividad, ID_Deportista)
VALUES ('Caminata Matutina','2020/11/02','05:00:00','Mapa1',15,'01:45:10','Personal','Caminata','luRapa');
INSERT INTO proyecto1.actividad(NombreActividad, Fecha, Hora, Mapa, Kilometros, Duracion, Completitud, Tipo_Actividad, ID_Deportista)
VALUES ('Ruta Guapiles','2020/11/21','06:00:00','Mapa2',25,'02:05:35','Personal','Ciclismo','rodribon');
INSERT INTO proyecto1.actividad(NombreActividad, Fecha, Hora, Mapa, Kilometros, Duracion, Completitud, Tipo_Actividad, ID_Deportista)
VALUES ('Catarata Escondida','2020/12/01','05:00:00','Mapa3',35,'05:25:40','Personal','Caminata','terecastro');
INSERT INTO proyecto1.actividad(NombreActividad, Fecha, Hora, Mapa, Kilometros, Duracion, Completitud, Tipo_Actividad, ID_Deportista)
VALUES ('Mar Abierto','2020/12/06','05:30:00','Mapa4',10,'01:35:12','Personal','Nadar','vanneH95');
INSERT INTO proyecto1.actividad(NombreActividad, Fecha, Hora, Mapa, Kilometros, Duracion, Completitud, Tipo_Actividad, ID_Deportista)
VALUES ('San Silvestre','2020/12/31','06:00:00','Mapa 1',10,'00:45:31','Carrera','','MMMartin');
INSERT INTO proyecto1.actividad(NombreActividad, Fecha, Hora, Mapa, Kilometros, Duracion, Completitud, Tipo_Actividad, ID_Deportista)
VALUES ('Corre caminos','2020/12/23','18:15:00','Mapa5',5,'00:35:15','Reto','Correr','sebas2008');

--Mostrar lo Datos de la Tabla Actividad
SELECT * FROM proyecto1.actividad;

--##################################################################################################
--#######################                    CARRERA                   #############################
--##################################################################################################

--Inserción de Datos Tabla Carrera
INSERT INTO proyecto1.carrera(ID_Carrera, ID_Organizador, Nombre, Fecha, Recorrido, Cuenta, Costo, Privacidad, Tipo_Actividad)
VALUES (DEFAULT,'adri85','San Silvestre','2020/12/31','Mapa 1',231245567889,15000,TRUE,'Correr');
INSERT INTO proyecto1.carrera(ID_Carrera, ID_Organizador, Nombre, Fecha, Recorrido, Cuenta, Costo, Privacidad, Tipo_Actividad)
VALUES (DEFAULT,'flor1211','Clasica Palmarin','2021/01/27','Mapa 2',1234567890,10000,TRUE,'Ciclismo');
INSERT INTO proyecto1.carrera(ID_Carrera, ID_Organizador, Nombre, Fecha, Recorrido, Cuenta, Costo, Privacidad, Tipo_Actividad)
VALUES (DEFAULT,'castillo16','Aventura Reventazon','2020/10/25','Mapa 3',1472583690,25000,FALSE,'Kayak');
INSERT INTO proyecto1.carrera(ID_Carrera, ID_Organizador, Nombre, Fecha, Recorrido, Cuenta, Costo, Privacidad, Tipo_Actividad)
VALUES (DEFAULT,'laujp16','Ascenso Chirripo','2020/02/14','Mapa 4',201523189841,20000,FALSE,'Caminata');
INSERT INTO proyecto1.carrera(ID_Carrera, ID_Organizador, Nombre, Fecha, Recorrido, Cuenta, Costo, Privacidad, Tipo_Actividad)
VALUES (DEFAULT,'chico04','Cerro Pelado','2021/01/02','Mapa 5',150023456950,35000,TRUE,'Caminata');

--Mostrar Datos de la Tabla Carrera
SELECT * FROM proyecto1.carrera;

--##################################################################################################
--#######################                    CATEGORIA                 #############################
--##################################################################################################

--Insercion Datos en Tabla Categoria
INSERT INTO proyecto1.categoria (nombre_categoria, descripcion)
VALUES ('Junior','menos de 15 años');
INSERT INTO proyecto1.categoria (nombre_categoria, descripcion)
VALUES ('Sub-23','de 15 a 23 años');
INSERT INTO proyecto1.categoria (nombre_categoria, descripcion)
VALUES ('Open','de 24 a 30 años');
INSERT INTO proyecto1.categoria (nombre_categoria, descripcion)
VALUES ('Elite','cualquiera puede inscribirse');
INSERT INTO proyecto1.categoria (nombre_categoria, descripcion)
VALUES ('Master A','de 30 a 40 años');
INSERT INTO proyecto1.categoria (nombre_categoria, descripcion)
VALUES ('Master B','de 41 a 50');
INSERT INTO proyecto1.categoria (nombre_categoria, descripcion)
VALUES ('Master C','más de 51 años');

--Mostrar Datos de la Tabla Categoria
SELECT * FROM proyecto1.categoria;

--##################################################################################################
--#######################              CATEGORIA_CARRERA               #############################
--##################################################################################################
INSERT INTO proyecto1.categoria_carrera(ID_CATEGORIA, ID_CARRERA) VALUES (1,1);
INSERT INTO proyecto1.categoria_carrera(ID_CATEGORIA, ID_CARRERA) VALUES (2,1);
INSERT INTO proyecto1.categoria_carrera(ID_CATEGORIA, ID_CARRERA) VALUES (3,1);
INSERT INTO proyecto1.categoria_carrera(ID_CATEGORIA, ID_CARRERA) VALUES (4,1);
INSERT INTO proyecto1.categoria_carrera(ID_CATEGORIA, ID_CARRERA) VALUES (5,1);
INSERT INTO proyecto1.categoria_carrera(ID_CATEGORIA, ID_CARRERA) VALUES (6,1);
INSERT INTO proyecto1.categoria_carrera(ID_CATEGORIA, ID_CARRERA) VALUES (7,1);
INSERT INTO proyecto1.categoria_carrera(ID_CATEGORIA, ID_CARRERA) VALUES (1,2);
INSERT INTO proyecto1.categoria_carrera(ID_CATEGORIA, ID_CARRERA) VALUES (2,2);
INSERT INTO proyecto1.categoria_carrera(ID_CATEGORIA, ID_CARRERA) VALUES (3,2);
INSERT INTO proyecto1.categoria_carrera(ID_CATEGORIA, ID_CARRERA) VALUES (4,2);
INSERT INTO proyecto1.categoria_carrera(ID_CATEGORIA, ID_CARRERA) VALUES (5,2);
INSERT INTO proyecto1.categoria_carrera(ID_CATEGORIA, ID_CARRERA) VALUES (6,2);
INSERT INTO proyecto1.categoria_carrera(ID_CATEGORIA, ID_CARRERA) VALUES (2,3);
INSERT INTO proyecto1.categoria_carrera(ID_CATEGORIA, ID_CARRERA) VALUES (3,3);
INSERT INTO proyecto1.categoria_carrera(ID_CATEGORIA, ID_CARRERA) VALUES (4,3);
INSERT INTO proyecto1.categoria_carrera(ID_CATEGORIA, ID_CARRERA) VALUES (3,4);
INSERT INTO proyecto1.categoria_carrera(ID_CATEGORIA, ID_CARRERA) VALUES (4,4);
INSERT INTO proyecto1.categoria_carrera(ID_CATEGORIA, ID_CARRERA) VALUES (5,4);
INSERT INTO proyecto1.categoria_carrera(ID_CATEGORIA, ID_CARRERA) VALUES (2,5);
INSERT INTO proyecto1.categoria_carrera(ID_CATEGORIA, ID_CARRERA) VALUES (3,5);
INSERT INTO proyecto1.categoria_carrera(ID_CATEGORIA, ID_CARRERA) VALUES (4,5);
INSERT INTO proyecto1.categoria_carrera(ID_CATEGORIA, ID_CARRERA) VALUES (5,5);
INSERT INTO proyecto1.categoria_carrera(ID_CATEGORIA, ID_CARRERA) VALUES (6,5);
INSERT INTO proyecto1.categoria_carrera(ID_CATEGORIA, ID_CARRERA) VALUES (7,5);

--Mostrar Datos de la Tabla Categoria-Carrera
SELECT * FROM proyecto1.categoria_carrera;

--##################################################################################################
--#######################                INSCRIPCION                   #############################
--##################################################################################################
INSERT INTO proyecto1.inscripcion(ID_CARRERA, USUARIO_DEP, COMPROBANTE, CATEGORIA) VALUES (1,'cruz16','URL','Master B');
INSERT INTO proyecto1.inscripcion(ID_CARRERA, USUARIO_DEP, COMPROBANTE, CATEGORIA) VALUES (1,'MMMartin','URL','Sub-23');
INSERT INTO proyecto1.inscripcion(ID_CARRERA, USUARIO_DEP, COMPROBANTE, CATEGORIA) VALUES (1,'ElbaVL','URL','Sub-23');
INSERT INTO proyecto1.inscripcion(ID_CARRERA, USUARIO_DEP, COMPROBANTE, CATEGORIA) VALUES (1,'terecastro','URL','Master B');
INSERT INTO proyecto1.inscripcion(ID_CARRERA, USUARIO_DEP, COMPROBANTE, CATEGORIA) VALUES (2,'MadrizR','URL','Junior');
INSERT INTO proyecto1.inscripcion(ID_CARRERA, USUARIO_DEP, COMPROBANTE, CATEGORIA) VALUES (2,'cgr1995','URL','Open');
INSERT INTO proyecto1.inscripcion(ID_CARRERA, USUARIO_DEP, COMPROBANTE, CATEGORIA) VALUES (2,'carlos','URL','Elite');
INSERT INTO proyecto1.inscripcion(ID_CARRERA, USUARIO_DEP, COMPROBANTE, CATEGORIA) VALUES (2,'vanneH95','URL','Elite');
INSERT INTO proyecto1.inscripcion(ID_CARRERA, USUARIO_DEP, COMPROBANTE, CATEGORIA) VALUES (2,'MMMartin','URL','Elite');
INSERT INTO proyecto1.inscripcion(ID_CARRERA, USUARIO_DEP, COMPROBANTE, CATEGORIA) VALUES (2,'luRapa','URL','Elite');
INSERT INTO proyecto1.inscripcion(ID_CARRERA, USUARIO_DEP, COMPROBANTE, CATEGORIA) VALUES (3,'cLima','URL','Elite');
INSERT INTO proyecto1.inscripcion(ID_CARRERA, USUARIO_DEP, COMPROBANTE, CATEGORIA) VALUES (3,'carlitos','URL','Elite');
INSERT INTO proyecto1.inscripcion(ID_CARRERA, USUARIO_DEP, COMPROBANTE, CATEGORIA) VALUES (3,'julimasis','URL','Elite');
INSERT INTO proyecto1.inscripcion(ID_CARRERA, USUARIO_DEP, COMPROBANTE, CATEGORIA) VALUES (3,'sebas2008','URL','Elite');
INSERT INTO proyecto1.inscripcion(ID_CARRERA, USUARIO_DEP, COMPROBANTE, CATEGORIA) VALUES (4,'carlitos','URL','Open');
INSERT INTO proyecto1.inscripcion(ID_CARRERA, USUARIO_DEP, COMPROBANTE, CATEGORIA) VALUES (4,'cgr1995','URL','Open');
INSERT INTO proyecto1.inscripcion(ID_CARRERA, USUARIO_DEP, COMPROBANTE, CATEGORIA) VALUES (4,'vanneH95','URL','Sub-23');
INSERT INTO proyecto1.inscripcion(ID_CARRERA, USUARIO_DEP, COMPROBANTE, CATEGORIA) VALUES (4,'ElbaVL','URL','Sub-23');
INSERT INTO proyecto1.inscripcion(ID_CARRERA, USUARIO_DEP, COMPROBANTE, CATEGORIA) VALUES (5,'josueRL','URL','Master A');
INSERT INTO proyecto1.inscripcion(ID_CARRERA, USUARIO_DEP, COMPROBANTE, CATEGORIA) VALUES (5,'terecastro','URL','Elite');
INSERT INTO proyecto1.inscripcion(ID_CARRERA, USUARIO_DEP, COMPROBANTE, CATEGORIA) VALUES (5,'cLima','URL','Sub-23');
INSERT INTO proyecto1.inscripcion(ID_CARRERA, USUARIO_DEP, COMPROBANTE, CATEGORIA) VALUES (5,'MMMartin','URL','Sub-23');

--Mostrar Datos de la Tabla Inscripcion
SELECT * FROM proyecto1.inscripcion;

--##################################################################################################
--#######################                    GRUPO                     #############################
--##################################################################################################

--Inserción de Datos Tabla Grupo
INSERT INTO proyecto1.grupo(ID_GRUPO, NOMBRE, ADMINISTRADOR) VALUES (DEFAULT,'Sapos Tristes','alvadc');
INSERT INTO proyecto1.grupo(ID_GRUPO, NOMBRE, ADMINISTRADOR) VALUES (DEFAULT,'Guerreros del Asfalto','adri85');
INSERT INTO proyecto1.grupo(ID_GRUPO, NOMBRE, ADMINISTRADOR) VALUES (DEFAULT,'Amiguis','cgr2910');
INSERT INTO proyecto1.grupo(ID_GRUPO, NOMBRE, ADMINISTRADOR) VALUES (DEFAULT,'Los Jinetes','felocruz');
INSERT INTO proyecto1.grupo(ID_GRUPO, NOMBRE, ADMINISTRADOR) VALUES (DEFAULT,'Tiburones del Golfito','flor1211');
INSERT INTO proyecto1.grupo(ID_GRUPO, NOMBRE, ADMINISTRADOR) VALUES (DEFAULT,'SuperCampeones','solano23');
INSERT INTO proyecto1.grupo(ID_GRUPO, NOMBRE, ADMINISTRADOR) VALUES (DEFAULT,'Los Avengers','chico04');
INSERT INTO proyecto1.grupo(ID_GRUPO, NOMBRE, ADMINISTRADOR) VALUES (DEFAULT,'Ciclismo Alternativo','castillo16');
INSERT INTO proyecto1.grupo(ID_GRUPO, NOMBRE, ADMINISTRADOR) VALUES (DEFAULT,'Vueltos Klover','alvadc');
INSERT INTO proyecto1.grupo(ID_GRUPO, NOMBRE, ADMINISTRADOR) VALUES (DEFAULT,'Aventureros','adri85');

--Mostrar Datos de la Tabla Grupo
SELECT * FROM proyecto1.grupo;

--##################################################################################################
--##################                    DEPORTISTA_GRUPO                ############################
--##################################################################################################

--Insercion de Datos en la Tabla Deportista-Grupo
INSERT INTO proyecto1.deportista_grupo(usuario_dep, id_grupo) VALUES ('rodribon',1);
INSERT INTO proyecto1.deportista_grupo(usuario_dep, id_grupo) VALUES ('carlitos',1);
INSERT INTO proyecto1.deportista_grupo(usuario_dep, id_grupo) VALUES ('cruz16',1);
INSERT INTO proyecto1.deportista_grupo(usuario_dep, id_grupo) VALUES ('luRapa',1);
INSERT INTO proyecto1.deportista_grupo(usuario_dep, id_grupo) VALUES ('MadrizR',1);
INSERT INTO proyecto1.deportista_grupo(usuario_dep, id_grupo) VALUES ('terecastro',1);
INSERT INTO proyecto1.deportista_grupo(usuario_dep, id_grupo) VALUES ('sebas2008',1);
INSERT INTO proyecto1.deportista_grupo(usuario_dep, id_grupo) VALUES ('larisa',2);
INSERT INTO proyecto1.deportista_grupo(usuario_dep, id_grupo) VALUES ('josueRL',2);
INSERT INTO proyecto1.deportista_grupo(usuario_dep, id_grupo) VALUES ('ferrerC',2);
INSERT INTO proyecto1.deportista_grupo(usuario_dep, id_grupo) VALUES ('ElbaVL',2);
INSERT INTO proyecto1.deportista_grupo(usuario_dep, id_grupo) VALUES ('adri45s',2);
INSERT INTO proyecto1.deportista_grupo(usuario_dep, id_grupo) VALUES ('rodribon',2);
INSERT INTO proyecto1.deportista_grupo(usuario_dep, id_grupo) VALUES ('julimasis',2);
INSERT INTO proyecto1.deportista_grupo(usuario_dep, id_grupo) VALUES ('luRapa',2);
INSERT INTO proyecto1.deportista_grupo(usuario_dep, id_grupo) VALUES ('guivalcas',3);
INSERT INTO proyecto1.deportista_grupo(usuario_dep, id_grupo) VALUES ('vanneH95',3);
INSERT INTO proyecto1.deportista_grupo(usuario_dep, id_grupo) VALUES ('sebas2008',3);
INSERT INTO proyecto1.deportista_grupo(usuario_dep, id_grupo) VALUES ('carlos',3);
INSERT INTO proyecto1.deportista_grupo(usuario_dep, id_grupo) VALUES ('terecastro',3);
INSERT INTO proyecto1.deportista_grupo(usuario_dep, id_grupo) VALUES ('larisa',3);
INSERT INTO proyecto1.deportista_grupo(usuario_dep, id_grupo) VALUES ('ferrerC',3);
INSERT INTO proyecto1.deportista_grupo(usuario_dep, id_grupo) VALUES ('cgr1995',3);
INSERT INTO proyecto1.deportista_grupo(usuario_dep, id_grupo) VALUES ('cgr1995',4);
INSERT INTO proyecto1.deportista_grupo(usuario_dep, id_grupo) VALUES ('milHerr',4);
INSERT INTO proyecto1.deportista_grupo(usuario_dep, id_grupo) VALUES ('cruz16',4);
INSERT INTO proyecto1.deportista_grupo(usuario_dep, id_grupo) VALUES ('guivalcas',4);
INSERT INTO proyecto1.deportista_grupo(usuario_dep, id_grupo) VALUES ('julimasis',4);
INSERT INTO proyecto1.deportista_grupo(usuario_dep, id_grupo) VALUES ('luRapa',4);
INSERT INTO proyecto1.deportista_grupo(usuario_dep, id_grupo) VALUES ('luRapa',5);
INSERT INTO proyecto1.deportista_grupo(usuario_dep, id_grupo) VALUES ('ferrerC',5);
INSERT INTO proyecto1.deportista_grupo(usuario_dep, id_grupo) VALUES ('carlitos',5);
INSERT INTO proyecto1.deportista_grupo(usuario_dep, id_grupo) VALUES ('vanneH95',5);
INSERT INTO proyecto1.deportista_grupo(usuario_dep, id_grupo) VALUES ('cLima',5);
INSERT INTO proyecto1.deportista_grupo(usuario_dep, id_grupo) VALUES ('carlos',5);
INSERT INTO proyecto1.deportista_grupo(usuario_dep, id_grupo) VALUES ('cruz16',5);
INSERT INTO proyecto1.deportista_grupo(usuario_dep, id_grupo) VALUES ('MadrizR',6);
INSERT INTO proyecto1.deportista_grupo(usuario_dep, id_grupo) VALUES ('sebas2008',6);
INSERT INTO proyecto1.deportista_grupo(usuario_dep, id_grupo) VALUES ('milHerr',6);
INSERT INTO proyecto1.deportista_grupo(usuario_dep, id_grupo) VALUES ('terecastro',6);
INSERT INTO proyecto1.deportista_grupo(usuario_dep, id_grupo) VALUES ('rodribon',6);
INSERT INTO proyecto1.deportista_grupo(usuario_dep, id_grupo) VALUES ('larisa',6);
INSERT INTO proyecto1.deportista_grupo(usuario_dep, id_grupo) VALUES ('josueRL',7);
INSERT INTO proyecto1.deportista_grupo(usuario_dep, id_grupo) VALUES ('cLima',7);
INSERT INTO proyecto1.deportista_grupo(usuario_dep, id_grupo) VALUES ('ferrerC',7);
INSERT INTO proyecto1.deportista_grupo(usuario_dep, id_grupo) VALUES ('carlos',7);
INSERT INTO proyecto1.deportista_grupo(usuario_dep, id_grupo) VALUES ('ElbaVL',7);
INSERT INTO proyecto1.deportista_grupo(usuario_dep, id_grupo) VALUES ('rodribon',7);
INSERT INTO proyecto1.deportista_grupo(usuario_dep, id_grupo) VALUES ('luRapa',7);
INSERT INTO proyecto1.deportista_grupo(usuario_dep, id_grupo) VALUES ('guivalcas',7);
INSERT INTO proyecto1.deportista_grupo(usuario_dep, id_grupo) VALUES ('rodribon',8);
INSERT INTO proyecto1.deportista_grupo(usuario_dep, id_grupo) VALUES ('guivalcas',8);
INSERT INTO proyecto1.deportista_grupo(usuario_dep, id_grupo) VALUES ('larisa',8);
INSERT INTO proyecto1.deportista_grupo(usuario_dep, id_grupo) VALUES ('carlitos',8);
INSERT INTO proyecto1.deportista_grupo(usuario_dep, id_grupo) VALUES ('ferrerC',8);
INSERT INTO proyecto1.deportista_grupo(usuario_dep, id_grupo) VALUES ('adri45s',8);
INSERT INTO proyecto1.deportista_grupo(usuario_dep, id_grupo) VALUES ('ElbaVL',8);
INSERT INTO proyecto1.deportista_grupo(usuario_dep, id_grupo) VALUES ('MadrizR',9);
INSERT INTO proyecto1.deportista_grupo(usuario_dep, id_grupo) VALUES ('julimasis',9);
INSERT INTO proyecto1.deportista_grupo(usuario_dep, id_grupo) VALUES ('cgr1995',9);
INSERT INTO proyecto1.deportista_grupo(usuario_dep, id_grupo) VALUES ('terecastro',9);
INSERT INTO proyecto1.deportista_grupo(usuario_dep, id_grupo) VALUES ('luRapa',9);
INSERT INTO proyecto1.deportista_grupo(usuario_dep, id_grupo) VALUES ('cLima',9);
INSERT INTO proyecto1.deportista_grupo(usuario_dep, id_grupo) VALUES ('rodribon',9);
INSERT INTO proyecto1.deportista_grupo(usuario_dep, id_grupo) VALUES ('vanneH95',10);
INSERT INTO proyecto1.deportista_grupo(usuario_dep, id_grupo) VALUES ('guivalcas',10);
INSERT INTO proyecto1.deportista_grupo(usuario_dep, id_grupo) VALUES ('cgr1995',10);
INSERT INTO proyecto1.deportista_grupo(usuario_dep, id_grupo) VALUES ('MMMartin',10);
INSERT INTO proyecto1.deportista_grupo(usuario_dep, id_grupo) VALUES ('carlos',10);

--Mostrar Datos de la Tabla Deportista-Grupo
SELECT * FROM proyecto1.deportista_grupo;
--##################################################################################################
--#######################                    RETO                      #############################
--##################################################################################################

--Inserción de Datos Tabla Reto
INSERT INTO proyecto1.reto(Nombre, Periodo, Privacidad, Tipo_Reto, Tipo_Actividad, ID_Organizador)
VALUES ('Corre caminos','2020/12/23',FALSE,'Altitud','Correr','castillo16');
INSERT INTO proyecto1.reto(Nombre, Periodo, Privacidad, Tipo_Reto, Tipo_Actividad, ID_Organizador)
VALUES ('Subibaja','2021/05/23',TRUE,'Fondo','Correr','chico04');
INSERT INTO proyecto1.reto(Nombre, Periodo, Privacidad, Tipo_Reto, Tipo_Actividad, ID_Organizador)
VALUES ('Vuelta al mundo','2020/11/30',FALSE,'Fondo','Kayak','flor1211');
INSERT INTO proyecto1.reto(Nombre, Periodo, Privacidad, Tipo_Reto, Tipo_Actividad, ID_Organizador)
VALUES ('Kayakey','2020/11/30',TRUE,'Altitud','Kayak','adri85');
INSERT INTO proyecto1.reto(Nombre, Periodo, Privacidad, Tipo_Reto, Tipo_Actividad, ID_Organizador)
VALUES ('Caminado por un sueño','2021/02/25',FALSE,'Altitud','Senderismo','cgr2910');
INSERT INTO proyecto1.reto(Nombre, Periodo, Privacidad, Tipo_Reto, Tipo_Actividad, ID_Organizador)
VALUES ('Senderos de mi pueblo','2021/06/07',TRUE,'Fondo','Senderismo','felocruz');
INSERT INTO proyecto1.reto(Nombre, Periodo, Privacidad, Tipo_Reto, Tipo_Actividad, ID_Organizador)
VALUES ('Biking tour','2021/01/01',FALSE,'Fondo','Ciclismo','flor1211');
INSERT INTO proyecto1.reto(Nombre, Periodo, Privacidad, Tipo_Reto, Tipo_Actividad, ID_Organizador)
VALUES ('Andando sobre ruedas','2021/03/01',TRUE,'Altitud','Ciclismo','adri85');
INSERT INTO proyecto1.reto(Nombre, Periodo, Privacidad, Tipo_Reto, Tipo_Actividad, ID_Organizador)
VALUES ('Aguas peligrosas','2021/05/31',TRUE,'Altitud','Nadar','solano23');
INSERT INTO proyecto1.reto(Nombre, Periodo, Privacidad, Tipo_Reto, Tipo_Actividad, ID_Organizador)
VALUES ('Pies caminantes','2021/08/04',FALSE,'Altitud','Caminata','cgr2910');
INSERT INTO proyecto1.reto(Nombre, Periodo, Privacidad, Tipo_Reto, Tipo_Actividad, ID_Organizador)
VALUES ('Caminando por la paz','2020/12/28',TRUE,'Fondo','Caminata','felocruz');
INSERT INTO proyecto1.reto(Nombre, Periodo, Privacidad, Tipo_Reto, Tipo_Actividad, ID_Organizador)
VALUES ('Pies caminantes','2020/12/31',TRUE,'Altitud','Caminata','solano23');

--Mostrar Datos de la Tabla Reto
SELECT * FROM proyecto1.reto;

--##################################################################################################
--##################                   DEPORTISTA_RETO                      ########################
--##################################################################################################

--Insercion de Datos de la Tabla Deportista-Reto
INSERT INTO proyecto1.deportista_reto(usuario_dep, id_reto) VALUES ('adri45s',1);
INSERT INTO proyecto1.deportista_reto(usuario_dep, id_reto) VALUES ('cruz16',1);
INSERT INTO proyecto1.deportista_reto(usuario_dep, id_reto) VALUES ('josueRL',1);
INSERT INTO proyecto1.deportista_reto(usuario_dep, id_reto) VALUES ('carlitos',1);
INSERT INTO proyecto1.deportista_reto(usuario_dep, id_reto) VALUES ('julimasis',1);
INSERT INTO proyecto1.deportista_reto(usuario_dep, id_reto) VALUES ('josueRL',2);
INSERT INTO proyecto1.deportista_reto(usuario_dep, id_reto) VALUES ('vanneH95',2);
INSERT INTO proyecto1.deportista_reto(usuario_dep, id_reto) VALUES ('carlos',2);
INSERT INTO proyecto1.deportista_reto(usuario_dep, id_reto) VALUES ('MMMartin',2);
INSERT INTO proyecto1.deportista_reto(usuario_dep, id_reto) VALUES ('cLima',2);
INSERT INTO proyecto1.deportista_reto(usuario_dep, id_reto) VALUES ('josueRL',3);
INSERT INTO proyecto1.deportista_reto(usuario_dep, id_reto) VALUES ('larisa',3);
INSERT INTO proyecto1.deportista_reto(usuario_dep, id_reto) VALUES ('rodribon',3);
INSERT INTO proyecto1.deportista_reto(usuario_dep, id_reto) VALUES ('ferrerC',4);
INSERT INTO proyecto1.deportista_reto(usuario_dep, id_reto) VALUES ('luRapa',4);
INSERT INTO proyecto1.deportista_reto(usuario_dep, id_reto) VALUES ('sebas2008',4);
INSERT INTO proyecto1.deportista_reto(usuario_dep, id_reto) VALUES ('cgr1995',4);
INSERT INTO proyecto1.deportista_reto(usuario_dep, id_reto) VALUES ('cruz16',4);
INSERT INTO proyecto1.deportista_reto(usuario_dep, id_reto) VALUES ('cLima',5);
INSERT INTO proyecto1.deportista_reto(usuario_dep, id_reto) VALUES ('julimasis',5);
INSERT INTO proyecto1.deportista_reto(usuario_dep, id_reto) VALUES ('luRapa',5);
INSERT INTO proyecto1.deportista_reto(usuario_dep, id_reto) VALUES ('sebas2008',5);
INSERT INTO proyecto1.deportista_reto(usuario_dep, id_reto) VALUES ('ElbaVL',5);
INSERT INTO proyecto1.deportista_reto(usuario_dep, id_reto) VALUES ('guivalcas',6);
INSERT INTO proyecto1.deportista_reto(usuario_dep, id_reto) VALUES ('milHerr',6);
INSERT INTO proyecto1.deportista_reto(usuario_dep, id_reto) VALUES ('cgr1995',6);
INSERT INTO proyecto1.deportista_reto(usuario_dep, id_reto) VALUES ('MadrizR',6);
INSERT INTO proyecto1.deportista_reto(usuario_dep, id_reto) VALUES ('terecastro',6);
INSERT INTO proyecto1.deportista_reto(usuario_dep, id_reto) VALUES ('terecastro',7);
INSERT INTO proyecto1.deportista_reto(usuario_dep, id_reto) VALUES ('sebas2008',7);
INSERT INTO proyecto1.deportista_reto(usuario_dep, id_reto) VALUES ('ElbaVL',7);
INSERT INTO proyecto1.deportista_reto(usuario_dep, id_reto) VALUES ('carlos',7);
INSERT INTO proyecto1.deportista_reto(usuario_dep, id_reto) VALUES ('carlitos',7);
INSERT INTO proyecto1.deportista_reto(usuario_dep, id_reto) VALUES ('milHerr',8);
INSERT INTO proyecto1.deportista_reto(usuario_dep, id_reto) VALUES ('terecastro',8);
INSERT INTO proyecto1.deportista_reto(usuario_dep, id_reto) VALUES ('adri45s',8);
INSERT INTO proyecto1.deportista_reto(usuario_dep, id_reto) VALUES ('MMMartin',8);
INSERT INTO proyecto1.deportista_reto(usuario_dep, id_reto) VALUES ('cruz16',8);
INSERT INTO proyecto1.deportista_reto(usuario_dep, id_reto) VALUES ('vanneH95',9);
INSERT INTO proyecto1.deportista_reto(usuario_dep, id_reto) VALUES ('rodribon',9);
INSERT INTO proyecto1.deportista_reto(usuario_dep, id_reto) VALUES ('ferrerC',9);
INSERT INTO proyecto1.deportista_reto(usuario_dep, id_reto) VALUES ('milHerr',9);
INSERT INTO proyecto1.deportista_reto(usuario_dep, id_reto) VALUES ('adri45s',10);
INSERT INTO proyecto1.deportista_reto(usuario_dep, id_reto) VALUES ('cgr1995',10);
INSERT INTO proyecto1.deportista_reto(usuario_dep, id_reto) VALUES ('josueRL',10);
INSERT INTO proyecto1.deportista_reto(usuario_dep, id_reto) VALUES ('terecastro',10);
INSERT INTO proyecto1.deportista_reto(usuario_dep, id_reto) VALUES ('cLima',10);
INSERT INTO proyecto1.deportista_reto(usuario_dep, id_reto) VALUES ('larisa',10);
INSERT INTO proyecto1.deportista_reto(usuario_dep, id_reto) VALUES ('julimasis',11);
INSERT INTO proyecto1.deportista_reto(usuario_dep, id_reto) VALUES ('ferrerC',11);
INSERT INTO proyecto1.deportista_reto(usuario_dep, id_reto) VALUES ('luRapa',11);
INSERT INTO proyecto1.deportista_reto(usuario_dep, id_reto) VALUES ('terecastro',11);
INSERT INTO proyecto1.deportista_reto(usuario_dep, id_reto) VALUES ('josueRL',12);
INSERT INTO proyecto1.deportista_reto(usuario_dep, id_reto) VALUES ('guivalcas',12);
INSERT INTO proyecto1.deportista_reto(usuario_dep, id_reto) VALUES ('terecastro',12);
INSERT INTO proyecto1.deportista_reto(usuario_dep, id_reto) VALUES ('ferrerC',12);
INSERT INTO proyecto1.deportista_reto(usuario_dep, id_reto) VALUES ('luRapa',12);
INSERT INTO proyecto1.deportista_reto(usuario_dep, id_reto) VALUES ('sebas2008',12);

--Mostrar Datos de la Tabla Deportista-Reto
SELECT * FROM proyecto1.deportista_reto;
--##################################################################################################
--#######################                GRUPO_CARRERA                  ############################
--##################################################################################################

--Inserción de Datos Tabla Grupo_Carrera
--Carrera Privadas, solo Algunos Grupos Pueden Verla => Privacidad = TRUE
INSERT INTO proyecto1.grupo_carrera(ID_GRUPO, ID_CARRERA) VALUES (1,1);
INSERT INTO proyecto1.grupo_carrera(ID_GRUPO, ID_CARRERA) VALUES (2,1);
INSERT INTO proyecto1.grupo_carrera(ID_GRUPO, ID_CARRERA) VALUES (3,1);
INSERT INTO proyecto1.grupo_carrera(ID_GRUPO, ID_CARRERA) VALUES (4,2);
INSERT INTO proyecto1.grupo_carrera(ID_GRUPO, ID_CARRERA) VALUES (5,2);
INSERT INTO proyecto1.grupo_carrera(ID_GRUPO, ID_CARRERA) VALUES (6,2);
INSERT INTO proyecto1.grupo_carrera(ID_GRUPO, ID_CARRERA) VALUES (7,5);
INSERT INTO proyecto1.grupo_carrera(ID_GRUPO, ID_CARRERA) VALUES (8,5);
INSERT INTO proyecto1.grupo_carrera(ID_GRUPO, ID_CARRERA) VALUES (9,5);
INSERT INTO proyecto1.grupo_carrera(ID_GRUPO, ID_CARRERA) VALUES (10,5);

--Mostrar Datos de la Tabla Grupo_Carrera
SELECT * FROM proyecto1.grupo_carrera;

--##################################################################################################
--####################                    GRUPO_RETO                      ##########################
--##################################################################################################
--Insercion de Datos Tabla Grupo_Reto
INSERT INTO proyecto1.grupo_reto(id_grupo, id_reto) VALUES (7,2);
INSERT INTO proyecto1.grupo_reto(id_grupo, id_reto) VALUES (8,2);
INSERT INTO proyecto1.grupo_reto(id_grupo, id_reto) VALUES (9,2);
INSERT INTO proyecto1.grupo_reto(id_grupo, id_reto) VALUES (10,2);

INSERT INTO proyecto1.grupo_reto(id_grupo, id_reto) VALUES (1,4);
INSERT INTO proyecto1.grupo_reto(id_grupo, id_reto) VALUES (3,4);
INSERT INTO proyecto1.grupo_reto(id_grupo, id_reto) VALUES (5,4);
INSERT INTO proyecto1.grupo_reto(id_grupo, id_reto) VALUES (6,4);
INSERT INTO proyecto1.grupo_reto(id_grupo, id_reto) VALUES (7,4);
INSERT INTO proyecto1.grupo_reto(id_grupo, id_reto) VALUES (8,4);

INSERT INTO proyecto1.grupo_reto(id_grupo, id_reto) VALUES (1,6);
INSERT INTO proyecto1.grupo_reto(id_grupo, id_reto) VALUES (3,6);
INSERT INTO proyecto1.grupo_reto(id_grupo, id_reto) VALUES (4,6);
INSERT INTO proyecto1.grupo_reto(id_grupo, id_reto) VALUES (5,6);
INSERT INTO proyecto1.grupo_reto(id_grupo, id_reto) VALUES (10,6);

INSERT INTO proyecto1.grupo_reto(id_grupo, id_reto) VALUES (1,8);
INSERT INTO proyecto1.grupo_reto(id_grupo, id_reto) VALUES (3,8);
INSERT INTO proyecto1.grupo_reto(id_grupo, id_reto) VALUES (7,8);
INSERT INTO proyecto1.grupo_reto(id_grupo, id_reto) VALUES (9,8);

INSERT INTO proyecto1.grupo_reto(id_grupo, id_reto) VALUES (3,9);
INSERT INTO proyecto1.grupo_reto(id_grupo, id_reto) VALUES (4,9);
INSERT INTO proyecto1.grupo_reto(id_grupo, id_reto) VALUES (7,9);
INSERT INTO proyecto1.grupo_reto(id_grupo, id_reto) VALUES (8,9);
INSERT INTO proyecto1.grupo_reto(id_grupo, id_reto) VALUES (10,9);

INSERT INTO proyecto1.grupo_reto(id_grupo, id_reto) VALUES (2,11);
INSERT INTO proyecto1.grupo_reto(id_grupo, id_reto) VALUES (3,11);
INSERT INTO proyecto1.grupo_reto(id_grupo, id_reto) VALUES (6,11);
INSERT INTO proyecto1.grupo_reto(id_grupo, id_reto) VALUES (8,11);
INSERT INTO proyecto1.grupo_reto(id_grupo, id_reto) VALUES (9,11);

INSERT INTO proyecto1.grupo_reto(id_grupo, id_reto) VALUES (4,12);
INSERT INTO proyecto1.grupo_reto(id_grupo, id_reto) VALUES (5,12);
INSERT INTO proyecto1.grupo_reto(id_grupo, id_reto) VALUES (8,12);
INSERT INTO proyecto1.grupo_reto(id_grupo, id_reto) VALUES (9,12);

--Mostrar Datos de la Tabla Grupo-Reto
SELECT * FROM proyecto1.grupo_reto;

--##################################################################################################
--#################                   PATROCINADOR_CARRERA                      ####################
--##################################################################################################

--Inserción de Datos Tabla Patrocinador_Carrera
INSERT INTO proyecto1.patrocinador_carrera(ID_PATROCINADOR, ID_CARRERA) VALUES (1,3);
INSERT INTO proyecto1.patrocinador_carrera(ID_PATROCINADOR, ID_CARRERA) VALUES (12,3);
INSERT INTO proyecto1.patrocinador_carrera(ID_PATROCINADOR, ID_CARRERA) VALUES (11,3);
INSERT INTO proyecto1.patrocinador_carrera(ID_PATROCINADOR, ID_CARRERA) VALUES (4,2);
INSERT INTO proyecto1.patrocinador_carrera(ID_PATROCINADOR, ID_CARRERA) VALUES (2,2);
INSERT INTO proyecto1.patrocinador_carrera(ID_PATROCINADOR, ID_CARRERA) VALUES (9,2);
INSERT INTO proyecto1.patrocinador_carrera(ID_PATROCINADOR, ID_CARRERA) VALUES (10,1);
INSERT INTO proyecto1.patrocinador_carrera(ID_PATROCINADOR, ID_CARRERA) VALUES (11,1);
INSERT INTO proyecto1.patrocinador_carrera(ID_PATROCINADOR, ID_CARRERA) VALUES (7,1);
INSERT INTO proyecto1.patrocinador_carrera(ID_PATROCINADOR, ID_CARRERA) VALUES (6,5);
INSERT INTO proyecto1.patrocinador_carrera(ID_PATROCINADOR, ID_CARRERA) VALUES (1,5);
INSERT INTO proyecto1.patrocinador_carrera(ID_PATROCINADOR, ID_CARRERA) VALUES (2,4);
INSERT INTO proyecto1.patrocinador_carrera(ID_PATROCINADOR, ID_CARRERA) VALUES (10,4);

--Mostrar Datos de la Tabla Patrocinador_Carrera
SELECT * FROM proyecto1.patrocinador_carrera;

--##################################################################################################
--#################                   PATROCINADOR_RETO                         ####################
--##################################################################################################

--Inserción de Datos Tabla Patrocinador_Reto
INSERT INTO proyecto1.patrocinador_reto(id_patrocinador, id_reto) VALUES (12,1);
INSERT INTO proyecto1.patrocinador_reto(id_patrocinador, id_reto) VALUES (4,1);
INSERT INTO proyecto1.patrocinador_reto(id_patrocinador, id_reto) VALUES (8,1);
INSERT INTO proyecto1.patrocinador_reto(id_patrocinador, id_reto) VALUES (15,2);
INSERT INTO proyecto1.patrocinador_reto(id_patrocinador, id_reto) VALUES (1,2);
INSERT INTO proyecto1.patrocinador_reto(id_patrocinador, id_reto) VALUES (9,2);
INSERT INTO proyecto1.patrocinador_reto(id_patrocinador, id_reto) VALUES (14,3);
INSERT INTO proyecto1.patrocinador_reto(id_patrocinador, id_reto) VALUES (7,3);
INSERT INTO proyecto1.patrocinador_reto(id_patrocinador, id_reto) VALUES (6,3);
INSERT INTO proyecto1.patrocinador_reto(id_patrocinador, id_reto) VALUES (11,4);
INSERT INTO proyecto1.patrocinador_reto(id_patrocinador, id_reto) VALUES (13,4);
INSERT INTO proyecto1.patrocinador_reto(id_patrocinador, id_reto) VALUES (4,4);
INSERT INTO proyecto1.patrocinador_reto(id_patrocinador, id_reto) VALUES (2,5);
INSERT INTO proyecto1.patrocinador_reto(id_patrocinador, id_reto) VALUES (3,5);
INSERT INTO proyecto1.patrocinador_reto(id_patrocinador, id_reto) VALUES (5,5);
INSERT INTO proyecto1.patrocinador_reto(id_patrocinador, id_reto) VALUES (12,6);
INSERT INTO proyecto1.patrocinador_reto(id_patrocinador, id_reto) VALUES (14,6);
INSERT INTO proyecto1.patrocinador_reto(id_patrocinador, id_reto) VALUES (1,6);
INSERT INTO proyecto1.patrocinador_reto(id_patrocinador, id_reto) VALUES (13,7);
INSERT INTO proyecto1.patrocinador_reto(id_patrocinador, id_reto) VALUES (15,7);
INSERT INTO proyecto1.patrocinador_reto(id_patrocinador, id_reto) VALUES (1,8);
INSERT INTO proyecto1.patrocinador_reto(id_patrocinador, id_reto) VALUES (9,8);
INSERT INTO proyecto1.patrocinador_reto(id_patrocinador, id_reto) VALUES (10,9);
INSERT INTO proyecto1.patrocinador_reto(id_patrocinador, id_reto) VALUES (5,9);
INSERT INTO proyecto1.patrocinador_reto(id_patrocinador, id_reto) VALUES (1,10);
INSERT INTO proyecto1.patrocinador_reto(id_patrocinador, id_reto) VALUES (10,10);
INSERT INTO proyecto1.patrocinador_reto(id_patrocinador, id_reto) VALUES (15,11);
INSERT INTO proyecto1.patrocinador_reto(id_patrocinador, id_reto) VALUES (14,11);
INSERT INTO proyecto1.patrocinador_reto(id_patrocinador, id_reto) VALUES (6,12);
INSERT INTO proyecto1.patrocinador_reto(id_patrocinador, id_reto) VALUES (9,12);

--Mostrar Datos de la Tabla Patrocinador_Reto
SELECT * FROM proyecto1.patrocinador_reto;

--##################################################################################################
--#################                   AMIGO                         ####################
--##################################################################################################

--Inserción de Datos Tabla Amigo
INSERT INTO proyecto1.amigo(DEPORTISTA, AMIGO) VALUES ('adri45s','josueRL');
INSERT INTO proyecto1.amigo(DEPORTISTA, AMIGO) VALUES ('adri45s','terecastro');
INSERT INTO proyecto1.amigo(DEPORTISTA, AMIGO) VALUES ('adri45s','vanneH95');
INSERT INTO proyecto1.amigo(DEPORTISTA, AMIGO) VALUES ('adri45s','carlos');
INSERT INTO proyecto1.amigo(DEPORTISTA, AMIGO) VALUES ('adri45s','sebas2008');
INSERT INTO proyecto1.amigo(DEPORTISTA, AMIGO) VALUES ('adri45s','ElbaVL');
INSERT INTO proyecto1.amigo(DEPORTISTA, AMIGO) VALUES ('ElbaVL','cruz16');
INSERT INTO proyecto1.amigo(DEPORTISTA, AMIGO) VALUES ('ElbaVL','guivalcas');
INSERT INTO proyecto1.amigo(DEPORTISTA, AMIGO) VALUES ('MMMartin','vanneH95');
INSERT INTO proyecto1.amigo(DEPORTISTA, AMIGO) VALUES ('MadrizR','sebas2008');
INSERT INTO proyecto1.amigo(DEPORTISTA, AMIGO) VALUES ('MadrizR','cgr1995');