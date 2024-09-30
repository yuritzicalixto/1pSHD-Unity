using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class pointsFinal : MonoBehaviour
{
    public TMP_Text Puntuacion;
    // Número total de lanzamientos
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Calcular efectividad (ejemplo: aciertos / lanzamientosTotales)

        Puntuacion.text = "Puntuación Final: " + gameController.puntos.ToString() + " puntos";
    }
}
