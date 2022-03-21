using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
public class Music : MonoBehaviour
{
    [SerializeField] AudioMixer PercussionAudio;
    [SerializeField] PlayerMovement playerMovement;
    float volume;
    // Start is called before the first frame update
    void Start()
    {
        PercussionAudio.SetFloat("PercussionVolume", -80.0f);
    }

    // Update is called once per frame
    void Update()
    {
        PercussionAudio.GetFloat("PercussionVolume", out volume);
        if (playerMovement.isPlayerMoving && volume != 0.0f){
            PercussionAudio.SetFloat("PercussionVolume", 0.0f);
        }
        if (!playerMovement.isPlayerMoving && volume != -80.0f)
        {
            PercussionAudio.SetFloat("PercussionVolume", -80.0f);
        }
    }
}
