using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yukarıasa : MonoBehaviour
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
        if (c1.transform.position.y >= c1Poz.y + OffSet && !ChangeDirBool)
        {
            directionC1 *= -1;

            ChangeDirBool = !ChangeDirBool;
        }
        else if (c1.transform.position.y <= c1Poz.y && ChangeDirBool)
        {
            directionC1 *= -1;

            ChangeDirBool = !ChangeDirBool;
        }
        c1.transform.position += Vector3.up * Speed * Time.deltaTime * directionC1;
    }
    void CubeMove2()
    {
        if (c2.transform.position.y <= c2Poz.y + -OffSet && !ChangeDirBool2)
        {
            directionC2 *= -1;

            ChangeDirBool2 = !ChangeDirBool2;
        }
        else if (c2.transform.position.y >= c2Poz.y && ChangeDirBool2)
        {
            directionC2 *= -1;

            ChangeDirBool2 = !ChangeDirBool2;
        }
        c2.transform.position += Vector3.up * Speed * Time.deltaTime * directionC2;
    }
    void Update()
    {
        CubeMove1();
        CubeMove2();
    }
}
