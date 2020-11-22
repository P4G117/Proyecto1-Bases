package com.example.straviatec

import android.content.Intent
import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.view.View
import android.widget.Button
import android.widget.EditText
import android.widget.Toast
import kotlinx.android.synthetic.main.activity_main.*
import android.content.DialogInterface
import androidx.appcompat.app.AlertDialog
import kotlinx.android.synthetic.main.activity_2.*
import kotlinx.android.synthetic.main.activity_main.username


//const val EXTRA_MESSAGE = "com.example.straviatec.MESSAGE"


class MainActivity : AppCompatActivity() {
    @Override
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.home)

    }

    //Se llama para ir a la pagina de logIn
    fun logIn(view: View){
        val intent = Intent(this, loginActivity::class.java)
        startActivity(intent)
    }
    //Para guardar los Datos en la Tabla
    fun saveData(view: View){
        val idactividad = username.text.toString()
        val nombre = password.text.toString()
        //val email = u_email.text.toString()
        val databaseHandler: DataBaseHandler= DataBaseHandler(this)
        if(idactividad.trim()!="" && nombre.trim()!=""){
            val status = databaseHandler.addEmployee(ActividadesModelClass(Integer.parseInt(idactividad),nombre))
            if(status > -1){
                Toast.makeText(applicationContext,"record save",Toast.LENGTH_LONG).show()
                username.text.clear()
                password.text.clear()

            }
        }else{
            Toast.makeText(applicationContext,"id or name or email cannot be blank",Toast.LENGTH_LONG).show()
        }

    }

    //Para ver los Datos de la Tabla
    fun viewRecord(view: View){

        val databaseHandler: DataBaseHandler= DataBaseHandler(this)

        val act: List<ActividadesModelClass> = databaseHandler.viewActividades()
        val actArrayIdActividad = Array<String>(act.size){"0"}
        val actArrayNombreActividad = Array<String>(act.size){"null"}

        var index = 0
        for(e in act){
            actArrayIdActividad[index] = e.idactividad.toString()
            actArrayNombreActividad[index] = e.nombreactividad

            index++
        }

        val ListAdapter = ActividadesAdapter(this,actArrayIdActividad,actArrayNombreActividad)
        actvName.adapter = ListAdapter
    }
    
}