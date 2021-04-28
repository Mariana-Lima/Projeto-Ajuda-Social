package com.example.ajudasocial;

import androidx.appcompat.app.AlertDialog;
import androidx.appcompat.app.AppCompatActivity;

import android.content.DialogInterface;
import android.net.Uri;
import android.os.AsyncTask;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.TextView;
import android.widget.Toast;

import java.sql.*;

public class consulta extends AppCompatActivity {

    Boolean Recusar = Boolean.FALSE;
    TextView text,errorText;
    Button show;
    Button Sim,Nao;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_consulta);

        text = (TextView) findViewById(R.id.textview);
        errorText = (TextView) findViewById(R.id.textview2);
        show = (Button) findViewById(R.id.button);
        Sim = (Button) findViewById(R.id.sim);
        Nao = (Button) findViewById(R.id.nao);

        Sim.setVisibility(View.INVISIBLE);
        Nao.setVisibility(View.INVISIBLE);

        show.setOnClickListener(new View.OnClickListener() {

            @Override
            public void onClick(View view) {
                new Async().execute();
            }
        });
    }



    class Async extends AsyncTask<Void, Void, Void> {

        String cpf = ((EditText)findViewById(R.id.edit_cpf)).getText().toString();
        String nasc = ((EditText)findViewById(R.id.edit_nasc)).getText().toString();
        String records = "",error="";

        @Override
        protected Void doInBackground(Void... voids) {
            try
            {

                Class.forName("com.mysql.jdbc.Driver");
                Connection connection = DriverManager.getConnection("jdbc:mysql://192.168.15.11:3306/ajudasocial", "andro", "andro");
                Statement statement = connection.createStatement();
                if(Recusar == Boolean.TRUE){
                    statement.executeUpdate("DELETE FROM oportunidades where cpf = '"+ cpf + "' ");
                }
                ResultSet resultSet = statement.executeQuery("SELECT * FROM oportunidades where cpf = '"+ cpf + "' ");

                while(resultSet.next()) {
                    records += "CPF: " + resultSet.getString(2) + "\n" +
                            "Tipo da Vaga: "  + resultSet.getString(3) + "\n" +
                            "Cargo: "         + resultSet.getString(4) + "\n" +
                            "Data: "          + resultSet.getString(5) + "\n" +
                            "Horario: "       + resultSet.getString(6) + "\n" +
                            "Descrição: "     + resultSet.getString(7) + "\n" +
                            "Telefone: "      + resultSet.getString(8) + "\n" +
                            "Email: "         + resultSet.getString(9) + "\n" +
                            "Modalidade: "    + resultSet.getString(10) + "\n";
                }

            }

            catch(Exception e)
            {
                error = e.toString();
            }
            return null;
        }



        @Override
        protected void onPostExecute(Void aVoid) {
            text.setText(records);
            if ( text.getText().toString() == ""){
                //Toast.makeText(getApplicationContext(), "Não Há Vagas", Toast.LENGTH_LONG).show();
                text.setText("Não Há Vagas Registradas no Seu Perfil.\n\nAguarde Uma Oportunidade !");
            }else{
                Sim.setVisibility(View.VISIBLE);
                Nao.setVisibility(View.VISIBLE);
            }
            if(error != "")
                //errorText.setText(error);
            super.onPostExecute(aVoid);
        }

    }

    public void buttonsim (View view){
        AlertDialog.Builder alert = new AlertDialog.Builder(consulta.this);
        alert.setTitle("Confirmação");
        alert.setMessage("Confirma essa Vaga? ");
        alert.setPositiveButton("SIM", new DialogInterface.OnClickListener() {
                    public void onClick(DialogInterface dialog, int which) {

                        // Write your code here to invoke YES event
                        Sim.setVisibility(View.INVISIBLE);
                        Nao.setVisibility(View.INVISIBLE);
                        text.setText("Agendado !");
                        Toast.makeText(getApplicationContext(), "Aceito! Compareça na Data e Hora Marcada!", Toast.LENGTH_LONG).show();
                    }
                });
        alert.setNegativeButton("NÃO",null);
        alert.show();
    }

    public void buttonnao (View view){
        AlertDialog.Builder alert = new AlertDialog.Builder(consulta.this);
        alert.setTitle("Recusar");
        alert.setMessage("Recusar essa Vaga? ");
        alert.setPositiveButton("SIM", new DialogInterface.OnClickListener() {
            public void onClick(DialogInterface dialog, int which) {

                // Write your code here to invoke YES event
                Recusar = Boolean.TRUE;
                show.callOnClick();
                Sim.setVisibility(View.INVISIBLE);
                Nao.setVisibility(View.INVISIBLE);
                Toast.makeText(getApplicationContext(), "Removida! Aguarde uma Nova Oportunidade !", Toast.LENGTH_LONG).show();
            }
        });
        alert.setNegativeButton("NÃO",null);
        alert.show();
    }


}