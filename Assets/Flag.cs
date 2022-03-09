using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flag : MonoBehaviour
{
    // Start is called before the first frame update
    public bool FlagEntered;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Flag Entered!");
        FlagEntered = true;
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        Debug.Log("Flag Exited!");
        FlagEntered = false;
    }
}
