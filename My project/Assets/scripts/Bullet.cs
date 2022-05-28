using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public static int zombieCount=0;
    private void OnTriggerEnter(Collider other) {
         if(other.gameObject.tag == "Zombie"){
                Destroy(other.gameObject);
                zombieCount++;
                Debug.Log(zombieCount+"Zombieeeee");
            }
    }
}
