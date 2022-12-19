using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class instantiate : MonoBehaviour
{
    public GameObject go;
    [SerializeField] Transform t1;
    
    // Start is called before the first frame update

    void Start()
    {
        StartCoroutine(TeleportDelay());
        t1 = transform;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator TeleportDelay()
    {
        while(true)
        {
            yield return new WaitForSeconds(2f);
            Instantiate(go,t1.position,Quaternion.identity,null);
        }

    }


}
