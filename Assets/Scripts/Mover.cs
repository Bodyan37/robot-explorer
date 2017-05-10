using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    public float speed;
    public Rigidbody rb;
    public Transform spawn;
    void Start()
    {
        spawn = GameObject.Find("LazerSpawn").transform;
    }

    void OnCollisionEnter(Collision collision)
    {
        print(collision.contacts[0].point.x);
        print(collision.contacts[0].point.z);
        rb.isKinematic = true;
        Points.pointsList.Add(collision.contacts[0].point);
        Destroy(gameObject, 1.0f);
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.transform.position + rb.transform.up * Time.deltaTime * speed);
    }
}