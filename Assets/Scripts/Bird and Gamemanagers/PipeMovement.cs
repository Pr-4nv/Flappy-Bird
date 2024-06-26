using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PipeMovement : MonoBehaviour
{

    public float moveSpeed = 6;
    public float deadZone = -80;
    private GameObject Bird;
    public CollisionManager collisionManager;

    void Awake()
    {
        collisionManager = GameObject.FindGameObjectWithTag("Bird").GetComponent<CollisionManager>();
    }

    
    void Update()
    {


        transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime;

        if (transform.position.x < deadZone)
        {
            Destroy(gameObject);
        }

        if (collisionManager.isGameOver == true)
        {
            moveSpeed = 0;
        }
    }


}
