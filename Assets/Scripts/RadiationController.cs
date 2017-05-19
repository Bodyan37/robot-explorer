using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RadiationController : MonoBehaviour {

    public float speed;
    public int doze;
    public float maxLenght;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.localScale += new Vector3(0.01f, 0.01f, 0.01f)*speed;
        if (transform.localScale.x >= maxLenght)
        {
            transform.localScale = new Vector3(0, 0, 0);
        }
		
	}
}
