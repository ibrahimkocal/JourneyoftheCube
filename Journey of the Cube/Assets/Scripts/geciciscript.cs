using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
  


public class geciciscript : MonoBehaviour
{
    [SerializeField]
    private int teleportindex;
    public void ���nlan()
    {
        SceneManager.LoadScene(teleportindex);
    }
    private void OnTriggerEnter(Collider other)
    {
        ���nlan();
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