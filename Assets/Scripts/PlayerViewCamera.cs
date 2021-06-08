using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerViewCamera : MonoBehaviour
{
    public GameObject player;
    public GameObject mainCamera;
    private Vector3 offset = new Vector3(0.301141024f, 2.02821517f, 1.75942469f);

    void Start()
    {
        transform.position = player.transform.position + offset;
    }

    // Update is called once per frame

    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            gameObject.SetActive(false);
            mainCamera.SetActive(true);
        }
    }
}