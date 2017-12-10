using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour {

    // Watched Tutorials at https://www.youtube.com/channel/UCyBsvsU7uiurMiBZIYXvnyg
    // Makes enemies walk forwards until they hit a wall or the edge of a platform

    public float moveSpeed;
    public bool moveRight;

    public Transform wallCheck;
    public float wallCheckRadius;
    public LayerMask whatIsWall;
    private bool onWall;

    private bool nearEdge;
    public Transform edgeCheck;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        onWall = Physics2D.OverlapCircle(wallCheck.position, wallCheckRadius, whatIsWall);

        nearEdge = Physics2D.OverlapCircle(edgeCheck.position, wallCheckRadius, whatIsWall);

        if (onWall || !nearEdge)
            moveRight = !moveRight;
        if (moveRight)
        {
            transform.localScale = new Vector3(-1f, 1f, 1f);
            GetComponent<Rigidbody2D>().velocity = new Vector2(moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
        }
        else
        {
            transform.localScale = new Vector3(1f, 1f, 1f);
            GetComponent<Rigidbody2D>().velocity = new Vector2(-moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
        }
	}
}
