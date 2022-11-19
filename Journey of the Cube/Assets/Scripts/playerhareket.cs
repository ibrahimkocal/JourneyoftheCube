using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerhareket : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField]
    float speed,jump;
    [SerializeField]
    Vector3 ReSpawnPozition;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(new Vector3(-speed,0,0) );
        }
        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(new Vector3(speed, 0, 0));
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(new Vector3(0, 0, -speed));
        }
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(new Vector3(0, 0, speed));
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(new Vector3(0, jump, 0));
        }
        if (transform.position.y <= -10)
        {
            Dead();
        }


    }
    private void Dead()
        {
            transform.position = ReSpawnPozition;
        }
}
