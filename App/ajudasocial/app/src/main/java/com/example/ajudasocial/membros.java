package com.example.ajudasocial;

import androidx.appcompat.app.AppCompatActivity;

import android.os.AsyncTask;
import android.os.Bundle;
import android.view.View;
import android.view.textclassifier.ConversationActions;
import android.widget.Button;
import android.widget.EditText;
import android.widget.RadioButton;
import android.widget.RadioGroup;
import android.widget.Spinner;
import android.widget.TextView;
import android.widget.Toast;

import com.vicmikhailau.maskededittext.MaskedEditText;

import java.sql.*;

public class membros extends AppCompatActivity {
    TextView text,errorText;
    Button show;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_membros);
        text = (TextView) findViewById(R.id.textview);
        errorText = (TextView) findViewById(R.id.textview2);
        show = (Button) findViewById(R.id.button);
        setTitle("Cadastro Trabalhador");
        show.setOnClickListener(new View.OnClickListener() {

            @Override
            public void onClick(View view) {
                new Async().execute();
            }
        });
    }

    class Async extends AsyncTask<Void, Void, Void> {
        String records = "",error="";

        String nome = ((EditText)findViewById(R.id.edit_nome)).getText().toString();
        String cpf = ((EditText)findViewById(R.id.edit_cpf)).getText().toString();
        String rg = ((EditText)findViewById(R.id.edit_rg)).getText().toString();
        String nascimento = ((EditText)findViewById(R.id.edit_nascimento)).getText().toString();
        String escolaridade = ((Spinner)findViewById(R.id.edit_escolaridade)).getSelectedItem().toString();

        int selectedId = ((RadioGroup)findViewById(R.id.grupogenero)).getCheckedRadioButtonId();
        String genero = ((RadioButton) findViewById(selectedId)).getText().toString();

        int selectedId2 = ((RadioGroup)findViewById(R.id.grupopessoas)).getCheckedRadioButtonId();
        String pessoas = ((RadioButton) findViewById(selectedId2)).getText().toString();

        String email = ((EditText)findViewById(R.id.edit_email)).getText().toString();
        String telefone = ((EditText)findViewById(R.id.edit_telefone)).getText().toString();
        String celular = ((EditText)findViewById(R.id.edit_celular)).getText().toString();
        String endereco = ((EditText)findViewById(R.id.edit_endereco)).getText().toString();
        String numero = ((EditText)findViewById(R.id.edit_numero)).getText().toString();
        String complemento = ((EditText)findViewById(R.id.edit_complemento)).getText().toString();
        String cep = ((EditText)findViewById(R.id.edit_cep)).getText().toString();
        String renda = ((Spinner)findViewById(R.id.edit_renda)).getSelectedItem().toString();
        //String tipodoacao = ((Spinner)findViewById(R.id.edit_tipodoacao)).getSelectedItem().toString();
        //String entidade = ((Spinner)findViewById(R.id.edit_entidade)).getSelectedItem().toString();

        @Override
        protected Void doInBackground(Void... voids) {
            try
            {
                Class.forName("com.mysql.jdbc.Driver");
                Connection connection = DriverManager.getConnection("jdbc:mysql://192.168.15.11/ajudasocial", "andro", "andro");
                Statement statement = connection.createStatement();
                statement.executeUpdate("INSERT INTO trabalhador(nome, cpf, rg, nascimento, escolaridade, genero, email, telefone, celular, endereco, numero, complemento, cep, renda_familiar, pessoas_casa) VALUES ('" + nome + "', '" + cpf + "', '" + rg + "', '" + nascimento + "', '" + escolaridade + "', '" + genero + "', '" + email + "', '" + telefone + "', '" + celular + "', '" + endereco + "', " + numero + ", '" + complemento + "', '" + cep + "', '" + renda + "', '" + pessoas + "')");
                ResultSet resultSet = statement.executeQuery("SELECT * FROM trabalhador");


                while(resultSet.next()) {
                    records = "Usuário Cadastrado!";
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
            //text.setText(records);
            if(error != ""){
                if(error.substring(0,91).equals("com.mysql.jdbc.exceptions.jdbc4.MySQLIntegrityConstraintViolationException: Duplicate entry")){
                    Toast.makeText(getApplicationContext(), "CPF Já Cadastrado!", Toast.LENGTH_LONG).show();
                }else{
                    Toast.makeText(getApplicationContext(), "Preencha Corretamente o Formulário!", Toast.LENGTH_LONG).show();
                }
                //System.out.println(error.substring(0,91));
                //Toast.makeText(getApplicationContext(), error, Toast.LENGTH_LONG).show();
            }else{
                Toast.makeText(getApplicationContext(), "Usuário Cadastrado!", Toast.LENGTH_LONG).show();
            }
            //errorText.setText(error);
            super.onPostExecute(aVoid);
        }
    }
}