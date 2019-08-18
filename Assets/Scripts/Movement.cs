using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    // Start is called before the first frame update
    public KeyCode jump;
    public KeyCode drop;
    public KeyCode action;
    public KeyCode crouch;
    public KeyCode itemL;
    public KeyCode itemR;

    public float fallMultiplier = 2.5f;
    public float lowJumpMultiplier = 2f;


    public float speed;
    [Range(1, 10)]
    public float jumpVelocity;


    [Header("Components")]
    protected Collider2D coll;
    private Rigidbody2D rb2d;
    [Header("Inputs")]
    public float horizontalMove = 0.0f;
    public float verticalMove = 0.0f;
    private Vector2 playerInput;
    private Vector2 movement;

   
   
    [Header("Movement")]
    protected Vector2 movePlayer;

   



    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        coll = GetComponent<Collider2D>();
    }


    void Update()
    {
        MoveInput();

    }

  
    [ContextMenu("Move Input")]
    protected void MoveInput()
    {
        horizontalMove = Input.GetAxis("Horizontal");

       Vector2  movement = new Vector2(horizontalMove, 0.0f) * speed;

        rb2d.AddForce(movement);



    }

    protected void Jump()
    {
        if (Input.GetKeyDown(jump))
        {
            GetComponent<Rigidbody2D>().velocity = Vector2.up * jumpVelocity;
        }
    }

    protected void betterJump()
    {
        if (rb2d.velocity.y < 0)
        {
            rb2d.velocity += Vector2.up * Physics2D.gravity.y * (fallMultiplier - 1) * Time.deltaTime;
        }
        else if (rb2d.velocity.y > 0 && !Input.GetKeyDown(jump))
        {
            rb2d.velocity += Vector2.up * Physics2D.gravity.y * (lowJumpMultiplier - 1) * Time.deltaTime;
        }
    }


}