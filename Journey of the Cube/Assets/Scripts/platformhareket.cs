using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platformhareket : MonoBehaviour
{
    public Rigidbody rb;
    public float speed;
    public float forcespeed;
    public bool timer;

    // Start is called before the first frame update
    void Start()
    {
        forcespeed = speed;  
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = Vector3.forward *forcespeed;

        if (timer)
        {
            if (forcespeed > 4)
            {
                forcespeed = -speed;
                timer = true;

            }else if(forcespeed < 0)
            {
                forcespeed = speed;
                timer = true;
            }
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "untagged")
        {
            timer = true;
        }
    }

}
