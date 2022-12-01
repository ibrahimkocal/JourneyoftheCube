using UnityEngine.UI;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using TMPro;

public class Timer : MonoBehaviour
{
    
    public TextMeshPro timerText;
    private float startTime;
    
    // Start is called before the first frame update
    void Start()
    {
        startTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        float t = Time.time - startTime;
        string minutes = ((int) t/ 60).ToString();
        string seconds = (t % 60 ).ToString("f0");

        timerText.text = "\n"+minutes + ":" + seconds;   

        if(int.Parse(seconds)<10)
        {
            timerText.text = "\n"+"0"+ minutes + ":" + "0"+seconds;
        }
        else
        {
            timerText.text = "\n"+"0"+ minutes + ":" + seconds; 
            if(int.Parse(minutes)<10 && int.Parse(seconds)>59)
            {
                int intseconds = 00;
                timerText.text = "\n"+"0"+ minutes + ":" + intseconds; 
            }   
        }
    }
}
