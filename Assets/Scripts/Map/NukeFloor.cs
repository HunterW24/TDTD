using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NukeFloor : MonoBehaviour
{
    public ParticleSystem nukeSmoke;

    public AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Boom")
        {

            Destroy(collision.gameObject);
            GameObject[] balls = GameObject.FindGameObjectsWithTag("Ball");
            foreach (GameObject ball in balls)
            {
                Destroy(ball);
            }

            nukeSmoke.Play();
            
        }
    }
}
