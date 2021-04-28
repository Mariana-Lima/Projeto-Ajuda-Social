package com.example.ajudasocial;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.net.Uri;
import android.os.Bundle;
import android.view.View;

public class suspeita extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_suspeita);
        setTitle("Recomendação");
    }

    public void telainicial(View view){
        Intent inicial = new Intent(getApplicationContext(),  MainActivity.class);
        startActivity(inicial);
    }

    public void postosproximos(View view){
        String url = "https://www.google.com.br/maps/search/postos+de+sa%C3%BAde+pr%C3%B3ximos";
        Intent i = new Intent(Intent.ACTION_VIEW);
        i.setData(Uri.parse(url));
        startActivity(i);
    }

}
