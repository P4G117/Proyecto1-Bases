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
        setContentView(R.layout.activity_main)
    }
    //Se llama para ir a la pagina principal
    fun inicio(view: View){
        val username = findViewById<EditText>(R.id.username)
        val password = findViewById<EditText>(R.id.password)

        val username_value = username.text.toString()
        val password_value = password.text.toString()


        val intent = Intent(this, Activity2::class.java)
        intent.putExtra(EXTRA_MESSAGE, username_value)

        startActivity(intent)

    }
}