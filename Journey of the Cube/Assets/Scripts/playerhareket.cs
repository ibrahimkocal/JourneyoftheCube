using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class playerhareket : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField]
    float speed,jump;
    [SerializeField]
    Vector3 ReSpawnPozition;
    bool isgrounded = false ;


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
            rb.AddForce(new Vector3(-speed*Time.deltaTime,0,0) );
        }
        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(new Vector3(speed*Time.deltaTime, 0, 0));
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(new Vector3(0, 0, -speed * Time.deltaTime));
        }
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(new Vector3(0, 0, speed * Time.deltaTime));
        }
        if (Input.GetKeyDown(KeyCode.Space) && !isgrounded)
        {
            rb.AddForce(new Vector3(0, jump, 0));
            isgrounded = true;
            
        }
        if (transform.position.y <= -10)
        {
            Dead();
        }
    
        

    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "grounded")
        {
            isgrounded = false;
        }
        
    }
    private void Dead()
        {
            transform.position = ReSpawnPozition;
        }
}
