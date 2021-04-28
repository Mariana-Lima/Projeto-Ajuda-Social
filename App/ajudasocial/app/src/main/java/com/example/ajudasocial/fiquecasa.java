package com.example.ajudasocial;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;

public class fiquecasa extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_fiquecasa);
        setTitle("Recomendação");
    }

    public void telainicial(View view){
        Intent inicial = new Intent(getApplicationContext(),  MainActivity.class);
        startActivity(inicial);
    }
}
