using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ZOM : MonoBehaviour
{
    public GameObject player;
   
    private float yPos;
    public float gravity = -9.81f;
    Vector3 playerPosition;

   
    
    private void Start()
    {
      
        
    }

    private void Update() {
        this.transform.LookAt(player.transform);
        this.transform.Translate(Vector3.forward * 2 * Time.deltaTime);

        
    }
  
 



}