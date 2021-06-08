using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    public GameObject playerViewCamera;

    private readonly Vector3 m_Offset = new Vector3(0, 5, -7);

    // Start is called before the first frame update
    void Start()
    {
        transform.position = player.transform.position + m_Offset;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = player.transform.position + m_Offset;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            gameObject.SetActive(false);
            playerViewCamera.SetActive(true);

        }
    }
}