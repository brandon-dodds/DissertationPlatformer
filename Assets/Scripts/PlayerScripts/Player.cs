using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] GameObject spawnPoint;
    public bool dead;
    void Start()
    {
        dead = false;
    }
    void Update()
    {
        if (dead)
        {
            respawn();
            dead = false;
        }
    }
    void respawn()
    {
        transform.position = spawnPoint.transform.position;
    }
}
