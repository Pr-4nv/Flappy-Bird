using UnityEngine;
using NerdStudios.CustomHeader;
public class PipeSponner : MonoBehaviour
{
    [CustomHeader("PipeSponner", HeaderColor.Blue, 16)]
    public GameObject pipe;
    public float spawnRate = 2;
    private float timer =0;
    public float heightOffset = 10;

   
    void Start()
    {
        spawnPipe();
    }

   
    void Update()
    {
        if (timer < spawnRate)
        {
             timer = timer + Time.deltaTime;
        }else
        
        {
            spawnPipe();
            timer = 0;
        }

    }

    void spawnPipe()

    {
        float lowestPoint = transform.position.y - heightOffset;
        float heighestPoint = transform.position.y + heightOffset;

        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lowestPoint, heighestPoint), 0), transform.rotation);
    }
}