using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFallow : MonoBehaviour
{
    [SerializeField]
    Transform _PlayerTransform;
    [SerializeField]
    Vector3 _Offset;

    // Update is called once per frame
    void Update()
    {
        transform.position = _PlayerTransform.position + _Offset;
        
    }

}
