using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BushSound : MonoBehaviour
{ 
    
    void Update()
    {

    }
    void OnMouseDown()
    {
        AudioSource audio = gameObject.GetComponent<AudioSource>();
        audio.PlayOneShot((AudioClip)Resources.Load("bush"));
    }
}