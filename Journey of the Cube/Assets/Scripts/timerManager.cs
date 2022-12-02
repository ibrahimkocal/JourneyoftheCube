using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timerManager : MonoBehaviour
{
    [SerializeField] float timeSpeed;
    int IEsecond = 0;
    int IEMinute = 0;
    string timeText;
    void Start()
    {
        StartCoroutine(timer());
    }
    public string GetTime() {
        return timeText;   
    }
    IEnumerator timer() {
        while (true) {
            IEsecond++; 
            yield return new WaitForSeconds(timeSpeed); 
            CalculateTime();
            TextTime();
            Debug.Log(IEsecond + " " + IEMinute);  
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
