using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MontañaFollow : MonoBehaviour {
    public GameObject jugador;
    private Vector3 offsetMontaña = new Vector3(2.490141f, 148.2388f, 163.6978f);
    // Start is called before the first frame update
    void Start()
    {
    }

    // LateUpdate se llama una vez por frame despues de Update(), mas fluido
    void LateUpdate()
    {
        //Sigue al jugador y tiene un offset para que no este directamente encima del vehiculo
        transform.position = jugador.transform.position + offsetMontaña;
    }
}
