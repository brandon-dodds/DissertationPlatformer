using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
public class MusicChange : MonoBehaviour
{
    [SerializeField] AudioMixer dynamicSound;
    [SerializeField] AudioMixer staticSound;
    float dynamicVolume;
    float staticVolume;
    [SerializeField] DynamicScriptableObject dynamicScriptableObject;
    // Start is called before the first frame update
    void Start()
    {
        if (dynamicScriptableObject.enableDynamic)
        {
            dynamicSound.SetFloat("DynamicVolume", 0.0f);
            staticSound.SetFloat("StaticVolume", -80.0f);
        }
        else
        {
            dynamicSound.SetFloat("DynamicVolume", -80.0f);
            staticSound.SetFloat("StaticVolume", 0.0f);
        }
    }

    // Update is called once per frame
    void Update()
    {
        dynamicSound.GetFloat("DynamicVolume", out dynamicVolume);
        staticSound.GetFloat("StaticVolume", out staticVolume);
        if (Input.GetKeyDown(KeyCode.F))
        {
            if(dynamicVolume == 0.0f)
            {
                dynamicSound.SetFloat("DynamicVolume", -80.0f);
            }
            else
            {
                dynamicSound.SetFloat("DynamicVolume", 0.0f);
            }

            if (staticVolume == 0.0f)
            {
                staticSound.SetFloat("StaticVolume", -80.0f);
            }
            else
            {
                staticSound.SetFloat("StaticVolume", 0.0f);
            }
        }
    }
}
