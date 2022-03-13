using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] GameObject spawnPoint;
    [SerializeField] Flag flag;
    private void Start()
    {
        transform.position = spawnPoint.transform.position;
    }
    private void Update()
    {
        if (flag.FlagEntered)
        {
            Respawn();
        }
    }
    public void Respawn()
    {
        transform.position = spawnPoint.transform.position;
    }
}
