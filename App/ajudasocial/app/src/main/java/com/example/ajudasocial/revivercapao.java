package com.example.ajudasocial;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.net.Uri;
import android.os.Bundle;
import android.view.View;

public class revivercapao extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_revivercapao);
        setTitle("Reviver Capão");
    }

    public void siterevivercapao(View view){
        String url = "https://www.facebook.com/revivercapao/";
        Intent i = new Intent(Intent.ACTION_VIEW);
        i.setData(Uri.parse(url));
        startActivity(i);
    }

    public void locaterevivercapao(View view){
        String url = "https://goo.gl/maps/idutL3DKPYTqP2My7";
        Intent i = new Intent(Intent.ACTION_VIEW);
        i.setData(Uri.parse(url));
        startActivity(i);
    }

    public void next(View view){
        Intent institutopaulista = new Intent(getApplicationContext(),  institutopaulista.class);
        startActivity(institutopaulista);
    }

    public void previous(View view){
        Intent casacrianca = new Intent(getApplicationContext(),  casacrianca.class);
        startActivity(casacrianca);
    }


}
