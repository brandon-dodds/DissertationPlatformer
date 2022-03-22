using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
public class Music : MonoBehaviour
{
    [SerializeField] AudioMixer Mixer;
    [SerializeField] PlayerMovement playerMovement;
    float PercussionVolume;
    float BassVolume;
    float playerStandStill;
    float playerMoveTime;
    // Start is called before the first frame update
    void Start()
    {
        Mixer.SetFloat("PercussionVolume", -80.0f);
        Mixer.SetFloat("BassVolume", -80.0f);
    }

    // Update is called once per frame
    void Update()
    {
        Mixer.GetFloat("PercussionVolume", out PercussionVolume);
        Mixer.GetFloat("BassVolume", out BassVolume);
        if (!playerMovement.isPlayerMoving)
        {
            playerStandStill += Time.deltaTime;
        }
        if (playerMovement.isPlayerMoving)
        {
            playerMoveTime += Time.deltaTime;
        }
        if (playerMovement.isPlayerMoving && PercussionVolume != 0.0f)
        {
            playerStandStill = 0.0f;
            Mixer.SetFloat("PercussionVolume", 0.0f);
        }
        if (playerStandStill > 0.2f && PercussionVolume != -80.0f)
        {
            Mixer.SetFloat("PercussionVolume", -80.0f);
        }
        if (playerMoveTime > 1.5f && BassVolume != 0.0f)
        {
            playerStandStill = 0.0f;
            Mixer.SetFloat("BassVolume", 0.0f);
        }
        if (playerStandStill > 0.2f && BassVolume != -80.0f)
        {
            playerMoveTime = 0.0f;
            Mixer.SetFloat("BassVolume", -80.0f);
        }
    }
}
