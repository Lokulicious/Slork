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

    private Vector3 velocity;

    
    void Start()
    {
        speed = 30;
        rotationSpeed = 10;
        rb = GetComponent<Rigidbody>();
    }
    void FixedUpdate()
    {
        vertical = Input.GetAxis("Vertical");
        horizontal = Input.GetAxis("Horizontal");

        rotate = Input.GetAxis("Mouse X");
        direction = new Vector3(vertical, 0, -horizontal);

        rb.rotation = Quaternion.Euler(rb.rotation.eulerAngles + new Vector3(0f, rotationSpeed * rotate, 0f));

        velocity = rb.rotation * direction * speed;

        rb.velocity = velocity * Time.fixedDeltaTime;
    }
}
