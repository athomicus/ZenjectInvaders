using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class EnemySpawner : MonoBehaviour
{
    private float timeSinceSpawn = 0.0f;
    public float timeBetweenSpawn =  10.0f;

   [Inject]
   Enemy.EnemyFactory enemyFactory;

    // Update is called once per frame
    void Update()
    {
        
        timeSinceSpawn += Time.deltaTime;
        if( timeSinceSpawn > timeBetweenSpawn)
        {
            //Spawn
           Enemy enemy = enemyFactory.Create();
           Destroy(enemy.gameObject, 55.0f);
            
           timeSinceSpawn = 0.0f;
        }
    }
}
