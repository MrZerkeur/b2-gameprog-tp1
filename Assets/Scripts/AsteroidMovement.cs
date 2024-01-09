using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class AsteroidMovement : MonoBehaviour
{
    private AsteroidSpawn _gameController;
    private float _speed = 4; 
    
    void Update()
    {
        float moveX = 0;
        float moveY = -1;

        Vector2 movement = new Vector2(moveX, moveY);
        
        transform.Translate(movement * (Time.deltaTime * _speed));
    }

    void OnBecameInvisible()
    {
        Destroy(gameObject);
        _gameController = GameObject.Find("GameController").GetComponent<AsteroidSpawn>();
        _gameController.UpdateScore(1);
    }
}
