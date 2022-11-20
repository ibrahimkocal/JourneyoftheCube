using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class leveltext : MonoBehaviour
{
    
    [SerializeField]
    TextMeshPro textMeshPro;
    [SerializeField]
    private string text;
    
    void Start()
    {
        textMeshPro = transform.GetChild(4).gameObject.GetComponent<TextMeshPro>();
        textMeshPro.text = text;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
