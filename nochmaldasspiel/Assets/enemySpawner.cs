using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemySpawner : MonoBehaviour
{
    [System.Serializable]
    public class WaveContent
    {
        [SerializeField][NonReorderable] GameObject[] enemySpawner;
        
        public GameObject[] GetEnemySpawnList()
        {
            return enemySpawner;
        }
    }


    [SerializeField] [NonReorderable] WaveContent[] waves;
    int currentWave = 0;
    float spawnRange = 25;
    public int enemiesKilled = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        SpawnWave();
    }

    // Update is called once per frame
    void Update()
    {
        if(enemiesKilled >= waves[currentWave].GetEnemySpawnList().Length)
        {
            
            currentWave += 1;
            SpawnWave();
        }
    }

    void SpawnWave()
    {
        
        for (int i = 0; i < waves[currentWave].GetEnemySpawnList().Length; i++) 
        {
            
           
            
                
            Instantiate(waves[currentWave].GetEnemySpawnList()[i], FindSpawnLoc(), Quaternion.identity);
                
                
                
            
        }
    }

    Vector3  FindSpawnLoc()
    {
        Vector2 SpawnPos;
        
        Transform SpawnTransform = transform;

        float xLoc = Random.Range(-spawnRange, spawnRange) + transform.position.x;
        float yLoc = Random.Range(-spawnRange, spawnRange) + transform.position.y;

        SpawnPos = new Vector2(xLoc, yLoc);

        return SpawnPos;
    }
}
