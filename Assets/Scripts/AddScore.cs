using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddScore : MonoBehaviour
{
    public int score = 0;
    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
        score++;
    }
}