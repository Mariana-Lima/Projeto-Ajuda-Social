package com.example.ajudasocial;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.net.Uri;
import android.os.Bundle;
import android.view.View;

public class reviva extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_reviva);
        setTitle("Ong Reviva");
    }

    public void siteongreviva(View view){
        String url = "https://reviva.org.br/";
        Intent i = new Intent(Intent.ACTION_VIEW);
        i.setData(Uri.parse(url));
        startActivity(i);
    }

    public void locateongreviva(View view){
        String url = "https://goo.gl/maps/ZHka3AvvRHH1ujZ97";
        Intent i = new Intent(Intent.ACTION_VIEW);
        i.setData(Uri.parse(url));
        startActivity(i);
    }

    public void previous(View view){
        Intent institutopaulista = new Intent(getApplicationContext(),  institutopaulista.class);
        startActivity(institutopaulista);
    }
}
