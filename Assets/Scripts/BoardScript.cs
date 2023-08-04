using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardScript : MonoBehaviour
{
    public GameObject ballPrefabs;
    public float timeDelay = 0.5f;
   

 

    public List<Sprite> sprites = new List<Sprite>();

 

    private void Start()
    {
        StartCoroutine(SpawnBall());
    }

    private IEnumerator SpawnBall()
        
    {
        while (true)
        {
            InitBall() ;
            yield return new WaitForSeconds(timeDelay);

        }
    }

    private void InitBall()
    {
        GameObject ball = Instantiate(ballPrefabs);
        SpriteRenderer spriteRenderer = ball.GetComponent<SpriteRenderer>();
        int i = Random.Range(0, sprites.Count);
        spriteRenderer.sprite = sprites[i];
        BallScript ballScript = ball.GetComponent<BallScript>();
        ballScript.SetBallType(i);
    }
}
