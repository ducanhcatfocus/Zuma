using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum EBall
{
    red,
    blue, 
    green,
}
public class BallScript : MonoBehaviour
{
    public float speed = 2f;
    public EBall ballType;

    public BallMovementScript ballMovement;

    public void SetBallType(int i)
    {
        if(i == 0)
        {
            ballType = EBall.red;
            return;
        }
        if (i == 1)
        {
            ballType = EBall.blue;
            return;
        }
       
            ballType = EBall.green;
     
    }

    private void Start()
    {
        StartMove();
    }

    private void StartMove()
    {
        ballMovement.Set(speed);
    }
}
