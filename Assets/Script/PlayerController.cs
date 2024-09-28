using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public float Jumpforce;
    public float Movespeed;
    private Rigidbody2D rb;
    public Button leftBtn;
    public Button rightBtn;


    public bool isGrounded;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        leftBtn.onClick.AddListener(() =>
        {
            JumpLeft();
        });

        rightBtn.onClick.AddListener(() =>
        {
            JumpRight(); 
        });
    }    

    public void JumpLeft() {
        if (isGrounded)
        {
            rb.velocity = new Vector2(-Movespeed, Jumpforce);
            isGrounded = false;
        }
        
    }
    public void JumpRight() {
        if (isGrounded) 
        {
            rb.velocity = new Vector2(Movespeed, Jumpforce);
            isGrounded = false;
        }
       
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Platform")) 
            isGrounded = true;
        
    }
}
