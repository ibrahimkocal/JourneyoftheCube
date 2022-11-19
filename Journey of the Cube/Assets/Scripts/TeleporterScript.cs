using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class TeleporterScript : MonoBehaviour
{
    [SerializeField]
    int SceneID;
    private void OnCollisionEnter(Collision collision)
    {
        if(SceneID == 3)
        {
            SceneManager.LoadScene(SceneID);
        }


        if (SceneID == -1 )
        {
            Application.Quit();
        }
    }
}
