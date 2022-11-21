using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
  


public class geciciscript : MonoBehaviour
{
    [SerializeField]
    private int teleportindex;
    public void isinlan()
    {
        SceneManager.LoadScene(teleportindex);
    }
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void isinlan(int sahneID)
    {
        SceneManager.LoadScene(sahneID);
    }
}
