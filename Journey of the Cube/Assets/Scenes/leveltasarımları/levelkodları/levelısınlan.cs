using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelısınlan : MonoBehaviour

{
    public bool isOpen = false;
    [SerializeField]
    private int sahneID;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            if (isOpen)
            {
                GetComponent<geciciscript>().isinlan(sahneID);
            }
            else
            {
                Debug.Log("bu bölüm henüz açlamadı");
            }
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        //if (collision.collider.tag == "Player")
        //{
        //    if (isOpen)
        //    {
        //        GetComponent<geciciscript>().isinlan(sahneID);
        //    }
        //    else
        //    {
        //        Debug.Log("bu bölüm henüz açlamadı");
        //    }
        //} 
    }

    
}
