using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bölümbitis : MonoBehaviour
{
    [SerializeField]
    private int sahneID;
    [SerializeField]
    private string level;
    
    private void OnTriggerEnter(Collider other)
    {
        DatabaseConnection.AddValue("Level02", 1);       
        Debug.Log(DatabaseConnection.GetValueINT("Level02").ToString());
        GetComponent<geciciscript>().isinlan(sahneID);
               
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
