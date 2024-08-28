using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private bool isAI;
    [SerializeField] private int speed;
    [SerializeField] private Transform ball;
    private Rigidbody2D paddle;
    private float direction_y;

    // Start is called before the first frame update
    void Start()
    {
        paddle = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isAI)
        {
            AImovement();
        }
        else
        {
            direction_y = Input.GetAxisRaw("Vertical");
            paddle.velocity = new Vector2(0, direction_y * speed);
        }
    }

    private void AImovement()
    {
        Vector2 paddlePosition = transform.position;
        Vector2 ballPosition = ball.position;

        if (ballPosition.y > paddlePosition.y)
        {
            paddle.velocity = new Vector2(0, speed/2);
        }
    }
}
