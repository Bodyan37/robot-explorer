using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    private Rigidbody rb;
    private int i = 0;
    private int j = 0;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Invoke("Example", 0.3f);
    }

    void Example()
    {
        transform.position = new Vector3(i-9, 0.5f, j-9);
        j += (i + 1) / 19;
        i = (i + 1) % 19;
        Invoke("Example", 0.3f);
    }
    private void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        print(Input.anyKeyDown.ToString());
        Vector3 movement = new Vector3(5, 0.0f, 5);
        if (Input.anyKeyDown)
        {
            transform.position = new Vector3(i, 0.5f, i);
            i++;
        }
        //transform.position = new Vector3(rb.position.x+moveHorizontal, rb.position.y, rb.position.z+moveVertical);
    }
}
