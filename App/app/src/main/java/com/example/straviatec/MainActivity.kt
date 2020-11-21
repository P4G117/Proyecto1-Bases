package com.example.straviatec

import android.content.Intent
import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.view.View
import android.widget.Button
import android.widget.EditText

const val EXTRA_MESSAGE = "com.example.straviatec.MESSAGE"


class MainActivity : AppCompatActivity() {

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.home)
    }
    //Se llama para ir a la pagina de logIn
    fun logIn(view: View){
        val intent = Intent(this, loginActivity::class.java)
        startActivity(intent)
    }
}