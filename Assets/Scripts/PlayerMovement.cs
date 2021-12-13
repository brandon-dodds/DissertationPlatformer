using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] readonly float speed;
    void Update()
    {
        transform.Translate(new Vector2(Input.GetAxis("Horizontal") * speed * Time.deltaTime, 0));
    } 
}
