using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public int moveSpeed = 5;
    public float jumpForce = 10;
    public Transform feetPos;
    public float checkRadius = 0.5f;
    public LayerMask whatIsGround;
    public float jumpTime = 0.5f;
    public bool isJumping;

    private bool isGrounded;
    private Rigidbody2D rbody;
    private float jumpTimeTimer;

    // Start is called before the first frame update
    void Start()
    {
        rbody = GetComponent<Rigidbody2D>();
        GetComponent<Rigidbody2D>().freezeRotation = true;
    }

    // Update is called once per frame
    void Update()
    {
        rbody.velocity = new Vector2(Input.GetAxis("Horizontal") * moveSpeed, rbody.velocity.y);
        jumpScript();

        isGrounded = Physics2D.OverlapCircle(feetPos.position, checkRadius, whatIsGround);
    }

    public void jumpScript()
    {
        if (isGrounded == true && Input.GetKeyDown(KeyCode.Space))
        {
            isJumping = true;
            jumpTimeTimer = jumpTime;
            GetComponent<Rigidbody2D>().velocity = Vector2.up * jumpForce;
        }
        if (Input.GetKey(KeyCode.Space) && isJumping == true)
        {
            if (jumpTimeTimer > 0)
            {
                GetComponent<Rigidbody2D>().velocity = Vector2.up * jumpForce;
                jumpTimeTimer -= Time.deltaTime;
            }
            else
            {
                isJumping = false;
            }
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            isJumping = false;
        }
    }

}
