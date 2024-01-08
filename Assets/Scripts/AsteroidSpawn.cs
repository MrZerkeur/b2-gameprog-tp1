using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidSpawn : MonoBehaviour
{
    public GameObject asteroid;
    public float spawnTime = 3f;
    
    void Start () {
        InvokeRepeating(nameof(SpawnAsteroid), 0, spawnTime);
    }
    
    void SpawnAsteroid()
    {
        for (int i = 0; i < 2; i++)
        {
            GameObject newAsteroid = Instantiate(asteroid);
            float spawnX = Random.Range(-9f, 9f);
            float spawnY = 5.20f;
            Vector2 position = new Vector2(spawnX, spawnY);
            newAsteroid.transform.position = position;
        }
    }
}
