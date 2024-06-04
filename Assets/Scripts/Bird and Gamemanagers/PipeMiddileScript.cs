using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NerdStudios.CustomHeader;
public class PipeMiddileScript : MonoBehaviour
{

    [CustomHeader("PipeMiddileScript", HeaderColor.Blue, 16)]
    public LogicScript logic;

   
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Bird"))
        {
            logic.addScore();
            logic.AddCoin();

            if (logic.audioSource != null && logic.Pass != null)
            {
                Debug.Log("bird Pass");
                logic.playPass();
            }

            // Find the coin object within the pipe prefab by tag and destroy it
            Transform parentTransform = transform.parent;
            if (parentTransform != null)
            {
                // Search for all child objects with the Coin tag
                foreach (Transform child in parentTransform)
                {
                    if (child.CompareTag("Coin"))
                    {
                        Destroy(child.gameObject);
                        break; // Exit the loop after destroying the coin
                    }
                }
            }
        }
    }

}
