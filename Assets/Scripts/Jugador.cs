using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador : MonoBehaviour
{
    private float horizontal;
    [Range (1,10)]
    public float velocidad;
    public GameObject Misil;
    public Jugador()
    {
        this.velocidad = 2;
    }

    void moverHorizontal()
    {
        this.horizontal = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * (horizontal*Time.deltaTime*velocidad));

        if(transform.position.x < -4)
        {
            transform.position = new Vector3(x:-4, transform.position.y, transform.position.z);
        }
        if(transform.position.x > 4)
        {
            transform.position = new Vector3(x:4,transform.position.y, transform.position.z);
        }

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        moverHorizontal();
        lanzar();
    }

    void lanzar() 
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(Misil, transform.position, transform.rotation);
        }
    }
}
