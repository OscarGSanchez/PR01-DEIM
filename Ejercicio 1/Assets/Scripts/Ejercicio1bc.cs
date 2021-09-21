using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio1bc : MonoBehaviour
{
    public string MyName = "Oscar";
    public int Numero = 70;
    public int Num1 = 10;
    public int Num2 = 20;
    public float Decimal = 70.60f;
    public bool Alive = true;
    int Sumar;


    // Start is called before the first frame update
    void Start()
    {

        Debug.Log(MyName);
        Debug.Log(Numero);
        Debug.Log(Decimal);
        Debug.Log(Alive);

        Sumar = Num1 + Num2;
        Debug.Log("El resultado es =" + Sumar);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
