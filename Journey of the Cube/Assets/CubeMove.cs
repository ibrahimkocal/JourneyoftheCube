using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class CubeMove : MonoBehaviour
{
    [SerializeField]
    GameObject c1, c2;
    [SerializeField]
    float MoveOffSet;
    [SerializeField]
    float CubeSpeed;
    int direction = 1;
    // Start is called before the first frame update
    [SerializeField]
    float spawnc1, spawnc2;
    void Start()
    {
        c1 = transform.GetChild(0).gameObject;
        c2 = transform.GetChild(1).gameObject;
        spawnc1 = c1.transform.position.z + MoveOffSet;
        spawnc2 = c2.transform.position.z + MoveOffSet;
    }

    // Update is called once per frame
    void Update()
    {
       // MoveCube1(c1);
        MoveCube2(c2);
    }
    bool changeDir = false, changeDir2 = false;
    private void MoveCube1(GameObject a)
    {
        Vector3 offSet = new Vector3(a.transform.position.x , a.transform.position.y , a.transform.position.z + MoveOffSet );
        if((spawnc1 <= -offSet.z && !changeDir))
        {
            direction *= -1;
            changeDir = true;
            Debug.Log("Çalýþtý");
        }
        a.transform.position = a.transform.position + (Vector3.forward * CubeSpeed * direction) * Time.deltaTime;
    }
    private void MoveCube2(GameObject a)
    {
        Debug.Log(spawnc1 + " " + spawnc1 + MoveOffSet);
        if( (spawnc1 <= spawnc1 + MoveOffSet ) && !changeDir2)
        {
            direction *= -1;
            Debug.Log("Çalýþtý");
            changeDir2 = true;
        }
        c1.transform.position += new Vector3(0, 0, CubeSpeed * Time.deltaTime * direction);
    }
}
