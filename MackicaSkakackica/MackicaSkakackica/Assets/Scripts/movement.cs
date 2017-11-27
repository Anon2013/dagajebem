using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour {

    public float highJump = 10.0f;
    private Rigidbody rb;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () { 
        if (Input.GetButton("Jump"))
        {
            rb.velocity = new Vector3(this.transform.position.x,this.transform.position.y,this.transform.position.z * Time.deltaTime);
        }
	}
}
