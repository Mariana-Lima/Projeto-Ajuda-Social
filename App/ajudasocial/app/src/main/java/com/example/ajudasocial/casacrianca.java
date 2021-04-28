package com.example.ajudasocial;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.net.Uri;
import android.os.Bundle;
import android.view.View;

public class casacrianca extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_casacrianca);
        setTitle("Casa da Criança Santo Amaro");
    }

    public void sitecasacrianca(View view){
        String url = "http://www.casadacriancasantoamaro.org.br/doacoes.php";
        Intent i = new Intent(Intent.ACTION_VIEW);
        i.setData(Uri.parse(url));
        startActivity(i);
    }

    public void locatecasacrianca(View view){
        String url = "https://maps.google.com/maps?ll=-23.656728,-46.696303&z=14&t=m&hl=pt-BR&gl=US&mapclient=embed&q=R.%20Padre%20Chico%2C%20320%20-%20Santo%20Amaro%20S%C3%A3o%20Paulo%20-%20SP%2004662-002";
        Intent i = new Intent(Intent.ACTION_VIEW);
        i.setData(Uri.parse(url));
        startActivity(i);
    }

    public void next(View view){
        Intent revivercapao = new Intent(getApplicationContext(),  revivercapao.class);
        startActivity(revivercapao);
    }
}
