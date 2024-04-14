using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMiddileScript : MonoBehaviour
{
     public LogicScript logic;
   

   
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        logic.addScore();
        if (logic.audioSource != null && logic.Pass != null)
        {
            Debug.Log("bird Pass");
            logic.playPass();
        }


    }
}
