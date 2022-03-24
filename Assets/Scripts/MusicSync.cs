using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicSync : MonoBehaviour
{
    [SerializeField] AudioSource master;
    [SerializeField] AudioSource track1;
    [SerializeField] AudioSource track2;

    // Update is called once per frame
    void Update()
    {
        track2.timeSamples = track1.timeSamples = master.timeSamples;
    }
}
