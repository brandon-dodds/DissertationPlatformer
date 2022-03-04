using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class UIText : MonoBehaviour
{
    [SerializeField] TMP_Text text_object;
    // Start is called before the first frame update
    void Start()
    {
        text_object.text = "00:00:00";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
