using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // SceneManager.LoadScene("Start");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     public void escenaJuego()
    {
        SceneManager.LoadScene("Juego");
    }

}
