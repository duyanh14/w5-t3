using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stick : MonoBehaviour
{
    [SerializeField] private float speed;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        // rb.AddTorque(Vector3.up*speed*Time.deltaTime, ForceMode.VelocityChange);
        transform.Rotate(0, speed * Time.deltaTime, 0);
    }
}
