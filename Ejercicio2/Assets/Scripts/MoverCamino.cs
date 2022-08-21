using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverCamino : MonoBehaviour{
    // Numero de set del Camino(carretera y obstaculos)
    public int numCamino;
    // Cuantas veces se movio el set
    private int setActual = 0;
    // Para saber si hay que rotarlo
    public bool esObstaculo;
    private Quaternion rotIni;
    private Vector3 posIni;

    public GameObject jugador;

    // Start is called before the first frame update
    void Start(){
        rotIni = transform.rotation;
        posIni = transform.position;
    }

    // Update is called once per frame
    void Update() {
        if (jugador.transform.position.z >= 200*numCamino+800*setActual){
            transform.position = new Vector3(posIni.x, posIni.y, transform.position.z + 800);
            transform.rotation = rotIni;
            setActual++;
        }

        else if (jugador.transform.position.z <= -200 * (5 - numCamino) + 800 * setActual){
            transform.position = new Vector3(posIni.x, posIni.y, transform.position.z - 800);
            transform.rotation = rotIni;
            setActual--;
        }
    }
}
