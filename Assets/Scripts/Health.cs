using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using TMPro;

public class Health : MonoBehaviour
{

    public TextMeshProUGUI healthText;
    public static int health = 100;
    
    void Start()
    {
        health = 100;

        healthText.text = "Health: " + health.ToString();
    }

    
    void Update()
    {
        healthText.text = "Health: " + health.ToString();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "end")
        {
            health--;
        }
    }
}
