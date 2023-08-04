using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovementScript : MonoBehaviour
{
    private float speed;
    private List<Transform> pathPoints = new List<Transform>();
    public PathScript path;
    public Vector3 startPos;
    public Vector3 endPos;
    public int currentIndex;
    private bool isReach;


    public void Set(float speed)
    {
        this.speed = speed;
        pathPoints = path.GetPath();
        transform.position = pathPoints[currentIndex].position;
        startPos = pathPoints[currentIndex].position;
        endPos = pathPoints[currentIndex + 1].position;
    }

    private void Update()
    {
        if(!isReach)
        {
            BallMove();

        }
    }

    private void BallMove()
    {
        Vector3 direction = endPos - startPos;
        transform.position += speed * Time.deltaTime * direction.normalized;

        if (Vector3.Distance(transform.position, endPos) <= 0.05f)
        {
            currentIndex++;

            if(currentIndex == pathPoints.Count - 1)
            {
                isReach = true;
                return;
            }
            startPos = pathPoints[currentIndex].position;
            endPos = pathPoints[currentIndex+1].position;
        }
    }


}
