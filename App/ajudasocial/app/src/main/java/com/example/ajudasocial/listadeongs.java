package com.example.ajudasocial;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.ListView;

public class listadeongs extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_listadeongs);
        setTitle("Lista de Ongs");
    }

    public void casacrianca(View view){
        Intent casacrianca = new Intent(getApplicationContext(),  casacrianca.class);
        startActivity(casacrianca);
    }

    public void revivercapao(View view){
        Intent revivercapao = new Intent(getApplicationContext(),  revivercapao.class);
        startActivity(revivercapao);
    }

    public void institutopaulista(View view){
        Intent institutopaulista = new Intent(getApplicationContext(),  institutopaulista.class);
        startActivity(institutopaulista);
    }

    public void reviva(View view){
        Intent reviva = new Intent(getApplicationContext(),  reviva.class);
        startActivity(reviva);
    }

}
