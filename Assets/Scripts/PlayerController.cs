using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rb;
    public float speed;
    public float rotationSpeed;
    private float vertical;
    private float horizontal;
    private float rotate;
    public Vector3 direction;
    
    void Start()
    {
        speed = 1000;
        rotationSpeed = 500;
        rb = GetComponent<Rigidbody>();
    }
    void FixedUpdate()
    {
        vertical = Input.GetAxis("Vertical");
        horizontal = Input.GetAxis("Horizontal");
        rotate = Input.GetAxis("Mouse X");
        direction = new Vector3(vertical, 0, -horizontal);
        rb.velocity = direction * speed * Time.fixedDeltaTime;

        transform.Rotate((transform.up * rotate) * rotationSpeed * Time.fixedDeltaTime);
    }
}
