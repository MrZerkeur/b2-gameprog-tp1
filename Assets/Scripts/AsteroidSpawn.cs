using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class AsteroidSpawn : MonoBehaviour
{
    public GameObject asteroid;
    public float spawnTime = 1.5f;
    
    private int _score;
    private TextMeshProUGUI _scoreText;
    
    void Start ()
    {
        _score = 0;
        InvokeRepeating(nameof(SpawnAsteroid), spawnTime, spawnTime);
    }
    
    void SpawnAsteroid()
    {
        int scoreIncrement = 20;
        int baseSpawnRepeat = 2;

        int spawnRepeat = baseSpawnRepeat + (_score - 1) / scoreIncrement;
        
        SpawnRepeat(spawnRepeat);
    }

    private void SpawnRepeat(int asteroidNumber)
    {
        for (int i = 0; i < asteroidNumber; i++)
        {
            GameObject newAsteroid = Instantiate(asteroid);
            float spawnX = Random.Range(-9f, 9f);
            float spawnY = 5.20f;
            Vector2 position = new Vector2(spawnX, spawnY);
            newAsteroid.name = "Asteroid";
            newAsteroid.transform.position = position;
        }
    }

    public void UpdateScore(int scoreToAdd)
    {
        _score++;
        _scoreText = GameObject.Find("Score").GetComponent<TextMeshProUGUI>();
        _scoreText.text = $"Score : {_score}";
    }
}
