using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fab : MonoBehaviour
{
    public GameObject [] enemigos;
    private int randomEnemigo;
    private float rangoX=2;
    private float tiempo;

    void crearEnemigo()
    {
        //Genera de manera aleatoria a los enemigos
        //                                                            y       z
        Vector3 posicion = new Vector3(Random.Range(-rangoX, rangoX), 0.02f, 5.22f);
        //Selecciona los enemigos del arreglo
        randomEnemigo = Random.Range(0, enemigos.Length);
        Instantiate(enemigos[randomEnemigo], posicion, enemigos[randomEnemigo].transform.rotation);
    }
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("crearEnemigo", 2,2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
