using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shield : MonoBehaviour
{
   
    public GameObject aaa;
    
    public AudioSource audioSource;
    public AudioClip audioClip;
    private bool sound;

    private void Start() {
        
    }

    private void Update() {
        aaa.SetActive(false);
        // if(audioSource.isPlaying()){
        //     audioSource.Stop();
            
        // }
        
    }
    public void InvokeShield(){

            
            aaa.SetActive(true);
            
            

        
        
       
    }

}
