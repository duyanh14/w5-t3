using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SphereMove : MonoBehaviour
{
    private Rigidbody point;
    public Rigidbody point1;
    public Rigidbody point2;

    private Rigidbody targetPoint;

    private float moveSpeed = 3f;

    void Start()
    {
        point = GetComponent<Rigidbody>();
        targetPoint = point1;
    }

    void Update()
    {
        point.transform.position = Vector3.MoveTowards(   point.transform.position,targetPoint.transform.position, moveSpeed*Time.deltaTime);
        
        if (point.transform.position == point1.transform.position)
        {
            targetPoint = point2;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == targetPoint.name)
        {
            Debug.Log("Touch " + targetPoint.name);
        }
    }
}