using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] float jumpForce;
    bool isGrounded;
    [SerializeField] Transform feetPos;
    [SerializeField] float checkRadius;
    [SerializeField] LayerMask whatIsGround;
    Rigidbody2D rb;
    [SerializeField] float actionCooldown;
    float timeSinceAction = 0.0f;
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        transform.Translate(new Vector2(Input.GetAxis("Horizontal") * speed * Time.deltaTime, 0));
        if (Input.GetAxis("Vertical") > 0 && isGrounded && timeSinceAction > actionCooldown)
        {
            jump();
        }
        isGrounded = Physics2D.OverlapCircle(feetPos.position, checkRadius, whatIsGround);
        if (isGrounded)
        {
            timeSinceAction += Time.deltaTime;
        }
    }  

    void jump()
    {
        rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        timeSinceAction = 0.0f;
    }
}
