package com.example.ajudasocial;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;

public class orientacoescovid extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_orientacoescovid);
        setTitle("Orientações Covid - 19");
    }

    public void opentestcovid(View view){
        Intent testcovid = new Intent(getApplicationContext(),  testcovid.class);
        startActivity(testcovid);
    }
}
