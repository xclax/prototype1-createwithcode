using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private float speed = 20.0f;
    private float turnSpeed = 20;
    private float m_HorizontalInput;
    private float m_VerticalInput;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       m_HorizontalInput = Input.GetAxis("Horizontal");
       m_VerticalInput = Input.GetAxis("Vertical");

       transform.Translate(Vector3.forward * (Time.deltaTime * speed * m_VerticalInput));
       transform.Rotate(Vector3.up * (Time.deltaTime * turnSpeed * m_HorizontalInput));
    }
}
