using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rb;
    public float speed;
    private float vertical;
    private float horizontal;
    public Vector3 direction;
    
    void Start()
    {
        speed = 100;
        rb = GetComponent<Rigidbody>();
    }
    void FixedUpdate()
    {
        vertical = Input.GetAxis("Vertical");
        horizontal = Input.GetAxis("Horizontal");

        direction = new Vector3(vertical, 0, horizontal);
        
        rb.velocity = direction * speed * Time.fixedDeltaTime;
    }
}
