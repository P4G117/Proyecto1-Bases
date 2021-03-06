SELECT D.primer_nombre, D.apellido1, D.apellido2, A.nombreactividad, A.tipo_actividad, A.kilometros, A.mapa
FROM proyecto1.deportista AS D, proyecto1.actividad AS A
WHERE D.usuario_dep = 'ElbaVL' AND D.usuario_dep = A.id_deportista;

SELECT amigo
FROM proyecto1.amigo
WHERE proyecto1.amigo.deportista = 'adri45s';

SELECT primer_nombre, apellido1,apellido2, foto,
       nombreactividad, tipo_actividad, kilometros, duracion
FROM
     ((proyecto1.amigo RIGHT JOIN proyecto1.deportista ON proyecto1.amigo.amigo = proyecto1.deportista.usuario_dep)
     RIGHT JOIN proyecto1.actividad ON proyecto1.amigo.amigo = proyecto1.actividad.id_deportista)
WHERE proyecto1.amigo.deportista = 'adri45s';
--###########################################################################
--###########################################################################
--###########################################################################

--###########################################################################
--##          Ver los Amigos de un Deportista y sus Actividades            ##
--###########################################################################

SELECT D.primer_nombre ||' '|| D.apellido1 ||' '|| D.apellido2 AS nombre, D.foto, A.nombreactividad, A.tipo_actividad, A.kilometros, A.duracion
FROM
     ((proyecto1.amigo AS J RIGHT JOIN proyecto1.deportista AS D ON J.amigo = D.usuario_dep)
     RIGHT JOIN proyecto1.actividad AS A ON J.amigo = A.id_deportista)
WHERE J.deportista = 'adri45s';

--###########################################################################
--##           Ver los Posibles Amigos para un Deportista                  ##
--###########################################################################
SELECT D.usuario_dep, D.primer_nombre, D.apellido1, D.apellido2
FROM proyecto1.deportista AS D
EXCEPT
SELECT D.usuario_dep, D.primer_nombre, D.apellido1, D.apellido2
FROM
     (proyecto1.amigo AS J RIGHT JOIN proyecto1.deportista AS D ON J.amigo = D.usuario_dep)
WHERE J.deportista != 'adri45s';

SELECT * FROM proyecto1.deportista;

--###########################################################################
--##          Buscar Amigo o Persona en Especifico por el Nombre           ##
--###########################################################################

SELECT D.usuario_dep, D.primer_nombre, D.apellido1, D.apellido2
FROM proyecto1.deportista AS D
WHERE D.primer_nombre LIKE 'R%'
EXCEPT
SELECT D.usuario_dep, D.primer_nombre, D.apellido1, D.apellido2
FROM
     (proyecto1.amigo AS J RIGHT JOIN proyecto1.deportista AS D ON J.amigo = D.usuario_dep)
WHERE J.deportista = 'adri45s';

SELECT * FROM proyecto1.deportista;
--###########################################################################
--##     Buscar Amigo o Persona en Especifico por el Nombre y Apellido     ##
--###########################################################################

SELECT D.usuario_dep, D.primer_nombre, D.apellido1, D.apellido2
FROM proyecto1.deportista AS D
WHERE D.primer_nombre LIKE 'R%' AND D.apellido1 LIKE 'B%'
EXCEPT
SELECT D.usuario_dep, D.primer_nombre, D.apellido1, D.apellido2
FROM
     (proyecto1.amigo AS J RIGHT JOIN proyecto1.deportista AS D ON J.amigo = D.usuario_dep)
WHERE J.deportista = 'adri45s';

--###########################################################################
--##    Buscar Amigo o Persona en Especifico por el Nombre y Apellidos     ##
--###########################################################################

SELECT D.usuario_dep, D.primer_nombre, D.apellido1, D.apellido2
FROM proyecto1.deportista AS D
WHERE D.primer_nombre LIKE 'R%' AND D.apellido1 LIKE 'B%' AND D.apellido2 LIKE 'V%'
EXCEPT
SELECT D.usuario_dep, D.primer_nombre, D.apellido1, D.apellido2
FROM
     (proyecto1.amigo AS J RIGHT JOIN proyecto1.deportista AS D ON J.amigo = D.usuario_dep)
WHERE J.deportista = 'adri45s';

--###########################################################################
--##                   Ver todos los Retos que sean Publicos               ##
--###########################################################################

SELECT id_reto, nombre,periodo,tipo_reto,tipo_actividad FROM proyecto1.reto WHERE proyecto1.reto.privacidad = FALSE;

--###########################################################################
--##                 Ver todos las Carreras que sean Publicos              ##
--###########################################################################

SELECT id_carrera, nombre, fecha, recorrido, cuenta, costo, tipo_actividad
FROM proyecto1.carrera AS C WHERE C.privacidad = FALSE;

--###########################################################################
--##            Grupos que pertenece un Deportista: Segun el grupo         ##
--##        del cual sea Parte, tira los retos las que puede participar    ##
--###########################################################################

