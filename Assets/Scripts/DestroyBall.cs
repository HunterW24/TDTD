using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBall : MonoBehaviour
{
    public int balloonHp = 1;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "shot")
        {
            /*balloonHp -= Shot.shot;*/
            ScoreManager.score++;
            ScoreManager.points++;

            Destroy(collision.gameObject);
            Destroy(gameObject);

            
            
        }
        /*if (balloonHp <= 0)
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }*/
    }
}
