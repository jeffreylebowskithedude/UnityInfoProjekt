using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] enemySpawner Spawner;
    public int enemyHealth = 20;
    
    public void TakeDamage(int damage)
    {
        enemyHealth -= damage;

        if(enemyHealth <= 0)
        {
            Death();
        }
    }
    public void Death()
    {
        Spawner.enemiesKilled += 1;
        Destroy(gameObject);
        
    }
}
