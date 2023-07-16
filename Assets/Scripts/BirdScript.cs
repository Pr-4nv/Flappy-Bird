using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{

public Rigidbody2D rb;
public float upSpeed;
public CollisionManager collision;

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            rb.velocity = Vector2.up * upSpeed;
        }
        
        if(collision.isGameOver == true)
        {
            upSpeed = 0;
        }
    }

   
}
