using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] GameObject spawnPoint;
    public void respawn()
    {
        transform.position = spawnPoint.transform.position;
        transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 0);
    }
}
