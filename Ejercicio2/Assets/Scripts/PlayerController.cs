using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour{
    private float velocidad = 20.0f;
    private float velocidadDoblar = 50.0f;
    private float horInput;
    private float verInput;

    // Start is called before the first frame update
    void Start(){
    }

    // Update is called once per frame
    void Update(){
        //Le asigna a la variable el valor del input horizontal
        horInput = Input.GetAxis("Horizontal");
        //Le asigna a la variable el valor del input horizontal
        verInput = Input.GetAxis("Vertical");

        // Mueve el vehiculo para adelante teniendo en cuenta el tiempo real
        transform.Translate(Vector3.forward * Time.deltaTime * velocidad * verInput);
        // Mueve el vehiculo para los lados teniendo en cuenta el tiempo real y el input
        transform.Rotate(Vector3.up, Time.deltaTime * velocidadDoblar * horInput);
    }
}
