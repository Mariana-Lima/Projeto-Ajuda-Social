package com.example.ajudasocial;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;

public class soliedariedade extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_soliedariedade);
        setTitle("Solidariedade");
    }

    public void abrirong(View view){
        Intent ongs = new Intent(getApplicationContext(),  listadeongs.class);
        startActivity(ongs);
    }

}
