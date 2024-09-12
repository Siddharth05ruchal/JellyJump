using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float JumpForce;
    public float horizontalJumpForce;
    public bool canMoveHorizontally = true;
    
    public Rigidbody2D rb;
    private bool isGrounded;
    private float moveInput;

    void Start()
    {
        rb.GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        moveInput = Input.GetAxis("Horizontal");

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded) {
            JumpDiagonally();
        }

    }
    void FixedUpdate()
    {
        if (!isGrounded && canMoveHorizontally)
        {
            rb.velocity = new Vector2(moveInput * horizontalJumpForce, rb.velocity.y);
        }
    }

    public void JumpDiagonally() {
        Vector2 JumpDirection = new Vector2(moveInput * horizontalJumpForce, JumpForce);
        rb.velocity = JumpDirection;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Platform") { 
            isGrounded= true;
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Platform") { 
            isGrounded = false;
        }
    }
}
