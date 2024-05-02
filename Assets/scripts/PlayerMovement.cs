using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class PlayerMovement : MonoBehaviour
{
    public float speedFactor = 5f;
    public float verticalSpeedFactor = 2000f;
    private Rigidbody2D rigidBody;
    private Animator animator;

    public float spawnX;
    public float spawnY;

    public void goToSpawn()
    {
        gameObject.transform.position = new Vector2(spawnX, spawnY);
    }

    private bool IsGrounded()
    {
        float yDistanceCheck = gameObject.GetComponent<Collider2D>().bounds.extents.y + 0.1f;
        Debug.DrawLine(rigidBody.transform.position, new Vector2(rigidBody.transform.position.x, rigidBody.transform.position.y - yDistanceCheck), Color.red);
        bool raycast1 = Physics2D.Raycast(rigidBody.transform.position, Vector2.down, yDistanceCheck);
        Debug.Log(raycast1);
        return raycast1;

    }

    private void Start()
    {
        animator = GetComponent<Animator>();
        rigidBody = GetComponent<Rigidbody2D>();
    }
    private void FixedUpdate()
    {
        var horizontalAxisInput = Input.GetAxis("Horizontal");
        if(horizontalAxisInput != 0)
        {
            animator.SetBool("isWalking", true);
        } else
        {
            animator.SetBool("isWalking", false);
        }
        rigidBody.velocity = new Vector2(horizontalAxisInput * speedFactor, rigidBody.velocity.y);
        if(IsGrounded() && Input.GetAxis("Vertical") > 0)
        {
            Debug.Log("Adding vertical force");
            rigidBody.AddForce(new Vector2(0, verticalSpeedFactor));
        }

    }
}
