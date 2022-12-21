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
            Vector3 offset= new Vector3(0,0.7f,0);
            Instantiate(go,t1.position+offset,Quaternion.identity,null);
        }

    }


}
