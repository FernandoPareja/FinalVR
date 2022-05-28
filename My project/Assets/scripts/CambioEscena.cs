using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class CambioEscena : MonoBehaviour
{
     public float timer = 5.0f;

     public Text textoTimer;
    // Start is called be  fore the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;

        textoTimer.text= "" + timer.ToString("f1");
        if (timer <= 0.0f)
            {
                CargarJuego();
            }
 
    }

    public void CargarJuego(){

        SceneManager.LoadScene("Juego");
    }

   
}
