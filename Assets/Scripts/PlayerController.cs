using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    private Rigidbody rb;
    public GameObject lazer;
    public Transform lazerSpawn;
    public float fireRate = 0.1F;
    public float mapRate = 0.5F;
    private float nextFire = 0.0F;
    private float nextMap = 0.0F;
    private GameObject q;
    private bool flag = true;
    private bool autofire;
    public Animator animator;
    private bool turning = false;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        //Invoke("Example", 0.3f);
        q = GameObject.Find("Quad");
        autofire = false;
    }

    private void Update()
    {

        if (Input.GetButton("Jump") && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            Instantiate(lazer, lazerSpawn.position, lazerSpawn.rotation);
        }
        if (Input.GetButton("Fire3") && Time.time > nextMap)
        {
            nextMap = Time.time + mapRate;
            flag = !flag;
            q.SetActive(flag);
        }
        if (Input.GetButton("Fire2") && Time.time > nextMap)
        {
            nextMap = Time.time + mapRate;
            autofire = !autofire;
            turning = !turning;
        }
            if (autofire && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            Instantiate(lazer, lazerSpawn.position, lazerSpawn.rotation);
        }
    }

    private void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        if (turning)
        {
            print(turning);
            rb.MoveRotation(rb.rotation * Quaternion.Euler(0.0f, 0.04f, 0.0f));
        }
        if (moveVertical != 0)
        {
            
            rb.MovePosition(rb.transform.position + rb.transform.forward * Time.deltaTime * moveVertical);
        }

        if (Input.GetButton("Vertical") || Input.GetButton("Horizontal"))
        {
            animator.SetBool("Moving", true);
        }
        else animator.SetBool("Moving", false);


        rb.MoveRotation(rb.rotation * Quaternion.Euler(0.0f, moveHorizontal * 2, 0.0f));

    }

}
