using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rb;
    bool upPressed;
    float power = 300;
    float startSpeed = 5, maxSpeed = 8;
    //public MeshRenderer ground;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.AddForce(Vector2.right * startSpeed);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            upPressed = true;
        }
        //ground.material.mainTextureOffset += new Vector2(Time.time * .3f, 0);
    }
    private void FixedUpdate()
    {
        if (upPressed)
        {
            upPressed = false;
            rb.AddForce(Vector2.up * power);
        }
        if (rb.velocity.x < maxSpeed)
        {
            rb.AddForce(Vector2.right);
        }
    }
}
