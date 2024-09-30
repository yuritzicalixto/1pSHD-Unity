using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destruct : MonoBehaviour
{
    private int limiteSuperior;
    private int limiteInferior;
    public Destruct(){
        this.limiteSuperior = 6;
        this.limiteInferior = -6;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.z > this.limiteSuperior)
        {
            Destroy(gameObject);
        }

        if(transform.position.z < this.limiteInferior)
        {
            Destroy(gameObject);
        }
    }
}
