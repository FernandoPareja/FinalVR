using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Player : MonoBehaviour
{
   // Start is called before the first frame update
      void OnTriggerEnter(Collider other) {
        
            if(other.gameObject.tag == "Zombie"){
                SceneManager.LoadScene("Inicio");
            }
        
    }
}
