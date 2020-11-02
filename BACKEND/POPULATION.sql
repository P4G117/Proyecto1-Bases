SELECT * FROM tipo_actividad;
SELECT * FROM categoria;

INSERT INTO TIPO_ACTIVIDAD (tipo_actividad)
VALUES
       ('Correr'),
       ('Nadar'),
       ('Ciclismo'),
       ('Senderismo'),
       ('Kayak'),
       ('Caminata');

INSERT INTO CATEGORIA (nombre_categoria, descripcion)
VALUES
       ('Junior','menos de 15 años'),
       ('Sub-23','de 15 a 23 años'),
       ('Open','de 24 a 30 años'),
       ('Elite','cualquiera puede inscribirse'),
       ('Master A','de 30 a 40 años'),
       ('Master B','de 41 a 50'),
       ('Master C','más de 51 años');