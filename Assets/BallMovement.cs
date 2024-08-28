using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    [SerializeField] AudioClip BallSoundEffect;
    [SerializeField] AudioSource audioSource;
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
        //ball.velocity = new Vector2(speed, speed);
        //ball.transform(1f, 1f);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        audioSource.PlayOneShot(BallSoundEffect);
    }
}
