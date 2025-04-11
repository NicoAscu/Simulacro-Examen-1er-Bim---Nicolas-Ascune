using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heladeria : MonoBehaviour
{
    //declaracion de variables

    public string codigoHelado;
    public float cantidadDeHeladoEnGramos;

    float precioGramo = 1.25f;
    float precio;
    float promocion;

    // Start is called before the first frame update
    void Start()
    {
        //ingreso y validacion de datos
        if (cantidadDeHeladoEnGramos < 250 || cantidadDeHeladoEnGramos > 3000)
        {
            Debug.Log("cantidad de helado no valida, la cantidad permitida es entre 250g y 3kg");
        }
        else
        {
            if (codigoHelado == "CHO" || codigoHelado == "DDL")
            {
                precio = cantidadDeHeladoEnGramos * precioGramo;
                Debug.Log("El precio de tu helado es de $" + precio);

            } else if (codigoHelado == "FRU") {
                precio = cantidadDeHeladoEnGramos * precioGramo;
                promocion = precio * 0.1f;
                precio = precio - promocion;
                Debug.Log("El precio de tu helado es de $" + precio);
            }


        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
