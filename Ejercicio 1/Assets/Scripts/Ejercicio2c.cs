using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2c : MonoBehaviour
{
    int numero;

    // Start is called before the first frame update
    void Start()
    {
        while (numero != 60)
        {
            numero = Random.Range(0, 100);
            print(numero);
        }

        print("Tu numero es: " + numero);
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
