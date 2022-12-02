using UnityEngine.UI;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using TMPro;

public class Timer2 : MonoBehaviour
{
    [SerializeField]float timeSpeed;
    public TextMeshProUGUI timerText;
    [SerializeField] timerManager timeManagers;
    private float startTime;
    
    // Start is called before the first frame update
    void Start()
    {
        startTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        timerText.text = timeManagers.GetTime();
    }


}
