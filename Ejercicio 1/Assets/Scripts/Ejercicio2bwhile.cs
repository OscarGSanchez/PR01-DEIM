using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2bwhile : MonoBehaviour
{
    int Numero = 0;

    // Start is called before the first frame update
    void Start()
    {
        while (Numero < 10)
        {
            Numero++;
            print(Numero);
            
        }

        print("Tu numero es: " + Numero);


        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
