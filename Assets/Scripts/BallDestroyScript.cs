using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallDestroyScript : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Ball"))
        {
            Debug.Log("ball");

            BallScript ball = collision.GetComponent<BallScript>();

            if(ball != null)
            {
                
                Destroy(ball.gameObject);
            }
        }
    }
}
