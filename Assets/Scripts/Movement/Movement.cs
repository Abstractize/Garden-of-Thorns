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

    public float speed;
    [Header("Jump Variables")]
    public float fallMultiplier = 2.5f;
    public float lowJumpMultiplier = 2.0f;
    [Header("Components")]
    protected Collider2D coll;
    protected Rigidbody2D rb;
    protected CharacterController2D player;
    [Header("Inputs")]
    public float horizontalMove = 0.0f;
    public float verticalMove = 0.0f;
    private Vector2 playerInput;
    private Vector2 movement;

   
   
    [Header("Movement")]
    protected Vector2 movePlayer;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        coll = GetComponent<Collider2D>();
        player = GetComponent<CharacterController2D>();
    }


    void FixedUpdate()
    {
        MoveInput();
        player.Move(horizontalMove * speed *Time.fixedDeltaTime,Input.GetKey(crouch),Input.GetKeyDown(jump));
    }

  
    [ContextMenu("Move Input")]
    protected void MoveInput()
    {
        horizontalMove = Input.GetAxis("Horizontal");
        verticalMove = Input.GetAxis("Vertical");
    }
    protected void BetterJump()
    {
        if (rb.velocity.y < 0)
        {
            rb.velocity += Vector2.up * Physics2D.gravity.y * (fallMultiplier - 1) * Time.deltaTime;
        }
        else if (rb.velocity.y > 0 && !Input.GetKeyDown(jump))
        {
            rb.velocity += Vector2.up * Physics2D.gravity.y * (lowJumpMultiplier - 1) * Time.deltaTime;
        }
    }
}