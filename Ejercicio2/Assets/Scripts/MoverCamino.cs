using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverCamino : MonoBehaviour{
    private Quaternion rotIni;
    private Vector3 posIni;

    private bool izq = true;

    public GameObject jugador;

    // Start is called before the first frame update
    void Start(){
        rotIni = transform.rotation;
        posIni = transform.position;
    }

    // Update is called once per frame
    void Update() {
        // Se chequea si se movio el auto a otra carretera para resetear los obstaculos
        // No se puede chequear si el jugador llega a 200 en z por que se moveria antes
        if (jugador.transform.position.x >= 200 & izq){
            transform.position = new Vector3(posIni.x, posIni.y, posIni.z);
            transform.rotation = rotIni;
            izq = false;
        }
        else if (jugador.transform.position.x <= 200 & !izq){
            transform.position = new Vector3(posIni.x, posIni.y, posIni.z);
            transform.rotation = rotIni;
            izq = true;
        }
    }
}
