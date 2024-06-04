using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NerdStudios.CustomHeader;

public class BirdScript : MonoBehaviour
{

[CustomHeader("BirdScript", HeaderColor.Blue, 16)]

public Rigidbody2D rb;
public float upSpeed;
public CollisionManager collision;

    
    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            rb.velocity = Vector2.up * upSpeed;
        }

        if(Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = Vector2.up * upSpeed;
        }
        
        if(collision.isGameOver == true)
        {
            upSpeed = 0;
        }
    }

   
}