SELECT A.nombre,W.id_reto, W.nombre, periodo, tipo_reto, tipo_actividad
FROM
     (((proyecto1.deportista_grupo AS J RIGHT JOIN proyecto1.deportista AS D ON J.usuario_dep = D.usuario_dep)
     RIGHT JOIN proyecto1.grupo AS A ON J.id_grupo = A.id_grupo)
     RIGHT JOIN proyecto1.grupo_reto AS P ON P.id_grupo = A.id_grupo)
     RIGHT JOIN proyecto1.reto AS W ON P.id_reto = W.id_reto
WHERE D.usuario_dep = 'adri45s';

--###########################################################################
--##           Grupos que pertenece un Deportista: Segun el grupo          ##
--##      del cual sea Parte, tira las carreras las que puede participar   ##
--###########################################################################

SELECT A.nombre, W.id_carrera, W.nombre, fecha, recorrido, cuenta, costo, tipo_actividad
FROM
     (((proyecto1.deportista_grupo AS J RIGHT JOIN proyecto1.deportista AS D ON J.usuario_dep = D.usuario_dep)
     RIGHT JOIN proyecto1.grupo AS A ON J.id_grupo = A.id_grupo)
     RIGHT JOIN proyecto1.grupo_carrera AS P ON P.id_grupo = A.id_grupo)
     RIGHT JOIN proyecto1.carrera AS W ON P.id_carrera = W.id_carrera
WHERE D.usuario_dep = 'adri45s';

--###########################################################################
--##             Ver los resultados de una carrera que esta Inscrito       ##
--###########################################################################

SELECT D.primer_nombre, D.apellido1, D.apellido2, A.duracion, I.categoria
FROM
     ((proyecto1.inscripcion AS I RIGHT JOIN proyecto1.deportista AS D ON I.usuario_dep = D.usuario_dep)
     RIGHT JOIN proyecto1.actividad AS A ON A.id_deportista = D.usuario_dep),
     proyecto1.carrera AS C
WHERE I.id_carrera = C.id_carrera AND C.nombre = 'Clasica Palmarin' AND A.nombreactividad = 'Clasica Palmarin'
ORDER BY A.duracion ASC;

SELECT nombre FROM proyecto1.carrera;

--###########################################################################
--##                    Reporte Participantes por Carrera                  ##
--###########################################################################

SELECT D.primer_nombre, D.apellido1, D.apellido2, date_part('year',age(D.fecnac)) AS Edad, I.categoria
FROM
    (proyecto1.inscripcion AS I RIGHT JOIN proyecto1.deportista AS D ON I.usuario_dep = D.usuario_dep),
    proyecto1.carrera AS C
WHERE I.id_carrera = C.id_carrera AND C.nombre  = 'Clasica Palmarin'
ORDER BY I.categoria;

--###########################################################################
--##                    Reporte Posiciones por Carrera                     ##
--###########################################################################

SELECT D.primer_nombre, D.apellido1, D.apellido2, date_part('year',age(D.fecnac)) AS Edad, A.duracion, I.categoria
FROM
    ((proyecto1.inscripcion AS I RIGHT JOIN proyecto1.deportista AS D ON I.usuario_dep = D.usuario_dep)
     RIGHT JOIN proyecto1.actividad AS A ON A.id_deportista = D.usuario_dep),
    proyecto1.carrera AS C
WHERE I.id_carrera = C.id_carrera AND C.nombre  = 'Clasica Palmarin' AND A.nombreactividad = 'Clasica Palmarin'
--GROUP BY D.primer_nombre, I.categoria
ORDER BY A.duracion;

--AQUI ESTAN LAS NUEVAS CONSULTAS !!!!!!!!
--###########################################################################
--##                        Followers y Following                          ##
--###########################################################################

SELECT count(amigo) AS Seguidos
FROM proyecto1.amigo AS A
WHERE A.deportista = 'adri45s';

SELECT count(deportista) AS Seguidores
FROM proyecto1.amigo AS A
WHERE A.amigo = 'adri45s';

--###########################################################################
--##           Ver el Total de Actividades de un Deportista                ##
--###########################################################################

SELECT count(nombreactividad) AS actividades
FROM proyecto1.actividad AS A
WHERE A.id_deportista = 'MMMartin';
--###########################################################################
--##                   Obtener la Edad de un Deportista                    ##
--###########################################################################
SELECT date_part('year',age(D.fecnac)) AS Edad
FROM proyecto1.deportista AS D
WHERE D.usuario_dep = 'adri45s';
--###########################################################################
--##              Grupos a los que no pertenece un Deportista              ##
--###########################################################################

SELECT A.id_grupo, A.nombre
FROM
     ((proyecto1.deportista_grupo AS J JOIN proyecto1.deportista AS D ON J.usuario_dep = D.usuario_dep)
     JOIN proyecto1.grupo AS A ON J.id_grupo = A.id_grupo)
WHERE D.usuario_dep != 'adri45s'
EXCEPT
SELECT A.id_grupo, A.nombre
FROM
     ((proyecto1.deportista_grupo AS J JOIN proyecto1.deportista AS D ON J.usuario_dep = D.usuario_dep)
     JOIN proyecto1.grupo AS A ON J.id_grupo = A.id_grupo)
