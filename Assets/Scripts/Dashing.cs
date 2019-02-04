using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dashing : MonoBehaviour
{

    public float dashForce;
    private float dashTime;
    private float dashTimeCounter;
    public bool isDashing;
    private bool isGrounded;
    public LayerMask whatIsGround;
    public Transform feetPos;
    public Rigidbody2D rbody;

    void Start()
    {
        rbody = GetComponent<Rigidbody2D>();
    }

    public void dashScript()
    {

    }

    void Update()
    {
        
    }
}
