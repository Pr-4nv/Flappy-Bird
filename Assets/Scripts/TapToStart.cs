using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TapToStart : MonoBehaviour
{
    public GameObject[] objectsToActivate;
    public GameObject ObjectToDeactivate;
    
    public Button button;

   

    public void ActivateObjects()
    {
        
        foreach (GameObject obj in objectsToActivate)
        {
            obj.SetActive(true);
        }

        ObjectToDeactivate.SetActive(false);
        
    }
}
