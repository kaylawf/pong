using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    [SerializeField] AudioClip BallSoundEffect;
    [SerializeField] AudioSource audioSource;
    //[SerializeField] private Transform ballPos;
    [SerializeField] private Transform playerPaddle;
    [SerializeField] private Transform AIPaddle;
    private Rigidbody2D ball;
    //private CircleCollider2D ball;
    private int speed = 5;

    // Start is called before the first frame update
    void Start()
    {
        ball = gameObject.GetComponent<Rigidbody2D>();
        //ball = gameObject.GetComponent<CircleCollider2D>();
        ball.velocity = new Vector2(-speed, 0);
        if (audioSource == null)
        {
            audioSource = GetComponent<AudioSource>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        //Vector2 ballPosition = transform.position;
        ////Vector2 AIPosition = AIPaddle.position;
        //Vector2 playerPosition = playerPaddle.position;

        //while (ball.velocity.x == 0)
        //{
        //    if (ballPosition.y == playerPosition.y)
        //    {
        //        ball.velocity = new Vector2(speed, 0.1f);

        //    }
        //}

        //ball.velocity = new Vector2(speed, speed);
        //ball.transform(1f, 1f);
    }

    //private void OnCollisionEnter2D(Collision2D collision)
    //{
    //    audioSource.PlayOneShot(BallSoundEffect);
    //}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Vector2 ballPosition = transform.position;
        //Vector2 AIPosition = AIPaddle.position;
        Vector2 playerPosition = playerPaddle.position;

        if (ballPosition.y == playerPosition.y)
        {
            ball.velocity = new Vector2(speed, 0.5f);

        }
    }
}
