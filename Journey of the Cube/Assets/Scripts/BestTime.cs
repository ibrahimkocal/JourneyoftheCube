using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BestTime : MonoBehaviour
{
    [SerializeField] timerManager tm;
    [SerializeField] string[] Levels;
    TextMeshPro text;
    [SerializeField] string MevcutLevelAdı;
    void Start()
    {
        text = GetComponent<TextMeshPro>();
        text.text = "\n" + DatabaseConnection.GetValueINT(MevcutLevelAdı +"_EndSecond").ToString();
       
         if(PlayerPrefs.GetString("unity.player_session_count") == "1") {
            foreach (string level in Levels) {
                DatabaseConnection.AddValue(level +"_EndSecond" , 200);
            }
         }

    }
    public void GameEnd(string LevelName) {
       int RealSecond = tm.GetTimeRealSecond(); 
        
        if ( RealSecond < DatabaseConnection.GetValueINT( LevelName+"_EndSecond")) {
            
            DatabaseConnection.AddValue(LevelName+"_EndSecond" , RealSecond);
        }
    }
    
}
