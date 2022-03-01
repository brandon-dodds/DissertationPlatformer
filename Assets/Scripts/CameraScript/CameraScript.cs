using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    int screenHeight;
    int screenWidth;
    [SerializeField] Player player;
    Vector3 screenPosOfPlayer;
    Camera cam;
    void Start()
    {
        screenHeight = Screen.height;
        screenWidth = Screen.width;
        cam = GetComponent<Camera>();
    }
    // Update is called once per frame
    void Update()
    {
        screenPosOfPlayer = cam.WorldToScreenPoint(player.transform.position);
        transform.position = new Vector3(player.transform.position.x, player.transform.position.y, transform.position.z);
    }
}
