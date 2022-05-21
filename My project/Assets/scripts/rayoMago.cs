using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rayoMago : MonoBehaviour
{

    public float speed = 40;
    public GameObject bullet;
    public Transform barrel;
    public AudioSource audioSource;
    public AudioClip audioClip;
    private float fireRate = 1.0f;
    private float lastShot = 0.0f;
    public void Fire(){
        if(Time.time > fireRate +lastShot){
        GameObject spawnedBullet = Instantiate(bullet, barrel.position, barrel.rotation);
        spawnedBullet.GetComponent<Rigidbody>().velocity = speed * barrel.up;
        audioSource.PlayOneShot(audioClip);
        
        Destroy(spawnedBullet, 2);
        lastShot = Time.time;
       }
    }
}
