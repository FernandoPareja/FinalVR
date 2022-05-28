using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemySpawn : MonoBehaviour
{
    public int waveValue;
    public int currWave;
    public Transform spawnLocation;
    public GameObject zombie;
    public int waveDuration;
    private float waveTimer;
    private float spawnInterval;
    private float spawnTimer;
    private int contador = 0;
    public Bullet contar;
    public GameObject bullet;
    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    void Update() {
        
            if(contador < 10){
            GameObject spawnedZombie = Instantiate(zombie, spawnLocation.position, Quaternion.identity);
            contador++;
            Debug.Log(Bullet.zombieCount +"aaaa");
            if(Bullet.zombieCount>2){
              contador = 0;
              Debug.Log(Bullet.zombieCount +"aaaa");

          }
            
            }
          
            
              
    }
    }

   

