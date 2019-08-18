using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    // Start is called before the first frame update
    public KeyCode drop;
    public KeyCode action;
    public KeyCode crouch;
    public KeyCode itemL;
    public KeyCode itemR;

    public float speed;


    [Header("Components")]
    protected Collider2D coll;
    [Header("Inputs")]
    public float horizontalMove = 0.0f;
    public float verticalMove = 0.0f;
    private Vector2 playerInput;

   
   
    [Header("Movement")]
    protected Vector2 movePlayer;

    private Rigidbody2D rb2d;



    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        coll = GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        MoveInput();
    }

  
    [ContextMenu("Move Input")]
    protected void MoveInput()
    {
        horizontalMove = Input.GetAxis("Horizontal");

        Vector2 movement = new Vector2(horizontalMove, 0.0f);

        rb2d.AddForce(movement * speed);

    }


}