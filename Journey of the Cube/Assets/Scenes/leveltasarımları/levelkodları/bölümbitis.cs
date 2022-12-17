using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class bölümbitis : MonoBehaviour
{
    [SerializeField]
    private int sahneID;
    public TextMeshProUGUI timerText;
    public TextMeshProUGUI timerTitleText;
    [SerializeField]
    private string NewLevel;
    public string levelNumber; 
    public TextMeshProUGUI levelText;

    [SerializeField] string Levelnn;
    [SerializeField]BestTime BestTimeS;
    [SerializeField]GameObject levelCompleteS;
    [SerializeField]GameObject pauseMenu;
    private bool isClickedButton = false;

    IEnumerator timer()
    {
        // yield return new WaitForSeconds(3f);
        while(!isClickedButton)
        {
            yield return null;         
        }
        GetComponent<geciciscript>().isinlan(sahneID);
    }
    private void OnTriggerEnter(Collider other)
    {
        DatabaseConnection.AddValue(NewLevel, 1);       
        Debug.Log(DatabaseConnection.GetValueINT(NewLevel).ToString());
        StartCoroutine(timer());
        levelCompleteS.SetActive(true);
        timerText.enabled = false;
        timerTitleText.enabled = false;
        levelText.text = "LEVEL "+ levelNumber;
        Time.timeScale = 0f;
        pauseMenu.SetActive(false);
        BestTimeS.GameEnd(Levelnn);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OKButton()
    {
        levelCompleteS.SetActive(false);
        Time.timeScale = 1f;
        isClickedButton = true;
    }
}
