using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIAudioManger : MonoBehaviour
{
    [SerializeField]

    public AudioSource audioSourse;
    public AudioClip UiBgScore;
    // Start is called before the first frame update
    void Start()
    {
        audioSourse.PlayOneShot(UiBgScore);
    }

   
}
