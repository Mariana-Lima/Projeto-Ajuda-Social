package com.example.ajudasocial;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;

public class telacadastro extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_telacadastro);
        setTitle("Cadastre-se");
    }

    public void voluntario(View view){
        Intent voluntario = new Intent(getApplicationContext(),  cadastro.class);
        startActivity(voluntario);
    }

    public void trabalhador(View view){
        Intent trabalhador = new Intent(getApplicationContext(),  membros.class);
        startActivity(trabalhador);
    }


}
