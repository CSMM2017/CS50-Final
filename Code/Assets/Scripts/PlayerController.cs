using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    // Watched Tutorials at https://www.youtube.com/channel/UCyBsvsU7uiurMiBZIYXvnyg

    public float moveSpeed;
    private float moveVelocity;
	public float jumpHeight;

    public Transform groundCheck;
    public float groundCheckRadius;
    public LayerMask whatIsGround;
    private bool onGround;

    public bool doubleJumpCheck;

    private Animator anim;

    public float knockback;
    public float knockbackTime;
    public float knockbackCount;
    public bool knockRight;
	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
		
	}

    void FixedUpdate()
    {
        onGround = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, whatIsGround);
    }

    // Update is called once per frame
    void Update () {
        // Checks if player is on the ground
        if (onGround)
        {
            doubleJumpCheck = false;
        }
        anim.SetBool("OnGround", onGround);

        // Sets the keys that cause the player to move

        if (Input.GetKeyDown(KeyCode.W))
        {
            if (!onGround && !doubleJumpCheck)
            {
                //GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, jumpHeight);
                Jump();
                doubleJumpCheck = true;
            }
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            if (onGround)
            {
                //GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, jumpHeight);
                Jump();
            }

        }

        moveVelocity = 0f;

        if (Input.GetKey(KeyCode.D))
        {
            //GetComponent<Rigidbody2D>().velocity = new Vector2(moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
            moveVelocity = moveSpeed;
        }
        if (Input.GetKey(KeyCode.A))
        {
            //GetComponent<Rigidbody2D>().velocity = new Vector2(-moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
            moveVelocity = -moveSpeed;
        }
        if (knockbackCount <= 0)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(moveVelocity, GetComponent<Rigidbody2D>().velocity.y);
        }
        else
        {
            if (knockRight)
                GetComponent<Rigidbody2D>().velocity = new Vector2(-knockback, knockback);
            if (!knockRight)
                GetComponent<Rigidbody2D>().velocity = new Vector2(knockback, knockback);
            knockbackCount -= Time.deltaTime;
        }
        anim.SetFloat("Speed", Mathf.Abs( GetComponent<Rigidbody2D>().velocity.x));
        
        //Flips character model when it switched direction.
        if (GetComponent<Rigidbody2D>().velocity.x > 0)
        {
            transform.localScale = new Vector3(1f, 1f, 1f);
        }
        else if (GetComponent<Rigidbody2D>().velocity.x < 0)
        {
            transform.localScale = new Vector3(-1f, 1f, 1f);
        }
    }
    public void Jump()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, jumpHeight);
    }
} 
 