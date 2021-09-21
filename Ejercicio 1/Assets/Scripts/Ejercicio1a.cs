using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio1a : MonoBehaviour
{
    string MyName;
    int Numero;
    float Decimal;
    bool Alive;

    // Start is called before the first frame update
    void Start()
    {
        MyName = "Oscar";
        Debug.Log(MyName);

        Numero = 50;
        Debug.Log(Numero);

        Decimal = 40.50f;
        Debug.Log(Decimal);

        Alive = true;
        Debug.Log(Alive);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
