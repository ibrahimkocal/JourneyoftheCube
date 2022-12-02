using UnityEngine.UI;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using TMPro;

public class Timer : MonoBehaviour
{
    [SerializeField] float TimeSpeed;
    public TextMeshPro timerText;
    private float startTime;
    [SerializeField] timerManager timeM;
    
    // Start is called before the first frame update
    void Start()
    {
        startTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        timerText.text = "\n" + timeM.GetTime();
    }

}
