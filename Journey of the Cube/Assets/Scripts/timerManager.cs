using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timerManager : MonoBehaviour
{
    [SerializeField] float timeSpeed;
    [SerializeField]int RealTimeSecond = 0;
    int IEsecond = 0;
    int IEMinute = 0;
    string timeText;
    void Start()
    {
        timeText = "00:00";
        StartCoroutine(timer());
    }
    public string GetTime() {
        return timeText;   
    }
    public int[] getTimeAsInt() {
        int[] time = {IEsecond , IEMinute };
        return time;
    }
    public int GetTimeRealSecond() {
        return RealTimeSecond;
    }
    IEnumerator timer() {
        while (true) {
            RealTimeSecond++;
            IEsecond++; 
            yield return new WaitForSeconds(timeSpeed); 
            CalculateTime();
            TextTime();
              
        }
        void CalculateTime() {
            if(IEsecond % 60 == 0) {
                IEMinute++;
                IEsecond = 0;
            }
        }
        void TextTime() {
            if(IEsecond<10)
            {
                timeText = "0"+ IEMinute + ":" + "0"+IEsecond;         
            }
            else
            {   
                timeText = "0"+ IEMinute + ":" + IEsecond; 
                if(IEsecond>59)
                {
                int intseconds = 00;
                timeText = "0"+ IEMinute + ":" + intseconds; 
                }   
            }
        }
    }
}
