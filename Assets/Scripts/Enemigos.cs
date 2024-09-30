using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigos : MonoBehaviour
{
    [Range (1,10)]
    public float velocidad;
    public Enemigos()
    {
        this.velocidad = 5;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
                transform .Translate(Vector3.forward*(Time.deltaTime*this.velocidad));
    }
}
