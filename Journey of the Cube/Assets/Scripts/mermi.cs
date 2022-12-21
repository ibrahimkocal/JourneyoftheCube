using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class mermi : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] float speed;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        rb.AddForce(new Vector3(speed * Time.deltaTime, 0,0 ));
    }
    private void OnCollisionEnter(Collision collision)
    {
        collision.gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(10, 3, 0),ForceMode.Impulse);
        Destroy(this.gameObject);
    }
}
