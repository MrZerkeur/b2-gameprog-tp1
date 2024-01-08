using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidMovement : MonoBehaviour
{
    public float speed = 5;
    // Update is called once per frame
    void Update()
    {
        float moveX = 0;
        float moveY = -1;

        Vector2 movement = new Vector2(moveX, moveY);
        
        transform.Translate(movement * (Time.deltaTime * speed));
    }

    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
