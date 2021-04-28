package com.example.ajudasocial;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.net.Uri;
import android.os.Bundle;
import android.view.View;

public class institutopaulista extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_institutopaulista);
        setTitle("Ong Instituto Paulista");
    }

    public void siteinstitutopaulista(View view){
        String url = "https://institutopaulista.webnode.com.br/";
        Intent i = new Intent(Intent.ACTION_VIEW);
        i.setData(Uri.parse(url));
        startActivity(i);
    }

    public void locateinstitutopaulista(View view){
        String url = "https://goo.gl/maps/SUCVagYffFcRk9C56";
        Intent i = new Intent(Intent.ACTION_VIEW);
        i.setData(Uri.parse(url));
        startActivity(i);
    }

    public void next(View view){
        Intent reviva = new Intent(getApplicationContext(),  reviva.class);
        startActivity(reviva);
    }

    public void previous(View view){
        Intent revivercapao = new Intent(getApplicationContext(),  revivercapao.class);
        startActivity(revivercapao);
    }
}
