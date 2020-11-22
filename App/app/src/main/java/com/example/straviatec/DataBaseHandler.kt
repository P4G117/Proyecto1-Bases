package com.example.straviatec

import android.content.Context
import android.database.sqlite.SQLiteDatabase
import android.database.sqlite.SQLiteOpenHelper
import android.content.ContentValues
import android.database.Cursor
import android.database.sqlite.SQLiteException

class DataBaseHandler(context: Context): SQLiteOpenHelper(context,DATABASE_NAME,null,DATABASE_VERSION) {
    //Valores para la Elaboracion de la Tabla/Base
    companion object {
        private val DATABASE_VERSION = 1
        private val DATABASE_NAME = "StraviaTec"
        private val TABLE_ACTIVIDADES = "Actividades"
        private val KEY_IDActividad = "idactividad"
        private val KEY_NombreActividad = "nombreactividad"
        /*private val KEY_Fecha = "fecha"
        private val KEY_Hora = "hora"
        private val KEY_Mapa = "mapa"
        private val KEY_Kilometros = "kilometros"
        private val KEY_Duracion = "duracion"
        private val KEY_Completitud = "completitud"
        private val KEY_TipoActividad = "tipoactividad"
        private val KEY_IDDeportista = "iddeportista"*/
    }

    override fun onCreate(db: SQLiteDatabase?) {

        val CREATE_ACTIVIDAD_TABLE = ("CREATE TABLE " + TABLE_ACTIVIDADES + "("
                + KEY_IDActividad + " INTEGER PRIMARY KEY," + KEY_NombreActividad + " TEXT,"
                + ")")
        /*
        val CREATE_CONTACTS_TABLE = ("CREATE TABLE " + TABLE_ACTIVIDADES + "("
                + KEY_IDActividad + " INTEGER PRIMARY KEY," + KEY_NombreActividad + " TEXT,"
                + KEY_Fecha + "TEXT," + KEY_Hora + "TEXT," + KEY_Mapa + "TEXT," + KEY_Kilometros + "INTEGER,"
                + KEY_Duracion + "TEXT," + KEY_Completitud + "TEXT," + KEY_TipoActividad + "TEXT," + KEY_IDDeportista + "TEXT" + ")")
        */
        db?.execSQL(CREATE_ACTIVIDAD_TABLE)
    }

    override fun onUpgrade(db: SQLiteDatabase?, oldVersion: Int, newVersion: Int) {

        db!!.execSQL("DROP TABLE IF EXISTS " + TABLE_ACTIVIDADES)
        onCreate(db)
    }

    //Metodo para Insertar en la Tabla
    fun addEmployee(act: ActividadesModelClass):Long{
        val db = this.writableDatabase
        val contentValues = ContentValues()
        contentValues.put(KEY_IDActividad, act.idactividad)
        contentValues.put(KEY_NombreActividad, act.nombreactividad)
        /*contentValues.put(KEY_Fecha,act.fecha )
        contentValues.put(KEY_Hora,act.hora )
        contentValues.put(KEY_Mapa,act.mapa )
        contentValues.put(KEY_Kilometros,act.kilometros )
        contentValues.put(KEY_Duracion,act.duracion )
        contentValues.put(KEY_Completitud,act.completitud )
        contentValues.put(KEY_TipoActividad,act.tipoactividad )
        contentValues.put(KEY_IDDeportista,act.iddeportista )*/

        val success = db.insert(TABLE_ACTIVIDADES, null, contentValues)

        db.close()
        return success
    }

    //Leer los Datos de la Tabla
    fun viewActividades():List<ActividadesModelClass>{
        val empList:ArrayList<ActividadesModelClass> = ArrayList<ActividadesModelClass>()
        //val selectQuery = "SELECT idactividad, nombreactividad, fecha, hora ,mapa , kilometros,duracion, completitud, tipoactividad, iddeportista FROM $TABLE_ACTIVIDADES"
        val selectQuery = "SELECT idactividad, nombreactividad FROM $TABLE_ACTIVIDADES"
        val db = this.readableDatabase
        var cursor: Cursor? = null
        try{
            cursor = db.rawQuery(selectQuery, null)
        }catch (e: SQLiteException) {
            db.execSQL(selectQuery)
            return ArrayList()
        }
        var IdActividad: Int
        var NombreActividad: String
        /*var Fecha: String
        var Hora: String
        var Mapa: String
        var Kilometros: Int
        var Duracion: String
        var Completitud: String
        var TipoActividad: String
        var IdDeportista: String*/

        if (cursor.moveToFirst()) {
            do {
                IdActividad = cursor.getInt(cursor.getColumnIndex("idactividad"))
                NombreActividad = cursor.getString(cursor.getColumnIndex("nombreactividad"))
                /*Fecha = cursor.getString(cursor.getColumnIndex("fecha"))
                Hora = cursor.getString(cursor.getColumnIndex("hora"))
                Mapa = cursor.getString(cursor.getColumnIndex("mapa"))
                Kilometros = cursor.getInt(cursor.getColumnIndex("kilometros"))
                Duracion = cursor.getString(cursor.getColumnIndex("duracion"))
                Completitud = cursor.getString(cursor.getColumnIndex("completitud"))
                TipoActividad = cursor.getString(cursor.getColumnIndex("tipoactividad"))
                IdDeportista = cursor.getString(cursor.getColumnIndex("iddeportista"))*/
                val emp= ActividadesModelClass(idactividad = IdActividad, nombreactividad = NombreActividad)
                /*
                val emp= ActividadesModelClass(idactividad = IdActividad, nombreactividad = NombreActividad, fecha = Fecha, hora = Hora,
                        mapa = Mapa, kilometros = Kilometros, duracion = Duracion, completitud = Completitud, tipoactividad = TipoActividad, iddeportista = IdDeportista)
                */

                empList.add(emp)
            } while (cursor.moveToNext())
        }
        return empList
    }

    fun updateActividades(act: ActividadesModelClass):Int{
        val db = this.writableDatabase
        val contentValues = ContentValues()
        contentValues.put(KEY_IDActividad, act.idactividad)
        contentValues.put(KEY_NombreActividad, act.nombreactividad)
        /*contentValues.put(KEY_Fecha,act.fecha )
        contentValues.put(KEY_Hora,act.hora )
        contentValues.put(KEY_Mapa,act.mapa )
        contentValues.put(KEY_Kilometros,act.kilometros )
        contentValues.put(KEY_Duracion,act.duracion )
        contentValues.put(KEY_Completitud,act.completitud )
        contentValues.put(KEY_TipoActividad,act.tipoactividad )
        contentValues.put(KEY_IDDeportista,act.iddeportista )*/


        val success = db.update(TABLE_ACTIVIDADES, contentValues,"idactividad="+act.idactividad,null)

        db.close()
        return success
    }
    fun deleteActividades(act: ActividadesModelClass):Int{
        val db = this.writableDatabase
        val contentValues = ContentValues()
        contentValues.put(KEY_IDActividad, act.idactividad)

        val success = db.delete(TABLE_ACTIVIDADES,"idactividad="+act.idactividad,null)

        db.close()
        return success
    }

}