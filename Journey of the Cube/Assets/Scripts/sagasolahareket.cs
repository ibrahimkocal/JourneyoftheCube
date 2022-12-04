using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sagasolahareket : MonoBehaviour
{
    
    GameObject c1, c2;
    [SerializeField]
    float Speed;
    int directionC1 = -1, directionC2 = 1;
    Vector3 c1Poz, c2Poz;
    [SerializeField]
    float OffSet;
    void Start()
    {
        c1 = transform.GetChild(0).gameObject;
        c2 = transform.GetChild(1).gameObject;
        c1Poz = c1.transform.position;
        c2Poz = c2.transform.position;
    }
    bool ChangeDirBool = false, ChangeDirBool2;
    void CubeMove1()
    {
        if (c1.transform.position.x >= c1Poz.x + OffSet && !ChangeDirBool)
        {
            directionC1 *= -1;
            Debug.Log("CubeMove1");
            ChangeDirBool = !ChangeDirBool;
        }
        else if (c1.transform.position.x <= c1Poz.x && ChangeDirBool)
        {
            directionC1 *= -1;
            Debug.Log("CubeMove1_2");
            ChangeDirBool = !ChangeDirBool;
        }
        c1.transform.position += Vector3.left * Speed * Time.deltaTime * directionC1;
    }
    void CubeMove2()
    {
        if (c2.transform.position.x <= c2Poz.x + -OffSet && !ChangeDirBool2)
        {
            directionC2 *= -1;
            Debug.Log("CubeMove1");
            ChangeDirBool2 = !ChangeDirBool2;
        }
        else if (c2.transform.position.x >= c2Poz.x && ChangeDirBool2)
        {
            directionC2 *= -1;
            Debug.Log("CubeMove1_2");
            ChangeDirBool2 = !ChangeDirBool2;
        }
        c2.transform.position += Vector3.left * Speed * Time.deltaTime * directionC2;
    }
    void Update()
    {
        CubeMove1();
        CubeMove2();
    }
}
