using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio4bc : MonoBehaviour
{
    float despx;
    float despy;
    [SerializeField] float speed;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        despx = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * despx * speed * Time.deltaTime);

        despy = Input.GetAxis("Vertical");
        transform.Translate(Vector3.up * despy * speed * Time.deltaTime);


    }
}
