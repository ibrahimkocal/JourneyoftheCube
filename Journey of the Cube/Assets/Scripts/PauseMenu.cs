using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class PauseMenu : MonoBehaviour
{
    public TextMeshProUGUI timerText;
    public TextMeshProUGUI timerTitleText;
    
    public Button pauseButton;
    public static bool isgamePaused = false;

    [SerializeField] GameObject pauseMenu;
    
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.P))
            if (isgamePaused)
            {
                ResumeGame();
            }
            else 
            {
                PauseGame();        
            }
    }

    public void PauseButtonClick()
    {
        if (isgamePaused)
            {
                ResumeGame();
            }
            else 
            {
                PauseGame();        
            }
    }

    public void ResumeGame()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        isgamePaused = false;
        timerText.enabled = true;
        timerTitleText.enabled = true;
        pauseButton.interactable = true;
    }

    void PauseGame()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
        isgamePaused = true;
        timerText.enabled = false;
        timerTitleText.enabled = false;
        pauseButton.interactable = false;
    }

    public void LoadMenu()
    {
        Time.timeScale = 1f;
        pauseButton.interactable = true;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); 
    }

    public void LobbyMenu()
    {   
        Time.timeScale = 1f;
        SceneManager.LoadScene(3);
    }

    public void QuitMenu()
    {
        Application.Quit();
        Debug.Log("Quit, oyun kapandı.");
    }
}
