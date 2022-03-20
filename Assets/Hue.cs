using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hue : MonoBehaviour
{
    public MeshRenderer terrain;
    public Slider red;
    public Slider green;
    public Slider blue;

    public void OnEdit()
    {
        Color color = terrain.material.color;
        color.r = red.value;
        color.g = green.value;
        color.b = blue.value;
        terrain.material.color = color;
        terrain.material.SetColor("_EmissionColor", color);
    }
}