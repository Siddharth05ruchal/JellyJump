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

    public float fallMul = 5f;

    public bool isGrounded;
    private bool firstLanding = false;

    [SerializeField]
    private BoxCollider2D groundCol;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        leftBtn.onClick.AddListener(() =>
        {
            if (GameManager.Instance.startGame)
            {
                JumpLeft();
            }
        });

        rightBtn.onClick.AddListener(() =>
        {
            if (GameManager.Instance.startGame)
            {
                JumpRight();
            }
        });
    }

    private void Update()
    {
        if(rb.velocity.y < 0f)
        {
            rb.velocity += Vector2.up * Physics2D.gravity.y * fallMul * Time.deltaTime;
        }

        if (firstLanding)
        {
            groundCol.isTrigger = true;
            groundCol.GetComponent<SpriteRenderer>().enabled = false;
        }
    }

    public void JumpLeft()
    {
        if (isGrounded)
        {
            rb.gravityScale = 1f;
            rb.velocity = new Vector2(-Movespeed, Jumpforce);
            isGrounded = false;
        }        
    }
    public void JumpRight() 
    {
        if (isGrounded) 
        {
            rb.gravityScale = 1f;
            rb.velocity = new Vector2(Movespeed, Jumpforce);
            isGrounded = false;
        }
       
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Platform") || collision.gameObject.CompareTag("Ground"))
        {
            if (collision.gameObject.CompareTag("Platform"))
            {
                firstLanding = true;
            }
            isGrounded = true;
            rb.gravityScale = fallMul;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Ground") && firstLanding)
        {
            GameManager.Instance.RestartGame(this.gameObject);
        }
    }
}
