using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bölümbitis : MonoBehaviour
{
    [SerializeField]
    private int sahneID;
    [SerializeField]
    private string NewLevel;
    [SerializeField] string Levelnn;
    [SerializeField]BestTime BestTimeS;
    private void OnTriggerEnter(Collider other)
    {
        DatabaseConnection.AddValue(NewLevel, 1);       
        Debug.Log(DatabaseConnection.GetValueINT(NewLevel).ToString());
        GetComponent<geciciscript>().isinlan(sahneID);
        BestTimeS.GameEnd(Levelnn);
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
