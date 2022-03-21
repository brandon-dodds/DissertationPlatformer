using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] float jumpForce;
    bool isGrounded;
    [SerializeField] Transform feetPos;
    [SerializeField] Vector2 checkRadius;
    [SerializeField] LayerMask whatIsGround;
    Rigidbody2D rb;
    [SerializeField] float actionCooldown;
    [SerializeField] int jumpGravScale;
    [SerializeField] int fallGravScale; 
    float timeSinceAction = 0.0f;
    public bool isPlayerMoving;
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        //transform.Translate(new Vector2(Input.GetAxis("Horizontal") * speed * Time.deltaTime, 0));
        rb.velocity = new Vector2(Input.GetAxis("Horizontal") * speed, rb.velocity.y);
        isGrounded = Physics2D.OverlapCapsule(feetPos.position, checkRadius, CapsuleDirection2D.Horizontal, 0f, whatIsGround);
        if (Input.GetAxis("Vertical") > 0 && isGrounded && timeSinceAction > actionCooldown)
        {
            Jump();
        }
        if (isGrounded)
        {
            timeSinceAction += Time.deltaTime;
        }
        if(rb.velocity.y < 0)
        {
            rb.gravityScale = fallGravScale;
        }
        if(rb.velocity.y >= 0)
        {
            rb.gravityScale = jumpGravScale;
        }
        isPlayerMoving = rb.velocity.magnitude > 0.2f;
        Debug.Log(isPlayerMoving);
    }

    void Jump()
    {
        rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        timeSinceAction = 0.0f;
    }
}
