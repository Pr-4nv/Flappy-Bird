using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class UILeanTween : MonoBehaviour
{

    [SerializeField]

    GameObject Taptostart;
    void Start()
    {
        LeanTween.scale(Taptostart, new Vector3(1.1f, 1.1f, 1.1f), .4f).setLoopPingPong();

    }

   

}
