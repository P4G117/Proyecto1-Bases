package com.example.straviatec

import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.widget.ArrayAdapter
import android.widget.EditText
import android.widget.Spinner
import android.widget.TextView

class Activity2 : AppCompatActivity() {

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_2)

        val username_val = intent.getStringExtra(EXTRA_MESSAGE)
        val password_val = intent.getStringExtra(EXTRA_PASSWORD)
        val spinner: Spinner = findViewById(R.id.spinner)

        val user_text = findViewById<TextView>(R.id.username).apply {
            text = username_val
        }
        val pass_text = findViewById<TextView>(R.id.password).apply {
            text = password_val
        }

        // Create an ArrayAdapter using the string array and a default spinner layout
        ArrayAdapter.createFromResource(
            this,
            R.array.planets_array,
            android.R.layout.simple_spinner_item
        ).also { adapter ->
            // Specify the layout to use when the list of choices appears
            adapter.setDropDownViewResource(android.R.layout.simple_spinner_dropdown_item)
            // Apply the adapter to the spinner
            spinner.adapter = adapter
        }
    }
}