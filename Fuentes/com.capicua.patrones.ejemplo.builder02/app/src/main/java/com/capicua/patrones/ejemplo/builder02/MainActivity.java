package com.capicua.patrones.ejemplo.builder02;

import android.app.AlertDialog;
import android.content.DialogInterface;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;

import java.util.ArrayList;

public class MainActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
    }

    public void button1_click(View v) {

        AlertDialog.Builder builder = new AlertDialog.Builder(this);

        builder
                .setTitle("Titulo del ejemplo 1")

                .setMessage("Texto del ejemplo 1, puede ser una pregunta")

                .setPositiveButton("Sí", new DialogInterface.OnClickListener() {
                    public void onClick(DialogInterface dialog, int id) {

                    }
                })

                .setNegativeButton("No", new DialogInterface.OnClickListener() {
                    public void onClick(DialogInterface dialog, int id) {

                    }
                });

        //Creo el dialogo y lo muestro
        AlertDialog dialog = builder.create();
        dialog.show();
    }


    public void button2_click(View v) {


        String[] colores = new String[]{"Rojo", "Verde", "Azul", "Naranja"};

        AlertDialog.Builder builder = new AlertDialog.Builder(this);

        builder
                .setTitle("Elija un color")

                .setItems(
                        colores,
                        new DialogInterface.OnClickListener() {
                            public void onClick(DialogInterface dialog, int which) {
                                // The 'which' argument contains the index position
                                // of the selected item
                            }
                        });

        //Creo el dialogo y lo muestro
        AlertDialog dialog = builder.create();
        dialog.show();
    }


    public void button3_click(View v) {

        String[] colores = new String[]{"Rojo", "Verde", "Azul", "Naranja"};

        final ArrayList mSelectedItems = new ArrayList();  // Where we track the selected items
        AlertDialog.Builder builder = new AlertDialog.Builder(this);


        builder.setTitle("Elija un color")

                .setTitle("Elija un color")

                .setMultiChoiceItems(
                        colores,
                        null,
                        new DialogInterface.OnMultiChoiceClickListener() {
                            @Override
                            public void onClick(DialogInterface dialog, int which, boolean isChecked) {
                                if (isChecked) {
                                    // If the user checked the item, add it to the selected items
                                    mSelectedItems.add(which);
                                } else if (mSelectedItems.contains(which)) {
                                    // Else, if the item is already in the array, remove it
                                    mSelectedItems.remove(Integer.valueOf(which));
                                }
                            }
                        })

                // Set the action buttons
                .setPositiveButton("Ok", new DialogInterface.OnClickListener() {
                    @Override
                    public void onClick(DialogInterface dialog, int id) {
                        // User clicked OK, so save the mSelectedItems results somewhere
                        // or return them to the component that opened the dialog

                    }
                })

                .setNegativeButton("Cancelar", new DialogInterface.OnClickListener() {
                    @Override
                    public void onClick(DialogInterface dialog, int id) {

                    }
                });

        //Creo el dialogo y lo muestro
        AlertDialog dialog = builder.create();
        dialog.show();
    }
}
