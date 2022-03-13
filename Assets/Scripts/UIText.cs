using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
public class UIText : MonoBehaviour
{
    [SerializeField] TMP_Text text_object;
    [SerializeField] Flag flag;
    double timer;
    // Start is called before the first frame update
    void Start()
    {
        text_object.text = "00:00:00";
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        TimeSpan time = TimeSpan.FromSeconds(timer);
        text_object.text = time.ToString(@"mm\:ss\:ff");
        if (flag.FlagEntered)
        {
            timer = 0.0f;
        }
    }
}
