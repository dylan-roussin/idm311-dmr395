using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WoodSound : MonoBehaviour
{

    void Update()
    {

    }
    void OnMouseDown()
    {
        AudioSource audio = gameObject.GetComponent<AudioSource>();
        audio.PlayOneShot((AudioClip)Resources.Load("wood"));
    }
}