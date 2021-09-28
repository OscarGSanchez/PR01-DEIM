using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2a : MonoBehaviour
{
    int Numero = 0;

    // Start is called before the first frame update
    void Start()
    {
     
    }

    
    // Update is called once per frame
    void Update()
    {

        if (Numero < 10)
        {
            Numero++;
            print(Numero);
        }

        print("Has llegado a 10");

    }



}
