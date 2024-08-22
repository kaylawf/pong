using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    private Rigidbody2D ball;
    private int speed = 5;

    // Start is called before the first frame update
    void Start()
    {
        ball = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        ball.velocity = new Vector2(speed, speed);
    }
}
