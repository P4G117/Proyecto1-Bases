import psycopg2 as pg
import csv

#Cambiarñ¿le el path para cada integrante.
file = r'C:/Users/nadie/OneDrive/Escritorio/Proyecto I Bases de Datos/Proyecto1-Bases/BACKEND/DATA/'

try:
    #Se crea la conexion a la base de datos StraviaTec
    conn = pg.connect(
            user = "postgres",
            password="maesly1234", # Aquí cada integrante coloca su propia contraseña
            host="localhost",
            port="5432",
            database="StraviaTec")
    cursor = conn.cursor()
    '''
    #Ingreso de datos a tabla patrocinador
    #Nombre del archivo de patrocinador
    patrocinador = r'Patrocinador.csv'
    archivoPatrocinador = """INSERT INTO PATROCINADOR
                VALUES(default,%s,%s,%s,%s)"""
    
    with open(file + patrocinador, 'r') as f:
        reader = csv.reader(f)
        next(reader) # Saltamos la primera linea donde traer la lista de atributos
        for record in reader:
            cursor.execute(archivoPatrocinador, record)
            conn.commit()
    
    #Ingreso de datos a tabla organizador
    #Nombre del archivo de organizador
    organizador = r'Organizador.csv'
    archivoOrganizador = """INSERT INTO ORGANIZADOR
                VALUES(default,%s, ROW(%s, %s,%s),%s,%s,%s,%s)"""
    
    with open(file + organizador, 'r') as f:
        reader = csv.reader(f)
        next(reader) # Saltamos la primera linea donde traer la lista de atributos
        for record in reader:
            cursor.execute(archivoOrganizador, record)
            conn.commit()
    
    #Ingreso de datos a tabla DEPORTISTA
    #Nombre del archivo de DEPORTISTA
    deportista = r'Deportista.csv'
    archivoDeportista = """INSERT INTO DEPORTISTA
                VALUES(default,%s, ROW(%s, %s,%s),%s,%s,%s,%s)"""
    
    with open(file + deportista, 'r') as f:
        reader = csv.reader(f)
        next(reader) # Saltamos la primera linea donde traer la lista de atributos
        for record in reader:
            cursor.execute(archivoDeportista, record)
            conn.commit()
    
    #Ingreso de datos a tabla actividad
    #Nombre del archivo de actividad
    actividad = r'Actividad.csv'
    archivoActividad = """INSERT INTO ACTIVIDAD
                VALUES(default,%s,%s,%s,%s,%s,%s,%s)"""
    
    with open(file + actividad, 'r') as f:
        reader = csv.reader(f)
        next(reader) # Saltamos la primera linea donde traer la lista de atributos
        for record in reader:
            cursor.execute(archivoActividad, record)
            conn.commit()
    
    #Ingreso de datos a tabla carrera
    #Nombre del archivo de carrera
    carrera = r'Carrera.csv'
    archivoCarrera = """INSERT INTO CARRERA
                VALUES(default,%s,%s,%s,%s,%s,%s,%s,%s,%s)"""
    
    with open(file + carrera, 'r') as f:
        reader = csv.reader(f)
        next(reader) # Saltamos la primera linea donde traer la lista de atributos
        for record in reader:
            cursor.execute(archivoCarrera, record)
            conn.commit()
    
    #Ingreso de datos a tabla PATROCINADOR_CARRERA
    #Nombre del archivo de PATROCINADOR_CARRERA
    patrocinador_carrera = r'Patrocinador_Carrera.csv'
    archivoPatroCarrera = """INSERT INTO PATROCINADOR_CARRERA
                VALUES(%s,%s)"""
    
    with open(file + patrocinador_carrera, 'r') as f:
        reader = csv.reader(f)
        next(reader) # Saltamos la primera linea donde traer la lista de atributos
        for record in reader:
            cursor.execute(archivoPatroCarrera, record)
            conn.commit()

    #Ingreso de datos a tabla CATEGORIA_CARRERA
    #Nombre del archivo de CATEGORIA_CARRERA
    categoria_carrera = r'Categoria_Carrera.csv'
    archivoCategCarrera = """INSERT INTO CATEGORIA_CARRERA
                VALUES(%s,%s)"""
    
    with open(file + categoria_carrera, 'r') as f:
        reader = csv.reader(f)
        next(reader) # Saltamos la primera linea donde traer la lista de atributos
        for record in reader:
            cursor.execute(archivoCategCarrera, record)
            conn.commit()

    #Ingreso de datos a tabla INSCRIPCION
    #Nombre del archivo de INSCRIPCION
    inscripcion = r'Inscripcion.csv'
    archivoInscripcion = """INSERT INTO INSCRIPCION
                VALUES(default,%s,%s,%s,%s)"""
    
    with open(file + inscripcion, 'r') as f:
        reader = csv.reader(f)
        next(reader) # Saltamos la primera linea donde traer la lista de atributos
        for record in reader:
            cursor.execute(archivoInscripcion, record)
            conn.commit()

    #Ingreso de datos a tabla DEPORTISTA_ACTIVIDAD
    #Nombre del archivo de DEPORTISTA_ACTIVIDAD
    deporActividad = r'Deportista_Actividad.csv'
    archivoDeporActividad = """INSERT INTO DEPORTISTA_ACTIVIDAD
                VALUES(%s,%s)"""
    
    with open(file + deporActividad, 'r') as f:
        reader = csv.reader(f)
        next(reader) # Saltamos la primera linea donde traer la lista de atributos
        for record in reader:
            cursor.execute(archivoDeporActividad, record)
            conn.commit()

    #Ingreso de datos a tabla GRUPO
    #Nombre del archivo de GRUPO
    grupo = r'Grupo.csv'
    archivoGrupo = """INSERT INTO GRUPO
                VALUES(default,%s,%s)"""
    
    with open(file + grupo, 'r') as f:
        reader = csv.reader(f)
        next(reader) # Saltamos la primera linea donde traer la lista de atributos
        for record in reader:
            cursor.execute(archivoGrupo, record)
            conn.commit()
    '''
    #Ingreso de datos a tabla DEPORTISTA_GRUPO
    #Nombre del archivo de DEPORTISTA_GRUPO
    deportgrupo = r'Deportista_Grupo.csv'
    archivoDeportGrupo = """INSERT INTO DEPORTISTA_GRUPO
                VALUES(%s,%s)"""
    
    with open(file + deportgrupo, 'r') as f:
        reader = csv.reader(f)
        next(reader) # Saltamos la primera linea donde traer la lista de atributos
        for record in reader:
            cursor.execute(archivoDeportGrupo, record)
            conn.commit()

    #Ingreso de datos a tabla RETO
    #Nombre del archivo de RETO
    reto = r'Reto.csv'
    archivoReto = """INSERT INTO RETO
                VALUES(default,%s,%s,%s,%s,%s,%s,%s)"""
    
    with open(file + reto, 'r') as f:
        reader = csv.reader(f)
        next(reader) # Saltamos la primera linea donde traer la lista de atributos
        for record in reader:
            cursor.execute(archivoReto, record)
            conn.commit()
            
    #Ingreso de datos a tabla DEPORTISTA_RETO
    #Nombre del archivo de DEPORTISTA_RETO
    deportreto = r'Deportista_Reto.csv'
    archivoDeportReto = """INSERT INTO DEPORTISTA_RETO
                VALUES(%s,%s)"""
    
    with open(file + deportreto, 'r') as f:
        reader = csv.reader(f)
        next(reader) # Saltamos la primera linea donde traer la lista de atributos
        for record in reader:
            cursor.execute(archivoDeportReto, record)
            conn.commit()
        
except (Exception, pg.Error) as e:
    print(e)

finally:
    if (conn):
        cursor.close()
        conn.close()
        print("Connection closed.")
