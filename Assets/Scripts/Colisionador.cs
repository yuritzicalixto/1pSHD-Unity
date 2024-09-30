using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //Importar para cambiar de escena

public class Colisionador : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        //Verificamos si colisionamos con el jugador
        if(other.CompareTag("jugador"))
        {
            if(gameController.vidas > 1)
            {
                gameController.vidas = gameController.vidas -= 1;
            }
            else 
            {
                //Cragar la escena Game Over
            SceneManager.LoadScene("GameOver");
            }
            Debug.Log("Fin del juego - Cargando escena de Game Over");
        }
        //Verfificamos si colisionamos con una esfera (proyectil)
        else if (other.CompareTag("bala"))
        {
            gameController.puntos = gameController.puntos += 1;
            //Destruye el enemigo actual (este juego)
            Destroy(gameObject);
            //Destruye la bala que ha colisionado
            Destroy(other.gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
