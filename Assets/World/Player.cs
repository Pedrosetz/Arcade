using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    public float moveSpeed = 5f;

    public float jumpForce = 10f;

    private bool isGrounded;

    public LayerMask groundLayer;

    private Rigidbody2D rb;

    private Collider2D col;

    private Vector2 movement;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        col = GetComponent<Collider2D>();
    }

    void Update()
    {
        
        float moveX = Input.GetAxisRaw("Horizontal"); 

        movement = new Vector2(moveX, rb.velocity.y);

        isGrounded = Physics2D.IsTouchingLayers(col, groundLayer);

        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce); 
        }
    }

    
    void FixedUpdate()
    {
        // Aplica o movimento horizontal ao Rigidbody2D
        rb.velocity = new Vector2(movement.x * moveSpeed, rb.velocity.y);
    }
}