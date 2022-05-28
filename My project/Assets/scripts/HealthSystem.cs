using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthSystem : MonoBehaviour
{
    private int health;
    private int maxHealth;
    public HealthSystem(int maxHealth){
        this.maxHealth = maxHealth;
        health = maxHealth;
    }

public int GetHealth(){
    
    return health;
}

public void Damage (int damageAmount){
    health -= damageAmount;
    if(health < 0) health = 0;
}

public float GetHealthPercent(){

    return (float) health / maxHealth;
}

}
