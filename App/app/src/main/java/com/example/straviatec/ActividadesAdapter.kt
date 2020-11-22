package com.example.straviatec

import android.app.Activity
import android.view.View
import android.view.ViewGroup
import android.widget.ArrayAdapter
import android.widget.TextView

/*class ActividadesAdapter(private val context: Activity, private val idactividad: Array<String>, private val nombreactividad: Array<String>,
private val fecha: Array<String>, private val hora: Array<String>, private val mapa: Array<String>, private val kilometros: Array<String>,
private val duracion: Array<String>, private  val completitud: Array<String>, private val tipoactividad: Array<String>, private val iddeportista: Array<String>)
    : ArrayAdapter<String>(context, R.layout.activity_2,idactividad){

}*/

class ActividadesAdapter(private val context: Activity, private val idactividad: Array<String>, private val nombreactividad: Array<String>)
    : ArrayAdapter<String>(context, R.layout.activity_2,idactividad){

    override fun getView(position: Int, view: View?, parent: ViewGroup): View {
        val inflater = context.layoutInflater
        val rowView = inflater.inflate(R.layout.activity_main, null, true)

        val idText = rowView.findViewById(R.id.username) as TextView
        val nameText = rowView.findViewById(R.id.password) as TextView


        idText.text = "Id: ${idactividad[position]}"
        nameText.text = "Name: ${nombreactividad[position]}"

        return rowView
    }
}
