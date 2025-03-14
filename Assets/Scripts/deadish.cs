using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteOutOfBounds : MonoBehaviour
{
    //Boundary in the X-Axis where the object will be deleted
   public float delay = 1.5f;
    private void Start()
    {
        Destroy(gameObject, delay);
    }
}