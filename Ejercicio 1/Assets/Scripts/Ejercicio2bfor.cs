using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2bfor : MonoBehaviour
{

    int numero = 0;

    // Start is called before the first frame update
    void Start()
    {
        for (numero = 0; numero < 10; numero++)
        {
            print("El numero es: " +numero);
        }

        print("Has llegado a 10");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
