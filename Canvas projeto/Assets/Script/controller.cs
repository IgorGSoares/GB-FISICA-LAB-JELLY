using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controller : MonoBehaviour
{
    public float speed = 5f;
    private Rigidbody2D rb;
    public float jumpPower;

    public int jumpCount = 2;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        Vector2 direction = new Vector2(x, y);
        Run(direction);

        if(Input.GetButtonDown("Jump") && jumpCount > 0)
        {
            Jump(Vector2.up);
        }

        if (Input.GetKeyDown(KeyCode.DownArrow) && jumpCount > 0)
        {
            Jump2(Vector2.up*-1);
        }
    }

    public void Run(Vector2 dir)
    {
        rb.AddForce(new Vector2(dir.x * speed, 0));
    }

    public void Jump(Vector2 dir)
    {
        jumpCount--;
        rb.velocity = new Vector2(rb.velocity.x, 0);
        rb.velocity += dir * jumpPower;
    }

    public void Jump2(Vector2 dir)
    {
        jumpCount--;
        rb.velocity = new Vector2(rb.velocity.x, 0);
        rb.velocity += dir * jumpPower;
    }
}
