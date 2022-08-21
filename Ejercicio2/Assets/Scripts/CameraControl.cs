using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour{
    public GameObject jugador;
    private Vector3 offset = new Vector3(0, 5, -7);
    // Start is called before the first frame update
    void Start(){
    }

    // LateUpdate se llama una vez por frame despues de Update(), mas fluido
    void LateUpdate(){
        //Sigue al jugador y tiene un offset para que no este directamente encima del vehiculo
        transform.position = jugador.transform.position + offset;
    }
}