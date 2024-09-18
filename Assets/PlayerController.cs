using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerController : MonoBehaviour
{
    public float Jumpforce;
    public float Movespeed;
    private Rigidbody2D rb;

    public bool isGrounded;

    private void Start() {
        rb = GetComponent<Rigidbody2D>(); 
    
    }
    private void Update()
    {
        if (isGrounded) {
            if (Input.GetKeyDown(KeyCode.A))
            {
                JumpLeft();

            }
            if (Input.GetKeyDown(KeyCode.D)) {
                JumpRight();
            }
        }
    }

    public void JumpLeft() {
        rb.velocity = new Vector2(-Movespeed, Jumpforce);
    }
    public void JumpRight() {
        rb.velocity = new Vector2(Movespeed, Jumpforce);
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Platform")) { 
            isGrounded = true;
        }
    }
    public void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Platform")) {
            isGrounded = false;
        }
    }
}
