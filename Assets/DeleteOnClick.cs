using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteOnClick : MonoBehaviour
{
    void Update()
    {

    }
    void OnMouseDown()
    {
        // this object was clicked - do something
        Destroy(this.gameObject);
    }
}
