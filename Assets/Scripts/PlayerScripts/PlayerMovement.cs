using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float speed;
    Rigidbody2D rb;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        transform.Translate(new Vector2(Input.GetAxis("Horizontal") * speed * Time.deltaTime, 0));
        if (Input.GetKeyDown(KeyCode.W))
        {
            jump();   
        }
    } 

    void jump()
    {
        if(rb.velocity.y == 0)
        {
            rb.AddForce(Vector2.up * speed, ForceMode2D.Impulse);
        }
    }
}
