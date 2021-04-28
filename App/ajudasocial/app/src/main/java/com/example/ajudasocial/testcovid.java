package com.example.ajudasocial;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.ImageView;
import android.widget.TextView;

import com.tomer.fadingtextview.FadingTextView;

public class testcovid extends AppCompatActivity {
    private FadingTextView fadingTextView;
    private int counter;
    String[] respostas = new String[7];

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_testcovid);
        setTitle("Teste Covid - 19");

        counter = 1;
        fadingTextView = findViewById(R.id.fading_text_view);
    }

    public void question2(View view){
        counter = counter + 1;
        String[] question2 = {"Sente dor de Cabeça?"};
        String[] question3 = {"Tem sentido Exaustão com Frequência?"};
        String[] question4 = {"Tem tido Congestão Nasal ou Espirros?"};
        String[] question5 = {"Tem tido crises de Tosse?"};
        String[] question6 = {"Sente dificuldade de Respirar?"};

        respostas[counter - 1] = ((Button) view).getText().toString();
        fadingTextView.setTimeout(1,FadingTextView.MINUTES);
        ImageView imagens = (ImageView)findViewById(R.id.imagens);
        ImageView imagens2 = (ImageView)findViewById(R.id.imagens2);
        switch (counter){
            case 2:
                fadingTextView.setTexts(question2);
                TextView febre = (TextView)findViewById(R.id.febre);
                febre.setText(((Button) view).getText().toString().toLowerCase());
                imagens2.setVisibility(view.INVISIBLE);
                imagens.setImageResource(R.drawable.dorcabeca);
                break;
            case 3:
                fadingTextView.setTexts(question3);
                TextView dorcabeca = (TextView)findViewById(R.id.dorcabeca);
                dorcabeca.setText(((Button) view).getText().toString().toLowerCase());
                imagens.setImageResource(R.drawable.fadiga);
                break;
            case 4:
                fadingTextView.setTexts(question4);
                TextView exaustao = (TextView)findViewById(R.id.exaustao);
                exaustao.setText(((Button) view).getText().toString().toLowerCase());
                imagens.setImageResource(R.drawable.nariz);
                break;
            case 5:
                fadingTextView.setTexts(question5);
                TextView congestao = (TextView)findViewById(R.id.congestao);
                congestao.setText(((Button) view).getText().toString().toLowerCase());
                imagens.setImageResource(R.drawable.tosse);
                break;
            case 6:
                fadingTextView.setTexts(question6);
                TextView tosse = (TextView)findViewById(R.id.tosse);
                tosse.setText(((Button) view).getText().toString().toLowerCase());
                imagens.setImageResource(R.drawable.faltadear);
                break;
            default:
                TextView faltaar = (TextView)findViewById(R.id.faltaar);
                faltaar.setText(((Button) view).getText().toString().toLowerCase());
                verify();
                break;
        }

    }

    public void verify(){
        if (respostas[6].equals("SIM")){
            System.out.println("Suspeita");
            Intent suspeitaview = new Intent(getApplicationContext(),  suspeita.class);
            startActivity(suspeitaview);
        }else if (respostas[1].equals("SIM") && respostas[2].equals("SIM") && respostas[3].equals("SIM") && respostas[4].equals("SIM") && respostas[5].equals("SIM")){
            System.out.println("Suspeita");
            Intent suspeitaview = new Intent(getApplicationContext(),  suspeita.class);
            startActivity(suspeitaview);
        }else{
            System.out.println("Fique em Casa");
            Intent fiquecasaview = new Intent(getApplicationContext(),  fiquecasa.class);
            startActivity(fiquecasaview);
        }
    }

}