WHERE D.usuario_dep = 'adri45s';

SELECT * FROM proyecto1.deportista_grupo;

--###########################################################################
--##                    Buscar un Grupo por su Nombre                      ##
--###########################################################################
SELECT A.id_grupo, A.nombre
FROM
     ((proyecto1.deportista_grupo AS J JOIN proyecto1.deportista AS D ON J.usuario_dep = D.usuario_dep)
     JOIN proyecto1.grupo AS A ON J.id_grupo = A.id_grupo)
WHERE D.usuario_dep != 'adri45s' AND A.nombre LIKE 'A%'
EXCEPT
SELECT A.id_grupo, A.nombre
FROM
     ((proyecto1.deportista_grupo AS J JOIN proyecto1.deportista AS D ON J.usuario_dep = D.usuario_dep)
     JOIN proyecto1.grupo AS A ON J.id_grupo = A.id_grupo)
WHERE D.usuario_dep = 'adri45s';

SELECT G.id_grupo, G.nombre
FROM proyecto1.grupo AS G
WHERE G.nombre LIKE 'A%';

--###########################################################################
--##       Ver las Carreras en que esta Inscrito el Deportista             ##
--###########################################################################

SELECT C.id_carrera, C.nombre
FROM
    (proyecto1.inscripcion AS I JOIN proyecto1.carrera AS C ON I.id_carrera = C.id_carrera)
WHERE I.usuario_dep = 'adri45s';

SELECT * FROM proyecto1.inscripcion;
--###########################################################################
--##          Ver los Retos en que esta Inscrito el Deportista             ##
--###########################################################################

SELECT C.id_reto, C.nombre
FROM
    (proyecto1.deportista_reto AS I JOIN proyecto1.reto AS C ON I.id_reto = C.id_reto)
WHERE I.usuario_dep = 'cgr1995';

--###########################################################################
--##             Ver Cantidad de Retos, Carreras, Grupos                   ##
--###########################################################################

SELECT count(nombre) AS Carreras
FROM proyecto1.carrera AS A
WHERE A.id_organizador = 'adri85';

SELECT count(nombre) AS Retos
FROM proyecto1.reto AS A
WHERE A.id_organizador = 'adri85';

SELECT count(nombre) AS Grupos
FROM proyecto1.grupo AS A
WHERE A.administrador = 'adri85';
--VER LAS CARRERAS, RETOS Y GRUPOS QUE HIZO UN ORGANIZADOR
SELECT A.id_carrera, A.id_organizador, A.nombre, A.fecha, A.recorrido, A.cuenta, A.costo, A.privacidad, A.tipo_actividad
FROM proyecto1.carrera AS A
WHERE A.id_organizador = 'adri85';

SELECT A.id_reto, A.nombre, A.periodo, A.privacidad, A.tipo_reto, A.tipo_actividad, A.id_organizador
FROM proyecto1.reto AS A
WHERE A.id_organizador = 'adri85';

SELECT A.id_grupo, A.nombre, A.administrador
FROM proyecto1.grupo AS A
WHERE A.administrador = 'adri85';
--###########################################################################
--##             Ver los Grupos en que esta un Deportista                  ##
--###########################################################################
SELECT G.iD_grupo, G.nombre, O.primer_nombre ||' '|| O.apellido1 AS Administrador
FROM ((proyecto1.deportista_grupo AS D JOIN proyecto1.grupo AS G ON D.id_grupo = G.id_grupo)
      JOIN proyecto1.organizador AS O ON G.administrador = O.usuario_org)
WHERE D.usuario_dep = 'sebas2008';

--###########################################################################
--##                          CRUD de Actividades                          ##
--###########################################################################
SELECT A.id_actividad, A.nombreactividad, A.fecha, A.hora,A.mapa, A.kilometros, A.duracion, A.completitud, A.tipo_actividad
FROM proyecto1.actividad AS A
WHERE A.id_deportista = 'adri45s';
--###########################################################################
--###########################################################################
--###########################################################################
SELECT * from proyecto1.deportista_grupo;

INSERT INTO proyecto1.deportista_grupo(USUARIO_DEP, ID_GRUPO) VALUES ('larisa',1);


SELECT * FROM proyecto1.deportista;
SELECT * FROM proyecto1.actividad;

SELECT A.nombre
FROM
    ((proyecto1.grupo_reto AS J RIGHT JOIN proyecto1.grupo AS D ON J.id_grupo = D.id_grupo)
    RIGHT JOIN proyecto1.reto AS A ON J.id_reto = A.id_reto)
WHERE J.id_grupo = 2 OR J.id_grupo = 8
ORDER BY J.id_grupo;

SELECT * FROM proyecto1.inscripcion, proyecto1.deportista WHERE proyecto1.inscripcion.usuario_dep = proyecto1.deportista.usuario_dep;
SELECT * FROM proyecto1.carrera AS G WHERE G.privacidad = TRUE;
SELECT * FROM proyecto1.reto AS G WHERE G.privacidad = TRUE;

SELECT * FROM proyecto1.deportista_grupo AS P WHERE P.usuario_dep = 'adri45s';


