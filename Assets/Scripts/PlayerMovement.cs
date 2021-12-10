using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float speed;
    // Update is called once per frame
    private Rigidbody2D _rigidBody2d;

    private void Start()
    {
        // Cache the value, don't call GetComponent<Rigidbody2D>() in FixedUpdate
        _rigidBody2d = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        _rigidBody2d.AddForce(new Vector2(Input.GetAxis("Horizontal") * speed, 0));
    } 
}
