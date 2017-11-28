using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gravity : MonoBehaviour
{

    public GameObject target;
    public float strengthOfGravity = 2.0f;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (target != null)
        {
            this.transform.position = Vector3.Lerp(transform.position, target.transform.position, Time.deltaTime);
        }
    }
}
