using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private bool isAI;
    [SerializeField] private int speed;
    private Rigidbody2D rb;
    private float direction_y;

    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void FixedUpdate()
    {
        if (isAI)
        {
            rb.velocity = new Vector2(0, speed);
        }
        else
        {
            direction_y = Input.GetAxisRaw("Vertical");
            rb.velocity = new Vector2(0, direction_y * speed);
        }
    }
}
