using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelPortalManeger : MonoBehaviour
{
    [SerializeField]
    GameObject[] portal;
    [SerializeField]
    string[] levels;

    private void Start()
    {
        DatabaseConnection.AddValue(levels[0], 1);
        
    }

    private void OnEnable()
    {
        kapilariguncelle();
        
    }

    private void kapilariguncelle()
    {
        for (int i = 0; i < portal.Length; i++)
        {
            int levelbool = DatabaseConnection.GetValueINT(levels[i]);
            if (levelbool == 1)
            {
                portal[i].transform.GetChild(3).gameObject.GetComponent<Renderer>().material.color = Color.green;
                portal[i].gameObject.GetComponent<levelýsýnlan>().isOpen = true;
                Debug.Log(i + " portal açýldý");
            }
        }
    }

    private void resetsave()
    {
        foreach (string level in levels)
        {
            DatabaseConnection.AddValue(level, 0);

        }
        DatabaseConnection.AddValue("Level01", 1);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            resetsave();
        }
    }
}
